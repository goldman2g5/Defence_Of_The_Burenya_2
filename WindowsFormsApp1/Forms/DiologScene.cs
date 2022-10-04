using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class DiologScene : Form
    {
        public DiologScene()
        {
            InitializeComponent();
            
            BGpictureBox.Controls.Add(GradientPanel);
            GradientPanel.Controls.Add(TextBox);
            
            
        }
    }
}
