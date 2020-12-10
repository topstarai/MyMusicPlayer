using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    /// <summary>
    /// 歌曲播放列表
    /// </summary>
    [Serializable]
    class Playlist
    {
        public const string FilePath = @"Config\PlayList.bin";

        public List<Music> Items { get;  }//存储播放列表

        public Playlist()
        {
            Items = new List<Music>();
        }

        /// <summary>
        /// 保存播放列表
        /// </summary>
        public void Save()
        {
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, Items);
                fs.Close();
            }
        }

        /// <summary>
        /// 加载播放列表
        /// </summary>
        public void Load()
        {
            if (File.Exists(FilePath))
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(FilePath, FileMode.Open);
                    BinaryFormatter bf = new BinaryFormatter();
                    var musicList = bf.Deserialize(fs) as List<Music>;
                    Items.AddRange(musicList);
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    fs?.Close();
                }
            }
        }

        public void Clear()
        {
            this.Items.Clear();
        }

        public void Remove(Music music)
        {
            Items.Remove(music);
        }
    }
}
