using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

using stdole;

namespace MiNa.InventorAddInDebugger.Common;

public static class PictureDispConverter
{
    private static Guid _iPictureDispGuid = typeof(IPictureDisp).GUID;
    private static readonly HandleCollector HandleCollector = new HandleCollector("Icon handles", 1000);

    /// <summary>Converts IPictureDisp to Icon if it is possible</summary>
    /// <param name="pictureDisp">Converted icon</param>
    /// <returns>Returns Image if pictureDisp.Type=3. Otherwise returns null</returns>
    /// <remarks></remarks>
    public static System.Drawing.Icon? PictureDispToIcon(IPictureDisp pictureDisp)
    {
        System.Drawing.Icon? icon = null;
        if (pictureDisp != null && pictureDisp.Type == (short)3)
            icon = System.Drawing.Icon.FromHandle(new IntPtr(pictureDisp.Handle));
        return icon;
    }

    /// <summary>Converts IPictureDisp to Image if it is possible</summary>
    /// <param name="pictureDisp">Converted image</param>
    /// <returns>Returns Image if pictureDisp.Type=1. Otherwise returns null</returns>
    /// <remarks></remarks>
    public static Image? PictureDispToImage(IPictureDisp pictureDisp)
    {
        Image? image = null;
        if (pictureDisp != null)
        {
            if (pictureDisp.Type == (short)1)
            {
                IntPtr hpalette = new IntPtr(pictureDisp.hPal);
                image = (Image)Image.FromHbitmap(new IntPtr(pictureDisp.Handle), hpalette);
            }

            if (pictureDisp.Type == (short)2)
                image = (Image)new Metafile(new IntPtr(pictureDisp.Handle), new WmfPlaceableFileHeader());
        }

        return image;
    }

    /// <summary>Converts an Icon into a IPictureDisp</summary>
    /// <param name="icon"></param>
    /// <returns></returns>
    public static IPictureDisp ToIPictureDisp(System.Drawing.Icon icon)
    {
        return PictureDispConverter.OleCreatePictureIndirect(
            new PictureDispConverter.PictDesc.Icon(icon),
            ref PictureDispConverter._iPictureDispGuid, true);
    }

    /// <summary>Converts an Image into a IPictureDisp</summary>
    /// <param name="image"></param>
    /// <returns></returns>
    public static IPictureDisp ToIPictureDisp(Image image)
    {
        return PictureDispConverter.OleCreatePictureIndirect(
            new PictureDispConverter.PictDesc.Bitmap(image is System.Drawing.Bitmap
                ? (System.Drawing.Bitmap)image
                : new System.Drawing.Bitmap(image)), ref PictureDispConverter._iPictureDispGuid, true);
    }

    [DllImport("OleAut32.dll", PreserveSig = false)]
    private static extern IPictureDisp OleCreatePictureIndirect(
        PictDesc.Icon pictDescIcon,
        ref Guid iid,
        bool fOwn);

    [DllImport("OleAut32.dll", PreserveSig = false)]
    private static extern IPictureDisp OleCreatePictureIndirect(
        PictDesc.Bitmap pictDescBitmap,
        ref Guid iid,
        bool fOwn);

    private static class PictDesc
    {
        public const short PicTypeUninitialized = -1;
        public const short PicTypeNone = 0;
        public const short PicTypeBitmap = 1;
        public const short PicTypeMetafile = 2;
        public const short PicTypeIcon = 3;
        public const short PicTypeEnhMetafile = 4;

        [StructLayout(LayoutKind.Sequential)]
        public class Icon
        {
            internal int cbSizeOfStruct = Marshal.SizeOf(typeof(PictureDispConverter.PictDesc.Icon));
            internal int picType = PicTypeIcon;
            internal IntPtr hicon = IntPtr.Zero;
            internal int unused1;
            internal int unused2;

            internal Icon(System.Drawing.Icon icon) => this.hicon = icon.ToBitmap().GetHicon();
        }

        [StructLayout(LayoutKind.Sequential)]
        public class Bitmap
        {
            internal int cbSizeOfStruct = Marshal.SizeOf(typeof(PictureDispConverter.PictDesc.Bitmap));
            internal int picType = PicTypeBitmap;
            internal IntPtr hbitmap = IntPtr.Zero;
            internal IntPtr hpal = IntPtr.Zero;
            internal int unused;

            internal Bitmap(System.Drawing.Bitmap bitmap) => this.hbitmap = bitmap.GetHbitmap();
        }
    }
}