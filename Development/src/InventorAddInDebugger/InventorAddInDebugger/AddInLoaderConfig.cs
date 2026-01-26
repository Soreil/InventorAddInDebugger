using System.Collections.Generic;

namespace MiNa.InventorAddInDebugger;

/// <summary>
/// AddIn loader configuration
/// </summary>
/// <param name="AddInAssemblyFile"> Gets and sets the full file name of the original build of the AddIn </param>
/// <param name="AddInClientId"> Gets and sets the ClientId of the AddIn </param>
/// <param name="AddInFullName"> Gets and sets the type FullName of the AddIn </param>
/// <param name="LoadOnStart"> Loads debugged AddIn when inventor starts </param>
public class AddInLoaderConfig()
{
    public string AddInAssemblyFile { get; set; } = "";
    public string AddInClientId { get; set; } = "";
    public string AddInFullName { get; set; } = "";
    public bool LoadOnStart { get; set; } = false;
    public List<AddInInfo> MruAddInInfos { get; set; } = [];
}