namespace MyMusicPlayer
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.label1 = new System.Windows.Forms.Label();
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.播放模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顺序播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.随机播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单曲循环ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.plTitle = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMusicList = new System.Windows.Forms.Button();
            this.btPlaylist = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lvMusicSource = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.cmsMusicSource = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddtoPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiDel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.lvPlaylist = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.cmsPlaylist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiPlay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShuffle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPlayDel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayDelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClearPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPlayAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.wmpPlayer = new LibVLCSharp.WinForms.VideoView();
            this.plBottom = new System.Windows.Forms.Panel();
            this.slider1 = new MyMusicPlayer.Slider();
            this.rbOrderMode = new System.Windows.Forms.RadioButton();
            this.rbShuffleMode = new System.Windows.Forms.RadioButton();
            this.rbLoopMode = new System.Windows.Forms.RadioButton();
            this.lblLrcText = new System.Windows.Forms.Label();
            this.lblRunTime = new System.Windows.Forms.Label();
            this.lblAllTime = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.plTitle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmsMusicSource.SuspendLayout();
            this.cmsPlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).BeginInit();
            this.plBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.MyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MyNotifyIcon.Icon")));
            this.MyNotifyIcon.Text = "我的音乐播放器";
            this.MyNotifyIcon.Visible = true;
            this.MyNotifyIcon.DoubleClick += new System.EventHandler(this.MyNotifyIcon_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.toolStripSeparator1,
            this.播放模式ToolStripMenuItem,
            this.tsmiSetting,
            this.toolStripSeparator2,
            this.tsmiExit});
            this.contextMenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 104);
            // 
            // tsmiShow
            // 
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(126, 22);
            this.tsmiShow.Text = "显示面板";
            this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(123, 6);
            // 
            // 播放模式ToolStripMenuItem
            // 
            this.播放模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顺序播放ToolStripMenuItem,
            this.随机播放ToolStripMenuItem,
            this.单曲循环ToolStripMenuItem});
            this.播放模式ToolStripMenuItem.Name = "播放模式ToolStripMenuItem";
            this.播放模式ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.播放模式ToolStripMenuItem.Text = "播放模式";
            // 
            // 顺序播放ToolStripMenuItem
            // 
            this.顺序播放ToolStripMenuItem.Name = "顺序播放ToolStripMenuItem";
            this.顺序播放ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.顺序播放ToolStripMenuItem.Text = "顺序播放";
            // 
            // 随机播放ToolStripMenuItem
            // 
            this.随机播放ToolStripMenuItem.Name = "随机播放ToolStripMenuItem";
            this.随机播放ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.随机播放ToolStripMenuItem.Text = "随机播放";
            // 
            // 单曲循环ToolStripMenuItem
            // 
            this.单曲循环ToolStripMenuItem.Name = "单曲循环ToolStripMenuItem";
            this.单曲循环ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.单曲循环ToolStripMenuItem.Text = "单曲循环";
            // 
            // tsmiSetting
            // 
            this.tsmiSetting.Name = "tsmiSetting";
            this.tsmiSetting.Size = new System.Drawing.Size(126, 22);
            this.tsmiSetting.Text = "程序设置";
            this.tsmiSetting.Click += new System.EventHandler(this.tsmiSetting_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(123, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(126, 22);
            this.tsmiExit.Text = "退出程序";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // plTitle
            // 
            this.plTitle.BackColor = System.Drawing.Color.Transparent;
            this.plTitle.Controls.Add(this.label2);
            this.plTitle.Controls.Add(this.panel1);
            this.plTitle.Controls.Add(this.label1);
            this.plTitle.Controls.Add(this.lblName);
            this.plTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTitle.ForeColor = System.Drawing.Color.Transparent;
            this.plTitle.Location = new System.Drawing.Point(0, 0);
            this.plTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.plTitle.Name = "plTitle";
            this.plTitle.Size = new System.Drawing.Size(1108, 40);
            this.plTitle.TabIndex = 10;
            this.plTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tab_title_MouseDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 40);
            this.label2.TabIndex = 10;
            this.label2.Text = "My Music Player";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnMusicList);
            this.panel1.Controls.Add(this.btPlaylist);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(655, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 40);
            this.panel1.TabIndex = 9;
            // 
            // btnMusicList
            // 
            this.btnMusicList.BackColor = System.Drawing.Color.Transparent;
            this.btnMusicList.FlatAppearance.BorderSize = 0;
            this.btnMusicList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicList.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMusicList.ForeColor = System.Drawing.Color.White;
            this.btnMusicList.Location = new System.Drawing.Point(70, 3);
            this.btnMusicList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMusicList.Name = "btnMusicList";
            this.btnMusicList.Size = new System.Drawing.Size(50, 32);
            this.btnMusicList.TabIndex = 11;
            this.btnMusicList.Text = "";
            this.btnMusicList.UseVisualStyleBackColor = false;
            this.btnMusicList.Click += new System.EventHandler(this.btnMusicList_Click);
            // 
            // btPlaylist
            // 
            this.btPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btPlaylist.FlatAppearance.BorderSize = 0;
            this.btPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlaylist.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btPlaylist.ForeColor = System.Drawing.Color.White;
            this.btPlaylist.Location = new System.Drawing.Point(13, 3);
            this.btPlaylist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btPlaylist.Name = "btPlaylist";
            this.btPlaylist.Size = new System.Drawing.Size(50, 32);
            this.btPlaylist.TabIndex = 10;
            this.btPlaylist.Text = "";
            this.btPlaylist.UseVisualStyleBackColor = false;
            this.btPlaylist.Click += new System.EventHandler(this.btPlaylist_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(173, 3);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(50, 32);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(290, 3);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 32);
            this.btnMin.TabIndex = 7;
            this.btnMin.Text = "";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(347, 3);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 32);
            this.btnMax.TabIndex = 6;
            this.btnMax.Text = "";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(405, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(317, 15);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 18;
            // 
            // lvMusicSource
            // 
            this.lvMusicSource.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvMusicSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMusicSource.BackColor = System.Drawing.Color.White;
            this.lvMusicSource.BackgroundImageTiled = true;
            this.lvMusicSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMusicSource.CheckBoxes = true;
            this.lvMusicSource.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.lvMusicSource.ContextMenuStrip = this.cmsMusicSource;
            this.lvMusicSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvMusicSource.ForeColor = System.Drawing.Color.Black;
            this.lvMusicSource.FullRowSelect = true;
            this.lvMusicSource.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvMusicSource.HideSelection = false;
            this.lvMusicSource.Location = new System.Drawing.Point(706, 38);
            this.lvMusicSource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvMusicSource.Name = "lvMusicSource";
            this.lvMusicSource.Size = new System.Drawing.Size(402, 554);
            this.lvMusicSource.TabIndex = 12;
            this.lvMusicSource.UseCompatibleStateImageBehavior = false;
            this.lvMusicSource.View = System.Windows.Forms.View.Details;
            this.lvMusicSource.Visible = false;
            this.lvMusicSource.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMusicSource_ItemSelectionChanged);
            this.lvMusicSource.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMusicSource_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "歌曲名";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "歌手";
            this.columnHeader4.Width = 87;
            // 
            // cmsMusicSource
            // 
            this.cmsMusicSource.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMusicSource.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectAll,
            this.tsmiAddtoPlaylist,
            this.toolStripSeparator5,
            this.tsmiDel,
            this.tsmiDelFile});
            this.cmsMusicSource.Name = "cmsAll";
            this.cmsMusicSource.ShowImageMargin = false;
            this.cmsMusicSource.Size = new System.Drawing.Size(141, 98);
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(140, 22);
            this.tsmiSelectAll.Text = "全部选中";
            this.tsmiSelectAll.Click += new System.EventHandler(this.tsmiSelectAll_Click);
            // 
            // tsmiAddtoPlaylist
            // 
            this.tsmiAddtoPlaylist.Name = "tsmiAddtoPlaylist";
            this.tsmiAddtoPlaylist.Size = new System.Drawing.Size(140, 22);
            this.tsmiAddtoPlaylist.Text = "添加到播放列表";
            this.tsmiAddtoPlaylist.Click += new System.EventHandler(this.tsmiAddtoPlaylist_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(137, 6);
            // 
            // tsmiDel
            // 
            this.tsmiDel.Name = "tsmiDel";
            this.tsmiDel.Size = new System.Drawing.Size(140, 22);
            this.tsmiDel.Text = "删除选中歌曲";
            this.tsmiDel.Visible = false;
            // 
            // tsmiDelFile
            // 
            this.tsmiDelFile.Name = "tsmiDelFile";
            this.tsmiDelFile.Size = new System.Drawing.Size(140, 22);
            this.tsmiDelFile.Text = "删除歌曲及文件";
            this.tsmiDelFile.Visible = false;
            // 
            // lvPlaylist
            // 
            this.lvPlaylist.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lvPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPlaylist.BackColor = System.Drawing.Color.White;
            this.lvPlaylist.BackgroundImageTiled = true;
            this.lvPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader2});
            this.lvPlaylist.ContextMenuStrip = this.cmsPlaylist;
            this.lvPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lvPlaylist.ForeColor = System.Drawing.Color.Black;
            this.lvPlaylist.FullRowSelect = true;
            this.lvPlaylist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvPlaylist.HideSelection = false;
            this.lvPlaylist.Location = new System.Drawing.Point(706, 38);
            this.lvPlaylist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvPlaylist.Name = "lvPlaylist";
            this.lvPlaylist.Size = new System.Drawing.Size(402, 554);
            this.lvPlaylist.TabIndex = 13;
            this.lvPlaylist.UseCompatibleStateImageBehavior = false;
            this.lvPlaylist.View = System.Windows.Forms.View.Details;
            this.lvPlaylist.Visible = false;
            this.lvPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvPlaylist_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Name = "columnHeader5";
            this.columnHeader5.Text = "编号";
            this.columnHeader5.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "歌曲名";
            this.columnHeader2.Width = 190;
            // 
            // cmsPlaylist
            // 
            this.cmsPlaylist.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsPlaylist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPlay,
            this.tsmiModel,
            this.toolStripSeparator3,
            this.tsmiPlayDel,
            this.tsmiPlayDelFile,
            this.tsmiClearPlaylist,
            this.toolStripSeparator4,
            this.tsmiPlayAdd});
            this.cmsPlaylist.Name = "cmsPlay";
            this.cmsPlaylist.Size = new System.Drawing.Size(166, 148);
            // 
            // tsmiPlay
            // 
            this.tsmiPlay.Name = "tsmiPlay";
            this.tsmiPlay.Size = new System.Drawing.Size(165, 22);
            this.tsmiPlay.Text = "播放";
            this.tsmiPlay.Click += new System.EventHandler(this.tsmiPlay_Click);
            // 
            // tsmiModel
            // 
            this.tsmiModel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOrder,
            this.tsmiShuffle,
            this.tsmiLoop});
            this.tsmiModel.Name = "tsmiModel";
            this.tsmiModel.Size = new System.Drawing.Size(165, 22);
            this.tsmiModel.Text = "播放模式";
            this.tsmiModel.Visible = false;
            // 
            // tsmiOrder
            // 
            this.tsmiOrder.Checked = true;
            this.tsmiOrder.CheckOnClick = true;
            this.tsmiOrder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiOrder.Name = "tsmiOrder";
            this.tsmiOrder.Size = new System.Drawing.Size(126, 22);
            this.tsmiOrder.Text = "列表循环";
            // 
            // tsmiShuffle
            // 
            this.tsmiShuffle.CheckOnClick = true;
            this.tsmiShuffle.Name = "tsmiShuffle";
            this.tsmiShuffle.Size = new System.Drawing.Size(126, 22);
            this.tsmiShuffle.Text = "随机播放";
            // 
            // tsmiLoop
            // 
            this.tsmiLoop.CheckOnClick = true;
            this.tsmiLoop.Name = "tsmiLoop";
            this.tsmiLoop.Size = new System.Drawing.Size(126, 22);
            this.tsmiLoop.Text = "单曲循环";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(162, 6);
            // 
            // tsmiPlayDel
            // 
            this.tsmiPlayDel.Name = "tsmiPlayDel";
            this.tsmiPlayDel.Size = new System.Drawing.Size(165, 22);
            this.tsmiPlayDel.Text = "删除歌曲";
            this.tsmiPlayDel.Visible = false;
            // 
            // tsmiPlayDelFile
            // 
            this.tsmiPlayDelFile.Name = "tsmiPlayDelFile";
            this.tsmiPlayDelFile.Size = new System.Drawing.Size(165, 22);
            this.tsmiPlayDelFile.Text = "删除歌曲及文件";
            this.tsmiPlayDelFile.Visible = false;
            // 
            // tsmiClearPlaylist
            // 
            this.tsmiClearPlaylist.Name = "tsmiClearPlaylist";
            this.tsmiClearPlaylist.Size = new System.Drawing.Size(165, 22);
            this.tsmiClearPlaylist.Text = "清空列表";
            this.tsmiClearPlaylist.Click += new System.EventHandler(this.tsmiClearPlaylist_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(162, 6);
            // 
            // tsmiPlayAdd
            // 
            this.tsmiPlayAdd.Name = "tsmiPlayAdd";
            this.tsmiPlayAdd.Size = new System.Drawing.Size(165, 22);
            this.tsmiPlayAdd.Text = "添加歌曲";
            this.tsmiPlayAdd.Visible = false;
            // 
            // timerPlay
            // 
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // wmpPlayer
            // 
            this.wmpPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wmpPlayer.BackColor = System.Drawing.Color.Black;
            this.wmpPlayer.Location = new System.Drawing.Point(0, 38);
            this.wmpPlayer.MediaPlayer = null;
            this.wmpPlayer.Name = "wmpPlayer";
            this.wmpPlayer.Size = new System.Drawing.Size(1108, 644);
            this.wmpPlayer.TabIndex = 26;
            this.wmpPlayer.Text = "videoView1";
            this.wmpPlayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            // 
            // plBottom
            // 
            this.plBottom.BackColor = System.Drawing.Color.Transparent;
            this.plBottom.Controls.Add(this.slider1);
            this.plBottom.Controls.Add(this.rbOrderMode);
            this.plBottom.Controls.Add(this.rbShuffleMode);
            this.plBottom.Controls.Add(this.rbLoopMode);
            this.plBottom.Controls.Add(this.lblLrcText);
            this.plBottom.Controls.Add(this.lblRunTime);
            this.plBottom.Controls.Add(this.lblAllTime);
            this.plBottom.Controls.Add(this.btnNext);
            this.plBottom.Controls.Add(this.btnPlay);
            this.plBottom.Controls.Add(this.btnPrevious);
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBottom.Location = new System.Drawing.Point(0, 590);
            this.plBottom.Name = "plBottom";
            this.plBottom.Size = new System.Drawing.Size(1108, 100);
            this.plBottom.TabIndex = 28;
            this.plBottom.Visible = false;
            this.plBottom.MouseLeave += new System.EventHandler(this.plBottom_MouseLeave);
            // 
            // slider1
            // 
            this.slider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider1.BackgroundColor = System.Drawing.Color.White;
            this.slider1.BorderColor = System.Drawing.Color.Transparent;
            this.slider1.FinishedColor = System.Drawing.Color.Gray;
            this.slider1.FontColor = System.Drawing.Color.Transparent;
            this.slider1.FontSize = 9F;
            this.slider1.Location = new System.Drawing.Point(93, 34);
            this.slider1.Maximum = 100D;
            this.slider1.Minimum = 0D;
            this.slider1.Name = "slider1";
            this.slider1.SetRectColor = System.Drawing.Color.Orange;
            this.slider1.ShowPercentTag = false;
            this.slider1.Size = new System.Drawing.Size(908, 14);
            this.slider1.SliderStyle = MyMusicPlayer.SliderStyle.Circle;
            this.slider1.TabIndex = 37;
            this.slider1.Text = "slider1";
            this.slider1.Value = 0D;
            // 
            // rbOrderMode
            // 
            this.rbOrderMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbOrderMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbOrderMode.AutoSize = true;
            this.rbOrderMode.BackColor = System.Drawing.Color.Transparent;
            this.rbOrderMode.FlatAppearance.BorderSize = 0;
            this.rbOrderMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbOrderMode.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbOrderMode.ForeColor = System.Drawing.Color.White;
            this.rbOrderMode.Location = new System.Drawing.Point(889, 57);
            this.rbOrderMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbOrderMode.Name = "rbOrderMode";
            this.rbOrderMode.Size = new System.Drawing.Size(39, 30);
            this.rbOrderMode.TabIndex = 36;
            this.rbOrderMode.Text = "";
            this.rbOrderMode.UseVisualStyleBackColor = false;
            this.rbOrderMode.Click += new System.EventHandler(this.rbOrderMode_CheckedChanged);
            // 
            // rbShuffleMode
            // 
            this.rbShuffleMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbShuffleMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbShuffleMode.AutoSize = true;
            this.rbShuffleMode.BackColor = System.Drawing.Color.Transparent;
            this.rbShuffleMode.FlatAppearance.BorderSize = 0;
            this.rbShuffleMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbShuffleMode.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbShuffleMode.ForeColor = System.Drawing.Color.White;
            this.rbShuffleMode.Location = new System.Drawing.Point(1014, 57);
            this.rbShuffleMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbShuffleMode.Name = "rbShuffleMode";
            this.rbShuffleMode.Size = new System.Drawing.Size(39, 30);
            this.rbShuffleMode.TabIndex = 35;
            this.rbShuffleMode.Text = "";
            this.rbShuffleMode.UseVisualStyleBackColor = false;
            this.rbShuffleMode.Click += new System.EventHandler(this.rbShuffleMode_CheckedChanged);
            // 
            // rbLoopMode
            // 
            this.rbLoopMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbLoopMode.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbLoopMode.AutoSize = true;
            this.rbLoopMode.BackColor = System.Drawing.Color.Transparent;
            this.rbLoopMode.FlatAppearance.BorderSize = 0;
            this.rbLoopMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbLoopMode.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbLoopMode.ForeColor = System.Drawing.Color.White;
            this.rbLoopMode.Location = new System.Drawing.Point(956, 55);
            this.rbLoopMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbLoopMode.Name = "rbLoopMode";
            this.rbLoopMode.Size = new System.Drawing.Size(39, 30);
            this.rbLoopMode.TabIndex = 34;
            this.rbLoopMode.Text = "";
            this.rbLoopMode.UseVisualStyleBackColor = false;
            this.rbLoopMode.Click += new System.EventHandler(this.rbLoopMode_CheckedChanged);
            // 
            // lblLrcText
            // 
            this.lblLrcText.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLrcText.BackColor = System.Drawing.Color.Transparent;
            this.lblLrcText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLrcText.ForeColor = System.Drawing.Color.Orange;
            this.lblLrcText.Location = new System.Drawing.Point(100, 5);
            this.lblLrcText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLrcText.Name = "lblLrcText";
            this.lblLrcText.Size = new System.Drawing.Size(897, 30);
            this.lblLrcText.TabIndex = 33;
            this.lblLrcText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRunTime
            // 
            this.lblRunTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRunTime.AutoSize = true;
            this.lblRunTime.BackColor = System.Drawing.Color.Transparent;
            this.lblRunTime.ForeColor = System.Drawing.Color.White;
            this.lblRunTime.Location = new System.Drawing.Point(44, 34);
            this.lblRunTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRunTime.Name = "lblRunTime";
            this.lblRunTime.Size = new System.Drawing.Size(49, 15);
            this.lblRunTime.TabIndex = 32;
            this.lblRunTime.Text = "00:00:00";
            // 
            // lblAllTime
            // 
            this.lblAllTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAllTime.AutoSize = true;
            this.lblAllTime.BackColor = System.Drawing.Color.Transparent;
            this.lblAllTime.ForeColor = System.Drawing.Color.White;
            this.lblAllTime.Location = new System.Drawing.Point(1004, 33);
            this.lblAllTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllTime.Name = "lblAllTime";
            this.lblAllTime.Size = new System.Drawing.Size(49, 15);
            this.lblAllTime.TabIndex = 31;
            this.lblAllTime.Text = "00:00:00";
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(677, 53);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 39);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(524, 49);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(57, 43);
            this.btnPlay.TabIndex = 30;
            this.btnPlay.Text = "";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(362, 49);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(57, 43);
            this.btnPrevious.TabIndex = 29;
            this.btnPrevious.Text = "";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 690);
            this.Controls.Add(this.plBottom);
            this.Controls.Add(this.lvPlaylist);
            this.Controls.Add(this.lvMusicSource);
            this.Controls.Add(this.plTitle);
            this.Controls.Add(this.wmpPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.plTitle.ResumeLayout(false);
            this.plTitle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.cmsMusicSource.ResumeLayout(false);
            this.cmsPlaylist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).EndInit();
            this.plBottom.ResumeLayout(false);
            this.plBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 播放模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem 顺序播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 随机播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单曲循环ToolStripMenuItem;
        private System.Windows.Forms.Panel plTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMusicList;
        private System.Windows.Forms.Button btPlaylist;
        private System.Windows.Forms.ListView lvMusicSource;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvPlaylist;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ContextMenuStrip cmsPlaylist;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlay;
        private System.Windows.Forms.ToolStripMenuItem tsmiModel;
        private System.Windows.Forms.ToolStripMenuItem tsmiOrder;
        private System.Windows.Forms.ToolStripMenuItem tsmiShuffle;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayDel;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayDelFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearPlaylist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayAdd;
        private System.Windows.Forms.ContextMenuStrip cmsMusicSource;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddtoPlaylist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiDel;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelFile;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Label lblName;
        private LibVLCSharp.WinForms.VideoView wmpPlayer;
        private System.Windows.Forms.Panel plBottom;
        private System.Windows.Forms.RadioButton rbOrderMode;
        private System.Windows.Forms.RadioButton rbShuffleMode;
        private System.Windows.Forms.RadioButton rbLoopMode;
        private System.Windows.Forms.Label lblLrcText;
        private System.Windows.Forms.Label lblRunTime;
        private System.Windows.Forms.Label lblAllTime;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPrevious;
        private Slider slider1;
    }
}

