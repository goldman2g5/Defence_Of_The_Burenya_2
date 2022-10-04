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
        }
    }
}
