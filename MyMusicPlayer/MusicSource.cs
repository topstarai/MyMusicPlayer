using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TagLib;
using TabligFile = TagLib.File;

namespace MyMusicPlayer
{
    class MusicSource
    {
        Setting _setting;

        /// <summary>
        /// 获取所有音乐列表
        /// </summary>
        public List<Music> Items { get; }

        public MusicSource(Setting setting)
        {
            Items = new List<Music>();
            _setting = setting;
        }

        public void Load()
        {
            //创建一个对象，可以枚举该路径下的所有文件，形成筛选
            if (Directory.Exists(_setting.SourcePath))
            {
                Items.Clear();//情况原有所有音乐列表

                DirectoryInfo dir = new DirectoryInfo(_setting.SourcePath);

                //设置筛选条件，获取所有音乐文件
                FileInfo[] files = dir.GetFiles("*.mp3")
                    .Concat(dir.GetFiles("*.mp4"))
                    .Concat(dir.GetFiles("*.wmv"))
                    .Concat(dir.GetFiles("*.wma"))
                    .Concat(dir.GetFiles("*.mkv"))
                    .Concat(dir.GetFiles("*.rmvb"))
                    .Concat(dir.GetFiles("*.avi"))
                    .ToArray();

                //遍历所有文件把筛选到的加入所有歌曲集合
                for (int i = 0; i < files.Length; i++)
                {
                    Music music = new Music();
                    music.FileName = files[i].FullName;
                    using var tfile = TabligFile.Create(music.FileName);
                    string title = tfile.Tag.Title;
                    music.Name = tfile.Tag.Title;
                    music.Singer = tfile.Tag.FirstPerformer;
                    int length = files[i].Name.IndexOf('.');
                    music.Name ??= files[i].Name.Substring(0, length);

                    music.Id = i + 1;

                    Items.Add(music);
                }
            }
        }
    }
}
