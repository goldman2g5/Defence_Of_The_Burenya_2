using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Misc
{
    internal static class Misc
    {
        public static List<T> CreateGenericList<T>(params T[] elements)
        {
            return new List<T>(elements);
        }
        public static string RandomString(int size, bool lowerCase = false) => Guid.NewGuid().ToString() + Guid.NewGuid().ToString();

        public static List<string> GetFilesPaths(string path) => Directory.GetFiles(path).ToList();

        public static List<string> GetFilesNames(string path)
        {
            List<string> fileNames = Directory.GetFiles(path).Select(x => x.Split('\\').Last()).ToList();

            for (int i = 0; i < fileNames.Count; i++)
            {
                int fileExtPos = fileNames[i].LastIndexOf(".");
                if (fileExtPos >= 0)
                    fileNames[i] = fileNames[i].Substring(0, fileExtPos);
            }

            return fileNames;
        }

    }
}
