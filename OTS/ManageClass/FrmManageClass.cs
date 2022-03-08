using OTS.DAO;
using OTS.ManageClass;
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

        private void btnEditClass_Click(object sender, EventArgs e)
        {
            string className = dgvClasses.SelectedRows[0].Cells["Name"].Value.ToString();
            string raw_classId = dgvClasses.SelectedRows[0].Cells["Id"].Value.ToString();
            Class targetEditClass = new Class()
            {
                Name = className,
                Id = Int32.Parse(raw_classId)
            };
            FrmEditClass frmEdit = new FrmEditClass(this, targetEditClass);
            frmEdit.Show();
        }
    }
}
