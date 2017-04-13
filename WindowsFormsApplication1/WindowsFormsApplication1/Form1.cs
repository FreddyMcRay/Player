using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using MetroFramework.Properties;
using Un4seen.Bass;
using MessageBox = System.Windows.Forms.MessageBox;

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
            PlayListsArray.Items.AddRange(PlayLists.OpenPlayListsArray());
            
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
            if (!string.IsNullOrEmpty(PlayLists.CurrentPlayList))
            {
                PlayLists.SavePlayList(WorkClass.Files);
            }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (PlayList.SelectedIndex != -1)
            {
                WorkClass.PlayedIndex = PlayList.SelectedIndex;
                PlayList.Refresh();
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
                    PlayList.Refresh();
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
            try
            {
                PlayBar.Value = Player.GetPosOfStream(Player.stream);
                metroLabel1.Text = TimeSpan.FromSeconds(Player.GetPosOfStream(Player.stream)).ToString();
            }
            catch (ArgumentOutOfRangeException)
            {
                StopButton_Click(this, new EventArgs());
                PlayList.SelectedIndex = WorkClass.PlayedIndex = 0;
                Player.EndOfPlayList = false;
            }

            if (Player.SwitchToNext())
            {
                PlayList.SelectedIndex = WorkClass.PlayedIndex + 1;
                PlayButton_Click(this,new EventArgs());
            }
            if (Player.EndOfPlayList)
            {
                StopButton_Click(this, new EventArgs());
                PlayList.SelectedIndex = WorkClass.PlayedIndex = 0;
                Player.EndOfPlayList = false;
            }
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

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NewPlayListName.Text))
            {
                StopButton_Click(this,new EventArgs());
                PlayLists.CurrentPlayList = NewPlayListName.Text;
                PlayLists.CreateNewPlayList();
                PlayList.Items.Clear();
                PlayLists.SavePlayListsArray();
                PlayListsArray.Items.Add(PlayLists.CurrentPlayList);
                PlayLists.CurrentPlayListIndex = PlayListsArray.Items.IndexOf(PlayLists.CurrentPlayList);
                PlayLists.SavePlayListsArray();
                NewPlayListName.Clear();
                WorkClass.PlayedIndex = 0;
            }
            else
            {
                if (PlayListsArray.SelectedIndex != -1)
                {
                    StopButton_Click(this, new EventArgs());
                    PlayLists.CurrentPlayList = PlayListsArray.Items[PlayListsArray.SelectedIndex].ToString();
                    PlayLists.CurrentPlayListIndex = PlayListsArray.SelectedIndex;
                    PlayList.Items.Clear();
                    WorkClass.Files.Clear();
                    WorkClass.Files.AddRange(PlayLists.OpenPlayList());
                    foreach (string file in WorkClass.Files)
                    {
                        TagReader TR = new TagReader(file);
                        PlayList.Items.Add(TR.artist + "-" + TR.title);
                    }
                    WorkClass.PlayedIndex = 0;
                }
                else
                {
                    if (PlayListsArray.Items.Count != 0)
                    {
                        StopButton_Click(this, new EventArgs());
                        PlayLists.CurrentPlayList = PlayListsArray.Items[0].ToString();
                        PlayLists.CurrentPlayListIndex = 0;
                        PlayList.Items.Clear();
                        WorkClass.Files.Clear();
                        WorkClass.Files.AddRange(PlayLists.OpenPlayList());
                        foreach (string file in WorkClass.Files)
                        {
                            TagReader TR = new TagReader(file);
                            PlayList.Items.Add(TR.artist + "-" + TR.title);
                        }
                        WorkClass.PlayedIndex = 0;
                    }
                }
            }
            PlayListsArray.Refresh();
        }

        private void PlayListsArray_DrawItem(object sender, DrawItemEventArgs e)
        {
            
            if (e.Index != -1)
            {
                e.DrawBackground();
                Brush MyBrush = Brushes.White;
                if (e.Index == PlayLists.CurrentPlayListIndex)
                    MyBrush = Brushes.Red;
                e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, MyBrush, e.Bounds,
                    StringFormat.GenericDefault);
            }
        }
    }
}
