using System.Diagnostics;
using Inventor;
using Application = Inventor.Application;

namespace MiNa.InventorAddInDebugger.Commands;

internal class AttachDebuggerCmd(Application inventor) : Command(inventor)
{
    protected override void ExecuteCommand(NameValueMap context)
    {
        Debugger.Launch();
    }
}