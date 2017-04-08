using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework.Properties;
using Un4seen.Bass;

namespace WindowsFormsApplication1
{
    public partial class Form1 : MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();
            BassNet.Registration("evgenuypetrushevskiv8@gmail.com", "2X23173031152222");
            openFileDialog1.Filter = "All formats| *.mp3; *.m4a; *.mp4; *.tta; *.alac; *.ogg; *.opus; *.ape; *.ac3; *.mpc; *.flac; *.wma; *.wv;"
                +"|MPEG Audio Layer III (*.mp3)|*.mp3"
                +"|Advanced Audio Coding (*.m4a;*.mp4)|*.m4a; *.mp4"
                +"|OGG Vorbis Audio (*.ogg)|*.ogg"
                +"|OPUS Audio (*.opus)|*.opus"
                +"|Dolby Digital AC3 (*.ac3)|*.ac3"
                +"|Monkey's Audio (*.ape)|*.ape"
                +"|MusePack (*.mpc)|*.mpc"
                +"|Free LOSSLESS Audio Codec (*.flac)|*.flac"
                +"|Windows Media Audio (*.wma)|*.wma"
                +"|True Audio (*.tta)|*.tta"
                +"|Apple LOSSLESS Audio Codec (*.alac)|*.alac"
                +"|WavPack (*.wv)|*.wv";
            openFileDialog1.Multiselect = true;
            openFileDialog1.Title = "Music browser";
            Player.InitBass(Player.hz);
            WorkClass.PlayedIndex = 0;
        }

        private void FilesButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string file in openFileDialog1.FileNames)
            {
                WorkClass.Files.Add(file);
                TagReader TR = new TagReader(file);
                PlayList.Items.Add(TR.artist + "-" + TR.title);
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if ((PlayList.Items.Count != 0) && (PlayList.SelectedIndex != -1))
            {
                WorkClass.LastPlayed = PlayList.SelectedIndex;
                WorkClass.PlayedIndex = PlayList.SelectedIndex;
                this.PlaylistRefresh();
                string current = WorkClass.Files[WorkClass.PlayedIndex];
                Player.Play(current, Player.volume);
                this.SetInfo();
                metroLabel1.Text = TimeSpan.FromSeconds(Player.GetPosOfStream(Player.stream)).ToString();
                metroLabel2.Text = TimeSpan.FromSeconds(Player.GetTimeOfStream(Player.stream)).ToString();
                PlayBar.Maximum = Player.GetTimeOfStream(Player.stream);
                PlayBar.Value = Player.GetPosOfStream(Player.stream);
                timer1.Enabled = true;
            }
            else
            {
                if (PlayList.Items.Count != 0)
                {
                    this.PlaylistRefresh();
                    this.SetInfo();
                    string current = WorkClass.Files[WorkClass.PlayedIndex];
                    Player.Play(current, Player.volume);
                    metroLabel1.Text = TimeSpan.FromSeconds(Player.GetPosOfStream(Player.stream)).ToString();
                    metroLabel2.Text = TimeSpan.FromSeconds(Player.GetTimeOfStream(Player.stream)).ToString();
                    PlayBar.Maximum = Player.GetTimeOfStream(Player.stream);
                    PlayBar.Value = Player.GetPosOfStream(Player.stream);
                    timer1.Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PlayBar.Value = Player.GetPosOfStream(Player.stream);
            metroLabel1.Text = TimeSpan.FromSeconds(Player.GetPosOfStream(Player.stream)).ToString();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            Player.Stop();
            timer1.Enabled = false;
            PlayBar.Value = 0;
            metroLabel1.Text = "00;00;00";
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            Player.Pause();
        }

        private void PlayBar_Scroll(object sender, ScrollEventArgs e)
        {
            Player.SetPosOfScroll(Player.stream,PlayBar.Value);

        }

        private void VolumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            Player.SetVolumeToStream(Player.stream,VolumeBar.Value);
        }

        private void PlaylistRefresh()
        {
            string temp;
            temp = PlayList.Items[WorkClass.LastPlayed].ToString();
            PlayList.Items.RemoveAt(WorkClass.LastPlayed);
            PlayList.Items.Insert(WorkClass.LastPlayed,temp);
        }

        private void PlayList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index!=-1)
            {
                e.DrawBackground();
                Brush MyBrush = Brushes.White;
                if (e.Index == WorkClass.PlayedIndex)
                    MyBrush = Brushes.Red;
                e.Graphics.DrawString(((ListBox) sender).Items[e.Index].ToString(), e.Font, MyBrush, e.Bounds,
                    StringFormat.GenericDefault);
            }
        }

        private void SetInfo()
        {
            
            TagReader TR = new TagReader(WorkClass.Files[WorkClass.PlayedIndex]);
            if (TR.cover != null)
            {
                Bitmap image = new Bitmap(TR.cover, 150, 170);
                CoverImage.Image = image;
                NameComp.Text = TR.title;
                Raiting.Text = "Raiting: " + TR.raiting + "%";
                Channels.Text = "Channels: " + TR.channels;
                Album.Text = "Album: " + TR.album;
            }
            else
            {
                Bitmap image = new Bitmap(Properties.Resources.Cover, 150, 170);
                CoverImage.Image = image;
                NameComp.Text = TR.title;
                Raiting.Text = "Raiting: " + TR.raiting + "%";
                Channels.Text = "Channels: " + TR.channels;
                Album.Text = "Album: " + TR.album;
            }
        }

        
    }
}
