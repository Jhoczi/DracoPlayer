using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MultimediaPlayer.Resources
{
    class NAudioComponent
    {
        public AudioFileReader AudioFile { get; private set; }
        public WaveOutEvent OutputDevice { get; private set; }
        public AudioPlaylist Playlist { get; private set; }
        public float CurrentVolume { get; set; }
        public bool IsRunning { get;private set; } = false;

        private string _filePath = "E:\\Muzyka";

        // Constructor
        public NAudioComponent()
        {
            CurrentVolume = 0.5f;
            Playlist = new AudioPlaylist();
            Playlist.InitPlaylist(_filePath);
            if (AudioFile == null)
            {
                AudioFile = new AudioFileReader(Playlist.Songs[Playlist.Index])
                {
                    Volume = CurrentVolume
                };
            }
            if (OutputDevice == null)
            {
                OutputDevice = new WaveOutEvent();
                OutputDevice.PlaybackStopped += OnPlaybackStopped;
                OutputDevice.Init(AudioFile);
            }
        }

        // Methods
        private void InitPlayer()
        {
            OutputDevice = new WaveOutEvent();
            AudioFile = new AudioFileReader(Playlist.Songs[Playlist.IndexList[Playlist.Index]]);
            OutputDevice.Init(AudioFile);
        }
        private void Play()
        {
            InitPlayer();
            if (OutputDevice.PlaybackState == PlaybackState.Paused || OutputDevice.PlaybackState == PlaybackState.Stopped)
            {
                IsRunning = true;
                OutputDevice.Play();
            }
            SetVolume(CurrentVolume);
            
        }
        public void NextSong()
        {
            Playlist.Next();
            InitPlayer();
        }
        public void PrevSong()
        {
            Playlist.Prev();
            InitPlayer();
        }
        
        private void Stop()
        {
            if (OutputDevice != null)
            {
                IsRunning = false;
                OutputDevice.Stop();
            }
        }
        private void Pause()
        {
            if (OutputDevice != null)
            {
                IsRunning = false;
                OutputDevice.Pause();
            }
        }
        public void TogglePlayPause()
        {
            if (OutputDevice != null)
            {
                if (OutputDevice.PlaybackState == PlaybackState.Playing)
                    Pause();
                else if (OutputDevice.PlaybackState == PlaybackState.Paused)
                    Play();
                else if (OutputDevice.PlaybackState == PlaybackState.Stopped)
                {
                    Playlist.IndexListHistory.Add(Playlist.Index);
                    Play();
                }
            }
            else
            {
                Play();
            }
        }

        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            if (OutputDevice != null)
            {
                OutputDevice.Dispose();
                OutputDevice = null;
            }
            if (AudioFile != null)
            {
                AudioFile.Dispose();
                AudioFile = null;
            }
        }

        public int GetEntityLengthInSeconds()
        {
            if (AudioFile != null)
                return (int)AudioFile.TotalTime.TotalSeconds;
            else
                return 0;
        }

        public int GetPositionInSeconds()
        {
            if (AudioFile != null)
                return (int)AudioFile.CurrentTime.TotalSeconds;
            else
                return 0;
        }
        public float GetVolume()
        {
            if (AudioFile != null)
            {
                return AudioFile.Volume;
            }
            return 1;
        }

        public void SetPosition(double value)
        {
            if (AudioFile != null)
            {
                AudioFile.CurrentTime = TimeSpan.FromSeconds(value);
            }
        }
        public void SetVolume(float value)
        {
            if (OutputDevice != null)
            {
                AudioFile.Volume = value;
            }
        }

        public int GetCurrentIndex()
        {
            return Playlist.Index;
        }

        public int GetElementOfIndexList(int position)
        {
            if (Playlist == null)
                throw new Exception("[ERROR]: Could not find playlist");
            return Playlist.IndexList[position];

        }

        public void CreateNewPlaylist()
        {
            Playlist.NewPlaylist();
        }

        public void SetCurrentSong(object sender)
        {
            Playlist.SetSong(sender);
            InitPlayer();
        }
    }
}
