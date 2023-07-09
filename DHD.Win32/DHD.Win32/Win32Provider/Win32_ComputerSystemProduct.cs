using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHD.Win32.Win32Provider
{
    /// <summary>
    /// The Win32_ComputerSystemProduct WMI class represents a product. This includes software and hardware used on this computer system.
    /// </summary>
    /// <remarks>
    /// The Win32_ComputerSystemProduct class is derived from CIM_Product.
    /// </remarks>
    public class Win32_ComputerSystemProduct : Win32ProviderBase
    {

        /// <summary>
        /// 产品的简短文本说明。
        /// Short textual description for the product.
        /// This property is inherited from CIM_Product.
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        /// 产品的文本说明。
        /// Textual description of the product.
        /// This property is inherited from CIM_Product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 产品标识，例如软件上的序列号、硬件芯片上的芯片编号或非商业产品的 () 项目编号。
        /// Product identification, such as a serial number on software, a die number on a hardware chip, or (for noncommercial products) a project number.
        /// This property is inherited from CIM_Product.
        /// </summary>
        public string IdentifyingNumber { get; set; }

        /// <summary>
        /// 常用的产品名称。
        /// Product's stock-keeping unit (SKU) information.
        /// This property is inherited from CIM_Product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// Product's stock-keeping unit (SKU) information.
        /// This property is inherited from CIM_Product.
        /// </summary>
        public string SKUNumber { get; set; }

        /// <summary>
        /// Universally unique identifier (UUID) for this product. A UUID is a 128-bit identifier that is guaranteed to be different from other generated UUIDs. If a UUID is not available, a UUID of all zeros is used.
        /// This value comes from the UUID member of the System Information structure in the SMBIOS information.
        /// </summary>
        public string UUID { get; set; }

        /// <summary>
        /// 产品供应商的名称，或销售产品 (制造商、经销商、OEM 等) 的实体的名称
        /// Name of the product's supplier, or the entity selling the product (the manufacturer, reseller, OEM, and so on).
        /// This property is inherited from CIM_Product.
        /// </summary>
        public string Vendor { get; set; }

        /// <summary>
        /// 
        /// Product version information.
        /// This property is inherited from CIM_Product.
        /// </summary>
        public string Version { get; set; }
    }
}
