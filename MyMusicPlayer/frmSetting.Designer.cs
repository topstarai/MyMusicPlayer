namespace MyMusicPlayer
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCommon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlMusicSource = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.gpCommon = new System.Windows.Forms.GroupBox();
            this.rbExit = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.chbSavePlaylist = new System.Windows.Forms.CheckBox();
            this.chbAutoPlay = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gpSkinPath = new System.Windows.Forms.GroupBox();
            this.btnBrowseSkin = new System.Windows.Forms.Button();
            this.btnBrowserMusic = new System.Windows.Forms.Button();
            this.txtBackground = new System.Windows.Forms.TextBox();
            this.txtMusicPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gpAbout = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fbdBrowserSource = new System.Windows.Forms.FolderBrowserDialog();
            this.pfdOpenBackground = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.gpCommon.SuspendLayout();
            this.gpSkinPath.SuspendLayout();
            this.gpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe MDL2 Assets", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(674, 14);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 39);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.Transparent;
            this.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefault.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDefault.ForeColor = System.Drawing.Color.White;
            this.btnDefault.Location = new System.Drawing.Point(588, 392);
            this.btnDefault.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(88, 33);
            this.btnDefault.TabIndex = 7;
            this.btnDefault.Text = " 默认";
            this.btnDefault.UseVisualStyleBackColor = false;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(469, 392);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "  保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCommon,
            this.tsmlMusicSource,
            this.tsmiAbout});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(10, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(93, 81);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiCommon
            // 
            this.tsmiCommon.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmiCommon.ForeColor = System.Drawing.Color.White;
            this.tsmiCommon.Name = "tsmiCommon";
            this.tsmiCommon.Size = new System.Drawing.Size(85, 25);
            this.tsmiCommon.Text = "操作习惯";
            this.tsmiCommon.Click += new System.EventHandler(this.tsmiCommon_Click);
            // 
            // tsmlMusicSource
            // 
            this.tsmlMusicSource.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmlMusicSource.ForeColor = System.Drawing.Color.White;
            this.tsmlMusicSource.Name = "tsmlMusicSource";
            this.tsmlMusicSource.Size = new System.Drawing.Size(85, 25);
            this.tsmlMusicSource.Text = "歌曲皮肤";
            this.tsmlMusicSource.Click += new System.EventHandler(this.tsmiSkin_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tsmiAbout.ForeColor = System.Drawing.Color.White;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(85, 25);
            this.tsmiAbout.Text = "关于程序";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // gpCommon
            // 
            this.gpCommon.BackColor = System.Drawing.Color.Transparent;
            this.gpCommon.Controls.Add(this.rbExit);
            this.gpCommon.Controls.Add(this.rbMin);
            this.gpCommon.Controls.Add(this.chbSavePlaylist);
            this.gpCommon.Controls.Add(this.chbAutoPlay);
            this.gpCommon.Controls.Add(this.label6);
            this.gpCommon.Controls.Add(this.label7);
            this.gpCommon.Font = new System.Drawing.Font("KaiTi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpCommon.ForeColor = System.Drawing.Color.White;
            this.gpCommon.Location = new System.Drawing.Point(156, 53);
            this.gpCommon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpCommon.Name = "gpCommon";
            this.gpCommon.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpCommon.Size = new System.Drawing.Size(519, 313);
            this.gpCommon.TabIndex = 13;
            this.gpCommon.TabStop = false;
            this.gpCommon.Text = "操作习惯";
            // 
            // rbExit
            // 
            this.rbExit.AutoSize = true;
            this.rbExit.Checked = true;
            this.rbExit.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbExit.Location = new System.Drawing.Point(82, 231);
            this.rbExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbExit.Name = "rbExit";
            this.rbExit.Size = new System.Drawing.Size(89, 20);
            this.rbExit.TabIndex = 7;
            this.rbExit.TabStop = true;
            this.rbExit.Text = "退出程序";
            this.rbExit.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbMin.Location = new System.Drawing.Point(82, 195);
            this.rbMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(121, 20);
            this.rbMin.TabIndex = 6;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "最小化到托盘";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // chbSavePlaylist
            // 
            this.chbSavePlaylist.AutoSize = true;
            this.chbSavePlaylist.Checked = true;
            this.chbSavePlaylist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSavePlaylist.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbSavePlaylist.Location = new System.Drawing.Point(82, 118);
            this.chbSavePlaylist.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chbSavePlaylist.Name = "chbSavePlaylist";
            this.chbSavePlaylist.Size = new System.Drawing.Size(170, 20);
            this.chbSavePlaylist.TabIndex = 5;
            this.chbSavePlaylist.Text = "退出时保存播放列表";
            this.chbSavePlaylist.UseVisualStyleBackColor = true;
            // 
            // chbAutoPlay
            // 
            this.chbAutoPlay.AutoSize = true;
            this.chbAutoPlay.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chbAutoPlay.Location = new System.Drawing.Point(82, 76);
            this.chbAutoPlay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chbAutoPlay.Name = "chbAutoPlay";
            this.chbAutoPlay.Size = new System.Drawing.Size(138, 20);
            this.chbAutoPlay.TabIndex = 4;
            this.chbAutoPlay.Text = "启动时自动播放";
            this.chbAutoPlay.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("KaiTi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(57, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "启动退出设置";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("KaiTi", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(58, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "主面板点击关闭时";
            // 
            // gpSkinPath
            // 
            this.gpSkinPath.BackColor = System.Drawing.Color.Transparent;
            this.gpSkinPath.Controls.Add(this.btnBrowseSkin);
            this.gpSkinPath.Controls.Add(this.btnBrowserMusic);
            this.gpSkinPath.Controls.Add(this.txtBackground);
            this.gpSkinPath.Controls.Add(this.txtMusicPath);
            this.gpSkinPath.Controls.Add(this.label8);
            this.gpSkinPath.Controls.Add(this.label9);
            this.gpSkinPath.Font = new System.Drawing.Font("KaiTi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpSkinPath.ForeColor = System.Drawing.Color.White;
            this.gpSkinPath.Location = new System.Drawing.Point(156, 53);
            this.gpSkinPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpSkinPath.Name = "gpSkinPath";
            this.gpSkinPath.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpSkinPath.Size = new System.Drawing.Size(519, 313);
            this.gpSkinPath.TabIndex = 14;
            this.gpSkinPath.TabStop = false;
            this.gpSkinPath.Text = "路径与皮肤";
            this.gpSkinPath.Visible = false;
            // 
            // btnBrowseSkin
            // 
            this.btnBrowseSkin.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseSkin.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseSkin.ForeColor = System.Drawing.Color.White;
            this.btnBrowseSkin.Location = new System.Drawing.Point(407, 201);
            this.btnBrowseSkin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowseSkin.Name = "btnBrowseSkin";
            this.btnBrowseSkin.Size = new System.Drawing.Size(88, 35);
            this.btnBrowseSkin.TabIndex = 10;
            this.btnBrowseSkin.Text = " 浏览";
            this.btnBrowseSkin.UseVisualStyleBackColor = false;
            this.btnBrowseSkin.Click += new System.EventHandler(this.btnBrowseSkin_Click);
            // 
            // btnBrowserMusic
            // 
            this.btnBrowserMusic.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowserMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowserMusic.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowserMusic.ForeColor = System.Drawing.Color.White;
            this.btnBrowserMusic.Location = new System.Drawing.Point(407, 90);
            this.btnBrowserMusic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBrowserMusic.Name = "btnBrowserMusic";
            this.btnBrowserMusic.Size = new System.Drawing.Size(88, 35);
            this.btnBrowserMusic.TabIndex = 9;
            this.btnBrowserMusic.Text = " 浏览";
            this.btnBrowserMusic.UseVisualStyleBackColor = false;
            this.btnBrowserMusic.Click += new System.EventHandler(this.btnBrowserMusic_Click);
            // 
            // txtBackground
            // 
            this.txtBackground.Location = new System.Drawing.Point(62, 201);
            this.txtBackground.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBackground.Name = "txtBackground";
            this.txtBackground.Size = new System.Drawing.Size(338, 30);
            this.txtBackground.TabIndex = 5;
            // 
            // txtMusicPath
            // 
            this.txtMusicPath.Location = new System.Drawing.Point(62, 90);
            this.txtMusicPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMusicPath.Name = "txtMusicPath";
            this.txtMusicPath.Size = new System.Drawing.Size(338, 30);
            this.txtMusicPath.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(58, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "歌曲路径：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(58, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 2;
            this.label9.Tag = "https://cn.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1";
            this.label9.Text = "皮肤路径：";
            this.label9.DoubleClick += new System.EventHandler(this.label9_DoubleClick);
            // 
            // gpAbout
            // 
            this.gpAbout.BackColor = System.Drawing.Color.Transparent;
            this.gpAbout.Controls.Add(this.label5);
            this.gpAbout.Controls.Add(this.label4);
            this.gpAbout.Controls.Add(this.label3);
            this.gpAbout.Controls.Add(this.label2);
            this.gpAbout.Controls.Add(this.label1);
            this.gpAbout.Font = new System.Drawing.Font("KaiTi", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gpAbout.ForeColor = System.Drawing.Color.White;
            this.gpAbout.Location = new System.Drawing.Point(156, 53);
            this.gpAbout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpAbout.Name = "gpAbout";
            this.gpAbout.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpAbout.Size = new System.Drawing.Size(519, 313);
            this.gpAbout.TabIndex = 15;
            this.gpAbout.TabStop = false;
            this.gpAbout.Text = "关于程序";
            this.gpAbout.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(279, 137);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "微信：sky-0-sky";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(58, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "版本：v 0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "作者：Mark Kang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("KaiTi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(279, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "日期： 2020年7月14日";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("KaiTi", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "我的音乐播放器";
            // 
            // pfdOpenBackground
            // 
            this.pfdOpenBackground.FileName = "openFileDialog1";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(744, 440);
            this.Controls.Add(this.gpSkinPath);
            this.Controls.Add(this.gpCommon);
            this.Controls.Add(this.gpAbout);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpCommon.ResumeLayout(false);
            this.gpCommon.PerformLayout();
            this.gpSkinPath.ResumeLayout(false);
            this.gpSkinPath.PerformLayout();
            this.gpAbout.ResumeLayout(false);
            this.gpAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCommon;
        private System.Windows.Forms.ToolStripMenuItem tsmlMusicSource;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.GroupBox gpCommon;
        private System.Windows.Forms.RadioButton rbExit;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.CheckBox chbSavePlaylist;
        private System.Windows.Forms.CheckBox chbAutoPlay;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpSkinPath;
        private System.Windows.Forms.Button btnBrowseSkin;
        private System.Windows.Forms.Button btnBrowserMusic;
        private System.Windows.Forms.TextBox txtBackground;
        private System.Windows.Forms.TextBox txtMusicPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpAbout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbdBrowserSource;
        private System.Windows.Forms.OpenFileDialog pfdOpenBackground;
    }
}