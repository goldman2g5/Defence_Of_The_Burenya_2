using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Misc;

namespace WindowsFormsApp1.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

            BGpictureBox.Controls.Add(VolumepictureBox1);
            BGpictureBox.Controls.Add(EffectsTrackBar);
            BGpictureBox.Controls.Add(EffectspictureBox);
            BGpictureBox.Controls.Add(EffectsTrackBar);
            BGpictureBox.Controls.Add(MusicTrackBar);
            BGpictureBox.Controls.Add(BackButton);
            
        }
        private void BackButton_Click(object sender, EventArgs e) => FormsHandler.Show("MainMenu");

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

    }
}
