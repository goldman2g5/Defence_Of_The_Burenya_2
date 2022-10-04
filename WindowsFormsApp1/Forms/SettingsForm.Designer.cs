namespace WindowsFormsApp1.Forms
{
    partial class SettingsForm
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
            this.MusicTrackBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.EffectsTrackBar = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.EffectspictureBox = new System.Windows.Forms.PictureBox();
            this.BackButton = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.VolumepictureBox1 = new System.Windows.Forms.PictureBox();
            this.BGpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.EffectspictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumepictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MusicTrackBar
            // 
            this.MusicTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.MusicTrackBar.FillColor = System.Drawing.Color.Black;
            this.MusicTrackBar.HoverState.Parent = this.MusicTrackBar;
            this.MusicTrackBar.Location = new System.Drawing.Point(12, 108);
            this.MusicTrackBar.Name = "MusicTrackBar";
            this.MusicTrackBar.Size = new System.Drawing.Size(323, 67);
            this.MusicTrackBar.TabIndex = 6;
            this.MusicTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(60)))));
            // 
            // EffectsTrackBar
            // 
            this.EffectsTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.EffectsTrackBar.FillColor = System.Drawing.Color.Black;
            this.EffectsTrackBar.HoverState.Parent = this.EffectsTrackBar;
            this.EffectsTrackBar.Location = new System.Drawing.Point(12, 270);
            this.EffectsTrackBar.Name = "EffectsTrackBar";
            this.EffectsTrackBar.Size = new System.Drawing.Size(323, 67);
            this.EffectsTrackBar.TabIndex = 7;
            this.EffectsTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(60)))));
            // 
            // EffectspictureBox
            // 
            this.EffectspictureBox.BackColor = System.Drawing.Color.Transparent;
            this.EffectspictureBox.Image = global::WindowsFormsApp1.Properties.Resources.EffectsVolume;
            this.EffectspictureBox.Location = new System.Drawing.Point(12, 181);
            this.EffectspictureBox.Name = "EffectspictureBox";
            this.EffectspictureBox.Size = new System.Drawing.Size(323, 83);
            this.EffectspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EffectspictureBox.TabIndex = 5;
            this.EffectspictureBox.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.CheckedState.Image = global::WindowsFormsApp1.Properties.Resources.BackButton;
            this.BackButton.CheckedState.ImageSize = new System.Drawing.Size(170, 170);
            this.BackButton.CheckedState.Parent = this.BackButton;
            this.BackButton.HoverState.Image = global::WindowsFormsApp1.Properties.Resources.BackButton;
            this.BackButton.HoverState.ImageSize = new System.Drawing.Size(170, 170);
            this.BackButton.HoverState.Parent = this.BackButton;
            this.BackButton.Image = global::WindowsFormsApp1.Properties.Resources.BackButton;
            this.BackButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.BackButton.ImageRotate = 0F;
            this.BackButton.ImageSize = new System.Drawing.Size(180, 180);
            this.BackButton.Location = new System.Drawing.Point(0, 488);
            this.BackButton.Name = "BackButton";
            this.BackButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BackButton.PressedState.Parent = this.BackButton;
            this.BackButton.ShadowDecoration.Parent = this.BackButton;
            this.BackButton.Size = new System.Drawing.Size(225, 189);
            this.BackButton.TabIndex = 4;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // VolumepictureBox1
            // 
            this.VolumepictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.VolumepictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Music;
            this.VolumepictureBox1.Location = new System.Drawing.Point(12, 12);
            this.VolumepictureBox1.Name = "VolumepictureBox1";
            this.VolumepictureBox1.Size = new System.Drawing.Size(323, 90);
            this.VolumepictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VolumepictureBox1.TabIndex = 2;
            this.VolumepictureBox1.TabStop = false;
            // 
            // BGpictureBox
            // 
            this.BGpictureBox.Image = global::WindowsFormsApp1.Properties.Resources.BackGround;
            this.BGpictureBox.Location = new System.Drawing.Point(-9, -24);
            this.BGpictureBox.Name = "BGpictureBox";
            this.BGpictureBox.Size = new System.Drawing.Size(1280, 720);
            this.BGpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGpictureBox.TabIndex = 1;
            this.BGpictureBox.TabStop = false;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.EffectsTrackBar);
            this.Controls.Add(this.MusicTrackBar);
            this.Controls.Add(this.EffectspictureBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.VolumepictureBox1);
            this.Controls.Add(this.BGpictureBox);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.EffectspictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumepictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BGpictureBox;
        private System.Windows.Forms.PictureBox VolumepictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton BackButton;
        private System.Windows.Forms.PictureBox EffectspictureBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar MusicTrackBar;
        private Siticone.Desktop.UI.WinForms.SiticoneTrackBar EffectsTrackBar;
    }
}