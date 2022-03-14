using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS.ManageTest
{
    public partial class TakeTest : Form
    {
        public TakeTest()
        {
            InitializeComponent();
            Random_Img();
        }

        private void TakeTest_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.label_mcname.Text = Environment.MachineName;
            Timer();
            
        }
        private void Timer()
        {
            CountDownTimer timer = new CountDownTimer();
            timer.SetTime(Convert.ToInt32("100"), 0);
            timer.Start();
            timer.TimeChanged += () => label13.Text = timer.TimeLeftStr;
            timer.CountDownFinished += () => label13.Text = "Finish!";
            timer.StepMs = 77;
        }



        private List<string> FilePath(string dir)
        {
            List<string> fileList = new List<string>(); 
            DirectoryInfo d = new DirectoryInfo(dir); //Assuming Test is your Folder

            FileInfo[] Files = d.GetFiles("*.png"); //Getting Text files

            foreach (FileInfo file in Files)
            {
                fileList.Add(dir + "\\" + file.Name);
            }
            return fileList;
        }


        private void Random_Img()
        {
            Random seed = new Random();
            List<string> paths = FilePath(@"C:\Users\trung\Desktop\Flag");
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            this.pictureBox1.Image = Image.FromFile(paths.ElementAt(seed.Next(0, paths.Count)));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
