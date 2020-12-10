using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace MyMusicPlayer
{
    /// <summary>
    /// 读取路径配置文件
    /// </summary>
    [Serializable]
    sealed class MusicManager
    {
        public readonly static MusicManager Instance = new MusicManager(Setting.Instance);
        public event EventHandler<MusicEventArgs> Playing;
        private Playlist Playlist { get;}
        public List<Music> Source => musicSource.Items;
        public List<Music> PlaylistItems => Playlist.Items;
        public Music Current => Player.Current;
        public MusicLrc CurrentLrc => Player.CurrentLrc;
        private MusicSource musicSource;
        private MusicPlayer Player { get; }
        private Setting _setting;
        private MusicManager(Setting setting)
        {
            musicSource = new MusicSource(setting);
            _setting = setting;
            Playlist = new Playlist();
            Player = new MusicPlayer(Playlist);
        }

        void RaisePlayingEvent()
        {
            // Raise the event in a thread-safe manner using the ?. operator.
            Playing?.Invoke(this, new MusicEventArgs(Current));
        }

        /// <summary>
        /// 播放音乐，并返回当前播放的歌曲信息
        /// </summary>
        /// <returns>返回当前播放的歌曲信息</returns>
        public Music Play()
        {
            var current = Player.Play();
            RaisePlayingEvent();
            return current;
        }

        /// <summary>
        /// 播放指定音乐
        /// </summary>
        /// <param name="music"></param>
        public void Play(Music music)
        {
            Player.Play(music);
        }

        /// <summary>
        /// 播放后一首
        /// </summary>
        public void Next()
        {
            Player.PlayNext();
            RaisePlayingEvent();
        }

        /// <summary>
        /// 播放前一首
        /// </summary>
        public void Previous()
        {
            Player.PlayPrevious();
            RaisePlayingEvent();
        }

        /// <summary>
        /// 重置
        /// </summary>
        public void Reset()
        {
            Playlist.Clear();
        }

        /// <summary>
        /// 设置播放模式
        /// </summary>
        /// <param name="mode"></param>
        public void SetPlayMode(PlayMode mode)
        {
            Player.PlayMode = mode;
        }

        /// <summary>
        /// 将指定的音乐列表放到播放列表里面
        /// </summary>
        /// <param name="musics">指定的播放列表</param>
        public void PutIntoPlaylist(List<Music> musics)
        {
            foreach (var item in musics)
            {
                foreach (Music s in Playlist.Items)
                {
                    if (s.Name == item.Name)
                    {
                        Playlist.Items.Remove(s);
                        break;
                    }
                }
                Playlist.Items.Add(item);
            }
        }

        /// <summary>
        /// 移除指定的歌曲
        /// </summary>
        /// <param name="music">指定的歌曲</param>
        public void RemoveSourceItem(Music music)
        {
            Source.Remove(music);
        }

        /// <summary>
        /// 移除指定的播放列表
        /// </summary>
        /// <param name="music">指定的歌曲</param>
        public void RemovePlaylistItem(Music music)
        {
            Playlist.Remove(music);
        }

        /// <summary>
        /// 清空播放列表
        /// </summary>
        public void ClearPlaylist()
        {
            Playlist.Clear();
        }

        /// <summary>
        /// 保存相关内容
        /// </summary>
        public void Save()
        {
            if (_setting.SavePlaylist)
                this.SavePlaylist();
        }

        /// <summary>
        /// 删除指定的音乐文件
        /// </summary>
        /// <param name="music">指定的音乐文件</param>
        public void Delete(Music music)
        {
            string path = music.FileName;
            File.Delete(path);
        }

        /// <summary>
        /// 加载所有音乐和播放列表
        /// </summary>
        public void LoadMusics()
        {
            this.LoadMusicSource();
            this.LoadPlaylist();
        }

        /// <summary>
        /// 加载播放列表
        /// </summary>
        public void LoadPlaylist()
        {
            if (File.Exists(Playlist.FilePath))
            {
                Playlist.Load();
            }
        }

        /// <summary>
        /// 加载所有音乐
        /// </summary>
        public void LoadMusicSource()
        {
            if (Directory.Exists(_setting.SourcePath))
            {
                musicSource.Load();
            }
        }

        /// <summary>
        /// 保存播放列表
        /// </summary>
        public void SavePlaylist()
        {
            Playlist.Save();
        }

        /// <summary>
        /// 更新路径
        /// </summary>
        public void Update()
        {
            foreach (Music s in Playlist.Items)
            {
                foreach (Music s1 in Source)
                {
                    if (s.Name == s1.Name)
                    {
                        s.FileName = s1.FileName;
                    }
                }
            }
        }
    }
}
