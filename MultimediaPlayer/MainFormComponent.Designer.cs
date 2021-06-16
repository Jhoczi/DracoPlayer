
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
            this.btnArtists = new FontAwesome.Sharp.IconButton();
            this.btnActivity = new FontAwesome.Sharp.IconButton();
            this.btnBrowse = new FontAwesome.Sharp.IconButton();
            this.labelMain = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelSearchBar = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.iconLogo = new FontAwesome.Sharp.IconButton();
            this.panelMediaBottom = new System.Windows.Forms.Panel();
            this.btnVolume = new FontAwesome.Sharp.IconButton();
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelPlayerEnd = new MetroFramework.Controls.MetroLabel();
            this.labelPlayerStart = new MetroFramework.Controls.MetroLabel();
            this.metroVolumeTrackbar = new MetroFramework.Controls.MetroTrackBar();
            this.playerTrackBar = new MetroFramework.Controls.MetroTrackBar();
            this.currentPlayPictureBox = new System.Windows.Forms.PictureBox();
            this.mediaTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelSearchBar.SuspendLayout();
            this.panelMediaBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPlayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.panelMenu.Controls.Add(this.btnArtists);
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
            // btnArtists
            // 
            this.btnArtists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnArtists.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnArtists.FlatAppearance.BorderSize = 0;
            this.btnArtists.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArtists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnArtists.ForeColor = System.Drawing.Color.White;
            this.btnArtists.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnArtists.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnArtists.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnArtists.Location = new System.Drawing.Point(0, 307);
            this.btnArtists.Name = "btnArtists";
            this.btnArtists.Size = new System.Drawing.Size(220, 60);
            this.btnArtists.TabIndex = 10;
            this.btnArtists.Text = "Artists";
            this.btnArtists.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnArtists.UseVisualStyleBackColor = false;
            this.btnArtists.Click += new System.EventHandler(this.btnArtists_Click);
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
            this.btnActivity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnActivity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActivity.Location = new System.Drawing.Point(0, 247);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(220, 60);
            this.btnActivity.TabIndex = 9;
            this.btnActivity.Text = "Activity";
            this.btnActivity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnActivity.UseVisualStyleBackColor = false;
            this.btnActivity.Click += new System.EventHandler(this.btnActivity_Click);
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
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
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
            this.panelSearchBar.Controls.Add(this.textSearch);
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
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textSearch.ForeColor = System.Drawing.Color.White;
            this.textSearch.Location = new System.Drawing.Point(20, 18);
            this.textSearch.Name = "textSearch";
            this.textSearch.PlaceholderText = "Search...";
            this.textSearch.Size = new System.Drawing.Size(144, 24);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panelMediaBottom.Controls.Add(this.labelAuthor);
            this.panelMediaBottom.Controls.Add(this.labelTitle);
            this.panelMediaBottom.Controls.Add(this.labelPlayerEnd);
            this.panelMediaBottom.Controls.Add(this.labelPlayerStart);
            this.panelMediaBottom.Controls.Add(this.metroVolumeTrackbar);
            this.panelMediaBottom.Controls.Add(this.playerTrackBar);
            this.panelMediaBottom.Controls.Add(this.currentPlayPictureBox);
            this.panelMediaBottom.Location = new System.Drawing.Point(220, 585);
            this.panelMediaBottom.Name = "panelMediaBottom";
            this.panelMediaBottom.Size = new System.Drawing.Size(980, 142);
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
            this.btnVolume.Location = new System.Drawing.Point(831, 62);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(31, 34);
            this.btnVolume.TabIndex = 10;
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            this.btnPrev.IconColor = System.Drawing.Color.White;
            this.btnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrev.Location = new System.Drawing.Point(461, 72);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(37, 58);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnNext.IconColor = System.Drawing.Color.White;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.Location = new System.Drawing.Point(558, 72);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(37, 58);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.PlayCircle;
            this.btnPlay.IconColor = System.Drawing.Color.White;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.Location = new System.Drawing.Point(504, 78);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(48, 46);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.Tag = "playS";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAuthor.ForeColor = System.Drawing.Color.Silver;
            this.labelAuthor.Location = new System.Drawing.Point(148, 79);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(90, 19);
            this.labelAuthor.TabIndex = 6;
            this.labelAuthor.Text = "Iron Maiden";
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
            this.labelPlayerEnd.Location = new System.Drawing.Point(912, 17);
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
            this.labelPlayerStart.Size = new System.Drawing.Size(44, 19);
            this.labelPlayerStart.TabIndex = 3;
            this.labelPlayerStart.Text = "00:00";
            // 
            // metroVolumeTrackbar
            // 
            this.metroVolumeTrackbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroVolumeTrackbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.metroVolumeTrackbar.CustomBackground = true;
            this.metroVolumeTrackbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(5)))), ((int)(((byte)(78)))));
            this.metroVolumeTrackbar.Location = new System.Drawing.Point(868, 64);
            this.metroVolumeTrackbar.Name = "metroVolumeTrackbar";
            this.metroVolumeTrackbar.Size = new System.Drawing.Size(88, 27);
            this.metroVolumeTrackbar.Style = MetroFramework.MetroColorStyle.White;
            this.metroVolumeTrackbar.TabIndex = 2;
            this.metroVolumeTrackbar.Text = "metroTrackBar1";
            this.metroVolumeTrackbar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroVolumeTrackbar.Value = 20;
            this.metroVolumeTrackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroVolumeTrackbar_Scroll);
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
            this.playerTrackBar.Size = new System.Drawing.Size(696, 27);
            this.playerTrackBar.Style = MetroFramework.MetroColorStyle.White;
            this.playerTrackBar.TabIndex = 1;
            this.playerTrackBar.Text = "metroTrackBar1";
            this.playerTrackBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.playerTrackBar.Value = 10;
            this.playerTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.playerTrackBar_Scroll);
            // 
            // currentPlayPictureBox
            // 
            this.currentPlayPictureBox.BackgroundImage = global::MultimediaPlayer.Properties.Resources.zelaznaDziewica;
            this.currentPlayPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.currentPlayPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentPlayPictureBox.Location = new System.Drawing.Point(0, 0);
            this.currentPlayPictureBox.Name = "currentPlayPictureBox";
            this.currentPlayPictureBox.Size = new System.Drawing.Size(131, 142);
            this.currentPlayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.currentPlayPictureBox.TabIndex = 0;
            this.currentPlayPictureBox.TabStop = false;
            // 
            // mediaTimer
            // 
            this.mediaTimer.Interval = 250;
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainMenu.AutoScroll = true;
            this.panelMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(23)))), ((int)(((byte)(27)))));
            this.panelMainMenu.Location = new System.Drawing.Point(220, 0);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(980, 585);
            this.panelMainMenu.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnArtists;
        private FontAwesome.Sharp.IconButton btnActivity;
        private FontAwesome.Sharp.IconButton btnBrowse;
        private System.Windows.Forms.Label labelMain;
        private FontAwesome.Sharp.IconButton iconLogo;
        private System.Windows.Forms.Panel panelSearchBar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Panel panelMediaBottom;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private MetroFramework.Controls.MetroLabel labelPlayerEnd;
        private MetroFramework.Controls.MetroLabel labelPlayerStart;
        private MetroFramework.Controls.MetroTrackBar metroVolumeTrackbar;
        private MetroFramework.Controls.MetroTrackBar playerTrackBar;
        private System.Windows.Forms.PictureBox currentPlayPictureBox;
        private FontAwesome.Sharp.IconButton btnVolume;
        private FontAwesome.Sharp.IconButton btnPrev;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.Timer mediaTimer;
        private System.Windows.Forms.Panel panelMainMenu;
    }
}