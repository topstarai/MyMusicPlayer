using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiCommon_Click(object sender, EventArgs e)
        {
            this.gpCommon.Visible = true;
            this.gpSkinPath.Visible = false;
            this.gpAbout.Visible = false;
        }

        private void tsmlMusicSource_Click(object sender, EventArgs e)
        {
            this.gpCommon.Visible = false;
            this.gpSkinPath.Visible = true;
            this.gpAbout.Visible = false;
        }

        private void tsmiSkin_Click(object sender, EventArgs e)
        {
            this.gpCommon.Visible = false;
            this.gpSkinPath.Visible = true;
            this.gpAbout.Visible = false;
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            this.gpCommon.Visible = false;
            this.gpSkinPath.Visible = false;
            this.gpAbout.Visible = true;
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

        private void btnBrowserMusic_Click(object sender, EventArgs e)
        {
            if (this.fbdBrowserSource.ShowDialog() == DialogResult.OK)
            {
                txtMusicPath.Text = this.fbdBrowserSource.SelectedPath;
                Setting.Instance.SourcePath = txtMusicPath.Text;
            }
        }

        private void btnBrowseSkin_Click(object sender, EventArgs e)
        {
            if (this.pfdOpenBackground.ShowDialog() == DialogResult.OK)
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
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            chbAutoPlay.Checked = Setting.Instance.AutoPlay;
            chbSavePlaylist.Checked = Setting.Instance.SavePlaylist;
            rbMin.Checked = Setting.Instance.Minimized;
            rbExit.Checked = Setting.Instance.Exited;
            txtMusicPath.Text = Setting.Instance.SourcePath;
            txtBackground.Text = Setting.Instance.Background;

            if (!string.IsNullOrEmpty(Setting.Instance.Background))
            {
                this.BackgroundImage = Image.FromFile(Setting.Instance.Background);
            }
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
                this.Owner.BackgroundImage = Image.FromFile(txtBackground.Text);
                this.BackgroundImage = SystemHelper.CloneCoveredBackground(
                    this.Owner.BackgroundImage as Bitmap,
                    this.Location.X,
                    this.Location.Y,
                    this.Width,
                    this.Height);
            }

            this.Close();
        }
    }
}
