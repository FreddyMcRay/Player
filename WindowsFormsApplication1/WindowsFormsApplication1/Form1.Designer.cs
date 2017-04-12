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
            this.PlayBar = new MetroFramework.Controls.MetroTrackBar();
            this.VolumeBar = new MetroFramework.Controls.MetroTrackBar();
            this.PlayList = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.FilesButton = new MetroFramework.Controls.MetroButton();
            this.StopButton = new MetroFramework.Controls.MetroButton();
            this.PauseButton = new MetroFramework.Controls.MetroButton();
            this.PlayButton = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Album = new System.Windows.Forms.Label();
            this.Channels = new System.Windows.Forms.Label();
            this.Raiting = new System.Windows.Forms.Label();
            this.NameComp = new System.Windows.Forms.Label();
            this.CoverImage = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PlayListsArray = new System.Windows.Forms.ListBox();
            this.OkButton = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CoverImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
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
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(389, 20);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(179, 305);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTabControl1.TabIndex = 15;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tabPage1.Controls.Add(this.Album);
            this.tabPage1.Controls.Add(this.Channels);
            this.tabPage1.Controls.Add(this.Raiting);
            this.tabPage1.Controls.Add(this.NameComp);
            this.tabPage1.Controls.Add(this.CoverImage);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(171, 263);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Info";
            // 
            // Album
            // 
            this.Album.BackColor = System.Drawing.Color.Transparent;
            this.Album.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Album.Location = new System.Drawing.Point(13, 210);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(150, 14);
            this.Album.TabIndex = 19;
            this.Album.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Channels
            // 
            this.Channels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Channels.Location = new System.Drawing.Point(13, 224);
            this.Channels.Name = "Channels";
            this.Channels.Size = new System.Drawing.Size(149, 12);
            this.Channels.TabIndex = 18;
            this.Channels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Raiting
            // 
            this.Raiting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Raiting.Location = new System.Drawing.Point(13, 237);
            this.Raiting.Name = "Raiting";
            this.Raiting.Size = new System.Drawing.Size(149, 14);
            this.Raiting.TabIndex = 17;
            this.Raiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameComp
            // 
            this.NameComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.NameComp.Location = new System.Drawing.Point(13, 195);
            this.NameComp.Name = "NameComp";
            this.NameComp.Size = new System.Drawing.Size(150, 16);
            this.NameComp.TabIndex = 16;
            this.NameComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoverImage
            // 
            this.CoverImage.Image = global::WindowsFormsApplication1.Properties.Resources.Cover;
            this.CoverImage.Location = new System.Drawing.Point(13, 23);
            this.CoverImage.Name = "CoverImage";
            this.CoverImage.Size = new System.Drawing.Size(150, 170);
            this.CoverImage.TabIndex = 15;
            this.CoverImage.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.tabPage2.Controls.Add(this.metroTextBox1);
            this.tabPage2.Controls.Add(this.OkButton);
            this.tabPage2.Controls.Add(this.PlayListsArray);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(171, 263);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PlayLists";
            // 
            // PlayListsArray
            // 
            this.PlayListsArray.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PlayListsArray.Font = new System.Drawing.Font("AA American Captain", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayListsArray.ForeColor = System.Drawing.Color.White;
            this.PlayListsArray.FormattingEnabled = true;
            this.PlayListsArray.ItemHeight = 14;
            this.PlayListsArray.Location = new System.Drawing.Point(15, 19);
            this.PlayListsArray.Name = "PlayListsArray";
            this.PlayListsArray.Size = new System.Drawing.Size(143, 144);
            this.PlayListsArray.TabIndex = 17;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(80, 203);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 18;
            this.OkButton.Text = "OK";
            this.OkButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OkButton.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(121, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(15, 171);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "New playlist name";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(143, 23);
            this.metroTextBox1.TabIndex = 19;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "New playlist name";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 382);
            this.Controls.Add(this.metroTabControl1);
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
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CoverImage)).EndInit();
            this.tabPage2.ResumeLayout(false);
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
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label Album;
        private System.Windows.Forms.Label Channels;
        private System.Windows.Forms.Label Raiting;
        private System.Windows.Forms.Label NameComp;
        private System.Windows.Forms.PictureBox CoverImage;
        private MetroFramework.Controls.MetroButton OkButton;
        private System.Windows.Forms.ListBox PlayListsArray;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}

