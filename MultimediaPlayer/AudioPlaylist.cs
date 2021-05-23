using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MultimediaPlayer
{
    class AudioPlaylist
    {
        public List<String> Songs { get; set; }
        public int Index { get; set; }

        public AudioPlaylist()
        {
            Index = 0;
            Songs = new List<string> { };
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
    }
}
