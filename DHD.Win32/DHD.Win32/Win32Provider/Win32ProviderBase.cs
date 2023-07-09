using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DHD.Win32.Win32Provider
{
    /// <summary>
    /// 基础类
    /// </summary>
    public class Win32ProviderBase
    {
        /// <summary>
        /// 实例化
        /// </summary>
        public Win32ProviderBase()
        { }

        /// <summary>
        /// 改类型的ManagementObject数据
        /// </summary>
        public System.Management.ManagementObject ManageObject { get; set; }

        /// <summary>
        /// 输出该类的所有属性的名称、值、类型
        /// </summary>
        /// <returns></returns>
        public string ToDebugString()
        {
            System.Reflection.PropertyInfo[] ps = this.GetType().GetProperties();
            if(ps == null || ps.Length == 0)
                return null;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*".PadLeft(30, '*'));
            foreach(var pro in ps)
            {
                if(pro.PropertyType == typeof(System.String[]))
                {
                    object val = pro.GetValue(this, null);
                    if(val != null)
                    {

                        string strVal = string.Empty;
                        foreach(string item in val as string[])
                        {
                            strVal += "|" + item;
                        }

                        sb.AppendLine(string.Format("[{0}]\t[{1}]\t[{2}]", pro.Name, strVal, pro.PropertyType.FullName));
                    }
                    else
                    {
                        sb.AppendLine(string.Format("[{0}]\t[{1}]\t[{2}]", pro.Name, "", pro.PropertyType.FullName));
                    }
                }
                else
                {
                    sb.AppendLine(string.Format("[{0}]\t[{1}]\t[{2}]", pro.Name, pro.GetValue(this, null), pro.PropertyType.FullName));
                }

            }

            return sb.ToString();
        }

        /// <summary>
        /// 将参数props中指定名称的属性输出调试信息字符串
        /// </summary>
        /// <param name="props"></param>
        /// <returns></returns>
        public String ToDebugString(List<String> props)
        {
            if (props == null) props = new List<string>();
            System.Reflection.PropertyInfo[] ps = this.GetType().GetProperties();
            if (ps == null || ps.Length == 0)
                return null;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*".PadLeft(30, '*'));
            foreach (var pro in ps)
            {
                if (props.Contains(pro.Name))
                {
                    if (pro.PropertyType == typeof(System.String[]))
                    {
                        object val = pro.GetValue(this, null);
                        if (val != null)
                        {

                            string strVal = string.Empty;
                            foreach (string item in val as string[])
                            {
                                strVal += "|" + item;
                            }

                            sb.AppendLine(string.Format("[{0}]\t[{1}]\t[{2}]", pro.Name, strVal, pro.PropertyType.FullName));
                        }
                        else
                        {
                            sb.AppendLine(string.Format("[{0}]\t[{1}]\t[{2}]", pro.Name, "", pro.PropertyType.FullName));
                        }
                    }
                    else
                    {
                        sb.AppendLine(string.Format("[{0}]\t[{1}]\t[{2}]", pro.Name, pro.GetValue(this, null), pro.PropertyType.FullName));
                    }
                }
            }

            return sb.ToString();
        }
    }
}
