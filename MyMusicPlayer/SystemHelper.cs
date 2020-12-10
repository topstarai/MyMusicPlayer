using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    class SystemHelper
    {
        public static readonly string[] VideoExtensions = {".3g2",".3gp",".3gp2",".3gpp",".amv",".asf",".avi",".bik",".bin",".divx",".drc",".dv",".f4v",".flv",".gvi",".gxf",".iso",".m1v",".m2v",".m2t",".m2ts",".m4v",".mkv",".mov",".mp2",".mp4",".mp4v",".mpe",".mpeg",".mpeg1",".mpeg2",".mpeg4",".mpg",".mpv2",".mts",".mxf",".mxg",".nsv",".nuv",".ogg",".ogm",".ogv",".ps",".rec",".rm",".rmvb",".rpl",".thp",".tod",".ts",".tts",".txd",".vob",".vro",".webm",".wm",".wmv",".wtv",".xesc" };
        public static readonly string[] AudioExtensions = {".3ga",".669",".a52",".acc",".ac3",".adt",".adts",".aif",".aiff",".amr",".aob",".ape",".awb",".caf",".dts",".flac",".it",".kar",".m4a",".m4b",".m4p",".m5p",".mid",".mka",".mlp",".mod",".mpa",".mp1",".mp2",".mp3",".mpc",".mpga",".mus",".oga",".ogg",".oma",".opus",".qcp",".ra",".rmi",".s3m",".sid",".spx",".thd",".tta",".voc",".vqf",".w64",".wav",".wma",".wv",".xa",".xm" };
 
        public static Image GetBingImageBackground(string jsonUrl="https://cn.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1")
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string getString = client.DownloadString(jsonUrl);

            dynamic item = JsonConvert.DeserializeObject(getString);
            string url = $"https://cn.bing.com/{item["images"][0]["url"]}";
            var data = client.DownloadData(url);
            return  Image.FromStream(new MemoryStream(data));
        }

        public static Bitmap CloneCoveredBackground(Bitmap bitmap,int x, int y, int width, int height)
        {
            //绘制矩形，定义起始位置和宽高
            Rectangle r = new Rectangle(x, y, width, height);
            //按矩形尺寸和起始位置截取bm的一部分
            return bitmap.Clone(r, bitmap.PixelFormat);
        }

        public static void SetListViewBackground(ListView listView,Bitmap bitmap)
        {
            var bm = CloneCoveredBackground(bitmap,listView.Location.X, listView.Location.Y, listView.Width, listView.Height);
            //把截取到的图片设置为lv背景，达到与主窗体背景完美契合的效果
            listView.BeginUpdate();
            listView.BackgroundImage = (Image)bm;
            listView.EndUpdate();
        }

        private static double GetGrayLevel(Color color)
        {
            return (0.299 * color.R + 0.587 * color.G + 0.114 * color.B) / 255;
        }

        private static Color GetReverseForegroundColor(double grayLevel) => grayLevel > 0.5 ? Color.Black : Color.White;
        public static Color GetReverseForegroundColor(Color color)=>GetReverseForegroundColor(GetGrayLevel(color));

    }
}
