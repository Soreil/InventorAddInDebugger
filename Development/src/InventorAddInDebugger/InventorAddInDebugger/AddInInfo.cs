namespace MiNa.InventorAddInDebugger
{
    /// <summary>
    /// Provides information about add-in in assembly
    /// </summary>
    /// <param name="FullName"> Gets the full name of the AddIn type </param>
    /// <param name="ClientId"> Gets the ClientId of the AddIn </param>
    public class AddInInfo
    {
        public AddInInfo()
        {

        }
        public AddInInfo(string fullName, string clientId)
        {
            FullName = fullName;
            ClientId = clientId;
        }

        public string FullName { get; set; } = "";
        public string ClientId { get; set; } = "";
    }

    public static class AddInInfoExtension
    {
        public static string DisplayName(this AddInInfo addInInfo) => addInInfo.FullName.Substring(10);
    }
}

