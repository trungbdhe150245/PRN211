using OTS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS.ViewTest
{
    public partial class FrmViewTest : Form
    {
        private Test test;
        public FrmViewTest(Test test)
        {
            this.test = test;
            InitializeComponent();
        }

        public void LoadTestInformation()
        {

        }

        private void FrmViewTest_Load(object sender, EventArgs e)
        {
            dtpStartTime.Format = DateTimePickerFormat.Custom;
            dtpStartTime.CustomFormat = "HH:mm";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
