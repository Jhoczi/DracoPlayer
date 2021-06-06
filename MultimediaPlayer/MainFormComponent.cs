using FontAwesome.Sharp;
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
        //TagLibMetadata mediaMetadata;

        List<IconButton> buttonsPlaySong = new List<IconButton> { };

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
            metroVolumeTrackbar.Value = (int)(player.AudioFile.Volume * 100);
            mediaTimer.Tick += UpdatePlayerStart;
            mediaTimer.Tick += UpdateTrackBar;
            labelTest.Text = $"{player.OutputDevice.PlaybackState}";
            CreateListPanel();
        }

        private void CreateListPanel()
        {
            FontAwesome.Sharp.IconButton iconButton;
            string title;
            string author;

            for (int i = 0; i < player.playlist.Songs.Count; i++)
            {
                //if (player.playlist.MediaMetadata[i].MetaDataTL.Tag.Title == null)
                //    title = "Unknown";
                //else
                //    title = player.playlist.MediaMetadata[i].MetaDataTL.Tag.Title;


                if (player.playlist.MediaMetadata[i].MetaDataTL.Tag.Performers.Length > 0)
                    author = player.playlist.MediaMetadata[i].MetaDataTL.Tag.Performers[0];
                else
                    author = "Unknow";
                var panel = new Panel()
                {
                    Name = $"songFromListPanel{i}",
                    Padding = new Padding(10, 10, 10, 10),
                    BackColor = Color.FromArgb(0, 0, 0),
                    Anchor = AnchorStyles.Top,
                    Location = new Point(0, i * 70),
                    Size = new Size(panelMainMenu.Width, 70),
                    Parent = panelMainMenu,
                    Visible = true,
                };
                var picture = new PictureBox()
                {
                    Image = player.playlist.MediaMetadata[i].GetImage(),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(0, 10),
                    Dock = DockStyle.Left,
                    Margin = new Padding(3, 3, 3, 3),
                    Size = new Size(60, 50),
                    Parent = panel,
                    Visible = true,
                };
                iconButton = new FontAwesome.Sharp.IconButton()
                {
                    IconChar = FontAwesome.Sharp.IconChar.PlayCircle,
                    Name = $"{i}",
                    IconColor = Color.White,
                    Location = new Point(110, 10),
                    FlatStyle = FlatStyle.Flat,
                    Tag = "playS",
                    //Click += (s, args) => { player.playlist.SetSong("xyz"); },
                    IconSize = 24,
                    Size = new Size(50, 50),
                    Parent = panel,
                    Visible = true,
                };
                //this.Controls.Add(iconButton);
                buttonsPlaySong.Add(iconButton);
                //player.playlist.SetSong(player.playlist.MediaMetadata[i].MetaDataTL.Tag.Title
                //buttonsPlaySong[i].Click += (s, args) => { player.playlist.SetSong(buttonsPlaySong[i]); };
                iconButton.Click += new EventHandler(ChangeSong);
                var labelSongTitle = new Label()
                {
                    Text = player.playlist.MediaMetadata[i].MetaDataTL.Tag.Title,
                    ForeColor = Color.LightGray,
                    Location = new Point(200, 29),
                    Size = new Size(300, 19),
                    Parent = panel,
                    Visible = true
                };
                var labelArtistsName = new Label()
                {
                    // TODO: FIX PROBLEM WITH PERFORMERS TABLE
                    //Text = player.playlist.MediaMetadata[i].MetaDataTL.Tag.Performers[0],
                    Text = author,
                    ForeColor = Color.LightGray,
                    Location = new Point(520, 29),
                    Size = new Size(200, 19),
                    Parent = panel,
                    Visible = true
                };
                var minutes = (int)player.playlist.MediaMetadata[i].MetaDataTL.Properties.Duration.TotalSeconds / 60;
                var seconds = (int)player.playlist.MediaMetadata[i].MetaDataTL.Properties.Duration.TotalSeconds % 60;
                var duration = new Label()
                {

                    Text = $"{minutes:D2}:{seconds:D2}",
                    ForeColor = Color.LightGray,
                    Location = new Point(850, 29),
                    Size = new Size(80, 19),
                    Parent = panel,
                    Visible = true
                };
                //iconButton.Click += (s, args) => { player.playlist.SetSong(iconButton.Name); };
            }
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
            player.TogglePlayPause();
            player.SetPosition(playerTrackBar.Value);
            if (btnPlay.IconChar != FontAwesome.Sharp.IconChar.StopCircle)
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
                buttonsPlaySong[player.playlist.Index].IconChar = IconChar.StopCircle;
            }
            else
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
                buttonsPlaySong[player.playlist.Index].IconChar = IconChar.PlayCircle;
            }   
            UpdateMediaData();
            UpdatePlayerComponents();

            labelTest.Text = $"{player.OutputDevice.PlaybackState}";
        }
        private void UpdateMediaData()
        {
            //if (player != null)
            //{
            //mediaMetadata = new TagLibMetadata(player.AudioFile.FileName);
            //labelTitle.Text = mediaMetadata.MetaDataTL.Tag.Title;
            if (player.playlist.MediaMetadata[player.playlist.Index].MetaDataTL.Tag.Performers.Length > 0)
                labelAuthor.Text = player.playlist.MediaMetadata[player.playlist.Index].MetaDataTL.Tag.Performers[0];
            else
                labelAuthor.Text = "Unknown";
            currentPlayPictureBox.Image = player.playlist.MediaMetadata[player.playlist.Index].GetImage();

            labelTitle.Text = player.playlist.MediaMetadata[player.playlist.Index].MetaDataTL.Tag.Title;
            //}
        }
            
        private void UpdatePlayerComponents()
        {

            //mediaTimer.Enabled = !mediaTimer.Enabled;
            mediaTimer.Enabled = true;
            playerTrackBar.Maximum = (int)player.GetEntityLengthInSeconds();
            UpdatePlayerEndTime();
            metroVolumeTrackbar.Value = metroVolumeTrackbar.Value = (int)(player.AudioFile.Volume * 100);

        }
        private void UpdatePlayerEndTime()
        {
            var minutes =  (int)player.GetEntityLengthInSeconds()/60;
            var seconds = (int)player.GetEntityLengthInSeconds() % 60;
            //string mf =  minutes < 10 ? $"{minutes:D2}" : minutes.ToString();
            //labelPlayerEnd.Text = $"{mf}:{seconds:D2}";
            labelPlayerEnd.Text = $"{minutes:D2}:{seconds:D2}";
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
                //player.Next();
                //player.NextSong();
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
                //btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
                ResetMenuPlayer();
                buttonsPlaySong[player.playlist.Index].IconChar = IconChar.PlayCircle;
                player.playlist.Next();
                player.NextSong();
                if (btnPlay.IconChar != FontAwesome.Sharp.IconChar.PlayCircle)
                {
                    player.Play();
                    buttonsPlaySong[player.playlist.Index].IconChar = IconChar.StopCircle;
                }
                UpdateMediaData();
                UpdatePlayerComponents();
            }
        }
        private void ResetMenuPlayer()
        {
            //mediaTimer.Enabled = !mediaTimer.Enabled;
            mediaTimer.Enabled = false;
            //btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
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
            buttonsPlaySong[player.playlist.Index].IconChar = IconChar.PlayCircle;
            player.playlist.Next();
            //btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            player.NextSong();

            if (btnPlay.IconChar != FontAwesome.Sharp.IconChar.PlayCircle)
            {
                player.Play();
                buttonsPlaySong[player.playlist.Index].IconChar = IconChar.StopCircle;
            }
                

            UpdateMediaData();
            UpdatePlayerComponents();
            //player.Play();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ResetMenuPlayer();
            player.Stop();
            buttonsPlaySong[player.playlist.Index].IconChar = IconChar.PlayCircle;
            player.playlist.Prev();
            //btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            player.NextSong();

            if (btnPlay.IconChar != FontAwesome.Sharp.IconChar.PlayCircle)
            {
                player.Play();
                buttonsPlaySong[player.playlist.Index].IconChar = IconChar.StopCircle;
            }


            UpdateMediaData();
            UpdatePlayerComponents();
        }

        private void ChangeSong(object sender, EventArgs e)
        {

            IconButton btn = sender as IconButton;
            ResetMenuPlayer();
            player.Stop();
            if (btn.IconChar == FontAwesome.Sharp.IconChar.StopCircle)
            {
                btn.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            }
            else
            {
                //btn.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
                //btnPlay.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
                player.playlist.SetSong(sender);
                btnPlay_Click(sender, e);
            }
            //ResetMenuPlayer();
            //player.SetPosition(playerTrackBar.Value);
            //player.TogglePlayPause();
            
            

            //UpdateMediaData();
            //UpdatePlayerComponents();
            MessageBox.Show($"{mediaTimer.Enabled}");
            labelTest.Text = $"{player.OutputDevice.PlaybackState}";

            

            ////buttonsPlaySong[player.playlist.Index].IconChar = IconChar.PlayCircle;
            //player.playlist.SetSong(sender);
            ////player.TogglePlayPause();
            //if (btn.IconChar == IconChar.StopCircle)
            //{
            //    buttonsPlaySong[player.playlist.Index].IconChar = IconChar.PlayCircle;
            //    btnPlay.IconChar = IconChar.PlayCircle;
            //    player.Pause();
            //}      
            //else
            //{
            //    btn.IconChar = IconChar.StopCircle;
            //    player.NextSong();
            //    if (btnPlay.IconChar != FontAwesome.Sharp.IconChar.PlayCircle)
            //        player.Play();
            //    UpdateMediaData();
            //    UpdatePlayerComponents();
            //}
            //buttonsPlaySong[player.playlist.Index].IconChar = IconChar.PlayCircle;      
            //player.NextSong();
            //if (btnPlay.IconChar != FontAwesome.Sharp.IconChar.PlayCircle)
            //    player.Play();
            //UpdateMediaData();
            //UpdatePlayerComponents();

            //if (btnPlay.IconChar == FontAwesome.Sharp.IconChar.StopCircle)
            //{
            //    //mediaTimer.Enabled = false;
            //    btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            //    btn.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            //}
            //else
            //{
            //    //mediaTimer.Enabled = true;
            //    btnPlay.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            //    btn.IconChar = FontAwesome.Sharp.IconChar.StopCircle;
            //} 

        }
    }
}
