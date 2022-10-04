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
            this.SnoopDog = new System.Windows.Forms.PictureBox();
            this.NewGameButton = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.LoadButton = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.SettingsButton = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.ExitButton = new Siticone.Desktop.UI.WinForms.SiticoneImageButton();
            this.LogopictureBox = new System.Windows.Forms.PictureBox();
            this.NecoArcGifpictureBox = new System.Windows.Forms.PictureBox();
            this.BGpictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SnoopDog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NecoArcGifpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SnoopDog
            // 
            this.SnoopDog.BackColor = System.Drawing.Color.Transparent;
            this.SnoopDog.Image = global::WindowsFormsApp1.Properties.Resources.snoop;
            this.SnoopDog.Location = new System.Drawing.Point(612, 235);
            this.SnoopDog.Name = "SnoopDog";
            this.SnoopDog.Size = new System.Drawing.Size(62, 111);
            this.SnoopDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SnoopDog.TabIndex = 10;
            this.SnoopDog.TabStop = false;
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.Transparent;
            this.NewGameButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.NewGameButton.CheckedState.Parent = this.NewGameButton;
            this.NewGameButton.HoverState.ImageSize = new System.Drawing.Size(240, 48);
            this.NewGameButton.HoverState.Parent = this.NewGameButton;
            this.NewGameButton.Image = global::WindowsFormsApp1.Properties.Resources.NewGame;
            this.NewGameButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.NewGameButton.ImageRotate = 0F;
            this.NewGameButton.ImageSize = new System.Drawing.Size(300, 60);
            this.NewGameButton.Location = new System.Drawing.Point(783, 143);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.NewGameButton.PressedState.Parent = this.NewGameButton;
            this.NewGameButton.ShadowDecoration.Parent = this.NewGameButton;
            this.NewGameButton.Size = new System.Drawing.Size(444, 107);
            this.NewGameButton.TabIndex = 9;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.BackColor = System.Drawing.Color.Transparent;
            this.LoadButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.LoadButton.CheckedState.Parent = this.LoadButton;
            this.LoadButton.HoverState.ImageSize = new System.Drawing.Size(225, 51);
            this.LoadButton.HoverState.Parent = this.LoadButton;
            this.LoadButton.Image = global::WindowsFormsApp1.Properties.Resources.Load;
            this.LoadButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.LoadButton.ImageRotate = 0F;
            this.LoadButton.ImageSize = new System.Drawing.Size(282, 63);
            this.LoadButton.Location = new System.Drawing.Point(770, 256);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.LoadButton.PressedState.Parent = this.LoadButton;
            this.LoadButton.ShadowDecoration.Parent = this.LoadButton;
            this.LoadButton.Size = new System.Drawing.Size(444, 90);
            this.LoadButton.TabIndex = 8;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingsButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingsButton.CheckedState.Parent = this.SettingsButton;
            this.SettingsButton.HoverState.ImageSize = new System.Drawing.Size(224, 57);
            this.SettingsButton.HoverState.Parent = this.SettingsButton;
            this.SettingsButton.Image = global::WindowsFormsApp1.Properties.Resources.Settings;
            this.SettingsButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.SettingsButton.ImageRotate = 0F;
            this.SettingsButton.ImageSize = new System.Drawing.Size(280, 61);
            this.SettingsButton.Location = new System.Drawing.Point(797, 352);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.SettingsButton.PressedState.Parent = this.SettingsButton;
            this.SettingsButton.ShadowDecoration.Parent = this.SettingsButton;
            this.SettingsButton.Size = new System.Drawing.Size(402, 87);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ExitButton.CheckedState.Parent = this.ExitButton;
            this.ExitButton.HoverState.ImageSize = new System.Drawing.Size(153, 46);
            this.ExitButton.HoverState.Parent = this.ExitButton;
            this.ExitButton.Image = global::WindowsFormsApp1.Properties.Resources.Exit;
            this.ExitButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.ExitButton.ImageRotate = 0F;
            this.ExitButton.ImageSize = new System.Drawing.Size(192, 58);
            this.ExitButton.Location = new System.Drawing.Point(746, 430);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ExitButton.PressedState.Parent = this.ExitButton;
            this.ExitButton.ShadowDecoration.Parent = this.ExitButton;
            this.ExitButton.Size = new System.Drawing.Size(402, 98);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
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
            this.NecoArcGifpictureBox.Click += new System.EventHandler(this.NecoArcGifpictureBox_Click);
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
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.ControlBox = false;
            this.Controls.Add(this.SnoopDog);
            this.Controls.Add(this.NewGameButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogopictureBox);
            this.Controls.Add(this.NecoArcGifpictureBox);
            this.Controls.Add(this.BGpictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Defence Of The Burenya 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SnoopDog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NecoArcGifpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BGpictureBox;
        private System.Windows.Forms.PictureBox NecoArcGifpictureBox;
        private System.Windows.Forms.PictureBox LogopictureBox;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton ExitButton;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton SettingsButton;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton LoadButton;
        private Siticone.Desktop.UI.WinForms.SiticoneImageButton NewGameButton;
        private System.Windows.Forms.PictureBox SnoopDog;
    }
}