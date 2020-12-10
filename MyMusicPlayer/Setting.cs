using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MyMusicPlayer
{
    [Serializable]
    public class Setting
    {
        const string ConfigPath = @"Config\appconfig.xml";
        private Setting(){}

        /// <summary>
        /// 返回单个实例
        /// </summary>
        public static Setting Instance 
        { 
            get 
            {
                return SettingCreator.Instance;
            }
        }

        //避免多线程出错
        class SettingCreator
        {
            internal static readonly Setting Instance = new Setting();
            static SettingCreator()
            {
                Instance.Load();
            }
        }

        public void Load2()
        {
            if (System.IO.File.Exists(ConfigPath))
            {
                XmlDocument document = new XmlDocument();
                document.Load(ConfigPath);
                XmlNode parent = document.DocumentElement;
                SourcePath = parent["SourcePath"].InnerText;
                Background = parent["Background"].InnerText;
                AutoPlay = Convert.ToBoolean(parent["AutoPlay"].InnerText);
                SavePlaylist = Convert.ToBoolean(parent["SavePlaylist"].InnerText);
                Minimized = Convert.ToBoolean(parent["Minimized"].InnerText);
                Exited = Convert.ToBoolean(parent["Exited"].InnerText);                
            }
        }

        public void Load()
        {
            if (System.IO.File.Exists(ConfigPath))
            {
                using (FileStream stream = new FileStream(ConfigPath, FileMode.Open))
                {
                    XmlSerializer xmlserilize = new XmlSerializer(typeof(Setting));
                    var setting = (Setting)xmlserilize.Deserialize(stream);

                    this.AutoPlay = setting.AutoPlay;
                    this.Background = setting.Background;
                    this.Exited = setting.Exited;
                    this.Minimized = setting.Minimized;
                    this.SavePlaylist = setting.SavePlaylist;
                    this.SourcePath = setting.SourcePath;

                    stream.Close();
                }
            }
        }

        /// <summary>
        /// 重置路径
        /// </summary>
        public void Save2()
        {
            // 添加XML文件声明
            var dec = new XDeclaration("1.0", "utf-8", "yes");
            
            //创建XML元素
            var xele = new XElement("config",
                new XElement("SourcePath", SourcePath),
                new XElement("Background", Background),
                new XElement("AutoPlay", AutoPlay),
                new XElement("SavePlaylist", SavePlaylist),
                new XElement("Minimized", Minimized),
                new XElement("Exited", Exited)
                );

            XDocument document = new XDocument(dec,xele);//创建XML文档对象
            
            //检查文件夹是否存在
            var pathDir = Path.GetDirectoryName(ConfigPath);
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }
            //保存配置文件
            document.Save(ConfigPath);
        }

        /// <summary>
        /// 重置路径
        /// </summary>
        public void Save()
        {
            //检查文件夹是否存在
            var pathDir = Path.GetDirectoryName(ConfigPath);
            if (!Directory.Exists(pathDir))
            {
                Directory.CreateDirectory(pathDir);
            }

            using (FileStream stream = new FileStream(ConfigPath, FileMode.Create))
            {
                XmlSerializer xmlserilize = new XmlSerializer(typeof(Setting));
                xmlserilize.Serialize(stream, this);
                stream.Close();
            }
        }

        ////歌曲目录路径
        public string SourcePath { get; set; } = string.Empty;

        //皮肤路径
        public string Background { get; set; }

        //自动播放
        public bool AutoPlay { get; set; } = false;

        //是否保存播放列表
        public bool SavePlaylist { get; set; } = true;

        //最小化到托盘
        public bool Minimized { get; set; } = true;

        //退出
        public bool Exited { get; set; } = false;
    }
}
