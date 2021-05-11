using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultimediaPlayer
{
    class AudioComponent
    {
        private WaveOutEvent _outputDevice;
        private AudioFileReader _audioFile;

        public AudioComponent()
        {
            Init();
        }
        private void Init()
        {
            if (_outputDevice == null)
            {
                _outputDevice = new WaveOutEvent();
                _outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (_audioFile == null)
            {
                _audioFile = new AudioFileReader(@"E:\test.mp3");
                _outputDevice.Init(_audioFile);
            }
        }

        public void Play()
        {
            if (_outputDevice == null)
            {
                Init();
            }
            _outputDevice.Play();
        }
        public void Stop()
        {
            if (_outputDevice != null)
            {
                if (_outputDevice.PlaybackState == PlaybackState.Playing)
                    _outputDevice.Pause();
                else if (_outputDevice.PlaybackState == PlaybackState.Paused)
                    _outputDevice.Play();
            }
        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            _outputDevice.Dispose();
            //_outputDevice = null;
            _audioFile.Dispose();
            //_audioFile = null;
        }
        public TimeSpan GetMediaLength()
        {
            return _audioFile.TotalTime;
        }
    }
}
