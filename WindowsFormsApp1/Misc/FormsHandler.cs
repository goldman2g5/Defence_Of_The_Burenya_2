using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Forms;
using System.Media;
using System.Windows.Forms;

namespace WindowsFormsApp1.Misc
{
    internal static class FormsHandler
    {
        private static readonly Dictionary<string, Form> FormsDict = new Dictionary<string, Form>
        {
            { "MainMenu", new MainMenuForm()},
            { "Settings", new SettingsForm()},
        };
        private static Form NowOnScreen;


        public static void Show(string name)
        {
            if (NowOnScreen != null)
                NowOnScreen.Hide();
            Form formToShow;
            FormsDict.TryGetValue(name, out formToShow);
            if (NowOnScreen != null)
                formToShow.Location = NowOnScreen.Location;
            formToShow.Show();
            NowOnScreen = formToShow;
        }

        public static void CloseAll()
        {
            
        }
    }
}
