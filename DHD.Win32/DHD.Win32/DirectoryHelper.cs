using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DHD.Win32
{
    /// <summary>
    /// 
    /// </summary>
    public static class DirectoryHelper
    {

        /// <summary>
        /// 将指定目录移动到指定位置
        /// </summary>
        /// <param name="source">要移动的源目录</param>
        /// <param name="destination">要移动到的目录（父目录）</param>
        /// <returns></returns>
        public static Boolean Move(String source, String destination)
        {
            if (!System.IO.Directory.Exists(source))
            {
                throw new ArgumentException("源目录不存在！", nameof(source));
            }

            if (!System.IO.Directory.Exists(destination))
            {
                System.IO.Directory.CreateDirectory(destination);
            }


            // 先在目标目录下创建源目录\
            String dirName = System.IO.Path.GetFileNameWithoutExtension(source.Trim('\\'));
            String targetDirPath = destination + "\\" + dirName;

            System.IO.Directory.CreateDirectory(targetDirPath);

            // 源目录下的所有文件进行移动
            String[] files = System.IO.Directory.GetFiles(source);
            foreach (String file in files)
            {
                System.IO.File.Move(file, targetDirPath + "\\" + System.IO.Path.GetFileName(file));
            }

            // 检查源目录下是否存在文件夹，存在则进行递归
            String[] dirs = System.IO.Directory.GetDirectories(source);
            foreach (String dir in dirs)
            {
                Move(dir, targetDirPath);
            }

            // 删除源目录
            System.IO.Directory.Delete(source, true);
            return true;

        }




    }
}
