﻿using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MultimediaPlayer.Resources
{
    class NAudioComponent
    {
        public AudioFileReader AudioFile { get; set; }
        public WaveOutEvent OutputDevice { get; set; }
        public float CurrentVolume { get; set; }

        public AudioPlaylist playlist { get; set; }

        private string _filePath = "E:\\Muzyka";

        // Constructor
        public NAudioComponent()
        {
            CurrentVolume = 0.5f;
            playlist = new AudioPlaylist();
            playlist.InitPlaylist(_filePath);
            if (AudioFile == null)
            {
                AudioFile = new AudioFileReader(playlist.Songs[playlist.Index])
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
        public void Play()
        {
            if (OutputDevice.PlaybackState == PlaybackState.Paused || OutputDevice.PlaybackState == PlaybackState.Stopped)
            {
                OutputDevice.Play();
            }
            SetVolume(CurrentVolume);
            
        }
        public void NextSong()
        {
            OutputDevice = new WaveOutEvent();
            AudioFile = new AudioFileReader(playlist.Songs[playlist.Index]);
            OutputDevice.Init(AudioFile);
        }
        public void Stop()
        {
            if (OutputDevice != null)
            {
                OutputDevice.Stop();
            }
        }
        public void Pause()
        {
            if (OutputDevice != null)
            {
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
                    NextSong();
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

        public double GetEntityLengthInSeconds()
        {
            if (AudioFile != null)
                return AudioFile.TotalTime.TotalSeconds;
            else
                return 0;
        }

        public double GetPositionInSeconds()
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
    }
}
