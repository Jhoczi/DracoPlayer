using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace MultimediaPlayer
{
    class AudioPlaylist
    {
        public event EventHandler UpdatePlaylist;
        public List<String> Songs { get; private set; }
        public int Index { get; private set; }

        public List<TagLibMetadata> MediaMetadata { get; private set; }

        public AudioPlaylist()
        {
            Index = 0;
            Songs = new List<string>();
            MediaMetadata = new List<TagLibMetadata>();
        }

        public void InitPlaylist(string path)
        {
            string title;
            string author;
            TagLibMetadata element;
            var files = Directory.EnumerateFiles(path,"*.*",SearchOption.AllDirectories)
                .Where(x => x.EndsWith(".mp3") || x.EndsWith(".wav") || x.EndsWith(".WAV") || x.EndsWith(".MKV") || x.EndsWith(".flac") || x.EndsWith(".FLAC"));

            if (files.Count() < 1)
            {
                return;
            }
            foreach (var item in files)
            {
                Songs.Add(item);
                element = new TagLibMetadata(item);
                if (element.MetaDataTL.Tag.Title == null)
                    element.MetaDataTL.Tag.Title = "Unknown";
                //if (element.MetaDataTL.Tag.Performers.Length < 0)
                //{ 
                //    element.MetaDataTL.Tag.Performers = new string[1] { "Unknown" };
                //    element.MetaDataTL.Save();
                //}
                //element.MetaDataTL.Tag.Performers[0] = "Unknown";
                MediaMetadata.Add(element);
            }
            //OpenFileDialog dlg = new OpenFileDialog();

            //dlg.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            //dlg.Multiselect = true;
            //DialogResult dialogResult = dlg.ShowDialog();



            //if (dialogResult == System.Windows.Forms.DialogResult.OK)
            //{
            //    foreach (String file in dlg.FileNames)
            //    {
            //        Playlist.Add(file);
            //    }
            //}
        }

        public void Next()
        {
            if (Index >= Songs.Count - 1)
            {
                return;
            }
            Index++;
        }

        public void Prev()
        {
            if (Index <= 0)
            {
                return;
            }
            Index--;
        }
        public void SetSong(object sender)
        {
            //for (int i = 0; i < Songs.Count; i++)
            //{
            //    if (MediaMetadata[i].MetaDataTL.Tag.Title == null)
            //        return;
            //    if (name == MediaMetadata[i].MetaDataTL.Tag.Title)
            //    {
            //        Index = i;
            //    }
            //}
            IconButton btn = sender as IconButton;
            //MessageBox.Show($"{btn.Name} Clicked.");
            int value = Int32.Parse(btn.Name);
            if (value > -1 && value < Songs.Count)
                Index = value;
            else
                return;
        }

    }
}
