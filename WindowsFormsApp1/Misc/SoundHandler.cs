using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Misc
{
    
    internal static class SoundHandler
    {


        private static SoundPlayer player = new SoundPlayer();
        private static SoundLibrary soundLibrary = new SoundLibrary();
        private static string NowPlayingBG;
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);


        static SoundHandler()
        {

        }
        public static void PlayBG(string SoundName)
        {
            if (NowPlayingBG == SoundName) return;
            NowPlayingBG = SoundName;
            player.Stop();
            player = new SoundPlayer($@"{soundLibrary[SoundName]}");
            player.PlayLooping();
        }

        public static void Play(string SoundName)
        {

            StringBuilder sb = new StringBuilder();
            string bullshit = Misc.RandomString(100000);
            mciSendString("open \"" + soundLibrary[SoundName] + "\" alias " + bullshit, sb, 0, IntPtr.Zero);
            mciSendString("play " + bullshit, sb, 0, IntPtr.Zero);
            
        }

    }
}
