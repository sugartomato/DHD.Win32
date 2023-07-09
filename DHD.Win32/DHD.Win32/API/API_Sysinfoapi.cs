using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace DHD.Win32
{
    /// <summary>
    /// 系统信息相关API
    /// </summary>
    public partial class WinAPI
    {

        /// <summary>
        /// 检索本地计算机的 NetBIOS 名称。 当系统从注册表读取该名称时，会在系统启动时建立此名称。
        /// GetComputerName 仅检索本地计算机的 NetBIOS 名称。 若要检索 DNS 主机名、DNS 域名或完全限定的 DNS 名称，请调用 GetComputerNameEx 函数。 IADsADSystemInfo 接口提供了其他信息。
        /// </summary>
        /// <param name="lpBuffer">
        ///     指向接收计算机名称或群集虚拟服务器名称的缓冲区的指针。 缓冲区大小应足够大，可以包含MAX_COMPUTERNAME_LENGTH + 1 个字符。
        /// </param>
        /// <param name="nSize">
        ///     在输入中，以 TCHAR 指定缓冲区的大小。 在输出中，复制到目标缓冲区的 TCHAR 数，不包括终止 null 字符。
        ///     如果缓冲区太小，函数将失败， GetLastError 返回ERROR_BUFFER_OVERFLOW。 lpnSize 参数指定所需的缓冲区大小，包括终止 null 字符。
        /// </param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern Boolean GetComputerNameW(StringBuilder lpBuffer, ref UInt32 nSize);


        /// <summary>
        /// 检索与本地计算机关联的 NetBIOS 或 DNS 名称。 当系统从注册表读取名称时，会在系统启动时建立这些名称。
        /// </summary>
        /// <param name="NameType">要检索的名称的类型。 此参数是 COMPUTER_NAME_FORMAT 枚举类型的值。</param>
        /// <param name="lpBuffer">
        ///     指向接收计算机名称或群集虚拟服务器名称的缓冲区的指针。
        ///     名称的长度可能大于MAX_COMPUTERNAME_LENGTH字符，因为 DNS 允许更长的名称。 若要确保此缓冲区足够大，请将此参数设置为 NULL ，并使用 lpnSize 参数中返回的所需缓冲区大小。
        /// </param>
        /// <param name="nSize">
        ///     在输入时，在 TCHAR 中指定缓冲区的大小。 在输出中，接收复制到目标缓冲区的 TCHAR 数，不包括终止 null 字符。
        ///     如果缓冲区太小，函数将失败， GetLastError 返回ERROR_MORE_DATA。 此参数接收所需的缓冲区大小，包括终止 null 字符。
        ///     如果 lpBuffer 为 NULL，则此参数必须为零。
        /// </param>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError=true, CharSet=CharSet.Auto)]
        public static extern Boolean GetComputerNameExW(COMPUTER_NAME_FORMAT NameType, StringBuilder lpBuffer, ref UInt32 nSize);


        /// <summary>
        /// 计算机名称检索的类型
        /// </summary>
        public enum COMPUTER_NAME_FORMAT
        { 
        
            /// <summary>
            /// 本地计算机的 NetBIOS 名称或与本地计算机关联的群集。 
            /// 此名称限制为MAX_COMPUTERNAME_LENGTH + 1 个字符，可能是 DNS 主机名的截断版本。 
            /// 例如，如果 DNS 主机名为“corporate-mail-server”，则 NetBIOS 名称将为“corporate-mail-”。
            /// </summary>
            ComputerNameDnsDomain,

            /// <summary>
            /// 本地计算机的 DNS 名称或与本地计算机关联的群集。
            /// </summary>
            ComputerNameDnsHostname,

            /// <summary>
            /// 唯一标识本地计算机或与本地计算机关联的群集的完全限定 DNS 名称。
            /// 此名称是 DNS 主机名和 DNS 域名的组合，格式为 HostName.DomainName。 例如，如果 DNS 主机名为“corporate-mail-server”，而 DNS 域名为“microsoft.com”，则完全限定的 DNS 名称为“corporate-mail-server.microsoft.com”。
            /// </summary>
            ComputerNameDnsFullyQualified,

            /// <summary>
            /// 本地计算机的 NetBIOS 名称。 在群集上，这是群集上本地节点的 NetBIOS 名称。
            /// </summary>
            ComputerNamePhysicalNetBIOS,

            /// <summary>
            /// 本地计算机的 DNS 主机名。 在群集上，这是群集上本地节点的 DNS 主机名。
            /// </summary>
            ComputerNamePhysicalDnsHostname,

            /// <summary>
            /// 分配给本地计算机的 DNS 域的名称。 在群集上，这是群集上本地节点的 DNS 域。
            /// </summary>
            ComputerNamePhysicalDnsDomain,

            /// <summary>
            /// 唯一标识计算机的完全限定 DNS 名称。 在群集上，这是群集上本地节点的完全限定 DNS 名称。 此完全限定的 DNS 名称是 DNS 主机名和 DNS 域名的组合，格式为 HostName.DomainName
            /// </summary>
            ComputerNamePhysicalDnsFullyQualified,

            /// <summary>
            /// 未使用的参数
            /// </summary>
            ComputerNameMax,
        }

    }
}
