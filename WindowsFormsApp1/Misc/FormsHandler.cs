using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1.Misc
{
    internal static class FormsHandler
    {
        private static readonly Dictionary<string, Form> FormsDict = new Dictionary<string, Form>
        {
            { "MainMenu", new MainMenuForm()},
            { "Settings", new SettingsForm()},
            { "Introduction", new DiologScene()},
        };
        private static Form NowOnScreen;


        public static void Show(string name)
        {
            if (NowOnScreen != null)
                NowOnScreen.Hide();
            Form formToShow;
            FormsDict.TryGetValue(name, out formToShow);


            if (NowOnScreen != null)
            {
                formToShow.Location = NowOnScreen.Location;
                formToShow.StartPosition = FormStartPosition.Manual;
            }
            else
            {
                formToShow.StartPosition = FormStartPosition.Manual;
                formToShow.Location = new Point(
                    Screen.PrimaryScreen.WorkingArea.Width / 2 - formToShow.Size.Width / 2,
                    Screen.PrimaryScreen.WorkingArea.Height / 2 - formToShow.Size.Height / 2);
                
            }
            formToShow.Show();
            NowOnScreen = formToShow;
        }

        public static void SetFormToCenter(Form form)
        {
            
        }

        public static void CloseAll()
        {
            
        }
    }
}
