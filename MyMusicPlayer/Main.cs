using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    public partial class Main : Form
    {
        private const string MaximizedIcon = "\xE923";
        private const string NormalIcon = "\xE922";
        private const string PauseIcon = "\xE103";
        private const string PlayIcon = "\xE102";
        public Main()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm setting = new SettingForm();
            setting.Owner = this;
            setting.ShowDialog();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            NativeMethods.ReleaseCapture();
            NativeMethods.SendMessage(this.Handle, 
                NativeMethods.WM_SYSCOMMAND, 
                NativeMethods.SC_MOVE + NativeMethods.HTCAPTION, 
                0);//*********************调用移动无窗体控件函数  

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Text = MaximizedIcon;
                //RenderListViews();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.Text = NormalIcon;
                //RenderListViews();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //设置最大化尺寸
            var width = Screen.PrimaryScreen.WorkingArea.Width;
            var height = Screen.PrimaryScreen.WorkingArea.Height;
            this.MaximumSize = new Size(width, height);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            //this.MyNotifyIcon.Visible = true;
            //this.Hide();
        }

        private void MyNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowMainForm();
        }

        private void ShowMainForm()
        {
            this.Show();
            this.MyNotifyIcon.Visible = false;
        }

        private void btnSource_Click(object sender, EventArgs e)
        {

        }
    }
}
