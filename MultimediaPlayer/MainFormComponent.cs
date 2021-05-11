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

        public MainFormComponent()
        {
            InitializeComponent();
            InitCustomFont();
            this.Font = new Font(_pfc.Families[0],this.Font.Size);
            playerTrackBar.Value = 0;
            
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
                //labelPlayerEnd.Text = player.GetMediaLength().ToString("mm:tt");
                UpdatePlayerEndTime();
                mediaTimer.Enabled = !mediaTimer.Enabled;
                mediaTimer.Tick += UpdateTrackBar;
            }
            else
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
                player.Stop();
                mediaTimer.Enabled = !mediaTimer.Enabled;
            }
        }
        private void UpdatePlayerEndTime()
        {
            var minutes =  (int)player.GetMediaLength().TotalMinutes;
            var seconds = player.GetMediaLength().Seconds;
            string mf =  minutes < 10 ? $"0{minutes}" : minutes.ToString();
            labelPlayerEnd.Text = $"{mf}:{seconds}";
        }
        private void UpdateTrackBar(object sender, EventArgs e)
        {
            MediaStartPlayer++;
            labelPlayerStart.Text = MediaStartPlayer.ToString();
        }

    }
}
