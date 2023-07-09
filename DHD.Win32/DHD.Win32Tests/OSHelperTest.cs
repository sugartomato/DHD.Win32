using DHD.Win32;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DHD.Win32Tests
{
    [TestClass]
    public class OSHelperTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(OSHelper.ComputerName);
            Console.WriteLine(OSHelper.OSName);
            Console.WriteLine(OSHelper.OSCaption);
            Console.WriteLine(OSHelper.OSVersion);
            Console.WriteLine(OSHelper.OSInstallDate);
            Console.WriteLine(OSHelper.OSSuiteMask);


        }
    }
}
