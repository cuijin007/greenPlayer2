using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace greenPlayer
{
    public partial class Form1 : Form
    {
        Process mplayer;
        StreamWriter mplayerIn;
        public Form1()
        {
            InitializeComponent();
            mplayer = new Process();
        }

        private void startVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "所有文件|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                mplayer.StartInfo.FileName = @"mplayer\mplayer.exe";
                mplayer.StartInfo.Arguments = string.Format("-slave -quiet \"{0}\"", dialog.FileName);
                mplayer.StartInfo.CreateNoWindow = true;
                mplayer.StartInfo.UseShellExecute = false;
                mplayer.StartInfo.ErrorDialog = false;
                mplayer.StartInfo.RedirectStandardInput = true;
                mplayer.StartInfo.RedirectStandardOutput = true;
                mplayer.StartInfo.RedirectStandardError = true;
                this.mplayer.OutputDataReceived += new DataReceivedEventHandler(mplayer_OutputDataReceived);
                this.mplayer.Start();
                mplayer.BeginErrorReadLine();
                mplayer.BeginOutputReadLine();
                
            }
            
        }

        void mplayer_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            MessageBox.Show(e.Data);
        }

        private void beginTime_Click(object sender, EventArgs e)
        {
           
            //StreamWriter writerIn;
            this.mplayer.StandardInput.WriteLine("get_time_pos");
           
        }

        private void stop_Click(object sender, EventArgs e)
        {
            this.mplayer.Kill();
            this.mplayer.Close();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            this.mplayer.StandardInput.WriteLine("pause");
        }

        private void seek_Click(object sender, EventArgs e)
        {
            this.mplayer.StandardInput.WriteLine("get_time_length");
        }
    }
}
