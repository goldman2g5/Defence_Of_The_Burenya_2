using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1.Forms
{
    public partial class DiologScene : Form
    {
        public DiologScene()
        {
            InitializeComponent();

            GradientPanel.Controls.Add(label1);
            BGpictureBox.Controls.Add(GradientPanel);
            


        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
