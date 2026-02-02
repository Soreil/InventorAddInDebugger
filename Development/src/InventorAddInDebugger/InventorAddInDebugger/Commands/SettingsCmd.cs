using System.Windows.Forms;
using Inventor;
using MiNa.InventorAddInDebugger.UI;
using Application = Inventor.Application;

namespace MiNa.InventorAddInDebugger.Commands;

internal class SettingsCmd(Application inventor, AddInLoaderConfigManager configManager) : Command(inventor)
{
    private static AddInLoaderConfig Config => StandardAddInServer.Config;

    protected override void ExecuteCommand(NameValueMap context)
    {
        var settingsDlg = new SettingsDlg();
        var dialogResult = settingsDlg.ShowDialog(InventorMainWindow);
        if (dialogResult == DialogResult.OK)
        {
            configManager.Load(Config);
        }

        //string settingsExe = Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
        //    "InventorAddInDebuggerConfig.exe");
        ////AddInInfo48.exe

        //var process = Process.Start(new ProcessStartInfo(
        //    settingsExe
        //) { UseShellExecute = true });
        //process.WaitForExit();
        //int exitCode = process.ExitCode;

        //if (exitCode == 0)
        //    _configManager.Load(Config);
    }
}