using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            BGpictureBox.Controls.Add(LogopictureBox);
            BGpictureBox.Controls.Add(NecoArcGifpictureBox);
            BGpictureBox.Controls.Add(NewGamepictureBox);
            BGpictureBox.Controls.Add(LoadpictureBox);
            BGpictureBox.Controls.Add(SettingspictureBox);
            BGpictureBox.Controls.Add(ExitpictureBox);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:/Users/bebra/Source/Repos/Defence_Of_The_Burenya_2/WindowsFormsApp1/Resources/MainMenu/bgmusic.wav";
            player.PlayLooping();
        }
    }
}
