using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;
using WindowsFormsApp1.Misc;

namespace WindowsFormsApp1
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            BGpictureBox.Controls.Add(LogopictureBox);
            BGpictureBox.Controls.Add(NecoArcGifpictureBox);
            BGpictureBox.Controls.Add(NewGameButton);
            BGpictureBox.Controls.Add(LoadButton);
            BGpictureBox.Controls.Add(SettingsButton);
            BGpictureBox.Controls.Add(ExitButton);
            SoundHandler.PlayBG("MainMenuBGMusic");
        }

        private void SettingsButton_Click(object sender, EventArgs e) 
        {
            FormsHandler.Show("Settings");
            SoundHandler.Play("Neco-ÑA");
        } 

        private void MainMenuForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            SoundHandler.Play("Neco-ÑA");
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            SoundHandler.Play("Neco-ÑA");
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            SoundHandler.Play("Neco-ÑA");
        }

        private void NecoArcGifpictureBox_Click(object sender, EventArgs e)
        {
            List<string> sounds = new List<string>() { "Neco-Chaina-Chainese", "Neco-dori-dori-dori", "Neco-fuero-fueru", "Neco-ÑA-ÑA-ÑA" };
            SoundHandler.Play(sounds[new Random().Next(0, sounds.Count - 1)]);
        }
    }
}

