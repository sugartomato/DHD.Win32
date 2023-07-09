using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DHD.Win32
{
    /// <summary>
    /// 屏幕相关
    /// </summary>
    public class ScreenHelper
    {
        #region 测试区方法

        /// <summary>
        /// 获取当前屏幕DPI
        /// </summary>
        /// <returns></returns>
        public static Int32 GetDPI()
        {
            IntPtr hdc = WinAPI.GetDC(IntPtr.Zero);
            Int32 result = WinAPI.GetDeviceCaps(hdc, (Int32)WinAPI.DeviceCapEnum.LOGPIXELSX);
            WinAPI.ReleaseDC(IntPtr.Zero, hdc);
            return result;
        }


        #endregion



        /// <summary>
        /// 获取屏幕的实际分辨率
        /// </summary>
        /// <returns></returns>
        public static Size GetScreenActualResloution()
        {
            //using (System.Drawing.Graphics g = System.Drawing.Graphics.FromHwnd(IntPtr.Zero))
            //{
            //    IntPtr hdc = g.GetHdc();

            //    Size result = new Size(
            //        API.GetDeviceCaps(hdc, (Int32)API.DeviceCapEnum.DESKTOPHORZRES),
            //        API.GetDeviceCaps(hdc, (Int32)API.DeviceCapEnum.DESKTOPVERTRES)
            //     );
            //    g.ReleaseHdc();
            //    return result;
            //}

            IntPtr hdc = WinAPI.GetDC(IntPtr.Zero);
            Size result = new Size(
                WinAPI.GetDeviceCaps(hdc, (Int32)WinAPI.DeviceCapEnum.DESKTOPHORZRES),
                WinAPI.GetDeviceCaps(hdc, (Int32)WinAPI.DeviceCapEnum.DESKTOPVERTRES)
            );
            WinAPI.ReleaseDC(IntPtr.Zero, hdc);
            return result;
        }


        public static Size GetScreenDisplayResolution(IntPtr hwnd)
        {
            Size result = new Size(
                WinAPI.GetDeviceCaps(hwnd, (Int32)WinAPI.DeviceCapEnum.HORZRES),
                WinAPI.GetDeviceCaps(hwnd, (Int32)WinAPI.DeviceCapEnum.VERTRES)
             );
            return result;
        }

        /// <summary>
        /// 获取屏幕的显示分辨率。比如实际分辨率是2560*1600，在150%的显示比例下，显示分辨率为1707*107
        /// </summary>
        /// <returns></returns>
        public static Size GetScreenDisplayResolution()
        {
            //using (System.Drawing.Graphics g = System.Drawing.Graphics.FromHwnd(IntPtr.Zero))
            //{
            //    IntPtr hdc = g.GetHdc();
            //    Size result = new Size(
            //        API.GetDeviceCaps(hdc, (Int32)API.DeviceCapEnum.HORZRES),
            //        API.GetDeviceCaps(hdc, (Int32)API.DeviceCapEnum.VERTRES)
            //     );
            //    g.ReleaseHdc();
            //    return result;
            //}
            IntPtr hdc = WinAPI.GetDC(IntPtr.Zero);
            Size result = new Size(
                WinAPI.GetDeviceCaps(hdc, (Int32)WinAPI.DeviceCapEnum.HORZRES),
                WinAPI.GetDeviceCaps(hdc, (Int32)WinAPI.DeviceCapEnum.VERTRES)
            );
            WinAPI.ReleaseDC(IntPtr.Zero, hdc);
            return result;

        }


    }
}
