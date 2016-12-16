using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;//needed to make a web client object
using System.Diagnostics;//needed to make use of PRocess.Start

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        WebClient client = new WebClient();//declare and set a new client object
        public Form1()//constructor, it runs when the form is made 
        {
            InitializeComponent();
        }

        private void btnWithFreezing_Click(object sender, EventArgs e)
        {
            //DownloadFile has the effect of freezing the interface while the download occurs
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                client.DownloadFile("https://pixabay.com/en/videos/download/video-5194_source.mp4", saveFileDialog1.FileName);
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "/select," + saveFileDialog1.FileName);//open windows explorer with file selected or highlighted
        }

        private void btnNoFreezing_Click(object sender, EventArgs e)
        {
            //DownloadFileAsync has the effect of downloading the file in the background while the program remains usable
            //the interface does not freeze during the download
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                client.DownloadFileAsync(new Uri("https://pixabay.com/en/videos/download/video-5194_source.mp4"), saveFileDialog1.FileName);
        }
    }
}
