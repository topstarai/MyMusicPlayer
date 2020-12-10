using System;

namespace MyMusicPlayer
{
    class MusicEventArgs:EventArgs
    {
        public Music CurrentMusic { get; }
        public MusicEventArgs(Music music)
        {
            CurrentMusic = music;
        }
    }
}