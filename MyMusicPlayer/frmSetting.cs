using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    public partial class frmSetting : Form
    {
        IRefresh _refresh;
        public frmSetting()
        {
            InitializeComponent();
        }
        public frmSetting(IRefresh refresh):this()
        {
            _refresh = refresh;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            this.gpAbout.Visible = true;
            this.gpSkinPath.Visible = false;
            this.gpCommon.Visible = false;
        }

        private void tsmiSkin_Click(object sender, EventArgs e)
        {
            this.gpSkinPath.Visible = true;
            this.gpCommon.Visible = false;
            this.gpAbout.Visible = false;
        }

        private void tsmiCommon_Click(object sender, EventArgs e)
        {
            this.gpCommon.Visible = true;
            this.gpAbout.Visible = false;
            this.gpSkinPath.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //将界面设置值保存到setting对象，并保存到本地磁盘
            Setting.Instance.AutoPlay = chbAutoPlay.Checked;
            Setting.Instance.Background = txtBackground.Text;
            Setting.Instance.Exited = rbExit.Checked;
            Setting.Instance.Minimized = rbMin.Checked;
            Setting.Instance.SavePlaylist = chbSavePlaylist.Checked;
            Setting.Instance.SourcePath = txtMusicPath.Text;
            
            Setting.Instance.Save();

            //加载背景图
            if (!string.IsNullOrEmpty(txtBackground.Text))
            {
                try
                {
                    this.Owner.BackgroundImage = Image.FromFile(txtBackground.Text);
                    this.BackgroundImage = SystemHelper.CloneCoveredBackground(
                        this.Owner.BackgroundImage as Bitmap,
                        this.Location.X,
                        this.Location.Y,
                        this.Width,
                        this.Height);
                }
                catch (Exception)
                {
                    this.Owner.BackgroundImage = SystemHelper.GetBingImageBackground(txtBackground.Text);
                    this.BackgroundImage = this.Owner.BackgroundImage.Clone() as Image;
                }
            }
            else
            {
                this.Owner.BackgroundImage = global::MyMusicPlayer.Properties.Resources.background;
                this.BackgroundImage = global::MyMusicPlayer.Properties.Resources.background;
            }

            _refresh.LoadAndBindMusics();
            _refresh.RenderListViews();

            this.Close();
        }

        private void btnBrowseSkin_Click(object sender, EventArgs e)
        {
            if (this.pfdOpenBackground.ShowDialog()==DialogResult.OK)
            {
                string fileName = this.pfdOpenBackground.SafeFileName;
                string fullName = this.pfdOpenBackground.FileName;

                // 判断文件名是否正确
                string extension = Path.GetExtension(fileName).ToLower();
                if (extension != ".jpg"
                    && extension != ".gif"
                    && extension != ".png"
                    && extension != ".bmp")
                {
                    MessageBox.Show("不是正确的图片格式。"
                        , "图片错误"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
                else
                {
                    txtBackground.Text = fullName;
                    txtBackground.Tag = fileName;
                }
            }

            //int dot = fileName.LastIndexOf('.');
            //string fileType = fileName.Substring(dot + 1).ToLower(); ;
            ////约束图片类型
            //if (fileType != "jpg" && fileType != "gif" && fileType != "png" && fileType != "bmp")
            //{
            //    MessageBox.Show("文件类型错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    e.Cancel = true;
            //}
            //else
            //{
            //    txtImg.Text = fullName;//路径显示
            //    txtImg.Tag = fileName;//文件名给tag，COPY会用到
            //}
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {
            chbAutoPlay.Checked = Setting.Instance.AutoPlay;
            chbSavePlaylist.Checked = Setting.Instance.SavePlaylist;
            rbMin.Checked = Setting.Instance.Minimized;
            rbExit.Checked = Setting.Instance.Exited;
            txtMusicPath.Text = Setting.Instance.SourcePath;
            txtBackground.Text = Setting.Instance.Background;

            if (!string.IsNullOrEmpty(Setting.Instance.Background))
            {
                try
                {
                    this.BackgroundImage = Image.FromFile(Setting.Instance.Background);
                }
                catch (Exception)
                {
                    this.Owner.BackgroundImage = SystemHelper.GetBingImageBackground(txtBackground.Text);
                    this.BackgroundImage = this.Owner.BackgroundImage.Clone() as Image;
                }
            }
        }

        private void btnBrowserMusic_Click(object sender, EventArgs e)
        {
            if (this.fbdBrowserSource.ShowDialog()==DialogResult.OK)
            {
                txtMusicPath.Text = this.fbdBrowserSource.SelectedPath;
                Setting.Instance.SourcePath = txtMusicPath.Text;
            }
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            this.chbAutoPlay.Checked = false;
            this.chbSavePlaylist.Checked = true;
            this.rbExit.Checked = true;
            this.rbMin.Checked = false;
            this.txtMusicPath.Text = string.Empty;
            this.txtBackground.Text = string.Empty;
        }

        private void label9_DoubleClick(object sender, EventArgs e)
        {
            this.txtBackground.Text = label9.Tag.ToString();
        }
    }
}
