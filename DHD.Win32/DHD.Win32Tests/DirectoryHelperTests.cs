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
    public class DirectoryHelperTests
    {
        [TestMethod()]
        public void MoveTest()
        {
            Boolean result = DirectoryHelper.Move(@"C:\Users\sugar\Desktop\20230627_徐姗姗发文 - 副本", @"D:\BaiduNetdiskDownload");
            Console.WriteLine(result);
        }
    }
}