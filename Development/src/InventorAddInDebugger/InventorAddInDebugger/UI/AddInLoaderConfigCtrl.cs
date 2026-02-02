using System;
using System.Collections.Generic;
using System.Windows.Forms;

using MiNa.InventorAddInDebugger.Properties;

using Environment = System.Environment;
using Path = System.IO.Path;

namespace MiNa.InventorAddInDebugger.UI
{
    public partial class AddInLoaderConfigCtrl : UserControl
    {
        private AddInLoaderConfig? _config;
        private ReferencesLoader _referencesLoader;

        public AddInLoaderConfigCtrl()
        {
            InitializeComponent();

            _referencesLoader = new ReferencesLoader();
        }

        public AddInLoaderConfig? Config
        {
            get => _config;
            set
            {
                _config = value;
                ConfigToControls();
            }
        }

        public void Save() => ControlsToConfig();

        private void btnBrowseNet48_Click(object sender, EventArgs e)
        {
            AddInInfoLoader addInInfoLoader = new AddInInfoLoader("AddInInfo48.exe");

            LoadAddInInfo(addInInfoLoader);
        }

        private void btnBrowseNet80_Click(object sender, EventArgs e)
        {
            AddInInfoLoader addInInfoLoader = new AddInInfoLoader("AddInInfo80.exe");

            LoadAddInInfo(addInInfoLoader);
        }

        private void ConfigToControls()
        {
            if (_config == null)
                return;

            tbAssemblyFile.Text = _config.AddInAssemblyFile;
            tbAddinClientId.Text = _config.AddInClientId;
            tbFullName.Text = _config.AddInFullName;
            cbLoadOnStart.Checked = _config.LoadOnStart;
            cmbRecent.Items.AddRange(_config.MruAddInInfos.ConvertAll(x => new AddInInfoComboItem(x)).ToArray());
        }

        private void ControlsToConfig()
        {
            if (_config == null)
                return;

            var asm = tbAssemblyFile.Text.Trim(' ', '"');
            var clid = tbAddinClientId.Text.Trim(" {}".ToCharArray());
            var fn = tbFullName.Text;
            var los = cbLoadOnStart.Checked;

            _config.AddInAssemblyFile = asm;
            _config.AddInClientId = clid;
            _config.AddInFullName = fn;
            _config.LoadOnStart = los;
        }

        private void LoadAddInInfo(AddInInfoLoader addInInfoLoader)
        {
            var fd = new OpenFileDialog();
            fd.Filter = "DLL Files|*.dll|All Files|*.*";
            fd.Title = "Select add-in build file";


            var dialogResult = fd.ShowDialog(this);

            if (dialogResult != DialogResult.OK) return;

            var addInsFromAssembly = addInInfoLoader.GetAddInsFromAssembly(fd.FileName);
            switch (addInsFromAssembly.Count)
            {
                case 0:
                    MessageBox.Show("There is no add-ins in this assembly");
                    break;
                case 1:
                    tbAssemblyFile.Text = fd.FileName;
                    tbAddinClientId.Text = addInsFromAssembly[0].ClientId;
                    tbFullName.Text = addInsFromAssembly[0].FullName;
                    break;
                default:
                    var selectAddInDlg = new SelectAddInDlg() { AddIns = addInsFromAssembly };
                    var showDialog = selectAddInDlg.ShowDialog(this);
                    if (showDialog == DialogResult.OK)
                    {
                        tbAssemblyFile.Text = fd.FileName;
                        tbAddinClientId.Text = selectAddInDlg.SelectedAddInInfo?.ClientId;
                        tbFullName.Text = selectAddInDlg.SelectedAddInInfo?.FullName;
                    }
                    else
                    {
                        tbAssemblyFile.Text = fd.FileName;
                        tbAddinClientId.Text = addInsFromAssembly[0].ClientId;
                        tbFullName.Text = addInsFromAssembly[0].FullName;
                    }

                    break;
            }
        }

        private void btnBrowseAddinFile_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            fd.Filter = ".addin Files|*.addin|All Files|*.*";
            fd.Title = "Select add-in manifest file";


            var dialogResult = fd.ShowDialog(this);

            if (dialogResult != DialogResult.OK) return;

            var loader = new AddInFileInfoLoader();
            var addInInfo = AddInFileInfoLoader.AddInInfo(fd.FileName);

            if (addInInfo is null || string.IsNullOrEmpty(addInInfo.FullName))
                MessageBox.Show(Resources.Msg_AddInNotFound, Resources.AddIn_DisplayName, MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

            if (addInInfo is not null)
            {
                tbAddinClientId.Text = addInInfo.ClientId;
                tbAssemblyFile.Text = addInInfo.FullName;
                tbFullName.Text = "";

                UpdateMruAddInInfos(addInInfo);
            }
        }

        private void UpdateMruAddInInfos(AddInInfo addInInfo)
        {
            Config?.MruAddInInfos.RemoveAll(x =>
                x.FullName.Equals(addInInfo.FullName, StringComparison.InvariantCultureIgnoreCase) &&
                x.ClientId.Equals(addInInfo.ClientId, StringComparison.InvariantCultureIgnoreCase));
            Config?.MruAddInInfos.Insert(0, addInInfo);
        }

        private void cmbRecent_SelectedIndexChanged(object sender, EventArgs e)
        {
            var addInInfo = cmbRecent.SelectedItem as AddInInfo;
            if (addInInfo == null) return;
            tbAddinClientId.Text = addInInfo.ClientId;
            tbAssemblyFile.Text = addInInfo.FullName;
        }


        private class AddInInfoComboItem : AddInInfo
        {
            public AddInInfoComboItem(AddInInfo addInInfo) : base(addInInfo.FullName, addInInfo.ClientId)
            {
            }

            public override string ToString()
            {
                if (FullName.Length < 75) return FullName;

                string[] strings = FullName.Split(Path.DirectorySeparatorChar);
                int pathLength = 0;
                var parts = new List<string>();
                for (int i = strings.Length - 1; i >= 0; i--)
                {
                    string part = strings[i];
                    pathLength += part.Length;
                    parts.Add(part);
                    if (pathLength >= 50) break;
                }

                parts.Add(Path.GetPathRoot(FullName) + "...");

                parts.Reverse();
                return string.Join(Path.DirectorySeparatorChar.ToString(), parts);
            }
        }
    }
}