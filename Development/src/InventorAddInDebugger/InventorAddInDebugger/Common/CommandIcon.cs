using System;
using stdole;

namespace MiNa.InventorAddInDebugger.Common;

/// <summary>Creates new instance</summary>
/// <param name="icon">Source icon</param>
public class CommandIcon(System.Drawing.Icon icon)
{

    /// <summary>Returns 16 pix icon</summary>
    public System.Drawing.Icon Ico16 => new System.Drawing.Icon(this.SourceIcon, 16, 16);

    /// <summary>Returns 24 pix icon</summary>
    public System.Drawing.Icon Ico24 => new System.Drawing.Icon(this.SourceIcon, 24, 24);

    /// <summary>Returns 32 pix icon</summary>
    public System.Drawing.Icon Ico32 => new System.Drawing.Icon(this.SourceIcon, 32, 32);

    /// <summary>Returns 32 pix icon converted to IPictureDisp</summary>
    public IPictureDisp? LargeRibboIcon => this.ToIPictureDisp(CommandIcon.IconSizeEnum.LargeRibbon);

    /// <summary>Returns 16 pix icon converted to IPictureDisp</summary>
    public IPictureDisp? SmallRibboIcon => this.ToIPictureDisp(CommandIcon.IconSizeEnum.SmallRibbon);

    /// <summary>Source icon</summary>
    public System.Drawing.Icon SourceIcon { get; set; } = icon;

    private IPictureDisp? ToIPictureDisp(CommandIcon.IconSizeEnum size)
    {
        try
        {
            return size switch
            {
                CommandIcon.IconSizeEnum.SmallRibbon => PictureDispConverter.ToIPictureDisp(this.Ico16),
                CommandIcon.IconSizeEnum.LargeRibbon => PictureDispConverter.ToIPictureDisp(this.Ico32),
                CommandIcon.IconSizeEnum.CommandBar => PictureDispConverter.ToIPictureDisp(this.Ico24),
                _ => null,
            };
        }
        catch (Exception)
        {
            return null;
        }
    }

    private enum IconSizeEnum
    {
        SmallRibbon,
        LargeRibbon,
        CommandBar,
    }
}