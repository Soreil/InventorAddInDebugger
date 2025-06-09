namespace MiNa.InventorAddInDebugger.UI
{
    partial class AddInLoaderConfigCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            lblLoadOnStart = new System.Windows.Forms.Label();
            cbLoadOnStart = new System.Windows.Forms.CheckBox();
            lblFullName = new System.Windows.Forms.Label();
            tbFullName = new System.Windows.Forms.TextBox();
            lblAddinClientId = new System.Windows.Forms.Label();
            tbAddinClientId = new System.Windows.Forms.TextBox();
            lblAssemblyFile = new System.Windows.Forms.Label();
            tbAssemblyFile = new System.Windows.Forms.TextBox();
            lblLoadFromFile = new System.Windows.Forms.Label();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            btnBrowseAddinFile = new System.Windows.Forms.Button();
            cmbRecent = new System.Windows.Forms.ComboBox();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblLoadOnStart, 0, 4);
            tableLayoutPanel1.Controls.Add(cbLoadOnStart, 1, 4);
            tableLayoutPanel1.Controls.Add(lblFullName, 0, 3);
            tableLayoutPanel1.Controls.Add(tbFullName, 1, 3);
            tableLayoutPanel1.Controls.Add(lblAddinClientId, 0, 2);
            tableLayoutPanel1.Controls.Add(tbAddinClientId, 1, 2);
            tableLayoutPanel1.Controls.Add(lblAssemblyFile, 0, 1);
            tableLayoutPanel1.Controls.Add(tbAssemblyFile, 1, 1);
            tableLayoutPanel1.Controls.Add(lblLoadFromFile, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(540, 225);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLoadOnStart
            // 
            lblLoadOnStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblLoadOnStart.AutoSize = true;
            lblLoadOnStart.Location = new System.Drawing.Point(4, 123);
            lblLoadOnStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLoadOnStart.Name = "lblLoadOnStart";
            lblLoadOnStart.Size = new System.Drawing.Size(76, 15);
            lblLoadOnStart.TabIndex = 9;
            lblLoadOnStart.Text = "Load on start";
            // 
            // cbLoadOnStart
            // 
            cbLoadOnStart.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbLoadOnStart.Location = new System.Drawing.Point(121, 119);
            cbLoadOnStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbLoadOnStart.Name = "cbLoadOnStart";
            cbLoadOnStart.Size = new System.Drawing.Size(415, 23);
            cbLoadOnStart.TabIndex = 10;
            cbLoadOnStart.UseVisualStyleBackColor = true;
            // 
            // lblFullName
            // 
            lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblFullName.AutoSize = true;
            lblFullName.Location = new System.Drawing.Point(4, 94);
            lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(86, 15);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Type FullName";
            // 
            // tbFullName
            // 
            tbFullName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbFullName.Enabled = false;
            tbFullName.Location = new System.Drawing.Point(121, 90);
            tbFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new System.Drawing.Size(415, 23);
            tbFullName.TabIndex = 5;
            // 
            // lblAddinClientId
            // 
            lblAddinClientId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblAddinClientId.AutoSize = true;
            lblAddinClientId.Location = new System.Drawing.Point(4, 65);
            lblAddinClientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAddinClientId.Name = "lblAddinClientId";
            lblAddinClientId.Size = new System.Drawing.Size(83, 15);
            lblAddinClientId.TabIndex = 1;
            lblAddinClientId.Text = "Addin ClientId";
            // 
            // tbAddinClientId
            // 
            tbAddinClientId.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbAddinClientId.Location = new System.Drawing.Point(121, 61);
            tbAddinClientId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbAddinClientId.Name = "tbAddinClientId";
            tbAddinClientId.Size = new System.Drawing.Size(415, 23);
            tbAddinClientId.TabIndex = 3;
            // 
            // lblAssemblyFile
            // 
            lblAssemblyFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblAssemblyFile.AutoSize = true;
            lblAssemblyFile.Location = new System.Drawing.Point(4, 36);
            lblAssemblyFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAssemblyFile.Name = "lblAssemblyFile";
            lblAssemblyFile.Size = new System.Drawing.Size(79, 15);
            lblAssemblyFile.TabIndex = 0;
            lblAssemblyFile.Text = "Assembly File";
            // 
            // tbAssemblyFile
            // 
            tbAssemblyFile.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbAssemblyFile.Location = new System.Drawing.Point(121, 32);
            tbAssemblyFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbAssemblyFile.Name = "tbAssemblyFile";
            tbAssemblyFile.Size = new System.Drawing.Size(415, 23);
            tbAssemblyFile.TabIndex = 2;
            // 
            // lblLoadFromFile
            // 
            lblLoadFromFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lblLoadFromFile.AutoSize = true;
            lblLoadFromFile.Location = new System.Drawing.Point(4, 7);
            lblLoadFromFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLoadFromFile.Name = "lblLoadFromFile";
            lblLoadFromFile.Size = new System.Drawing.Size(62, 15);
            lblLoadFromFile.TabIndex = 8;
            lblLoadFromFile.Text = "Load from";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            tableLayoutPanel2.Controls.Add(btnBrowseAddinFile, 0, 0);
            tableLayoutPanel2.Controls.Add(cmbRecent, 1, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(117, 0);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new System.Drawing.Size(423, 29);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // btnBrowseAddinFile
            // 
            btnBrowseAddinFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnBrowseAddinFile.Location = new System.Drawing.Point(3, 3);
            btnBrowseAddinFile.Name = "btnBrowseAddinFile";
            btnBrowseAddinFile.Size = new System.Drawing.Size(75, 23);
            btnBrowseAddinFile.TabIndex = 7;
            btnBrowseAddinFile.Text = "*.addin";
            toolTip1.SetToolTip(btnBrowseAddinFile, "Load information from .addin file");
            btnBrowseAddinFile.UseVisualStyleBackColor = true;
            btnBrowseAddinFile.Click += btnBrowseAddinFile_Click;
            // 
            // cmbRecent
            // 
            cmbRecent.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbRecent.DropDownWidth = 400;
            cmbRecent.FormattingEnabled = true;
            cmbRecent.Location = new System.Drawing.Point(85, 3);
            cmbRecent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cmbRecent.Name = "cmbRecent";
            cmbRecent.Size = new System.Drawing.Size(334, 23);
            cmbRecent.TabIndex = 8;
            cmbRecent.Text = "Recent...";
            cmbRecent.SelectedIndexChanged += cmbRecent_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AddInLoaderConfigCtrl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AddInLoaderConfigCtrl";
            Size = new System.Drawing.Size(540, 225);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbAddinClientId;
        private System.Windows.Forms.Label lblAssemblyFile;
        private System.Windows.Forms.Label lblAddinClientId;
        private System.Windows.Forms.TextBox tbAssemblyFile;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.Label lblLoadFromFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblLoadOnStart;
        private System.Windows.Forms.CheckBox cbLoadOnStart;
        private System.Windows.Forms.Button btnBrowseAddinFile;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cmbRecent;
    }
}
