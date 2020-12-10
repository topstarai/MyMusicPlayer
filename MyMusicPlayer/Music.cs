using System;

namespace MyMusicPlayer
{
    /// <summary>
    /// 歌曲类
    /// </summary>
    [Serializable]
    class Music
    {
        public string FileName { get; set; }

        public string Name { get; set; }

        public string Singer { get; set; }

        public int Id { get; set; }

        public PlayState State { get; set; }

        public string LrcName => $"{Name}.lrc";
    }

}
