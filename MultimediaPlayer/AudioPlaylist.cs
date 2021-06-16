using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace MultimediaPlayer
{
    class AudioPlaylist
    {
        public List<String> Songs { get; private set; }
        public int Index { get; private set; }
        public int[] IndexList { get; set; }
        public List<int> IndexListHistory { get; set; }
        public List<TagLibMetadata> MediaMetadata { get; private set; }
        TagLibMetadata _element;
        public AudioPlaylist()
        {
            Index = 0;
            Songs = new List<string>();
            MediaMetadata = new List<TagLibMetadata>();
            IndexListHistory = new List<int>();
        }

        public void InitPlaylist(string path)
        {
            var files = Directory.EnumerateFiles(path,"*.*",SearchOption.AllDirectories)
                .Where(x => x.EndsWith(".mp3") || x.EndsWith(".wav") || x.EndsWith(".WAV") || x.EndsWith(".MKV") || x.EndsWith(".flac") || x.EndsWith(".FLAC"));

            if (files.Count() < 1)
            {
                return;
            }
            foreach (var item in files)
            {
                Songs.Add(item);
                _element = new TagLibMetadata(item);
                if (_element.MetaDataTL.Tag.Title == null)
                    _element.MetaDataTL.Tag.Title = "Unknown";
                //if (element.MetaDataTL.Tag.Performers.Length < 0)
                //{ 
                //    element.MetaDataTL.Tag.Performers = new string[1] { "Unknown" };
                //    element.MetaDataTL.Save();
                //}
                //element.MetaDataTL.Tag.Performers[0] = "Unknown";
                MediaMetadata.Add(_element);
            }
            IndexList = new int[Songs.Count];
            for (int i = 0; i < Songs.Count; i++)
            {
                IndexList[i] = i;
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
        public void NewPlaylist()
        {
            Songs.Clear();
            MediaMetadata.Clear();
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            dlg.Multiselect = true;
            DialogResult dialogResult = dlg.ShowDialog();

            if (dialogResult == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String file in dlg.FileNames)
                {
                    Songs.Add(file);
                    _element = new TagLibMetadata(file);
                    if (_element.MetaDataTL.Tag.Title == null)
                        _element.MetaDataTL.Tag.Title = "Unknown";
                    //if (element.MetaDataTL.Tag.Performers.Length < 0)
                    //{ 
                    //    element.MetaDataTL.Tag.Performers = new string[1] { "Unknown" };
                    //    element.MetaDataTL.Save();
                    //}
                    //element.MetaDataTL.Tag.Performers[0] = "Unknown";
                    MediaMetadata.Add(_element);
                }
                IndexList = new int[Songs.Count];
                for (int i = 0; i < Songs.Count; i++)
                {
                    IndexList[i] = i;
                }
            }
        }

        public void Next()
        {
            if (Index >= IndexList.Length - 1)
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

        public void ResetIndex()
        {
            Index = 0;
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
            {
                Index = value;
                
            }
            else
                return;
        }
        public string GetAuthorFromMD(int index)
        {
            //return MediaMetadata[IndexList[index]].GetAuthor();
            return MediaMetadata[index].GetAuthor();
        }

        public string GetTitleFromMD(int index)
        {
            //return MediaMetadata[IndexList[index]].GetTitle();
            return MediaMetadata[index].GetTitle();
        }
        public Image GetImageFromMD(int index)
        {
            return MediaMetadata[IndexList[index]].GetImage();
            //return MediaMetadata[index].GetImage();
        }
    }
    
}
