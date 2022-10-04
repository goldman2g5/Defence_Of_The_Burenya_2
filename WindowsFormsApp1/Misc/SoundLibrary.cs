using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Misc
{
    internal class SoundLibrary
    {
        private string Name;
        private string Path;
        private static List<SoundLibrary>  MusicList = new List<SoundLibrary>()
        {
            new SoundLibrary("MainMenuBGMusic", "C:/Users/bebra/Source/Repos/Defence_Of_The_Burenya_2/WindowsFormsApp1/Resources/MainMenu/bgmusic.wav")
        };
        public SoundLibrary() { }

        private SoundLibrary(string name, string path)
        {
            Name = name;
            Path = path;
        }

        public void Add(string name, string path)
        {
            if (MusicList.Any(x => x.Name == name | x.Path == path)) return;
            MusicList.Add(new SoundLibrary(name, path));
        }
        public string this[string name] => name.Contains("/") ?
            MusicList.Find(x => name.Contains("/") ? x.Path == name : x.Name == name).Name :
            MusicList.Find(x => name.Contains("/") ? x.Path == name : x.Name == name).Path;


    }
}
