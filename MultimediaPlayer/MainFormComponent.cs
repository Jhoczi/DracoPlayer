using MultimediaPlayer.Resources;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MultimediaPlayer
{
    public partial class MainFormComponent : Form
    {
        // Font
        PrivateFontCollection _pfc = new PrivateFontCollection();
        // NAudio
        NAudioComponent player;
        TagLibMetadata mediaMetadata;
        

        public int MediaStartPlayer { get; set; } = 0;
        public int TimerTick { get; set; }

        public MainFormComponent()
        {
            InitializeComponent();
            InitCustomFont();
            this.Font = new Font(_pfc.Families[0],this.Font.Size);
            TimerTick = mediaTimer.Interval * 4;
            Init();
        }

        private void Init()
        {
            player = new NAudioComponent();
            UpdateMediaData();
            playerTrackBar.Value = 0;
            playerTrackBar.Maximum = (int)player.GetEntityLengthInSeconds();
            metroVolumeTrackbar.Maximum = 100;
            //metroVolumeTrackbar.Value = (int)player.GetVolume() * 100;
            metroVolumeTrackbar.Value = (int)(player.AudioFile.Volume * 100);
            mediaTimer.Tick += UpdatePlayerStart;
            mediaTimer.Tick += UpdateTrackBar;
        }

        private void InitCustomFont()
        {     
            int fontLength = Properties.Resources.Roboto_Regular.Length;

            byte[] fontdata = Properties.Resources.Roboto_Regular;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);

            _pfc.AddMemoryFont(data, fontLength);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (btnPlay.IconChar != FontAwesome.Sharp.IconChar.StopCircle)
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
                player.Play();
                UpdateMediaData();
            }
            else
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
                player.Pause();            
            }
            UpdatePlayerComponents();
            var tfile = TagLib.File.Create(@"E:\Muzyka\01 THE THEME FROM BIG WAVE.mp3");
            string title = tfile.Tag.Title;
            TimeSpan duration = tfile.Properties.Duration;
            Console.WriteLine("Title: {0}, duration: {1}", title, duration);

            labelTest.Text = $"{mediaMetadata.MetaDataTL.Tag.Title}";
        }
        private void UpdateMediaData()
        {
            if (player != null)
            {
                mediaMetadata = new TagLibMetadata(player.AudioFile.FileName);
                labelTitle.Text = mediaMetadata.MetaDataTL.Tag.Title;
                labelAuthor.Text = mediaMetadata.MetaDataTL.Tag.AlbumArtists[0];
                currentPlayPictureBox.Image = mediaMetadata.GetImage();
            }
        }
            
        private void UpdatePlayerComponents()
        {

            mediaTimer.Enabled = !mediaTimer.Enabled;
            playerTrackBar.Maximum = (int)player.GetEntityLengthInSeconds();
            UpdatePlayerEndTime();
            metroVolumeTrackbar.Value = metroVolumeTrackbar.Value = (int)(player.AudioFile.Volume * 100);

        }
        private void UpdatePlayerEndTime()
        {
            var minutes =  (int)player.GetEntityLengthInSeconds()/60;
            var seconds = (int)player.GetEntityLengthInSeconds()%60;
            string mf =  minutes < 10 ? $"0{minutes}" : minutes.ToString();
            labelPlayerEnd.Text = $"{mf}:{seconds}";
        }
        private void UpdatePlayerStart(object sender, EventArgs e)
        {
            
                playerTrackBar.Value = (int)player.GetPositionInSeconds();
                var minutes = (int)playerTrackBar.Value / 60;
                var seconds = (int)playerTrackBar.Value % 60;
                string sf = seconds < 10 ? $"0{seconds}" : $"{seconds}";
                string mf = minutes < 10 ? $"0{minutes}" : $"{minutes}";
                labelPlayerStart.Text = $"{mf}:{sf}";
            
            if (MediaStartPlayer == (int)player.GetEntityLengthInSeconds() +1)
            {
                ResetMenuPlayer();
            }
        }
        private void UpdateTrackBar(object sender, EventArgs e)
        {
            
                playerTrackBar.Value = (int)player.GetPositionInSeconds();
                var minutes = (int)playerTrackBar.Value / 60;
                var seconds = (int)playerTrackBar.Value % 60;
                string sf = seconds < 10 ? $"0{seconds}" : $"{seconds}";
                string mf = minutes < 10 ? $"0{minutes}" : $"{minutes}";
                //labelTest.Text = $"{mf}:{sf}";
            
            if (playerTrackBar.Value == playerTrackBar.Maximum)
            {
                ResetMenuPlayer();
            }
        }
        private void ResetMenuPlayer()
        {
            mediaTimer.Enabled = !mediaTimer.Enabled;
            btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            labelPlayerStart.Text = "00:00";
            playerTrackBar.Value = 0;

        }

        private void playerTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
                player.AudioFile.CurrentTime = new TimeSpan(0, 0, playerTrackBar.Value);
                var minutes = (int)playerTrackBar.Value / 60;
                var seconds = (int)playerTrackBar.Value % 60;
                string sf = seconds < 10 ? $"0{seconds}" : $"{seconds}";
                string mf = minutes < 10 ? $"0{minutes}" : $"{minutes}";
                labelPlayerStart.Text = $"{mf}:{sf}";
        }

        private void mediaTimer_Tick(object sender, EventArgs e)
        {
            //labelTest.Text = player.AudioFile;
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            if (btnVolume.IconChar == FontAwesome.Sharp.IconChar.VolumeUp)
            {
                metroVolumeTrackbar.Value = 0;
                player.AudioFile.Volume = 0;
            }
            else
            {
                player.SetVolume(player.CurrentVolume);
                metroVolumeTrackbar.Value = (int)(player.AudioFile.Volume * 100);   
            }         
            UpdateVolumeIcon();
        }

        private void metroVolumeTrackbar_Scroll(object sender, ScrollEventArgs e)
        {

            player.CurrentVolume = (float)metroVolumeTrackbar.Value / 100;
            player.SetVolume(player.CurrentVolume);
            UpdateVolumeIcon();
        }

        private void UpdateVolumeIcon()
        {
            if (btnVolume.IconChar == FontAwesome.Sharp.IconChar.VolumeUp && metroVolumeTrackbar.Value < 1)
            {
                btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            }
            else
            {
                btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //player.InitPlaylist();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ResetMenuPlayer();
            player.Stop();
            player.Next();
            btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ResetMenuPlayer();
            player.Stop();
            player.Prev();
            btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;         
        }
    }
}
