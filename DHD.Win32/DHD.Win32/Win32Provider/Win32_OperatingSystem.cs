using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHD.Win32.Win32Provider
{
    /// <summary>
    /// The Win32_OperatingSystem WMI class represents a Windows-based operating system installed on a computer.
    /// </summary>
    /// <remarks>
    ///     Minimum supported client:   Windows Vista
    ///     Minimum supported server:   Windows Server 2008
    ///     Namespace:                  Root\CIMV2
    ///     MOF:                        CIMWin32.mof
    ///     DLL:                        CIMWin32.dll
    /// </remarks>
    public class Win32_OperatingSystem : Win32ProviderBase
    {
        /// <summary>
        /// Name of the disk drive from which the Windows operating system starts.
        /// Example: "\\Device\Harddisk0"
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String BootDevice { get; set; } = String.Empty;

        /// <summary>
        /// Build number of an operating system. It can be used for more precise version information than product release version numbers.
        /// Example: "1381"
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String BuildNumber { get; set; } = String.Empty;

        /// <summary>
        /// Type of build used for an operating system.Examples: ""retail build"", ""checked build""
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String BuildType { get; set;} = String.Empty;

        /// <summary>
        /// Short description of the object—a one-line string. The string includes the operating system version. For example, "Microsoft Windows 7 Enterprise ". This property can be localized.
        /// Windows Vista and Windows 7:  This property may contain trailing characters. For example, the string "Microsoft Windows 7 Enterprise " (trailing space included) may be necessary to retrieve information using this property.
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String Caption { get; set; } = String.Empty;

        /// <summary>
        /// Code page value an operating system uses. A code page contains a character table that an operating system uses to translate strings for different languages. The American National Standards Institute (ANSI) lists values that represent defined code pages. If an operating system does not use an ANSI code page, this member is set to 0 (zero). The CodeSet string can use a maximum of six characters to define the code page value.
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String CodeSet { get; set; } = String.Empty;

        /// <summary>
        /// Code for the country/region that an operating system uses. Values are based on international phone dialing prefixes—also referred to as IBM country/region codes. This property can use a maximum of six characters to define the country/region code value.
        /// Example: "1" (United States)
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String CountryCode { get; set; } = String.Empty;

        /// <summary>
        /// Name of the first concrete class that appears in the inheritance chain used in the creation of an instance. When used with other key properties of the class, this property allows all instances of this class and its subclasses to be identified uniquely.
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String CreationClassName { get; set; } = String.Empty;

        /// <summary>
        /// Creation class name of the scoping computer system.
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String CSCreationClassName { get; set; } = String.Empty;

        /// <summary>
        /// NULL-terminated string that indicates the latest service pack installed on a computer. If no service pack is installed, the string is NULL.
        /// Example: "Service Pack 3"
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String CSDVersion { get; set; } = String.Empty;

        /// <summary>
        /// Name of the scoping computer system.
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String CSName { get; set; } = String.Empty;

        /// <summary>
        /// Number, in minutes, an operating system is offset from Greenwich mean time (GMT). The number is positive, negative, or zero.
        /// </summary>
        /// <remarks>
        ///     Data type: sint16
        ///     Access type: Read-only
        /// </remarks>
        public Int16 CurrentTimeZone { get; set; }

        /// <summary>
        /// Operating system is a checked (debug) build. If True, the debugging version is installed. Checked builds provide error checking, argument verification, and system debugging code. Additional code in a checked binary generates a kernel debugger error message and breaks into the debugger. This helps immediately determine the cause and location of the error. Performance may be affected in a checked build due to the additional code that is executed.
        /// </summary>
        /// <remarks>
        ///     Data type: boolean
        ///     Access type: Read-only
        /// </remarks>
        public Boolean Debug { get; set; }

        /// <summary>
        /// Description of the Windows operating system. Some user interfaces for example, those that allow editing of this description, limit its length to 48 characters.
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String Description { get; set; } = String.Empty;

        /// <summary>
        /// If True, the operating system is distributed across several computer system nodes. If so, these nodes should be grouped as a cluster.
        /// </summary>
        /// <remarks>
        ///     Data type: boolean
        ///     Access type: Read-only
        /// </remarks>
        public Boolean Distributed { get; set; }

        /// <summary>
        /// Number, in kilobytes, of physical memory currently unused and available.
        /// </summary>
        /// <remarks>
        ///     Data type: uint64
        ///     Access type: Read-only
        /// </remarks>
        public UInt64 FreePhysicalMemory { get; set; }

        /// <summary>
        /// Number, in kilobytes, that can be mapped into the operating system paging files without causing any other pages to be swapped out.
        /// </summary>
        /// <remarks>
        ///     Data type: uint64
        ///     Access type: Read-only
        /// </remarks>
        public UInt64 FreeSpaceInPagingFiles { get; set; }

        /// <summary>
        /// Number, in kilobytes, of virtual memory currently unused and available.
        /// </summary>
        /// <remarks>
        ///     Data type: uint64
        ///     Access type: Read-only
        /// </remarks>
        public UInt64 FreeVirtualMemory { get; set; }

        /// <summary>
        /// Date object was installed. This property does not require a value to indicate that the object is installed.
        /// </summary>
        /// <remarks>
        ///     Data type: datetime
        ///     Access type: Read-only
        /// </remarks>
        public DateTime InstallDate { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Date and time the operating system was last restarted.
        /// </summary>
        /// <remarks>
        ///     Data type: datetime
        ///     Access type: Read-only
        /// </remarks>
        public DateTime LastBootUpTime { get; set; } = DateTime.MinValue;

        /// <summary>
        /// Operating system version of the local date and time-of-day.
        /// </summary>
        /// <remarks>
        ///     Data type: datetime
        ///     Access type: Read-only
        /// </remarks>
        public DateTime LocalDateTime { get; set; }

        /// <summary>
        /// Language identifier used by the operating system. A language identifier is a standard international numeric abbreviation for a country/region. Each language has a unique language identifier (LANGID), a 16-bit value that consists of a primary language identifier and a secondary language identifier.
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String Locale { get; set; }

        /// <summary>
        /// Name of the operating system manufacturer. For Windows-based systems, this value is "Microsoft Corporation".
        /// </summary>
        /// <remarks>
        ///     Data type: string
        ///     Access type: Read-only
        /// </remarks>
        public String Manufacturer { get; set; }

        /// <summary>
        /// Maximum number of process contexts the operating system can support. The default value set by the provider is 4294967295 (0xFFFFFFFF). If there is no fixed maximum, the value should be 0 (zero). On systems that have a fixed maximum, this object can help diagnose failures that occur when the maximum is reached—if unknown, enter 4294967295 (0xFFFFFFFF).
        /// </summary>
        /// <remarks>
        ///     Data type: uint32
        ///     Access type: Read-only
        /// </remarks>
        public UInt32 MaxNumberOfProcesses { get; set; }

        /// <summary>
        /// Maximum number, in kilobytes, of memory that can be allocated to a process. For operating systems with no virtual memory, typically this value is equal to the total amount of physical memory minus the memory used by the BIOS and the operating system. For some operating systems, this value may be infinity, in which case 0 (zero) should be entered. In other cases, this value could be a constant, for example, 2G or 4G.
        /// </summary>
        /// <remarks>
        ///     Data type: uint64
        ///     Access type: Read-only
        /// </remarks>
        public UInt64 MaxProcessMemorySize { get; set; }

        /// <summary>
        /// Multilingual User Interface Pack (MUI Pack ) languages installed on the computer. For example, "en-us". MUI Pack languages are resource files that can be installed on the English version of the operating system. When an MUI Pack is installed, you can can change the user interface language to one of 33 supported languages.
        /// </summary>
        /// <remarks>
        ///     Data type:  string array
        ///     Access type: Read-only
        /// </remarks>
        public String[] MUILanguages { get; set; }

        /// <summary>
        /// Operating system instance within a computer system.
        /// </summary>
        /// <remarks>
        ///     Data type:  string
        ///     Access type: Read-only
        /// </remarks>
        public String Name { get; set; } = String.Empty;

        /// <summary>
        /// Number of user licenses for the operating system. If unlimited, enter 0 (zero). If unknown, enter -1.
        /// </summary>
        /// <remarks>
        ///     Data type:  uint32
        ///     Access type: Read-only
        /// </remarks>
        public UInt32 NumberOfLicensedUsers { get; set; }

        /// <summary>
        /// Number of process contexts currently loaded or running on the operating system.
        /// </summary>
        /// <remarks>
        ///     Data type:  uint32
        ///     Access type: Read-only
        /// </remarks>
        public UInt32 NumberOfProcesses { get; set; }

        /// <summary>
        /// Number of user sessions for which the operating system is storing state information currently.
        /// </summary>
        /// <remarks>
        ///     Data type:  uint32
        ///     Access type: Read-only
        /// </remarks>
        public UInt32 NumberOfUsers { get; set; }

        /// <summary>
        /// Stock Keeping Unit (SKU) number for the operating system. These values are the same as the PRODUCT_* constants defined in WinNT.h that are used with the GetProductInfo function.
        /// </summary>
        /// <remarks>
        ///     Data type:  uint32
        ///     Access type: Read-only
        /// </remarks>
        public UInt32 OperatingSystemSKU { get; set; }

        /// <summary>
        /// Company name for the registered user of the operating system.
        /// </summary>
        /// <remarks>
        ///     Data type:  string
        ///     Access type: Read-only
        /// </remarks>
        public String Organization { get; set; }

        /// <summary>
        /// Architecture of the operating system, as opposed to the processor. This property can be localized.
        /// </summary>
        /// <remarks>
        ///     Data type:  string
        ///     Access type: Read-only
        /// </remarks>
        public String OSArchitecture { get; set; }

        /// <summary>
        /// Language version of the operating system installed. 
        ///     参考：https://learn.microsoft.com/en-us/windows/win32/cimwin32prov/win32-operatingsystem
        /// </summary>
        /// <remarks>
        ///     Data type:  uint32
        ///     Access type: Read-only
        /// </remarks>
        public UInt32 OSLanguage { get; set; }

        /// <summary>
        /// Installed and licensed system product additions to the operating system. For example, the value of 146 (0x92) for OSProductSuite indicates Enterprise, Terminal Services, and Data Center (bits one, four, and seven set). The following list lists possible values.
        /// </summary>
        /// <remarks>
        ///     Data type:  uint32
        ///     Access type: Read-only
        /// </remarks>
        public UInt32 OSProductSuite { get; set; }

        /// <summary>
        /// Type of operating system. The following list identifies the possible values.
        /// </summary>
        /// <remarks>
        ///     Data type:  uint16
        ///     Access type: Read-only
        /// </remarks>
        public UInt16 OSType { get; set; }

        /// <summary>
        /// Operating system product serial identification number.
        /// Example: "10497-OEM-0031416-71674"
        /// </summary>
        public String SerialNumber { get; set; } = String.Empty;

        /// <summary>
        /// Current status of the object. Various operational and nonoperational statuses can be defined. Operational statuses include: "OK", "Degraded", and "Pred Fail" (an element, such as a SMART-enabled hard disk drive may function properly, but predicts a failure in the near future). Nonoperational statuses include: "Error", "Starting", "Stopping", and "Service". The Service status applies to administrative work, such as mirror-resilvering of a disk, reload of a user permissions list, or other administrative work. Not all such work is online, but the managed element is neither "OK" nor in one of the other states.
        /// </summary>
        /// <remarks>
        ///     Data type:  string
        ///     Access type: Read-only
        /// </remarks>
        public String Status { get; set; }

        /// <summary>
        /// Bit flags that identify the product suites available on the system.
        /// For example, to specify both Personal and BackOffice, set SuiteMask to 4 | 512 or 516.
        /// Example: "4.0"
        /// <remarks>
        ///     Data type:  uint32
        ///     Access type: Read-only
        /// </remarks>
        /// </summary>
        public UInt32 SuiteMask { get; set; } = 0;

        /// <summary>
        /// Version number of the operating system.
        /// </summary>
        /// <remarks>
        ///     Data type:  string
        ///     Access type: Read-only
        /// </remarks>
        public String Version { get; set; } = String.Empty;
    }

    /// <summary>
    /// Bit flags that identify the product suites available on the system.
    /// </summary>
    public enum Win32_OperatingSystem_SuiteMaskEnum : UInt32
    {
        Small_Business = 1,
        Enterprise = 2,
        BackOffice = 4,
        Communications = 8,
        Terminal_Services = 16,
        Small_Business_Restricted = 32,
        Embedded_Edition = 64,
        Datacenter_Edition = 128,
        Single_User = 256,
        Home_Edition = 512,
        Web_Server_Edition = 2048
    }

}
