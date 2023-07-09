using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DHD.Win32
{
    /// <summary>
    /// WindowsAPI定义
    /// </summary>
    public partial class WinAPI
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hdc">
        ///     A handle to the DC.
        /// </param>
        /// <param name="nIndex">
        ///     The item to be returned. This parameter can be one of the following values.
        /// </param>
        /// <returns>
        ///     The return value specifies the value of the desired item.
        ///     When nIndex is BITSPIXEL and the device has 15bpp or 16bpp, the return value is 16.
        /// </returns>
        [DllImport("gdi32.dll")]
        public static extern Int32 GetDeviceCaps(IntPtr hdc,Int32 nIndex);

        /// <summary>
        /// 
        /// </summary>
        public enum DeviceCapEnum:Int32
        {
            /// <summary>
            /// The device driver version.
            /// </summary>
            DRIVERVERSION = 0,

            /// <summary>
            /// Device technology. It can be any one of the following values.
            /// </summary>
            TECHNOLOGY = 2,

            /// <summary>
            /// 屏幕的屋里宽度，单位毫米
            /// Width, in millimeters, of the physical screen.
            /// </summary>
            HORZSIZE = 4,

            /// <summary>
            /// 屏幕的物理高度，单位毫米
            /// Height, in millimeters, of the physical screen.
            /// </summary>
            VERTSIZE = 6,

            /// <summary>
            /// Width, in pixels, of the screen; or for printers, the width, in pixels, of the printable area of the page.
            /// </summary>
            HORZRES = 8,

            /// <summary>
            /// Height, in raster lines, of the screen; or for printers, the height, in pixels, of the printable area of the page.
            /// </summary>
            VERTRES = 10,

            /// <summary>
            /// 屏幕的垂直发刷新频率。
            /// For display devices: the current vertical refresh rate of the device, in cycles per second (Hz).
            /// A vertical refresh rate value of 0 or 1 represents the display hardware's default refresh rate. This default rate is typically set by switches on a display card or computer motherboard, or by a configuration program that does not use display functions such as ChangeDisplaySettings.
            /// </summary>
            VREFRESH = 116,

            /// <summary>
            /// Vertical height of entire desktop in pixels
            /// </summary>
            DESKTOPVERTRES = 117,

            /// <summary>
            /// Horizontal width of entire desktop in pixels
            /// </summary>
            DESKTOPHORZRES = 118,

            /// <summary>
            /// Number of pixels per logical inch along the screen width. 
            /// In a system with multiple display monitors, this value is the same for all monitors.
            /// </summary>
            LOGPIXELSX = 88,
 
            /// <summary>
            /// Number of pixels per logical inch along the screen height. 
            /// In a system with multiple display monitors, this value is the same for all monitors.
            /// </summary>
            LOGPIXELSY = 90,
        }
    }
}
