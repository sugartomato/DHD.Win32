using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DHD.Win32.Win32Provider;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DHD.Win32Tests
{
    [TestClass]
    public class Win32ProviderTest
    {
        [TestMethod]
        public void Win32_ComputerSystemTest()
        {

            List<Win32_ComputerSystem> list = ProviderHelper<Win32_ComputerSystem>.GetAll();

            if (list.Count > 0)
            {
                foreach (var l in list)
                {
                    Console.WriteLine(l.ToDebugString());
                }
            }



        }


        [TestMethod]
        public void Win32_OperatingSystemTest()
        {
            List<Win32_OperatingSystem> list = ProviderHelper<Win32_OperatingSystem>.GetAll();

            if (list.Count > 0)
            {
                foreach (var l in list)
                {
                    Console.WriteLine(l.ToDebugString());
                }
            }
        }


        [TestMethod]
        public void Win32_ComputerSystemProductTest()
        {
            List<Win32_ComputerSystemProduct> list = ProviderHelper<Win32_ComputerSystemProduct>.GetAll();

            if (list.Count > 0)
            {
                foreach (var l in list)
                {
                    Console.WriteLine(l.ToDebugString());
                }
            }
        }

    }
}
