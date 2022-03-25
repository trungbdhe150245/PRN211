using OTS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS.test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TestDBContext tdb = new TestDBContext();


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessWrite();
        } 
        public Task ProcessWrite()
        {
            string filePath = @"C:\Users\trung\Desktop\test.txt";
            string text = "Hello World\r\n";

            return WriteTextAsync(filePath, text);
        }

        public async Task WriteTextAsync(string filePath, string text)
        {
            byte[] encodedText = Encoding.Unicode.GetBytes(text);

            using (FileStream sourceStream = new FileStream(filePath,
                FileMode.Append, FileAccess.Write, FileShare.None,
                bufferSize: 4096, useAsync: true))
            {
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length);
            };
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //ServiceController[] svcs = ServiceController.GetServices();

            //foreach (ServiceController svc in svcs)
            //{
            //    ListViewItem item = new ListViewItem();
            //    item.Text = svc.DisplayName;
            //    item.SubItems.Add(svc.ServiceName);
            //    item.SubItems.Add(svc.Status.ToString());

            //    listView1.Items.Add(item);
            //}

            Models.Test t = tdb.GetTest("PRO192_PT2");



        }


    }
}
