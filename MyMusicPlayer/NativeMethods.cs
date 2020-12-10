using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MyMusicPlayer
{
    class NativeMethods
    {
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        #region  获取播放文件的所有信息
        /// <summary>
        /// 获取播放文件的单个信息
        /// </summary>
        /// <param strF1="string">文件路径</param>
        /// <param iIndex="int">信息索引号</param>
        public static string GetFileInfo(string strF1, int iIndex)
        {
            string s = "";
            //应用Scripting,在“添加引用”对话框中选中"COM"选项卡，然后选中Microsoft Scripting Runtime，单击“确定”按钮
            //Scripting.FileSystemObject fso = new Scripting.FileSystemObject();
            //Scripting.File fl;
            //string pth = "";
            //string flname = "";

            ////应用Shell32,在“添加引用”对话框中选中"COM"选项卡，然后选中Microsoft Shell Controls And Automation，单击“确定”按钮
            //Shell32.Shell shl = new Shell32.Shell();
            //Shell32.Folder shfd;

            //fl = fso.GetFile(strF1);
            //pth = fl.ParentFolder.Path;
            //flname = fl.Name;

            //shfd = shl.NameSpace(pth);

            //if (shfd.GetDetailsOf(0, iIndex) != "" || shfd.GetDetailsOf(shfd.Items().Item(flname), iIndex) != "")
            //    if (shfd.GetDetailsOf(shfd.Items().Item(flname), iIndex) != "")
            //        s = shfd.GetDetailsOf(shfd.Items().Item(flname), iIndex);
            //    else
            //        s = "";
            return s;
        }
        #endregion

    }
}
