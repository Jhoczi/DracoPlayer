using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MultimediaPlayer
{
    class MainViewModel : INotifyPropertyChanged
    {
        private double _currentTrackLength;
        private double _currentTrackPosition;
        private double _currentVolume;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
