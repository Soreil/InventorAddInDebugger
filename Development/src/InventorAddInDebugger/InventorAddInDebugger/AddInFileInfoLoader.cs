using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

using MiNa.InventorAddInDebugger.UI;

namespace MiNa.InventorAddInDebugger;

internal static class AddInFileInfoLoader
{
    /// <summary>
    /// Gets the information about addin from .addin file
    /// </summary>
    /// <param name="addinFile">Full path to the .addin file</param>
    /// <returns></returns>
    public static AddInInfo? AddInInfo(string addinFile)
    {
        var addinXml = new XmlDocument();
        addinXml.Load(addinFile);
        if (addinXml.DocumentElement == null)
            return null;

        string clientId = addinXml.DocumentElement["ClientId"]?.InnerText ?? "";
        string assembly = addinXml.DocumentElement["Assembly"]?.InnerText ?? "";
        string? fullName = GetFullName(addinFile, assembly);
        var addInInfo = new AddInInfo(fullName ?? "", clientId);
        return addInInfo;
    }

    private static string? GetFullName(string addinFile, string assembly)
    {
        //Contains full file name
        if (Path.IsPathRooted(assembly)) return assembly;

        string addinFileDirectory = Path.GetDirectoryName(addinFile) ?? "";
        string expectedFullName = Path.Combine(addinFileDirectory, assembly);
        if (File.Exists(expectedFullName))
            return expectedFullName;

        string expectedRootDir = Path.GetDirectoryName(expectedFullName) ?? "";
        string dllFileName = Path.GetFileName(expectedFullName);
        string[] foundDlls = Directory.EnumerateFiles(expectedRootDir, dllFileName, SearchOption.AllDirectories).ToArray();
        return foundDlls.Length switch
        {
            0 => null,
            1 => foundDlls[0],
            _ => SelectDll(expectedRootDir, foundDlls),
        };
    }

    private static string? SelectDll(string rootDir, string[] foundDlls)
    {
        var selectDllDlg = new SelectDllDlg() { RootDir = rootDir, FoundDlls = foundDlls };
        var dialogResult = selectDllDlg.ShowDialog();
        if (dialogResult == DialogResult.OK)
            return selectDllDlg.SelectedDll;
        return null;
    }
}