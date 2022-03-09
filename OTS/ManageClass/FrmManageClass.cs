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
        private string querySearch = "";
        public FrmManageClass()
        {
            InitializeComponent();
        }

        public void LoadClassData()
        {
            txtClassSearch.Text = querySearch;
            try
            {
                ClassDBContext classDBContext = new ClassDBContext();
                dgvClasses.DataSource = classDBContext.getClasses(querySearch, "name");
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
            if (dgvClasses.SelectedRows.Count > 0)
            {
                string className = dgvClasses.SelectedRows[0].Cells["Name"].Value.ToString();
                string raw_classId = dgvClasses.SelectedRows[0].Cells["ClassCode"].Value.ToString();
                Class targetEditClass = new Class()
                {
                    Name = className,
                    ClassCode = Int32.Parse(raw_classId)
                };
                FrmEditClass frmEdit = new FrmEditClass(this, targetEditClass);
                frmEdit.Show();
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            List<Class> classes = new List<Class>();
           foreach (DataGridViewRow row in dgvClasses.SelectedRows)
            {
                Class eachSelectedClass = new Class();
                string raw_select_Id = row.Cells["ClassCode"].Value.ToString();
                eachSelectedClass.ClassCode = Int32.Parse(raw_select_Id);
                classes.Add(eachSelectedClass);
            }
           try
            {
                ClassDBContext classDBC = new ClassDBContext();
                int recordWasDelete = classDBC.DeleteClass(classes);
                if (recordWasDelete > 0)
                {
                    MessageBox.Show($"Delete {recordWasDelete} Successful!");
                    LoadClassData();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnClassSearch_Click(object sender, EventArgs e)
        {
            querySearch = txtClassSearch.Text;
            LoadClassData();
        }
    }
}
