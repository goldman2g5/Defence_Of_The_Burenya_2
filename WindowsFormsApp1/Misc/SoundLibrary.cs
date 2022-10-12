using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Misc
{
    internal class SoundLibrary
    {
        private string Name;
        private string Path;
        private static string SoundsFolder = "C:/Users/bebra/Source/Repos/Defence_Of_The_Burenya_22/WindowsFormsApp1/Resources/Sounds";
        private static List<SoundLibrary> SoundList = new List<SoundLibrary>();
        public SoundLibrary() { }

        private SoundLibrary(string name, string path)
        {
            Name = name;
            Path = path;
        }

        static SoundLibrary()
        {
            List<string> SoundPaths = Misc.GetFilesPaths(SoundsFolder);
            List<string> SoundsNames = Misc.GetFilesNames(SoundsFolder);
            for (int i = 0; i < SoundPaths.Count; i++)
            {
                SoundList.Add(new SoundLibrary(SoundsNames[i], SoundPaths[i]));
            }
                
        }

        public void Add(string name, string path)
        {
            if (SoundList.Any(x => x.Name == name | x.Path == path)) return;
            SoundList.Add(new SoundLibrary(name, path));
        }
        public string this[string name] => name.Contains("/") ?
            SoundList.Find(x => name.Contains("/") ? x.Path == name : x.Name == name).Name :
            SoundList.Find(x => name.Contains("/") ? x.Path == name : x.Name == name).Path;


    }
}
