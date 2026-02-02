using System.Windows.Forms;
using Inventor;
using MiNa.InventorAddInDebugger.Common;
using MiNa.InventorAddInDebugger.Properties;
using Application = Inventor.Application;

namespace MiNa.InventorAddInDebugger.Commands;

class DeactivateAddInCmd(Application inventor, AddInLoader addInLoader) : Command(inventor)
{
    protected override void ExecuteCommand(NameValueMap context)
    {
        try
        {
            addInLoader.Deactivate();
            ThisApplication.BubbleTip(Resources.Msg_SuccessfullyDeactivated);
        }
        catch (System.Exception ex)
        {
            ThisApplication.PromptBox(Resources.Msg_DeactivationOfAddInFailed,
                Resources.AddIn_DisplayName,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                promptStrings: [ex.ToString()]);
        }
    }
}