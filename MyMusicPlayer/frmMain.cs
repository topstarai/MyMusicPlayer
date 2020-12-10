using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MyMusicPlayer
{
    public partial class frmMain : Form, IRefresh
    {
        private const string NormalIcon = "\xE923";
        private const string MaximizedIcon = "\xE922";
        private const string PauseIcon = "\xE103";
        private const string PlayIcon = "\xE102";
        public LibVLC _libVLC;
        public MediaPlayer _mp;
        public frmMain()
        {
            InitializeComponent();
            Core.Initialize();
            _libVLC = new LibVLC();
            _mp = new MediaPlayer(_libVLC);
            wmpPlayer.MediaPlayer = _mp;
            wmpPlayer.MediaPlayer.Stopped += (sender,e)=> {
                this.Invoke(new Action(() => {
                    btnPlay.Text = PlayIcon;
                    slider1.Value = 0;
                    wmpPlayer.MediaPlayer.Position = 0;
                }));
            };
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (Setting.Instance.Exited)
            {
                Application.Exit();
            }
            else
            {
                this.MyNotifyIcon.Visible = true;
                this.Hide();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                btnMax.Text = MaximizedIcon;
                RenderListViews();
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMax.Text = NormalIcon;
                RenderListViews();
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ShowSetting();
        }

        private void ShowSetting()
        {
            frmSetting setting = new frmSetting(this);
            setting.Owner = this;
            setting.ShowDialog();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //设值最大化尺寸
            var width = Screen.PrimaryScreen.WorkingArea.Width;
            var height = Screen.PrimaryScreen.WorkingArea.Height;
            this.MaximumSize = new Size(width, height);

            //加载背景图
            if (!string.IsNullOrEmpty(Setting.Instance.Background))
            {
                if (System.IO.File.Exists(Setting.Instance.Background))
                {
                    this.BackgroundImage = Image.FromFile(Setting.Instance.Background);
                }
                else
                {
                    this.BackgroundImage = SystemHelper.GetBingImageBackground(Setting.Instance.Background);
                }
            }


            //foreach (var item in this.Controls)
            //{
            //    var l = item as Control;
            //    if (item is Label || item is Button)
            //    {
            //        var x = l.Location.X + l.Width / 2;
            //        var y = l.Location.Y + l.Height / 2;
            //        l.ForeColor = SystemHelper.GetReverseForegroundColor(new Bitmap(this.BackgroundImage).GetPixel(x,y));
            //    }
            //}

            //加载音乐和播放列表
            //soundViewer = new SoundViewer(this.pbSoundViwer);
            LoadAndBindMusics();

            //控制托盘图标可见性
            if (this.WindowState == FormWindowState.Maximized
                || this.WindowState == FormWindowState.Normal)
            {
                this.MyNotifyIcon.Visible = false;
            }
            else
            {
                this.MyNotifyIcon.Visible = true;
            }

            //自动播放音乐
            if (Setting.Instance.AutoPlay)
            {
                this.PlayMusic();
            }
        }

        public void LoadAndBindMusics()
        {
            MusicManager.Instance.LoadMusics();
            MusicManager.Instance.Playing += (s, args) =>
            {
                foreach (ListViewItem item in lvPlaylist.Items)
                {
                    if (item.Tag == args.CurrentMusic)
                    {
                        item.Selected = true;
                        item.BackColor = Color.Orange;
                    }
                    else
                    {
                        item.Selected = false;
                        item.BackColor = Color.Transparent;
                    }
                }
            };

            BindMusicToListView(MusicManager.Instance.Source, lvMusicSource);//将音乐绑定到listview
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //this.MyNotifyIcon.Visible = true;
            this.WindowState = FormWindowState.Minimized;
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
            //this.WindowState = FormWindowState.Normal;
        }

        private void tsmiShow_Click(object sender, EventArgs e)
        {
            ShowMainForm();
        }

        private void tsmiSetting_Click(object sender, EventArgs e)
        {
            ShowSetting();
        }

        private void tab_title_MouseDown(object sender, MouseEventArgs e)
        {
            NativeMethods.ReleaseCapture();
            NativeMethods.SendMessage(this.Handle, NativeMethods.WM_SYSCOMMAND, NativeMethods.SC_MOVE + NativeMethods.HTCAPTION, 0);//*********************调用移动无窗体控件函数  
        }

        public void RenderListViews()
        {
            RenderMusicListView();
            RenderPlaylistView();
        }

        private void RenderMusicListView()
        {
            var background = new Bitmap(this.BackgroundImage, this.Size);
            SystemHelper.SetListViewBackground(lvMusicSource, background);
        }

        private void RenderPlaylistView()
        {
            Bitmap background = new Bitmap(this.BackgroundImage, this.Size);
            SystemHelper.SetListViewBackground(lvPlaylist, background);
        }

        private void btnMusicList_Click(object sender, EventArgs e)
        {
            if (this.lvMusicSource.Visible == true)
            {
                this.lvMusicSource.Visible = false;
                this.btnMusicList.ForeColor = Color.White;
            }
            else
            {
                //设置当前活动按钮颜色
                this.btnMusicList.ForeColor = Color.Orange;
                this.btPlaylist.ForeColor = Color.White;

                //显示所有音乐的控件
                lvPlaylist.Visible = false;
                lvMusicSource.Visible = true;
            }

            RenderMusicListView();//将listview的背景背景设置为其覆盖的主窗体背景图

        }

        private void BindMusicToListView(List<Music> musics, ListView listView)
        {
            //如果所有歌曲集合为空，结束
            listView.Items.Clear();
            //遍历集合绑定到所有歌曲LV
            foreach (Music s in musics)
            {
                ListViewItem item = null;
                if (listView == lvMusicSource)
                {
                    item = new ListViewItem(s.Name);
                    item.Tag = s;
                    item.SubItems.Add(s.Singer);
                }
                if (listView == lvPlaylist)
                {
                    s.Id = listView.Items.Count + 1;
                    item = new ListViewItem(s.Id.ToString());
                    item.Tag = s;
                    item.SubItems.Add(s.Name);
                }
                if (item.Tag == MusicManager.Instance.Current)
                {
                    item.Selected = true;
                    item.BackColor = Color.Orange;
                }
                listView.Items.Add(item);
            }
        }

        private void btPlaylist_Click(object sender, EventArgs e)
        {
            if (lvPlaylist.Visible == true)
            {
                this.btPlaylist.ForeColor = Color.White;
                this.lvPlaylist.Visible = false;
            }
            else
            {
                //按钮设置颜色
                this.btPlaylist.ForeColor = Color.Orange;
                this.btnMusicList.ForeColor = Color.White;

                BindMusicToListView(MusicManager.Instance.PlaylistItems, lvPlaylist);//将音乐绑定到listview
                //RenderListViews();//将listview的背景背景设置为其覆盖的主窗体背景图

                this.lvPlaylist.Visible = true;
                this.lvMusicSource.Visible = false;
            }

            RenderPlaylistView();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            MusicManager.Instance.Save();
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            if (tsmiSelectAll.Text == "全部选中")
            {
                foreach (ListViewItem item in lvMusicSource.Items)
                {
                    item.Checked = true;
                    item.Selected = true;
                }
                tsmiSelectAll.Text = "取消选中";
            }
            else
            {
                foreach (ListViewItem item in lvMusicSource.Items)
                {
                    item.Checked = false;
                    item.Selected = false;
                }
                tsmiSelectAll.Text = "全部选中";
            }
        }

        private void tsmiAddtoPlaylist_Click(object sender, EventArgs e)
        {
            if (lvMusicSource.CheckedItems.Count > 0)
            {
                List<Music> musics = new List<Music>();

                foreach (ListViewItem item in lvMusicSource.CheckedItems)
                {
                    musics.Add(item.Tag as Music);
                }

                MusicManager.Instance.PutIntoPlaylist(musics);
                BindMusicToListView(MusicManager.Instance.PlaylistItems, lvPlaylist);
            }
        }

        private void tsmiPlay_Click(object sender, EventArgs e)
        {
            //if (!timer1.Enabled)
            //{
            //    MusicManager.Instance.Play(selectedMusic);
            //    timer1.Start();
            //}
            if (lvPlaylist.SelectedItems.Count > 0)
            {
                var selectedMusic = lvPlaylist.SelectedItems[0].Tag as Music;
                this.PlayMusic(PlayMode.None, selectedMusic);

                //MusicManager.Instance.Play(selectedMusic);
                //this.wmpPlayer.URL = selectedMusic.FileName;
                //MusicManager.Instance.Reset();
            }
        }

        private void tsmiClearPlaylist_Click(object sender, EventArgs e)
        {
            MusicManager.Instance.ClearPlaylist();
            BindMusicToListView(MusicManager.Instance.PlaylistItems, lvPlaylist);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //if (wmpPlayer.playState == WMPPlayState.wmppsPlaying)
            if (wmpPlayer.MediaPlayer.State == VLCState.Playing)
            {
                    //暂停播放
                //    wmpPlayer.Ctlcontrols.pause();
                wmpPlayer.MediaPlayer.Pause();
                //按钮图片修改为播放
                btnPlay.Text = PlayIcon;
                //停止控制歌词滚动的定时器
                if (timerPlay.Enabled)
                    timerPlay.Stop();
            }
            //else if (wmpPlayer.playState == WMPPlayState.wmppsPaused)
            else if (wmpPlayer.MediaPlayer.State == VLCState.Paused)
            {
                //开始播放
                //wmpPlayer.Ctlcontrols.play();
                wmpPlayer.MediaPlayer.Play();
                //按钮图片修改为暂停
                btnPlay.Text = PauseIcon;
                //启动歌词滚动
                if (!timerPlay.Enabled)
                    timerPlay.Start();
            }
            //else if (this.wmpPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            else if (this.wmpPlayer.MediaPlayer.State == VLCState.Stopped)
            {
                var mode = GetPlayMode();
                var music = this.lvPlaylist.SelectedItems.Count > 0
                    ? this.lvPlaylist.SelectedItems[0].Tag as Music : null;
                PlayMusic(mode, music);
            }
            else
            {
                //如果当前为正在播放
                if (MusicManager.Instance.PlaylistItems.Count == 0)
                {
                    if (MessageBox.Show("请添加音乐到播放列表") == DialogResult.OK)
                    {
                        return;
                    }
                }

                var music = this.lvPlaylist.SelectedItems.Count > 0
                    ? this.lvPlaylist.SelectedItems[0].Tag as Music : null;
                PlayMusic(PlayMode.None, music);
            }
        }
        private bool plfixed = false;
        private void PlayMusic(PlayMode mode = PlayMode.None, Music music = null)
        {
            if (Setting.Instance.SourcePath == "")
            {
                timerPlay.Enabled = false;
                return;
            }

            MusicManager.Instance.SetPlayMode(mode);

            //如果当前无播放歌曲，调用获取歌曲的方法
            //接收播放歌曲方法，获得一个歌曲对象
            Music current;
            if (music == null || mode != PlayMode.None)
            {
                current = MusicManager.Instance.Play();
            }
            else
            {
                MusicManager.Instance.Play(music);
                current = music;
            }

            //如果歌曲对象不为空
            if (current != null)
            {
                //播放器路径设置为该歌曲路径
                if (!timerPlay.Enabled)
                    timerPlay.Start();
                //wmpPlayer.URL = current.FileName;
                var extension = Path.GetExtension(current.FileName);
                if (SystemHelper.VideoExtensions.Contains(extension))
                {
                    wmpPlayer.Visible = true;
                    plBottom.Visible = false;
                    plfixed = false;
                }
                else
                {
                    wmpPlayer.Visible = false;
                    plBottom.Visible = true;
                    plfixed = true;
                }
                wmpPlayer.MediaPlayer.Play(new Media(_libVLC, new Uri(current.FileName)));
                btnPlay.Text = PauseIcon;

                //播放按钮图片修改为暂停图片
                SetConstantUIInfo();
                SetDynamicUIMusicInfo();
        }

    }

        /// <summary>
        /// 播放模式
        /// </summary>
        private PlayMode GetPlayMode()
        {
            PlayMode mode;
            if (rbLoopMode.Checked)
            {
                mode = PlayMode.Loop;
            }
            else if (rbShuffleMode.Checked)
            {
                mode = PlayMode.Shuffle;
            }
            else if (rbOrderMode.Checked)
            {
                mode = PlayMode.Order;
            }
            else
            {
                mode = PlayMode.None;
            }
            return mode;
        }

        private void SetDynamicUIMusicInfo()
        {
            //if (wmpPlayer.URL != "")
            if (wmpPlayer.MediaPlayer.Media!=null && wmpPlayer.MediaPlayer.Position>0)
            {
                //设置当前播放歌曲颜色
                //SongColor();
                //获取音量控件显示值，根据控制刻度数量计算
                //this.trackBar1.Value = wmpPlayer.settings.volume / 10;
                //歌曲时间显示，一个是总长度，一个是已播放长度，字符串类型
                //lblRunTime.Text = wmpPlayer.Ctlcontrols.currentPositionString;
                //slider1.Value = wmpPlayer.Ctlcontrols.currentPosition;
                var duration = wmpPlayer.MediaPlayer.Position * wmpPlayer.MediaPlayer.Media.Duration;
                TimeSpan span = TimeSpan.FromMilliseconds(wmpPlayer.MediaPlayer.Position * wmpPlayer.MediaPlayer.Media.Duration);
                lblRunTime.Text = span.ToString(@"hh\:mm\:ss");
                slider1.Value = duration;
                lblLrcText.Text = MusicManager.Instance.CurrentLrc.DicLrc.ContainsKey(lblRunTime.Text)
                    ? MusicManager.Instance.CurrentLrc.DicLrc[lblRunTime.Text] : lblLrcText.Text;
            }
        }

        private void SetConstantUIInfo()
        {
            //if (wmpPlayer.URL != "")
            //{
            //    lblAllTime.Text = wmpPlayer.currentMedia?.durationString;
            //    slider1.Maximum = wmpPlayer.currentMedia?.duration == 0 ? 100 : wmpPlayer.currentMedia?.duration ?? 100;
            //    slider1.Minimum = 0;
            //    this.lblName.Text = $"{MusicManager.Instance.Current?.Name}/{MusicManager.Instance.Current?.Singer}";
            //    MyNotifyIcon.Text = this.lblName.Text;
            //}

            if (wmpPlayer.MediaPlayer.Media != null && wmpPlayer.MediaPlayer.Media.Duration>0)
            {
                TimeSpan total = TimeSpan.FromMilliseconds(wmpPlayer.MediaPlayer.Media.Duration);
                lblAllTime.Text = total.ToString(@"hh\:mm\:ss");
                slider1.Maximum = wmpPlayer.MediaPlayer.Media.Duration == 0 ? 100 : wmpPlayer.MediaPlayer.Media.Duration;
                slider1.Minimum = 0;
                this.lblName.Text = $"{MusicManager.Instance.Current?.Name}/{MusicManager.Instance.Current?.Singer}";
                MyNotifyIcon.Text = this.lblName.Text;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MusicManager.Instance.Next();
            if (MusicManager.Instance.Current!=null)
            {
                //wmpPlayer.URL = MusicManager.Instance.Current.FileName;
                wmpPlayer.MediaPlayer.Play(new Media(_libVLC, new Uri(MusicManager.Instance.Current.FileName)));
                btnPlay.Text = PauseIcon;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            MusicManager.Instance.Previous();
            if (MusicManager.Instance.Current != null)
            {
                //wmpPlayer.URL = MusicManager.Instance.Current.FileName;
                wmpPlayer.MediaPlayer.Play(new Media(_libVLC, new Uri(MusicManager.Instance.Current.FileName)));
                btnPlay.Text = PauseIcon;
            }
        }

        private void lvPlaylist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lvPlaylist.SelectedItems.Count > 0)
                {
                    PlayMusic(PlayMode.None, lvPlaylist.SelectedItems[0].Tag as Music);
                }
            }
        }

        private void timerPlay_Tick(object sender, EventArgs e)
        {
            //自动下一首，如果当前播放完毕
            var mode = GetPlayMode();
            //if (this.wmpPlayer.playState == WMPPlayState.wmppsStopped && mode!= PlayMode.None)
            if (this.wmpPlayer.MediaPlayer.State == VLCState.Stopped && mode != PlayMode.None)
            {
                PlayMusic(mode);
                Thread.Sleep(1000);
            }

            SetConstantUIInfo();
            SetDynamicUIMusicInfo();
        }

        //private void wmpPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        //{
        //    if ((WMPPlayState)e.newState == WMPPlayState.wmppsStopped)
        //    {
        //        btnPlay.Text = PlayIcon;
        //    }
        //}

        ListViewItem CurrentSelectedItem;
        ListViewItem PreviousSelectedItem;
        private void lvMusicSource_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            if (PreviousSelectedItem != null)
            {
                PreviousSelectedItem.Checked = false;
            }
            PreviousSelectedItem = CurrentSelectedItem;
            CurrentSelectedItem = e.Item;
            e.Item.Checked = true;
        }

        private void slider1_MouseClick(object sender, MouseEventArgs e)
        {
            //if (!string.IsNullOrEmpty(wmpPlayer.URL))
            //{
            //    timerPlay.Stop();
            //    wmpPlayer.Ctlcontrols.pause();
            //    wmpPlayer.Ctlcontrols.currentPosition = this.slider1.Value;
            //    timerPlay.Start();
            //    wmpPlayer.Ctlcontrols.play();
            //    btnPlay.Text = PauseIcon;
            //}
            if (wmpPlayer.MediaPlayer.IsPlaying)
            {
                timerPlay.Stop();
                wmpPlayer.MediaPlayer.Pause();
                wmpPlayer.MediaPlayer.Position = (float)this.slider1.Value/wmpPlayer.MediaPlayer.Media.Duration;
                timerPlay.Start();
                wmpPlayer.MediaPlayer.Play();
                btnPlay.Text = PauseIcon;
            }
        }

        private void lvMusicSource_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lvMusicSource.SelectedItems.Count > 0)
                {
                    PlayMusic(PlayMode.None, lvMusicSource.SelectedItems[0].Tag as Music);
                    btnMusicList_Click(null,null);
                }
            }
        }

        private void rbOrderMode_CheckedChanged(object sender, EventArgs e)
        {
            ChangeRadioButtonForeColor(sender as RadioButton);
        }

        private void ChangeRadioButtonForeColor(RadioButton radioButton)
        {
            if (radioButton.Checked)
            {
                radioButton.ForeColor = Color.Orange;
            }
            else
            {
                radioButton.ForeColor = Color.White;
            }
        }

        private void rbLoopMode_CheckedChanged(object sender, EventArgs e)
        {
            ChangeRadioButtonForeColor(sender as RadioButton);
        }

        private void rbShuffleMode_CheckedChanged(object sender, EventArgs e)
        {
            ChangeRadioButtonForeColor(sender as RadioButton);
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (plfixed == false)
            {
                var loc = e.Location;
                if (loc.Y > this.Height - 100)
                {
                    plBottom.Visible = true;
                }
                else
                {
                    plBottom.Visible = false;
                }
            }
        }

        private void plBottom_MouseLeave(object sender, EventArgs e)
        {
            if (plfixed==false)
            {
                plBottom.Visible = false;
            }
        }
    }
}
