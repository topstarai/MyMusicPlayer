using System;

namespace MyMusicPlayer
{
    /// <summary>
    /// 播放状态
    /// </summary>
    [Serializable]
    public enum PlayState
    {
        //未播放
        Unplayed,
        //已播放
        Played,
        //切换
        Switch
    }
}
