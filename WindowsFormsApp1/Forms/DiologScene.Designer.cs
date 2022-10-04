namespace WindowsFormsApp1.Forms
{
    partial class DiologScene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BGpictureBox = new System.Windows.Forms.PictureBox();
            this.GradientPanel = new Siticone.Desktop.UI.WinForms.SiticoneGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BGpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BGpictureBox
            // 
            this.BGpictureBox.Image = global::WindowsFormsApp1.Properties.Resources.NecoArcBG;
            this.BGpictureBox.Location = new System.Drawing.Point(-9, -24);
            this.BGpictureBox.Name = "BGpictureBox";
            this.BGpictureBox.Size = new System.Drawing.Size(1280, 720);
            this.BGpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGpictureBox.TabIndex = 1;
            this.BGpictureBox.TabStop = false;
            // 
            // GradientPanel
            // 
            this.GradientPanel.BackColor = System.Drawing.Color.Transparent;
            this.GradientPanel.FillColor = System.Drawing.Color.Black;
            this.GradientPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.GradientPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.GradientPanel.Location = new System.Drawing.Point(1, 391);
            this.GradientPanel.Name = "GradientPanel";
            this.GradientPanel.ShadowDecoration.Parent = this.GradientPanel;
            this.GradientPanel.Size = new System.Drawing.Size(1270, 283);
            this.GradientPanel.TabIndex = 2;
            this.GradientPanel.UseTransparentBackground = true;
            // 
            // DiologScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.GradientPanel);
            this.Controls.Add(this.BGpictureBox);
            this.Name = "DiologScene";
            this.Text = "DiologScene";
            ((System.ComponentModel.ISupportInitialize)(this.BGpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BGpictureBox;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientPanel GradientPanel;
    }
}