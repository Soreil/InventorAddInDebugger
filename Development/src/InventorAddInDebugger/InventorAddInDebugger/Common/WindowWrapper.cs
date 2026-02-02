using System;
using System.Windows.Forms;

namespace MiNa.InventorAddInDebugger.Common;

/// <summary>Converts hWnd to IWin32Window</summary>
/// <remarks>Example:
/// Form.Show(new WindowWrapper(ThisApplication.MainFrameHWND))</remarks>
/// <remarks>Constructor</remarks>
/// <param name="handle">Inventor.Application.MainFrameHWND</param>
/// <remarks></remarks>
public class WindowWrapper(IntPtr handle) : IWin32Window
{

    /// <summary>Main window handle</summary>
    public IntPtr Handle { get; } = handle;
}