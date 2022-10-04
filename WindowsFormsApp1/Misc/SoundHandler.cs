using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Misc
{
    
    internal static class SoundHandler
    {


        private static SoundPlayer player = new SoundPlayer();
        private static SoundLibrary soundLibrary = new SoundLibrary();
        private static string NowPlayingBG;


        static SoundHandler()
        {

        }
        public static void playBG(string SoundName)
        {
            if (NowPlayingBG == SoundName) return;
            NowPlayingBG = SoundName;
            player.Stop();
            player.SoundLocation = soundLibrary[SoundName];
            player.PlayLooping();
        }

    }
}
