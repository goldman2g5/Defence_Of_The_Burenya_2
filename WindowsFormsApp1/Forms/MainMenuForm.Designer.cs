namespace WindowsFormsApp1
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.SettingspictureBox = new System.Windows.Forms.PictureBox();
            this.LoadpictureBox = new System.Windows.Forms.PictureBox();
            this.NewGamepictureBox = new System.Windows.Forms.PictureBox();
            this.LogopictureBox = new System.Windows.Forms.PictureBox();
            this.NecoArcGifpictureBox = new System.Windows.Forms.PictureBox();
            this.BGpictureBox = new System.Windows.Forms.PictureBox();
            this.ExitButton = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.SettingspictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewGamepictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NecoArcGifpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingspictureBox
            // 
            this.SettingspictureBox.BackColor = System.Drawing.Color.Transparent;
            this.SettingspictureBox.Image = global::WindowsFormsApp1.Properties.Resources.Settings;
            this.SettingspictureBox.Location = new System.Drawing.Point(903, 290);
            this.SettingspictureBox.Name = "SettingspictureBox";
            this.SettingspictureBox.Size = new System.Drawing.Size(347, 71);
            this.SettingspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SettingspictureBox.TabIndex = 5;
            this.SettingspictureBox.TabStop = false;
            this.SettingspictureBox.Click += new System.EventHandler(this.SettingspictureBox_Click);
            // 
            // LoadpictureBox
            // 
            this.LoadpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LoadpictureBox.Image = global::WindowsFormsApp1.Properties.Resources.Load;
            this.LoadpictureBox.Location = new System.Drawing.Point(903, 213);
            this.LoadpictureBox.Name = "LoadpictureBox";
            this.LoadpictureBox.Size = new System.Drawing.Size(347, 71);
            this.LoadpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadpictureBox.TabIndex = 4;
            this.LoadpictureBox.TabStop = false;
            // 
            // NewGamepictureBox
            // 
            this.NewGamepictureBox.BackColor = System.Drawing.Color.Transparent;
            this.NewGamepictureBox.Image = global::WindowsFormsApp1.Properties.Resources.NewGame;
            this.NewGamepictureBox.Location = new System.Drawing.Point(903, 135);
            this.NewGamepictureBox.Name = "NewGamepictureBox";
            this.NewGamepictureBox.Size = new System.Drawing.Size(347, 72);
            this.NewGamepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NewGamepictureBox.TabIndex = 3;
            this.NewGamepictureBox.TabStop = false;
            // 
            // LogopictureBox
            // 
            this.LogopictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LogopictureBox.Image = global::WindowsFormsApp1.Properties.Resources.Logo;
            this.LogopictureBox.Location = new System.Drawing.Point(12, 25);
            this.LogopictureBox.Name = "LogopictureBox";
            this.LogopictureBox.Size = new System.Drawing.Size(1238, 104);
            this.LogopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogopictureBox.TabIndex = 2;
            this.LogopictureBox.TabStop = false;
            // 
            // NecoArcGifpictureBox
            // 
            this.NecoArcGifpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.NecoArcGifpictureBox.Image = global::WindowsFormsApp1.Properties.Resources.NecoArcGif;
            this.NecoArcGifpictureBox.Location = new System.Drawing.Point(-1, 444);
            this.NecoArcGifpictureBox.Name = "NecoArcGifpictureBox";
            this.NecoArcGifpictureBox.Size = new System.Drawing.Size(297, 229);
            this.NecoArcGifpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NecoArcGifpictureBox.TabIndex = 1;
            this.NecoArcGifpictureBox.TabStop = false;
            // 
            // BGpictureBox
            // 
            this.BGpictureBox.Image = global::WindowsFormsApp1.Properties.Resources.BackGround;
            this.BGpictureBox.Location = new System.Drawing.Point(0, 0);
            this.BGpictureBox.Name = "BGpictureBox";
            this.BGpictureBox.Size = new System.Drawing.Size(1280, 720);
            this.BGpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGpictureBox.TabIndex = 0;
            this.BGpictureBox.TabStop = false;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.HoverState.ImageSize = new System.Drawing.Size(192, 58);
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.Image = global::WindowsFormsApp1.Properties.Resources.Exit;
            this.ExitButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.ExitButton.ImageRotate = 0F;
            this.ExitButton.ImageSize = new System.Drawing.Size(241, 73);
            this.ExitButton.Location = new System.Drawing.Point(903, 367);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ExitButton.PressedState.Parent = this.ExitButton;
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(347, 78);
            this.ExitButton.TabIndex = 6;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SettingspictureBox);
            this.Controls.Add(this.LoadpictureBox);
            this.Controls.Add(this.NewGamepictureBox);
            this.Controls.Add(this.LogopictureBox);
            this.Controls.Add(this.NecoArcGifpictureBox);
            this.Controls.Add(this.BGpictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Defence Of The Burenya 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SettingspictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoadpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewGamepictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NecoArcGifpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BGpictureBox;
        private System.Windows.Forms.PictureBox NecoArcGifpictureBox;
        private System.Windows.Forms.PictureBox SettingspictureBox;
        private System.Windows.Forms.PictureBox LoadpictureBox;
        private System.Windows.Forms.PictureBox NewGamepictureBox;
        private System.Windows.Forms.PictureBox LogopictureBox;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton ExitButton;
    }
}