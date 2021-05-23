using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultimediaPlayer
{
    class AudioComponent
    {
/*        private WaveOutEvent _outputDevice;
        private AudioFileReader _audioFile;*/
        public WaveOutEvent OutputDevice { get; set; }
        public AudioFileReader AudioFile { get; set; }
        public bool IsRunning { get; set; }
        public float CurrentVolume { get; set; }
        public AudioComponent()
        {
            Init();
        }
        private void Init()
        {
            if (OutputDevice == null)
            {
                OutputDevice = new WaveOutEvent();
                OutputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (AudioFile == null)
            {
                AudioFile = new AudioFileReader(@"E:\Muzyka\test.mp3");
                OutputDevice.Init(AudioFile);
            }
            CurrentVolume = 0.5f;
            ChangeVolume();
        }

        public void Play()
        {
            if (OutputDevice.PlaybackState == PlaybackState.Playing)
                OutputDevice.Stop();
            IsRunning = true;
            OutputDevice.Play();
        }
        public void Stop()
        {
            IsRunning = false;
            if (OutputDevice != null)
            {
                if (OutputDevice.PlaybackState == PlaybackState.Playing)
                    OutputDevice.Pause();
                else if (OutputDevice.PlaybackState == PlaybackState.Paused)
                    OutputDevice.Play();
            }
            
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            OutputDevice.Dispose();
            OutputDevice = null;
            AudioFile.Dispose();
            AudioFile = null;
        }
        public TimeSpan GetMediaLength()
        {
            return AudioFile.TotalTime;
        }
        public int GetCurrentTime()
        {
            return (int)AudioFile.CurrentTime.TotalSeconds;
        }
        public void ChangeVolume()
        {
            AudioFile.Volume = CurrentVolume;
        }

    }
}
