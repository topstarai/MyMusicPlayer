using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    /// <summary>
    /// 本类型用来处理音乐歌词
    /// </summary>
    [Serializable]
    class MusicLrc
    {
        //存放歌词的内容字段
        private Dictionary<string, string> dicLrc;
        /// <summary>
        /// 获取歌词内容的属性
        /// </summary>
        public Dictionary<string, string> DicLrc => dicLrc;

        //当前音乐字段
        private Music music;

        //歌词的路径
        private string LrcPath => $@"{Setting.Instance.SourcePath}\{Music?.LrcName}";
        /// <summary>
        /// 用于获取和存放歌曲
        /// </summary>
        public Music Music {
            get { return music; } 
            set { 
                if (music != value)
                {
                    music = value;
                    dicLrc.Clear();
                } 
            } 
        }

        /// <summary>
        /// 歌词构造函数
        /// </summary>
        public MusicLrc()
        {
            dicLrc = new Dictionary<string, string>();
        }

        /// <summary>
        /// 从歌词文件读取歌词内容
        /// </summary>
        public Dictionary<string, string> ReadLrc()
        {
            if (File.Exists(LrcPath))
            {
                DicLrc.Clear();
                //歌词路径设置为同该歌曲同名的Lrc文件
                //按特定编码读取文件，Lrc不指定编码会出现乱码Encoding.GetEncoding("gb2312")
                StreamReader sr = new StreamReader(LrcPath, Encoding.UTF8);
                //如果文件不为空，循环读取添加到歌词哈希表
                while (sr != null)
                {
                    try//因为不确定读取行数，所以要捕获异常，读取完成后出错执行break
                    {
                        string str = sr.ReadLine();
                        if (str?.Length > 10)
                        {
                            //获取歌词中时间的部分
                            string dt = str.Substring(1, 5);
                            //获取歌词部分
                            string lrc = str.Substring(10);
                            DicLrc.Add(dt, lrc);
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        break;
                    }
                }
                sr.Close();
            }
 
            return DicLrc;
        }
        /// <summary>
        /// 用于通过文件选择对话框来打开歌词文件
        /// </summary>
        /// <returns>返回歌词内容</returns>
        public Dictionary<string, string> OpenLrc()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "歌词文件(*.lrc)|*.lrc";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File.Copy(ofd.FileName, LrcPath, true);
                ReadLrc();
            }
            return DicLrc;
        }

    }
}
