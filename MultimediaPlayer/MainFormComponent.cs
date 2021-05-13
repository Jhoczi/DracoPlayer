using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MultimediaPlayer
{
    public partial class MainFormComponent : Form
    {
        // Delegat Definition
        public delegate void ManageMedia(object? sender, EventArgs e);
        // Font
        PrivateFontCollection _pfc = new PrivateFontCollection();
        // NAudio
        AudioComponent player = new AudioComponent();

        ManageMedia mediaDelegate;

        public int MediaStartPlayer { get; set; } = 0;
        public int TimerTick { get; set; }

        public MainFormComponent()
        {
            InitializeComponent();
            InitCustomFont();
            this.Font = new Font(_pfc.Families[0],this.Font.Size);
            TimerTick = mediaTimer.Interval * 4;
            playerTrackBar.Value = 0;
            playerTrackBar.Maximum = (int)player.GetMediaLength().TotalSeconds * 4;
            metroVolumeTrackbar.Maximum = 100;
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
                playerTrackBar.Maximum = (int)player.GetMediaLength().TotalSeconds;
                UpdatePlayerEndTime();    
            }
            else
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
                player.Stop();            
            }
            mediaTimer.Enabled = !mediaTimer.Enabled;
        }
        private void UpdatePlayerEndTime()
        {
            var minutes =  (int)player.GetMediaLength().TotalMinutes;
            var seconds = player.GetMediaLength().Seconds;
            string mf =  minutes < 10 ? $"0{minutes}" : minutes.ToString();
            labelPlayerEnd.Text = $"{mf}:{seconds}";
        }
        private void UpdatePlayerStart(object sender, EventArgs e)
        {
            if (player.IsRunning)
            {
                playerTrackBar.Value = player.GetCurrentTime();
                var minutes = (int)playerTrackBar.Value / 60;
                var seconds = (int)playerTrackBar.Value % 60;
                string sf = seconds < 10 ? $"0{seconds}" : $"{seconds}";
                string mf = minutes < 10 ? $"0{minutes}" : $"{minutes}";
                labelPlayerStart.Text = $"{mf}:{sf}";
            }
            if (MediaStartPlayer == (int)player.GetMediaLength().TotalSeconds +1)
            {
                ResetMenuPlayer();
            }
        }
        private void UpdateTrackBar(object sender, EventArgs e)
        {
            if (player.IsRunning)
            {
                playerTrackBar.Value = player.GetCurrentTime();
                var minutes = (int)playerTrackBar.Value / 60;
                var seconds = (int)playerTrackBar.Value % 60;
                string sf = seconds < 10 ? $"0{seconds}" : $"{seconds}";
                string mf = minutes < 10 ? $"0{minutes}" : $"{minutes}";
                //labelTest.Text = $"{mf}:{sf}";
            }
            if (playerTrackBar.Value == playerTrackBar.Maximum)
            {
                ResetMenuPlayer();
            }
        }
        private void ResetMenuPlayer()
        {
            player.IsRunning = false;
            player.Stop();
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
                player.ChangeVolume();
                metroVolumeTrackbar.Value = (int)(player.AudioFile.Volume * 100);   
            }         
            UpdateVolumeIcon();
        }

        private void metroVolumeTrackbar_Scroll(object sender, ScrollEventArgs e)
        {

            player.CurrentVolume = (float)metroVolumeTrackbar.Value / 100;
            player.ChangeVolume();
            labelTest.Text = ((float)metroVolumeTrackbar.Value/100).ToString();
            UpdateVolumeIcon();
        }

        private void UpdateVolumeIcon()
        {
            if (btnVolume.IconChar == FontAwesome.Sharp.IconChar.VolumeUp && metroVolumeTrackbar.Value == 0)
            {
                btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            }
            else
            {
                btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            }
        }
    }
}
