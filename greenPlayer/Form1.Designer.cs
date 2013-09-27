namespace greenPlayer
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.startVideo = new System.Windows.Forms.Button();
            this.beginTime = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.seek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startVideo
            // 
            this.startVideo.Location = new System.Drawing.Point(30, 43);
            this.startVideo.Name = "startVideo";
            this.startVideo.Size = new System.Drawing.Size(75, 23);
            this.startVideo.TabIndex = 0;
            this.startVideo.Text = "调用";
            this.startVideo.UseVisualStyleBackColor = true;
            this.startVideo.Click += new System.EventHandler(this.startVideo_Click);
            // 
            // beginTime
            // 
            this.beginTime.Location = new System.Drawing.Point(30, 72);
            this.beginTime.Name = "beginTime";
            this.beginTime.Size = new System.Drawing.Size(75, 23);
            this.beginTime.TabIndex = 1;
            this.beginTime.Text = "播放时间";
            this.beginTime.UseVisualStyleBackColor = true;
            this.beginTime.Click += new System.EventHandler(this.beginTime_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(2, 1);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 2;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(30, 101);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(75, 23);
            this.pause.TabIndex = 3;
            this.pause.Text = "暂停";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // seek
            // 
            this.seek.Location = new System.Drawing.Point(30, 130);
            this.seek.Name = "seek";
            this.seek.Size = new System.Drawing.Size(75, 23);
            this.seek.TabIndex = 4;
            this.seek.Text = "跳转";
            this.seek.UseVisualStyleBackColor = true;
            this.seek.Click += new System.EventHandler(this.seek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 283);
            this.Controls.Add(this.seek);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.beginTime);
            this.Controls.Add(this.startVideo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startVideo;
        private System.Windows.Forms.Button beginTime;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button seek;
    }
}

