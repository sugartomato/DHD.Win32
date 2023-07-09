using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHD.Win32
{
    /// <summary>
    /// 系统信息相关
    /// </summary>
    public class OSHelper
    {

        /// <summary>
        /// 计算机名
        /// </summary>
        public static String ComputerName
        {
            get
            {
                StringBuilder sb = new StringBuilder(260);
                UInt32 nSize = 260;
                Boolean read = WinAPI.GetComputerNameW(sb, ref nSize);
                if (read)
                {
                    return sb.ToString();
                }
                return "计算机名获取失败";
            }
        }


        private static Win32Provider.Win32_OperatingSystem _OperatingSystem = null;

        /// <summary>
        /// 系统名称
        /// </summary>
        public static String OSName
        {
            get
            {
                if (_OperatingSystem == null)
                {
                    _OperatingSystem = Win32Provider.ProviderHelper<Win32Provider.Win32_OperatingSystem>.GetAll()[0];
                }
                return _OperatingSystem.Name;
            }
        }

        /// <summary>
        /// 系统标签
        /// </summary>
        public static String OSCaption
        {
            get
            {
                if (_OperatingSystem == null)
                {
                    _OperatingSystem = Win32Provider.ProviderHelper<Win32Provider.Win32_OperatingSystem>.GetAll()[0];
                }
                return _OperatingSystem.Caption;
            }
        }

        /// <summary>
        /// 系统版本号
        /// </summary>
        public static String OSVersion
        {
            get
            {
                if (_OperatingSystem == null)
                {
                    _OperatingSystem = Win32Provider.ProviderHelper<Win32Provider.Win32_OperatingSystem>.GetAll()[0];
                }
                return _OperatingSystem.Version;
            }
        }

        /// <summary>
        /// 系统安装日期
        /// </summary>
        public static DateTime OSInstallDate
        {
            get
            {
                if (_OperatingSystem == null)
                {
                    _OperatingSystem = Win32Provider.ProviderHelper<Win32Provider.Win32_OperatingSystem>.GetAll()[0];
                }
                return _OperatingSystem.InstallDate;
            }
        }


        public static UInt32 OSSuiteMask
        {
            get
            {
                if (_OperatingSystem == null)
                {
                    _OperatingSystem = Win32Provider.ProviderHelper<Win32Provider.Win32_OperatingSystem>.GetAll()[0];
                }
                return _OperatingSystem.SuiteMask;
            }
        }




    }
}
