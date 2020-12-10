using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
            try
            {
                // 设置应用程序处理异常方式：ThreadException处理
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常
                Application.ThreadException += (sender, e) => ShowErrorMessages(e.Exception, e.ToString());
                //处理非UI线程异常
                AppDomain.CurrentDomain.UnhandledException += (sender, e) => ShowErrorMessages(e.ExceptionObject as Exception, e.ToString());


            }
            catch (Exception ex)
            {
                ShowErrorMessages(ex, string.Empty);
            }
        }

        private static void ShowErrorMessages(Exception ex, string backErrorMsg)
        {
            string str = GetExceptionMsg(ex, backErrorMsg);
            MessageBox.Show(str, "系统错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// 生成自定义异常消息
        /// </summary>
        /// <param name="ex">异常对象</param>
        /// <param name="backStr">备用异常消息：当ex为null时有效</param>
        /// <returns>异常字符串文本</returns>
        static string GetExceptionMsg(Exception ex, string backStr)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("系统出现错误，具体错误信息如下所示：");
            if (ex != null)
            {
                sb.AppendLine("【异常类型】：" + ex.GetType().Name);
                sb.AppendLine("【异常信息】：" + ex.Message);
            }
            else
            {
                sb.AppendLine("【未处理异常】：" + backStr);
            }
            return sb.ToString();
        }
    }
}
