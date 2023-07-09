using Microsoft.VisualStudio.TestTools.UnitTesting;
using DHD.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHD.Win32.Tests
{
    [TestClass()]
    public class ScreenHelperTests
    {
        [TestMethod()]
        public void GetScreenDisplayResolutionTest()
        {
            System.Drawing.Size s = ScreenHelper.GetScreenDisplayResolution();
            Console.WriteLine($"width:{s.Width},height:{s.Height}");
        }

        [TestMethod()]
        public void GetScreenActualResloutionTest()
        {
            System.Drawing.Size s = ScreenHelper.GetScreenActualResloution();
            Console.WriteLine($"width:{s.Width},height:{s.Height}");
        }
    }
}