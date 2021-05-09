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
        // Font
        PrivateFontCollection _pfc = new PrivateFontCollection();
        // NAudio
        AudioComponent player = new AudioComponent();

        public MainFormComponent()
        {
            InitializeComponent();
            InitCustomFont();
            this.Font = new Font(_pfc.Families[0],this.Font.Size);
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
            }
            else
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
                player.Stop();
            }
                     
        }
    }
}
