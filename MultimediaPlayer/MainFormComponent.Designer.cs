﻿
namespace MultimediaPlayer
{
    partial class MainFormComponent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnFilms = new FontAwesome.Sharp.IconButton();
            this.labelVideos = new System.Windows.Forms.Label();
            this.btnAlbums = new FontAwesome.Sharp.IconButton();
            this.btnArtists = new FontAwesome.Sharp.IconButton();
            this.btnSongs = new FontAwesome.Sharp.IconButton();
            this.labelYourMusic = new System.Windows.Forms.Label();
            this.btnPlaylists = new FontAwesome.Sharp.IconButton();
            this.btnActivity = new FontAwesome.Sharp.IconButton();
            this.btnBrowse = new FontAwesome.Sharp.IconButton();
            this.labelMain = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.iconLogo = new FontAwesome.Sharp.IconButton();
            this.panelMediaBottom = new System.Windows.Forms.Panel();
            this.btnVolume = new FontAwesome.Sharp.IconButton();
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPlayerEnd = new MetroFramework.Controls.MetroLabel();
            this.labelPlayerStart = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.playerTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.currentPlayPictureBox = new System.Windows.Forms.PictureBox();
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.PanelElementList = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelAuthor1 = new System.Windows.Forms.Label();
            this.labelTitle1 = new System.Windows.Forms.Label();
            this.btnPlaySong1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mediaTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelSearchBar.SuspendLayout();
            this.panelMediaBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPlayPictureBox)).BeginInit();
            this.panelMainMenu.SuspendLayout();
            this.PanelElementList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.panelMenu.Controls.Add(this.btnFilms);
            this.panelMenu.Controls.Add(this.labelVideos);
            this.panelMenu.Controls.Add(this.btnAlbums);
            this.panelMenu.Controls.Add(this.btnArtists);
            this.panelMenu.Controls.Add(this.btnSongs);
            this.panelMenu.Controls.Add(this.labelYourMusic);
            this.panelMenu.Controls.Add(this.btnPlaylists);
            this.panelMenu.Controls.Add(this.btnActivity);
            this.panelMenu.Controls.Add(this.btnBrowse);
            this.panelMenu.Controls.Add(this.labelMain);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 727);
            this.panelMenu.TabIndex = 0;
            // 
            // btnFilms
            // 
            this.btnFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnFilms.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilms.FlatAppearance.BorderSize = 0;
            this.btnFilms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilms.ForeColor = System.Drawing.Color.White;
            this.btnFilms.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btnFilms.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnFilms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilms.Location = new System.Drawing.Point(0, 647);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Size = new System.Drawing.Size(220, 60);
            this.btnFilms.TabIndex = 16;
            this.btnFilms.Text = "Video";
            this.btnFilms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilms.UseVisualStyleBackColor = false;
            // 
            // labelVideos
            // 
            this.labelVideos.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelVideos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelVideos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            this.labelVideos.Location = new System.Drawing.Point(0, 597);
            this.labelVideos.Margin = new System.Windows.Forms.Padding(0);
            this.labelVideos.Name = "labelVideos";
            this.labelVideos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelVideos.Size = new System.Drawing.Size(220, 50);
            this.labelVideos.TabIndex = 15;
            this.labelVideos.Text = "VIDEOS";
            this.labelVideos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAlbums
            // 
            this.btnAlbums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnAlbums.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlbums.FlatAppearance.BorderSize = 0;
            this.btnAlbums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbums.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAlbums.ForeColor = System.Drawing.Color.White;
            this.btnAlbums.IconChar = FontAwesome.Sharp.IconChar.CompactDisc;
            this.btnAlbums.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAlbums.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlbums.Location = new System.Drawing.Point(0, 537);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(220, 60);
            this.btnAlbums.TabIndex = 14;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbums.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlbums.UseVisualStyleBackColor = false;
            // 
            // btnArtists
            // 
            this.btnArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnArtists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArtists.FlatAppearance.BorderSize = 0;
            this.btnArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArtists.ForeColor = System.Drawing.Color.White;
            this.btnArtists.IconChar = FontAwesome.Sharp.IconChar.Guitar;
            this.btnArtists.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnArtists.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArtists.Location = new System.Drawing.Point(0, 477);
            this.btnArtists.Name = "btnArtists";
            this.btnArtists.Size = new System.Drawing.Size(220, 60);
            this.btnArtists.TabIndex = 13;
            this.btnArtists.Text = "Artists";
            this.btnArtists.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArtists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArtists.UseVisualStyleBackColor = false;
            // 
            // btnSongs
            // 
            this.btnSongs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnSongs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSongs.FlatAppearance.BorderSize = 0;
            this.btnSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSongs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSongs.ForeColor = System.Drawing.Color.White;
            this.btnSongs.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnSongs.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnSongs.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSongs.Location = new System.Drawing.Point(0, 417);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(220, 60);
            this.btnSongs.TabIndex = 12;
            this.btnSongs.Text = "Music";
            this.btnSongs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSongs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSongs.UseVisualStyleBackColor = false;
            // 
            // labelYourMusic
            // 
            this.labelYourMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelYourMusic.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelYourMusic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(217)))));
            this.labelYourMusic.Location = new System.Drawing.Point(0, 367);
            this.labelYourMusic.Margin = new System.Windows.Forms.Padding(0);
            this.labelYourMusic.Name = "labelYourMusic";
            this.labelYourMusic.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelYourMusic.Size = new System.Drawing.Size(220, 50);
            this.labelYourMusic.TabIndex = 11;
            this.labelYourMusic.Text = "YOUR MUSIC";
            this.labelYourMusic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPlaylists
            // 
            this.btnPlaylists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnPlaylists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaylists.FlatAppearance.BorderSize = 0;
            this.btnPlaylists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlaylists.ForeColor = System.Drawing.Color.White;
            this.btnPlaylists.IconChar = FontAwesome.Sharp.IconChar.Outdent;
            this.btnPlaylists.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.btnPlaylists.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlaylists.Location = new System.Drawing.Point(0, 307);
            this.btnPlaylists.Name = "btnPlaylists";
            this.btnPlaylists.Size = new System.Drawing.Size(220, 60);
            this.btnPlaylists.TabIndex = 10;
            this.btnPlaylists.Text = "Playlists";
            this.btnPlaylists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlaylists.UseVisualStyleBackColor = false;
            // 
            // btnActivity
            // 
            this.btnActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnActivity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActivity.FlatAppearance.BorderSize = 0;
            this.btnActivity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnActivity.ForeColor = System.Drawing.Color.White;
            this.btnActivity.IconChar = FontAwesome.Sharp.IconChar.History;
            this.btnActivity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.btnActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActivity.Location = new System.Drawing.Point(0, 247);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(220, 60);
            this.btnActivity.TabIndex = 9;
            this.btnActivity.Text = "Activity";
            this.btnActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActivity.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnBrowse.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnBrowse.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.btnBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBrowse.Location = new System.Drawing.Point(0, 187);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(220, 60);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = false;
            // 
            // labelMain
            // 
            this.labelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMain.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(235)))), ((int)(((byte)(217)))));
            this.labelMain.Location = new System.Drawing.Point(0, 137);
            this.labelMain.Margin = new System.Windows.Forms.Padding(0);
            this.labelMain.Name = "labelMain";
            this.labelMain.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelMain.Size = new System.Drawing.Size(220, 50);
            this.labelMain.TabIndex = 7;
            this.labelMain.Text = "MAIN";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.panelSearchBar);
            this.panelLogo.Controls.Add(this.iconLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 137);
            this.panelLogo.TabIndex = 0;
            // 
            // panelSearchBar
            // 
            this.panelSearchBar.Controls.Add(this.iconButton1);
            this.panelSearchBar.Controls.Add(this.textBox1);
            this.panelSearchBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchBar.Location = new System.Drawing.Point(0, 69);
            this.panelSearchBar.Name = "panelSearchBar";
            this.panelSearchBar.Padding = new System.Windows.Forms.Padding(20, 18, 20, 23);
            this.panelSearchBar.Size = new System.Drawing.Size(220, 65);
            this.panelSearchBar.TabIndex = 1;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 18;
            this.iconButton1.Location = new System.Drawing.Point(162, 18);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(38, 24);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(20, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search...";
            this.textBox1.Size = new System.Drawing.Size(144, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // iconLogo
            // 
            this.iconLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconLogo.FlatAppearance.BorderSize = 0;
            this.iconLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iconLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.iconLogo.IconChar = FontAwesome.Sharp.IconChar.Dragon;
            this.iconLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.iconLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLogo.Location = new System.Drawing.Point(0, 0);
            this.iconLogo.Name = "iconLogo";
            this.iconLogo.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.iconLogo.Size = new System.Drawing.Size(220, 69);
            this.iconLogo.TabIndex = 0;
            this.iconLogo.Text = "DracoPlayer";
            this.iconLogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconLogo.UseVisualStyleBackColor = true;
            // 
            // panelMediaBottom
            // 
            this.panelMediaBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMediaBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.panelMediaBottom.Controls.Add(this.btnVolume);
            this.panelMediaBottom.Controls.Add(this.btnPrev);
            this.panelMediaBottom.Controls.Add(this.btnNext);
            this.panelMediaBottom.Controls.Add(this.btnPlay);
            this.panelMediaBottom.Controls.Add(this.label1);
            this.panelMediaBottom.Controls.Add(this.labelTitle);
            this.panelMediaBottom.Controls.Add(this.labelPlayerEnd);
            this.panelMediaBottom.Controls.Add(this.labelPlayerStart);
            this.panelMediaBottom.Controls.Add(this.metroTrackBar1);
            this.panelMediaBottom.Controls.Add(this.playerTrackBar);
            this.panelMediaBottom.Controls.Add(this.currentPlayPictureBox);
            this.panelMediaBottom.Location = new System.Drawing.Point(220, 585);
            this.panelMediaBottom.Name = "panelMediaBottom";
            this.panelMediaBottom.Size = new System.Drawing.Size(983, 142);
            this.panelMediaBottom.TabIndex = 4;
            // 
            // btnVolume
            // 
            this.btnVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolume.FlatAppearance.BorderSize = 0;
            this.btnVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolume.IconChar = FontAwesome.Sharp.IconChar.VolumeUp;
            this.btnVolume.IconColor = System.Drawing.Color.White;
            this.btnVolume.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVolume.IconSize = 24;
            this.btnVolume.Location = new System.Drawing.Point(834, 62);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(31, 34);
            this.btnVolume.TabIndex = 10;
            this.btnVolume.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnPrev.IconColor = System.Drawing.Color.White;
            this.btnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrev.Location = new System.Drawing.Point(461, 59);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(37, 58);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnNext.IconColor = System.Drawing.Color.White;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.Location = new System.Drawing.Point(558, 59);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 58);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPlay.IconColor = System.Drawing.Color.White;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.Location = new System.Drawing.Point(504, 65);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 46);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(148, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Iron Maiden";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.LightGray;
            this.labelTitle.Location = new System.Drawing.Point(148, 44);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(155, 25);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Fear of the Dark";
            // 
            // labelPlayerEnd
            // 
            this.labelPlayerEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPlayerEnd.AutoSize = true;
            this.labelPlayerEnd.CustomBackground = true;
            this.labelPlayerEnd.CustomForeColor = true;
            this.labelPlayerEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPlayerEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerEnd.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPlayerEnd.ForeColor = System.Drawing.Color.White;
            this.labelPlayerEnd.Location = new System.Drawing.Point(915, 17);
            this.labelPlayerEnd.Name = "labelPlayerEnd";
            this.labelPlayerEnd.Size = new System.Drawing.Size(44, 19);
            this.labelPlayerEnd.TabIndex = 4;
            this.labelPlayerEnd.Text = "21:37";
            // 
            // labelPlayerStart
            // 
            this.labelPlayerStart.AutoSize = true;
            this.labelPlayerStart.CustomBackground = true;
            this.labelPlayerStart.CustomForeColor = true;
            this.labelPlayerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPlayerStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayerStart.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPlayerStart.ForeColor = System.Drawing.Color.White;
            this.labelPlayerStart.Location = new System.Drawing.Point(148, 17);
            this.labelPlayerStart.Name = "labelPlayerStart";
            this.labelPlayerStart.Size = new System.Drawing.Size(36, 19);
            this.labelPlayerStart.TabIndex = 3;
            this.labelPlayerStart.Text = "0:00";
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTrackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.metroTrackBar1.CustomBackground = true;
            this.metroTrackBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.metroTrackBar1.Location = new System.Drawing.Point(871, 64);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(88, 27);
            this.metroTrackBar1.Style = MetroFramework.MetroColorStyle.White;
            this.metroTrackBar1.TabIndex = 2;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTrackBar1.Value = 20;
            // 
            // playerTrackBar
            // 
            this.playerTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.playerTrackBar.CustomBackground = true;
            this.playerTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.playerTrackBar.Location = new System.Drawing.Point(199, 17);
            this.playerTrackBar.Name = "playerTrackBar";
            this.playerTrackBar.Size = new System.Drawing.Size(699, 27);
            this.playerTrackBar.Style = MetroFramework.MetroColorStyle.White;
            this.playerTrackBar.TabIndex = 1;
            this.playerTrackBar.Text = "metroTrackBar1";
            this.playerTrackBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.playerTrackBar.Value = 10;
            // 
            // currentPlayPictureBox
            // 
            this.currentPlayPictureBox.BackgroundImage = global::MultimediaPlayer.Properties.Resources.zelaznaDziewica;
            this.currentPlayPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentPlayPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentPlayPictureBox.Location = new System.Drawing.Point(0, 0);
            this.currentPlayPictureBox.Name = "currentPlayPictureBox";
            this.currentPlayPictureBox.Size = new System.Drawing.Size(131, 142);
            this.currentPlayPictureBox.TabIndex = 0;
            this.currentPlayPictureBox.TabStop = false;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.panelMainMenu.Controls.Add(this.PanelElementList);
            this.panelMainMenu.Location = new System.Drawing.Point(220, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(980, 585);
            this.panelMainMenu.TabIndex = 1;
            // 
            // PanelElementList
            // 
            this.PanelElementList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
            this.PanelElementList.Controls.Add(this.metroLabel1);
            this.PanelElementList.Controls.Add(this.labelAuthor1);
            this.PanelElementList.Controls.Add(this.labelTitle1);
            this.PanelElementList.Controls.Add(this.btnPlaySong1);
            this.PanelElementList.Controls.Add(this.pictureBox1);
            this.PanelElementList.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelElementList.Location = new System.Drawing.Point(0, 0);
            this.PanelElementList.Name = "PanelElementList";
            this.PanelElementList.Padding = new System.Windows.Forms.Padding(10);
            this.PanelElementList.Size = new System.Drawing.Size(980, 69);
            this.PanelElementList.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.CustomBackground = true;
            this.metroLabel1.CustomForeColor = true;
            this.metroLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(582, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "7:18";
            // 
            // labelAuthor1
            // 
            this.labelAuthor1.AutoSize = true;
            this.labelAuthor1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAuthor1.ForeColor = System.Drawing.Color.LightGray;
            this.labelAuthor1.Location = new System.Drawing.Point(417, 28);
            this.labelAuthor1.Name = "labelAuthor1";
            this.labelAuthor1.Size = new System.Drawing.Size(90, 19);
            this.labelAuthor1.TabIndex = 11;
            this.labelAuthor1.Text = "Iron Maiden";
            // 
            // labelTitle1
            // 
            this.labelTitle1.AutoSize = true;
            this.labelTitle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle1.ForeColor = System.Drawing.Color.LightGray;
            this.labelTitle1.Location = new System.Drawing.Point(182, 28);
            this.labelTitle1.Name = "labelTitle1";
            this.labelTitle1.Size = new System.Drawing.Size(133, 19);
            this.labelTitle1.TabIndex = 11;
            this.labelTitle1.Text = "1. Fear of the Dark";
            // 
            // btnPlaySong1
            // 
            this.btnPlaySong1.FlatAppearance.BorderSize = 0;
            this.btnPlaySong1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaySong1.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlaySong1.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPlaySong1.IconColor = System.Drawing.Color.White;
            this.btnPlaySong1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlaySong1.IconSize = 24;
            this.btnPlaySong1.Location = new System.Drawing.Point(110, 14);
            this.btnPlaySong1.Name = "btnPlaySong1";
            this.btnPlaySong1.Size = new System.Drawing.Size(48, 50);
            this.btnPlaySong1.TabIndex = 11;
            this.btnPlaySong1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MultimediaPlayer.Properties.Resources.zelaznaDziewica;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mediaTimer
            // 
            this.mediaTimer.Interval = 1000;
            // 
            // MainFormComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1203, 727);
            this.Controls.Add(this.panelMediaBottom);
            this.Controls.Add(this.panelMainMenu);
            this.Controls.Add(this.panelMenu);
            this.Name = "MainFormComponent";
            this.Text = "MainFormComponent";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelSearchBar.ResumeLayout(false);
            this.panelSearchBar.PerformLayout();
            this.panelMediaBottom.ResumeLayout(false);
            this.panelMediaBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPlayPictureBox)).EndInit();
            this.panelMainMenu.ResumeLayout(false);
            this.PanelElementList.ResumeLayout(false);
            this.PanelElementList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelMainMenu;
        private FontAwesome.Sharp.IconButton btnSongs;
        private System.Windows.Forms.Label labelYourMusic;
        private FontAwesome.Sharp.IconButton btnPlaylists;
        private FontAwesome.Sharp.IconButton btnActivity;
        private FontAwesome.Sharp.IconButton btnBrowse;
        private System.Windows.Forms.Label labelMain;
        private FontAwesome.Sharp.IconButton btnArtists;
        private FontAwesome.Sharp.IconButton btnFilms;
        private System.Windows.Forms.Label labelVideos;
        private FontAwesome.Sharp.IconButton btnAlbums;
        private FontAwesome.Sharp.IconButton iconLogo;
        private System.Windows.Forms.Panel panelSearchBar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panelMediaBottom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;
        private MetroFramework.Controls.MetroLabel labelPlayerEnd;
        private MetroFramework.Controls.MetroLabel labelPlayerStart;
        private MetroFramework.Controls.MetroTrackBar metroTrackBar1;
        private MetroFramework.Controls.MetroTrackBar playerTrackBar;
        private System.Windows.Forms.PictureBox currentPlayPictureBox;
        private FontAwesome.Sharp.IconButton btnVolume;
        private FontAwesome.Sharp.IconButton btnPrev;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.Panel PanelElementList;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Label labelAuthor1;
        private System.Windows.Forms.Label labelTitle1;
        private FontAwesome.Sharp.IconButton btnPlaySong1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer mediaTimer;
    }
}