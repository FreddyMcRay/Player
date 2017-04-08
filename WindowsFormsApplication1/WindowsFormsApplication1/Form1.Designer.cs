namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.PlayButton = new MetroFramework.Controls.MetroButton();
            this.PauseButton = new MetroFramework.Controls.MetroButton();
            this.StopButton = new MetroFramework.Controls.MetroButton();
            this.FilesButton = new MetroFramework.Controls.MetroButton();
            this.PlayBar = new MetroFramework.Controls.MetroTrackBar();
            this.VolumeBar = new MetroFramework.Controls.MetroTrackBar();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CoverImage = new System.Windows.Forms.PictureBox();
            this.NameComp = new System.Windows.Forms.Label();
            this.Raiting = new System.Windows.Forms.Label();
            this.Channels = new System.Windows.Forms.Label();
            this.Album = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoverImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Play;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayButton.Location = new System.Drawing.Point(23, 331);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(30, 24);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.UseSelectable = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Pause;
            this.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PauseButton.Location = new System.Drawing.Point(59, 331);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(30, 24);
            this.PauseButton.TabIndex = 1;
            this.PauseButton.UseMnemonic = false;
            this.PauseButton.UseSelectable = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Stop;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopButton.Location = new System.Drawing.Point(95, 331);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(30, 24);
            this.StopButton.TabIndex = 2;
            this.StopButton.UseSelectable = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // FilesButton
            // 
            this.FilesButton.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.AddFiles;
            this.FilesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FilesButton.Location = new System.Drawing.Point(532, 331);
            this.FilesButton.Name = "FilesButton";
            this.FilesButton.Size = new System.Drawing.Size(30, 24);
            this.FilesButton.TabIndex = 3;
            this.FilesButton.UseSelectable = true;
            this.FilesButton.Click += new System.EventHandler(this.FilesButton_Click);
            // 
            // PlayBar
            // 
            this.PlayBar.BackColor = System.Drawing.Color.Transparent;
            this.PlayBar.Location = new System.Drawing.Point(23, 302);
            this.PlayBar.Name = "PlayBar";
            this.PlayBar.Size = new System.Drawing.Size(220, 23);
            this.PlayBar.Style = MetroFramework.MetroColorStyle.Black;
            this.PlayBar.TabIndex = 5;
            this.PlayBar.Text = "metroTrackBar1";
            this.PlayBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PlayBar.Value = 0;
            this.PlayBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.PlayBar_Scroll);
            // 
            // VolumeBar
            // 
            this.VolumeBar.BackColor = System.Drawing.Color.Transparent;
            this.VolumeBar.Location = new System.Drawing.Point(268, 302);
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(115, 23);
            this.VolumeBar.Style = MetroFramework.MetroColorStyle.Black;
            this.VolumeBar.TabIndex = 6;
            this.VolumeBar.Text = "metroTrackBar2";
            this.VolumeBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.VolumeBar.Value = 100;
            this.VolumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.VolumeBar_Scroll);
            // 
            // PlayList
            // 
            this.PlayList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PlayList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.PlayList.Font = new System.Drawing.Font("AA American Captain", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayList.ForeColor = System.Drawing.Color.White;
            this.PlayList.FormattingEnabled = true;
            this.PlayList.ItemHeight = 14;
            this.PlayList.Location = new System.Drawing.Point(23, 36);
            this.PlayList.Name = "PlayList";
            this.PlayList.Size = new System.Drawing.Size(360, 238);
            this.PlayList.TabIndex = 7;
            this.PlayList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.PlayList_DrawItem);
            this.PlayList.DoubleClick += new System.EventHandler(this.PlayButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(9, 280);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "00;00;00";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(186, 280);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "00;00;00";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CoverImage
            // 
            this.CoverImage.Location = new System.Drawing.Point(412, 36);
            this.CoverImage.Name = "CoverImage";
            this.CoverImage.Size = new System.Drawing.Size(150, 170);
            this.CoverImage.TabIndex = 10;
            this.CoverImage.TabStop = false;
            // 
            // NameComp
            // 
            this.NameComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.NameComp.Location = new System.Drawing.Point(412, 207);
            this.NameComp.Name = "NameComp";
            this.NameComp.Size = new System.Drawing.Size(150, 16);
            this.NameComp.TabIndex = 11;
            this.NameComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Raiting
            // 
            this.Raiting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Raiting.Location = new System.Drawing.Point(409, 250);
            this.Raiting.Name = "Raiting";
            this.Raiting.Size = new System.Drawing.Size(153, 14);
            this.Raiting.TabIndex = 12;
            this.Raiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Channels
            // 
            this.Channels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Channels.Location = new System.Drawing.Point(415, 236);
            this.Channels.Name = "Channels";
            this.Channels.Size = new System.Drawing.Size(147, 12);
            this.Channels.TabIndex = 13;
            this.Channels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Album
            // 
            this.Album.BackColor = System.Drawing.Color.Transparent;
            this.Album.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Album.Location = new System.Drawing.Point(415, 222);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(147, 14);
            this.Album.TabIndex = 14;
            this.Album.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 382);
            this.Controls.Add(this.Album);
            this.Controls.Add(this.Channels);
            this.Controls.Add(this.Raiting);
            this.Controls.Add(this.NameComp);
            this.Controls.Add(this.CoverImage);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PlayList);
            this.Controls.Add(this.VolumeBar);
            this.Controls.Add(this.PlayBar);
            this.Controls.Add(this.FilesButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.PlayButton);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.CoverImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton PlayButton;
        private MetroFramework.Controls.MetroButton PauseButton;
        private MetroFramework.Controls.MetroButton StopButton;
        private MetroFramework.Controls.MetroButton FilesButton;
        private MetroFramework.Controls.MetroTrackBar PlayBar;
        private MetroFramework.Controls.MetroTrackBar VolumeBar;
        private System.Windows.Forms.ListBox PlayList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox CoverImage;
        private System.Windows.Forms.Label NameComp;
        private System.Windows.Forms.Label Raiting;
        private System.Windows.Forms.Label Channels;
        private System.Windows.Forms.Label Album;
    }
}

