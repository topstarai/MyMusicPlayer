using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    /// <summary>
    /// 该类型用于进行音乐播放的具体逻辑处理
    /// </summary>
    class MusicPlayer
    {
        private int id = 0;//当前播放的编号字段。
        //当前播放歌曲编号，非索引，id-1=索引
        private int Index => Id <= 0 ? 0 : Id - 1;
        //当前的播放曲目列表
        private Playlist _playlist;
        /// <summary>
        /// 获取或者设置当前播放歌曲的Id
        /// </summary>
        public int Id {
            get { return id; }
            private set{ 
                id = value;
                CurrentLrc.Music = Current;
            }
        }

        /// <summary>
        /// 获取存储播放列表
        /// </summary>
        public List<Music> PlaylistItems => _playlist.Items;

        /// <summary>
        /// 获取当前播放的歌曲信息
        /// </summary>
        public Music Current => PlaylistItems.Count>0? PlaylistItems[Index]:null;

        /// <summary>
        /// 获取当前播放的歌曲歌词
        /// </summary>
        public MusicLrc CurrentLrc { get; }

        /// <summary>
        /// 获取或设置当前播放的模式
        /// </summary>
        public PlayMode PlayMode { get; set; }

        public MusicPlayer(Playlist playlist)
        {
            CurrentLrc = new MusicLrc();
            this._playlist = playlist;
        }

        /// <summary>
        /// 播放歌曲
        /// </summary>
        /// <returns>返回当前歌曲对象</returns>
        protected Music OnPlay()
        {
            //如果播放集中存在对象
            if (PlaylistItems.Count > 0)
            {
                Current.State = PlayState.Played;
            }
            CurrentLrc.Music = Current;
            CurrentLrc.ReadLrc();
            return Current;
        }

        /// <summary>
        /// 播放歌曲
        /// </summary>
        /// <returns>返回当前歌曲对象</returns>
        public Music Play(Music music=null)
        {
            if (music!=null)
            {
                Id = music.Id;
                return OnPlay();
            }
            else
            {
                switch (PlayMode)
                {
                    case PlayMode.Order:
                        Switch(false);
                        break;
                    case PlayMode.Loop:
                        Repeat();
                        break;
                    case PlayMode.Shuffle:
                        Shuffle();
                        break;
                    default:
                        break;
                }
            }

            return Current;
        }

        /// <summary>
        /// 切歌，ture上一首，false下一首
        /// </summary>
        public void Switch(bool temp)
        {
            if (PlaylistItems?.Count>0)
            {
                //修改状态为cut，使主窗体song对象清空
                PlaylistItems[Index].State = PlayState.Switch;
                //上一首，如果已经是第一首就切换最后一首
                if (temp)
                {
                    PlayPrevious();
                }
                //下一首，如果已经是最后一首就切换第一首
                else
                {
                    PlayNext();
                }
            }
        }

        /// <summary>
        /// 播放上一首
        /// </summary>
        public void PlayPrevious()
        {
            if (Id == 1)
                Id = PlaylistItems.Count;
            else
                Id--;

            OnPlay();
        }
        /// <summary>
        /// 播放下一首
        /// </summary>
        public void PlayNext()
        {
            //如果当前播放为最后一首，编号重置为1
            if (Id == PlaylistItems.Count)
                Id = 1;
            else
                Id++;

            OnPlay();
        }
        /// <summary>
        /// 单曲循环
        /// </summary>
        public void Repeat() => OnPlay();

        /// <summary>
        /// 随机
        /// </summary>
        public void Shuffle()
        {
            Random r = new Random();
            int id = 1;
            do
            {
                id = r.Next(1, PlaylistItems.Count + 1);
            } while (id == Id && PlaylistItems.Count > 0);
            Id = id;
            OnPlay();
        }
    }
}
