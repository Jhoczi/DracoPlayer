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
using System.Linq;
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
        List<IconButton> buttonsPlaySong = new List<IconButton> { };

        public MainFormComponent()
        {
            InitializeComponent();
            InitCustomFont();
            Init();
        }

        private void Init()
        {
            this.Font = new Font(_pfc.Families[0], this.Font.Size);
            player = new NAudioComponent();
            playerTrackBar.Value = 0;
            playerTrackBar.Maximum = (int)player.GetEntityLengthInSeconds();
            metroVolumeTrackbar.Maximum = 100;
            metroVolumeTrackbar.Value = (int)(player.AudioFile.Volume * 100);
            mediaTimer.Tick += UpdatePlayerStart;
            mediaTimer.Tick += UpdateTrackBar;
            UpdateMediaData();
            CreateListPanel(player.Playlist.IndexList);
        }

        private void InitCustomFont()
        {
            int fontLength = Properties.Resources.Roboto_Regular.Length;

            byte[] fontdata = Properties.Resources.Roboto_Regular;

            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);

            _pfc.AddMemoryFont(data, fontLength);
        }

        private void CreateListPanel(int[] indexList)
        {
            Panel panel;
            PictureBox picture;
            IconButton iconButton;
            Label labelSongTitle;
            Label labelArtistsName;
            Label duration;
            int minutes, seconds;
            panelMainMenu.Controls.Clear();
            panelMainMenu.SuspendLayout();
            //for (int i = 0; i < player.Playlist.IndexList.Length; i++)
            for (int i = 0; i < indexList.Length; i++)
            {
                panel = new Panel()
                {
                    Name = $"songFromListPanel{i}",
                    Padding = new Padding(10, 10, 10, 10),
                    BackColor = Color.FromArgb(0, 0, 0),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                    Location = new Point(0, i * 70),
                    Size = new Size(panelMainMenu.Width, 70),
                    Parent = panelMainMenu,
                    Visible = true,
                };
                picture = new PictureBox()
                {
                    //Image = player.Playlist.GetImageFromMD(player.GetElementOfIndexList(indexList[i])),
                    Image = player.Playlist.GetImageFromMD(player.GetElementOfIndexList(indexList[i])),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(0, 10),
                    Dock = DockStyle.Left,
                    Margin = new Padding(3, 3, 3, 3),
                    Size = new Size(60, 50),
                    Parent = panel,
                    Visible = true,
                };
                iconButton = new IconButton()
                {
                    IconChar = IconChar.PlayCircle,
                    Name = $"{indexList[i]}",
                    IconColor = Color.White,
                    Location = new Point(110, 10),
                    FlatStyle = FlatStyle.Flat,
                    Tag = "playS",
                    IconSize = 32,
                    Size = new Size(50, 50),
                    Parent = panel,
                    Visible = true,
                };
                buttonsPlaySong.Add(iconButton);
                iconButton.Click += new EventHandler(ChangeSong);
                labelSongTitle = new Label()
                {
                    //Text = player.Playlist.GetTitleFromMD(player.GetElementOfIndexList(indexList[i])),
                    Text = player.Playlist.GetTitleFromMD(indexList[i]),
                    ForeColor = Color.LightGray,
                    Location = new Point(200, 29),
                    Size = new Size(300, 19),
                    Font = new Font(this.Font, FontStyle.Bold),
                    Parent = panel,
                    Visible = true
                };

                labelArtistsName = new Label()
                {
                    //Text = player.Playlist.GetAuthorFromMD(player.GetElementOfIndexList(indexList[i])),
                    Text = player.Playlist.GetAuthorFromMD(indexList[i]),
                    ForeColor = Color.LightGray,
                    Location = new Point(520, 29),
                    Size = new Size(200, 19),
                    Font = new Font(this.Font, FontStyle.Bold),
                    Parent = panel,
                    Visible = true
                };
                minutes = (int)player.Playlist.MediaMetadata[indexList[i]].MetaDataTL.Properties.Duration.TotalSeconds / 60;
                seconds = (int)player.Playlist.MediaMetadata[indexList[i]].MetaDataTL.Properties.Duration.TotalSeconds % 60;
                duration = new Label()
                {
                    Text = $"{minutes:D2}:{seconds:D2}",
                    ForeColor = Color.LightGray,
                    Location = new Point(850, 29),
                    Size = new Size(80, 19),
                    Font = new Font(this.Font, FontStyle.Bold),
                    Parent = panel,
                    Visible = true
                };
            }
            panelMainMenu.ResumeLayout();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            player.TogglePlayPause();
            player.SetPosition(playerTrackBar.Value);
            if (player.IsRunning)
            {
                btnPlay.IconChar = IconChar.StopCircle;
                buttonsPlaySong[ player.GetCurrentIndex() ].IconChar = IconChar.StopCircle;
            }
            else
            {
                btnPlay.IconChar = IconChar.PlayCircle;
                buttonsPlaySong[ player.GetCurrentIndex() ].IconChar = IconChar.PlayCircle;
            }
            UpdateMediaData();
            UpdatePlayerComponents();
        }
        private void UpdateMediaData()
        {
            labelAuthor.Text = player.Playlist.GetAuthorFromMD( player.GetCurrentIndex() );
            currentPlayPictureBox.Image = player.Playlist.GetImageFromMD(player.GetCurrentIndex());
            labelTitle.Text = player.Playlist.GetTitleFromMD( player.GetCurrentIndex() );
        }
            
        private void UpdatePlayerComponents()
        {
            mediaTimer.Enabled = true;
            playerTrackBar.Maximum = player.GetEntityLengthInSeconds();
            metroVolumeTrackbar.Value  = (int)(player.AudioFile.Volume * 100);
            UpdatePlayerEndTime();
        }
        private void UpdatePlayerEndTime()
        {
            var minutes =  player.GetEntityLengthInSeconds() / 60;
            var seconds = player.GetEntityLengthInSeconds() % 60;
            labelPlayerEnd.Text = $"{minutes:D2}:{seconds:D2}";
        }
        private void UpdatePlayerStart(object sender, EventArgs e)
        {      
            playerTrackBar.Value = player.GetPositionInSeconds();
            var minutes = playerTrackBar.Value / 60;
            var seconds = playerTrackBar.Value % 60;
            labelPlayerStart.Text = $"{minutes:D2}:{seconds:D2}";
        }
        private void UpdateTrackBar(object sender, EventArgs e)
        {
           playerTrackBar.Value = player.GetPositionInSeconds();
           if (playerTrackBar.Value == playerTrackBar.Maximum)
           {
                ResetMenuPlayer();
                buttonsPlaySong[player.GetCurrentIndex()].IconChar = IconChar.PlayCircle;
                player.NextSong();
                if (player.IsRunning)
                {
                    player.TogglePlayPause();
                    buttonsPlaySong[player.GetCurrentIndex()].IconChar = IconChar.StopCircle;
                }
                UpdateMediaData();
                UpdatePlayerComponents();
           }
        }
        private void ResetMenuPlayer()
        {
            mediaTimer.Enabled = false;
            labelPlayerStart.Text = "00:00";
            playerTrackBar.Value = 0;
        }

        private void playerTrackBar_Scroll(object sender, ScrollEventArgs e)
        {
            playerTrackBar.Value = e.NewValue;
            player.AudioFile.CurrentTime = new TimeSpan(0, 0, playerTrackBar.Value);
            var minutes = playerTrackBar.Value / 60;
            var seconds = playerTrackBar.Value % 60;
            labelPlayerStart.Text = $"{minutes:D2}:{seconds:D2}";
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
                btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            else
                btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            player.CreateNewPlaylist();
            CreateListPanel(player.Playlist.IndexList);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ResetMenuPlayer();
            buttonsPlaySong[player.GetCurrentIndex()].IconChar = IconChar.PlayCircle;
            if (player.IsRunning)
            {
                player.TogglePlayPause();
                player.NextSong();
                player.TogglePlayPause();
                buttonsPlaySong[player.GetCurrentIndex()].IconChar = IconChar.StopCircle;
            }
            else
            {
                player.NextSong();
            }   
            UpdateMediaData();
            UpdatePlayerComponents();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            ResetMenuPlayer();
            buttonsPlaySong[player.GetCurrentIndex()].IconChar = IconChar.PlayCircle;
            if (player.IsRunning)
            {
                player.TogglePlayPause();
                player.PrevSong();
                player.TogglePlayPause();
                buttonsPlaySong[player.GetCurrentIndex()].IconChar = IconChar.StopCircle;
            }
            else
            {
                player.PrevSong();
            }
            UpdateMediaData();
            UpdatePlayerComponents();
        }

        private void ChangeSong(object sender, EventArgs e)
        {
            //buttonsPlaySong[player.GetCurrentIndex()].Parent.BackColor = Color.Black;
            //buttonsPlaySong[player.GetCurrentIndex()].BackColor = Color.Black;
            foreach (var item in buttonsPlaySong)
            {
                item.IconChar = IconChar.PlayCircle;
            }
            IconButton btn = sender as IconButton;
            //btn.Parent.BackColor = Color.FromArgb(22, 23, 27);
            //buttonsPlaySong[player.GetCurrentIndex()].FlatStyle = FlatStyle.Flat;
            //buttonsPlaySong[player.GetCurrentIndex()].FlatAppearance.BorderSize = 0;
            //Color.FromArgb(22, 23, 27);
            ResetMenuPlayer();
            //buttonsPlaySong[player.GetCurrentIndex()].IconChar = IconChar.PlayCircle;
            if (player.IsRunning)
            {
                player.TogglePlayPause();
                player.SetCurrentSong(sender);
                player.TogglePlayPause();
                //buttonsPlaySong[player.GetCurrentIndex()].IconChar = IconChar.StopCircle;
                //btnPlay.IconChar = IconChar.StopCircle;
            }
            else
            {
                player.SetCurrentSong(sender);
                player.TogglePlayPause();   
            }
            //buttonsPlaySong[Int32.Parse(btn.Name)].IconChar = IconChar.StopCircle;
            btn.IconChar = IconChar.StopCircle;
            btnPlay.IconChar = IconChar.StopCircle;
            UpdateMediaData();
            UpdatePlayerComponents();
        }

        private void labelVideos_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string word = textSearch.Text;
            var result = player.Playlist.MediaMetadata.
                Select((item, index) => new { item.MetaDataTL, index })
                .Where(item => item.MetaDataTL.Tag.Title.ToLower().Contains(word.ToLower()))
                .Select(x=>x.index)
                .ToArray();

            player.Playlist.IndexList = result;

            panelMainMenu.Controls.Clear();
            if (result.Count() < 1)
                CreateListPanel(player.Playlist.IndexList);
            else
                CreateListPanel(result);
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            MessageBox.Show(player.Playlist.IndexListHistory.ToString());
            if (player.Playlist.IndexListHistory.Count < 1)
                return;
            panelMainMenu.Controls.Clear();

            FontAwesome.Sharp.IconButton iconButton;
            string title;
            string author;
            int i = 0;
            var result = player.Playlist.IndexListHistory
                .Select(y => y)
                .ToArray();

            CreateListPanel(result);
        }

        private void btnArtists_Click(object sender, EventArgs e)
        {
            var q = player.Playlist.MediaMetadata
                .Select((x,y) => new { x, index = y})
                .Where(x => x.x.MetaDataTL.Tag.Performers.Length > 0)
                .GroupBy(x=>x.x.MetaDataTL.Tag.Performers[0])
                .Select((x) => new { name = x.First().x.MetaDataTL.Tag.Performers[0], key = x.First().index })
                .ToList();

            var result = player.Playlist.MediaMetadata
                .Select((x) => new { tytul = x.MetaDataTL.Tag.Title, x })
                .Where(q => q.x.MetaDataTL.Tag.Performers.Length > 0)
                .GroupBy(g => g.x.MetaDataTL.Tag.Performers[0])
                .Select(s=>s.Count())
                .ToList();

            if (q.Count() < 1)
                return;
            panelMainMenu.Controls.Clear();
            panelMainMenu.SuspendLayout();
            int i = 0;
            string author;
            foreach (var item in q)
            {
                if (player.Playlist.MediaMetadata[item.key].MetaDataTL.Tag.Performers.Length > 0)
                    author = player.Playlist.MediaMetadata[item.key].MetaDataTL.Tag.Performers[0];
                else
                    author = "Unknow";
                var panel = new Panel()
                {
                    //Name = $"artist_panel_{item.Performers}",
                    Padding = new Padding(10, 10, 10, 10),
                    BackColor = Color.FromArgb(0, 0, 0),
                    Anchor = AnchorStyles.Top,
                    Location = new Point(0, i * 70),
                    Size = new Size(panelMainMenu.Width, 100),
                    Parent = panelMainMenu,
                    Visible = true,
                };
                var picture = new PictureBox()
                {
                    Image = player.Playlist.MediaMetadata[item.key].GetImage(),
                    BackgroundImageLayout = ImageLayout.Stretch,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(0, 10),
                    Dock = DockStyle.Left,
                    Margin = new Padding(3, 3, 3, 3),
                    Size = new Size(60, 50),
                    Parent = panel,
                    Visible = true,
                };
                var labelArtistsName = new Label()
                {
                    // TODO: FIX PROBLEM WITH PERFORMERS TABLE
                    //Text = player.playlist.MediaMetadata[i].MetaDataTL.Tag.Performers[0],
                    Text = item.name,
                    ForeColor = Color.LightGray,
                    Location = new Point(200, 32),
                    Size = new Size(200, 19),
                    Font = new Font(this.Font, FontStyle.Bold),
                    Parent = panel,
                    Visible = true
                };
                var labelSongCount = new Label()
                {
                    // TODO: FIX PROBLEM WITH PERFORMERS TABLE
                    //Text = player.playlist.MediaMetadata[i].MetaDataTL.Tag.Performers[0],
                    Text = $"Ilość utworów: {result[i]}",
                    ForeColor = Color.LightGray,
                    Location = new Point(400, 32),
                    Size = new Size(200, 19),
                    Font = new Font(this.Font, FontStyle.Bold),
                    Parent = panel,
                    Visible = true
                };
                //var iconButton = new FontAwesome.Sharp.IconButton()
                //{
                //    IconChar = FontAwesome.Sharp.IconChar.PlayCircle,
                //    //Name = $"{item.index}",
                //    Name = $"{i}",
                //    IconColor = Color.White,
                //    Location = new Point(600, 25),
                //    FlatStyle = FlatStyle.Flat,
                //    Tag = "playS",
                //    //Click += (s, args) => { player.playlist.SetSong("xyz"); },
                //    IconSize = 32,
                //    Size = new Size(50, 50),
                //    Parent = panel,
                //    Visible = true,
                //};
                //this.Controls.Add(iconButton);
                //buttonsPlaySong.Add(iconButton);
                //player.playlist.SetSong(player.playlist.MediaMetadata[i].MetaDataTL.Tag.Title
                //buttonsPlaySong[i].Click += (s, args) => { player.playlist.SetSong(buttonsPlaySong[i]); };

                i++;
            }
            panelMainMenu.ResumeLayout();

        }
    }
}
