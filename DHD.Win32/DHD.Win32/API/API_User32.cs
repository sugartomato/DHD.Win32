using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DHD.Win32
{
    public partial class WinAPI
    {

        /// <summary>
        ///     The GetDC function retrieves a handle to a device context (DC) for the client area of a specified window or for the entire screen. You can use the returned handle in subsequent GDI functions to draw in the DC. The device context is an opaque data structure, whose values are used internally by GDI.
        ///     The GetDCEx function is an extension to GetDC, which gives an application more control over how and whether clipping occurs in the client area.
        /// </summary>
        /// <param name="hWnd">
        ///     A handle to the window whose DC is to be retrieved. If this value is NULL, GetDC retrieves the DC for the entire screen.
        /// </param>
        /// <returns>
        ///     The GetDC function retrieves a common, class, or private DC depending on the class style of the specified window. For class and private DCs, GetDC leaves the previously assigned attributes unchanged. However, for common DCs, GetDC assigns default attributes to the DC each time it is retrieved. For example, the default font is System, which is a bitmap font. Because of this, the handle to a common DC returned by GetDC does not tell you what font, color, or brush was used when the window was drawn. To determine the font, call GetTextFace.
        ///     Note that the handle to the DC can only be used by a single thread at any one time
        ///     After painting with a common DC, the ReleaseDC function must be called to release the DC. Class and private DCs do not have to be released. ReleaseDC must be called from the same thread that called GetDC. The number of DCs is limited only by available memory.
        /// </returns>
        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);


        /// <summary>
        ///     The ReleaseDC function releases a device context (DC), freeing it for use by other applications. 
        ///     The effect of the ReleaseDC function depends on the type of DC. It frees only common and window DCs. It has no effect on class or private DCs.
        /// </summary>
        /// <param name="hWnd">
        ///     A handle to the window whose DC is to be released.
        /// </param>
        /// <param name="hDC">
        ///     A handle to the DC to be released.
        /// </param>
        /// <returns>
        ///     The return value indicates whether the DC was released. If the DC was released, the return value is 1.
        ///     If the DC was not released, the return value is zero.
        /// </returns>
        /// <remarks>
        ///     The application must call the ReleaseDC function for each call to the GetWindowDC function and for each call to the GetDC function that retrieves a common DC.
        ///     An application cannot use the ReleaseDC function to release a DC that was created by calling the CreateDC function; instead, it must use the DeleteDC function. 
        ///     ReleaseDC must be called from the same thread that called GetDC.
        /// </remarks>
        [DllImport("user32.dll")]
        public static extern Boolean ReleaseDC(IntPtr hWnd, IntPtr hDC);


        /// <summary>
        /// Retrieves the specified system metric or system configuration setting.
        /// Note that all dimensions retrieved by GetSystemMetrics are in pixels.
        /// </summary>
        /// <param name="nIndex">
        /// The system metric or configuration setting to be retrieved. This parameter can be one of the following values. 
        /// Note that all SM_CX* values are widths and all SM_CY* values are heights. 
        /// Also note that all settings designed to return Boolean data represent TRUE as any nonzero value, and FALSE as a zero value.
        /// </param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern Int32 GetSystemMetrics(Int32 nIndex);

        /// <summary>
        /// Retrieves the specified system metric or system configuration setting taking into account a provided DPI.
        /// </summary>
        /// <param name="nIndex">
        ///     The system metric or configuration setting to be retrieved. See GetSystemMetrics for the possible values.
        /// </param>
        /// <param name="dpi">
        ///     The DPI to use for scaling the metric.
        /// </param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern Int32 GetSystemMetricsForDpi(Int32 nIndex, UInt32 dpi);

        /// <summary>
        /// GetSystemMetrics参数定义枚举
        /// </summary>
        public enum SystemMetricsEnum:Int32
        {
            /// <summary>
            /// The flags that specify how the system arranged minimized windows. For more information, see the Remarks section in this topic.
            /// </summary>
            SM_ARRANGE = 56,

            /// <summary>
            /// The value that specifies how the system is started:
            ///     0 Normal boot
            ///     1 Fail-safe boot
            ///     2 Fail-safe with network boot
            ///  A fail-safe boot (also called SafeBoot, Safe Mode, or Clean Boot) bypasses the user startup files.
            /// </summary>
            SM_CLEANBOOT = 67,

            /// <summary>
            /// The number of display monitors on a desktop. For more information, see the Remarks section in this topic.
            /// </summary>
            SM_CMONITORS = 80,

            /// <summary>
            /// The number of buttons on a mouse, or zero if no mouse is installed.
            /// </summary>
            SM_CMOUSEBUTTONS = 43,

            /// <summary>
            /// The width of a window border, in pixels. This is equivalent to the SM_CXEDGE value for windows with the 3-D look.
            /// </summary>
            SM_CXBORDER = 5,

            /// <summary>
            /// The width of a cursor, in pixels. The system cannot create cursors of other sizes.
            /// </summary>
            SM_CXCURSOR = 13,

            /// <summary>
            /// This value is the same as SM_CXFIXEDFRAME.
            /// </summary>
            SM_CXDLGFRAME = 7,

            /// <summary>
            /// The width of the rectangle around the location of a first click in a double-click sequence, in pixels. The second click must occur within the rectangle that is defined by SM_CXDOUBLECLK and SM_CYDOUBLECLK for the system to consider the two clicks a double-click. The two clicks must also occur within a specified time.
            /// To set the width of the double-click rectangle, call SystemParametersInfo with SPI_SETDOUBLECLKWIDTH.
            /// </summary>
            SM_CXDOUBLECLK = 36,

            /// <summary>
            /// The width of the screen of the primary display monitor, in pixels. 
            /// This is the same value obtained by calling GetDeviceCaps as follows: GetDeviceCaps( hdcPrimaryMonitor, HORZRES).
            /// </summary>
            SM_CXSCREEN = 0,

            /// <summary>
            /// The height of the screen of the primary display monitor, in pixels. 
            /// This is the same value obtained by calling GetDeviceCaps as follows: GetDeviceCaps( hdcPrimaryMonitor, VERTRES).
            /// </summary>
            SM_CYSCREEN = 1,

        }


    }
}
