using System.Diagnostics;
using Inventor;
using Application = Inventor.Application;

namespace MiNa.InventorAddInDebugger.Commands;

internal class OpenBuildFolderCmd(Application inventor, AddInLoader addInLoader) : Command(inventor)
{
    protected override void ExecuteCommand(NameValueMap context)
    {
        var startInfo = new ProcessStartInfo("explorer.exe", $"/select,\"{addInLoader.LastVersionFile}\"")
            { UseShellExecute = true };
        Process.Start(startInfo);
    }
}