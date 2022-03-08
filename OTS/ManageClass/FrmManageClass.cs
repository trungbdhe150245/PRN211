using OTS.DAO;
using OTS.ManageClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS
{
    public partial class FrmManageClass : Form
    {
        public FrmManageClass()
        {
            InitializeComponent();
        }

        public void LoadClassData()
        {
            try
            {
                ClassDBContext classDBContext = new ClassDBContext();
                dgvClasses.DataSource = classDBContext.getClasses();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmManageClass_Load(object sender, EventArgs e)
        {
            LoadClassData();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            FrmCreateClass frmCreate = new FrmCreateClass(this);
            frmCreate.Show();
        }
    }
}
