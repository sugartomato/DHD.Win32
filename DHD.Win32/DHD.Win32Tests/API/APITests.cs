using DHD.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DHD.Win32.Tests
{
    [TestClass()]
    public class APITests
    {
        [TestMethod()]
        public void GetDeviceCapsTest()
        {
            using (System.Drawing.Graphics g = System.Drawing.Graphics.FromHwnd(IntPtr.Zero))
            {
                Console.WriteLine($"Graphics.DpiX:{g.DpiX}");
                Console.WriteLine($"Graphics.DpiY:{g.DpiY}");

                IntPtr hdc = g.GetHdc();

                foreach (WinAPI.DeviceCapEnum cap in Enum.GetValues(typeof(WinAPI.DeviceCapEnum)))
                {
                    int result = WinAPI.GetDeviceCaps(hdc, (Int32)cap);
                    Console.WriteLine($"{cap}:{result}");
                }
                g.ReleaseHdc();

                System.Windows.Forms.Screen s = System.Windows.Forms.Screen.PrimaryScreen;
                Console.WriteLine($"width:{s.Bounds.Width},height:{s.Bounds.Height}");
                Console.WriteLine("Done!");
            }
        }

        [TestMethod()]
        public void GetSystemMetricsTest()
        {
            Int32 t = WinAPI.GetSystemMetrics((Int32)WinAPI.SystemMetricsEnum.SM_CMONITORS);
            Console.WriteLine(t.ToString());

            Console.WriteLine("枚举所有");
            foreach (WinAPI.SystemMetricsEnum sm in Enum.GetValues(typeof(WinAPI.SystemMetricsEnum)))
            {
                Int32 result = WinAPI.GetSystemMetrics((Int32)sm);
                Console.WriteLine($"{sm}:{result}");
            }
            Console.Write("枚举完成！");
        }

        [TestMethod()]
        public void GetComputerNameExWTest()
        {
            foreach (var e in Enum.GetValues(typeof(WinAPI.COMPUTER_NAME_FORMAT)))
            {
                StringBuilder sb = new StringBuilder(260);
                UInt32 nSize = 260;
                Boolean read = WinAPI.GetComputerNameExW((WinAPI.COMPUTER_NAME_FORMAT)e, sb, ref nSize);
                Console.WriteLine(sb.ToString());
            }




        }

        [TestMethod()]
        public void GetComputerName()
        {
            Console.WriteLine(OSHelper.ComputerName);
        }

    }
}