using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Un4seen.Bass.AddOn.Tags;

namespace WindowsFormsApplication1
{
    public class TagReader
    {
        private int BitRate;
        public int bitRate { get { return BitRate; } }

        private int Freq;
        public int freq { get { return Freq;} }

        private string Channels;
        public string channels { get { return Channels;} }

        private string Artist;
        public string artist { get { return Artist;} }

        private string Album;
        public string album { get { return Album;} }

        private string Title;
        public string title { get { return Title;} }

        private string Year;
        public string year { get { return Year;} }

        private Image Cover;
        public Image cover { get { return Cover;} }

        private string Raiting;
        public string raiting { get { return Raiting;} }

        private Dictionary<int, string> ChannelType = new Dictionary<int, string>()
        {
            {0,"null" },
            {1,"mono" },
            {2,"stereo" }
        };

        public TagReader(string file)
        {
            TAG_INFO tag_info = new TAG_INFO();
            tag_info = BassTags.BASS_TAG_GetFromFile(file);
            BitRate = tag_info.bitrate;
            Freq = tag_info.channelinfo.freq;
            Channels = ChannelType[tag_info.channelinfo.chans];
            Artist = tag_info.artist;
            Album = tag_info.album;
            if (tag_info.title == "")
                Title = WorkClass.GetFileName(file);
            else
                Title = tag_info.title;
            Year = tag_info.year;
            Cover = tag_info.PictureGetImage(0);
            Raiting = tag_info.rating;
        }

    }
}
