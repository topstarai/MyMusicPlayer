using LibVLCSharp.WinForms;

namespace MyMusicPlayer
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowMain = new System.Windows.Forms.ToolStripMenuItem();
            this.播放模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顺序播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.随机播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单曲循环ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.slider1 = new MyMusicPlayer.Slider();
            this.lvAllMusic = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lvPlaylist = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.wmnPlayer = new LibVLCSharp.WinForms.VideoView();
            this.lblLrc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmnPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnSource);
            this.panel1.Controls.Add(this.btnPlaylist);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnMax);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 62);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnSource
            // 
            this.btnSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSource.FlatAppearance.BorderSize = 0;
            this.btnSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSource.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSource.ForeColor = System.Drawing.Color.White;
            this.btnSource.Location = new System.Drawing.Point(790, 13);
            this.btnSource.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(37, 45);
            this.btnSource.TabIndex = 8;
            this.btnSource.Text = "";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlaylist.FlatAppearance.BorderSize = 0;
            this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnPlaylist.Location = new System.Drawing.Point(735, 13);
            this.btnPlaylist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(37, 45);
            this.btnPlaylist.TabIndex = 7;
            this.btnPlaylist.Text = "";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Location = new System.Drawing.Point(898, 13);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(37, 45);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(1008, 22);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(37, 27);
            this.btnMin.TabIndex = 4;
            this.btnMin.Text = "";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.Location = new System.Drawing.Point(1063, 13);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(37, 45);
            this.btnMax.TabIndex = 3;
            this.btnMax.Text = "";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Music Player";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1119, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 45);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(715, 645);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 39);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(562, 642);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(57, 43);
            this.btnPlay.TabIndex = 13;
            this.btnPlay.Text = "";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(400, 642);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(57, 43);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.Text = "";
            this.btnPrevious.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowMain,
            this.播放模式ToolStripMenuItem,
            this.tsmiSetting,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 98);
            // 
            // tsmiShowMain
            // 
            this.tsmiShowMain.Name = "tsmiShowMain";
            this.tsmiShowMain.Size = new System.Drawing.Size(126, 22);
            this.tsmiShowMain.Text = "显示面板";
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
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(123, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(126, 22);
            this.tsmiExit.Text = "退出程序";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.MyNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("MyNotifyIcon.Icon")));
            this.MyNotifyIcon.Text = "My Music Player";
            this.MyNotifyIcon.Visible = true;
            this.MyNotifyIcon.DoubleClick += new System.EventHandler(this.MyNotifyIcon_DoubleClick);
            // 
            // slider1
            // 
            this.slider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.slider1.BackColor = System.Drawing.Color.Transparent;
            this.slider1.BackgroundColor = System.Drawing.Color.White;
            this.slider1.BorderColor = System.Drawing.Color.Black;
            this.slider1.FinishedColor = System.Drawing.Color.Gold;
            this.slider1.FontColor = System.Drawing.Color.Black;
            this.slider1.FontSize = 9F;
            this.slider1.Location = new System.Drawing.Point(72, 621);
            this.slider1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.slider1.Maximum = 100D;
            this.slider1.Minimum = 0D;
            this.slider1.Name = "slider1";
            this.slider1.SetRectColor = System.Drawing.Color.Orange;
            this.slider1.ShowPercentTag = false;
            this.slider1.Size = new System.Drawing.Size(1068, 14);
            this.slider1.SliderStyle = MyMusicPlayer.SliderStyle.Circle;
            this.slider1.TabIndex = 14;
            this.slider1.Text = "slider1";
            this.slider1.Value = 0D;
            // 
            // lvAllMusic
            // 
            this.lvAllMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAllMusic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvAllMusic.CheckBoxes = true;
            this.lvAllMusic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvAllMusic.FullRowSelect = true;
            this.lvAllMusic.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvAllMusic.HideSelection = false;
            this.lvAllMusic.Location = new System.Drawing.Point(793, 69);
            this.lvAllMusic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvAllMusic.Name = "lvAllMusic";
            this.lvAllMusic.Size = new System.Drawing.Size(382, 526);
            this.lvAllMusic.TabIndex = 15;
            this.lvAllMusic.UseCompatibleStateImageBehavior = false;
            this.lvAllMusic.View = System.Windows.Forms.View.Details;
            this.lvAllMusic.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Name = "columnHeader1";
            this.columnHeader1.Text = "歌曲";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Name = "columnHeader2";
            this.columnHeader2.Text = "歌手";
            // 
            // lvPlaylist
            // 
            this.lvPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lvPlaylist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPlaylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvPlaylist.FullRowSelect = true;
            this.lvPlaylist.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvPlaylist.HideSelection = false;
            this.lvPlaylist.Location = new System.Drawing.Point(793, 69);
            this.lvPlaylist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvPlaylist.Name = "lvPlaylist";
            this.lvPlaylist.Size = new System.Drawing.Size(382, 526);
            this.lvPlaylist.TabIndex = 16;
            this.lvPlaylist.UseCompatibleStateImageBehavior = false;
            this.lvPlaylist.View = System.Windows.Forms.View.Details;
            this.lvPlaylist.Visible = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Name = "columnHeader3";
            this.columnHeader3.Text = "编号";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Name = "columnHeader4";
            this.columnHeader4.Text = "歌曲名";
            // 
            // wmnPlayer
            // 
            this.wmnPlayer.BackColor = System.Drawing.Color.Black;
            this.wmnPlayer.Location = new System.Drawing.Point(113, 133);
            this.wmnPlayer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.wmnPlayer.MediaPlayer = null;
            this.wmnPlayer.Name = "wmnPlayer";
            this.wmnPlayer.Size = new System.Drawing.Size(448, 261);
            this.wmnPlayer.TabIndex = 17;
            // 
            // lblLrc
            // 
            this.lblLrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLrc.BackColor = System.Drawing.Color.Transparent;
            this.lblLrc.Location = new System.Drawing.Point(133, 597);
            this.lblLrc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLrc.Name = "lblLrc";
            this.lblLrc.Size = new System.Drawing.Size(952, 27);
            this.lblLrc.TabIndex = 19;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 698);
            this.Controls.Add(this.lblLrc);
            this.Controls.Add(this.wmnPlayer);
            this.Controls.Add(this.lvPlaylist);
            this.Controls.Add(this.lvAllMusic);
            this.Controls.Add(this.slider1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPrevious);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmnPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPrevious;
        private Slider slider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowMain;
        private System.Windows.Forms.ToolStripMenuItem 播放模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顺序播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 随机播放ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单曲循环ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSetting;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.ListView lvAllMusic;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvPlaylist;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private VideoView wmnPlayer;
        private System.Windows.Forms.Label lblLrc;
    }
}