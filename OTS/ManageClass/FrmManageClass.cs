using OTS.DAO;
using OTS.ManageClass;
using OTS.ManageMark;
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
        private string queryType = "name";
        public FrmManageClass()
        {
            InitializeComponent();
            BindingList<object> selectListQueryType = new BindingList<object>()
            {
                new {Code = "name", Name = "Class name"},
                new {Code = "code", Name = "Class Code"},
            };
            cbSearchOption.ValueMember = "Code";
            cbSearchOption.DisplayMember = "Name";
            cbSearchOption.DataSource = selectListQueryType;
            cbSearchOption.SelectedIndex = 0;
        }

        public void LoadClassData()
        {

            txtClassSearch.Text = querySearch;
            try
            {
                ClassDBContext classDBContext = new ClassDBContext();
                List<Class> classes = classDBContext.getClasses(querySearch, queryType);
                foreach (Class c in classes)
                {
                    dgvClasses.Rows.Add(c.ClassCode, c.ClassName, "Mark Report");
                }
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
                string className = dgvClasses.SelectedRows[0].Cells["ClassName"].Value.ToString();
                string classCode = dgvClasses.SelectedRows[0].Cells["ClassCode"].Value.ToString();
                Class targetEditClass = new Class()
                {
                    ClassName = className,
                    ClassCode = classCode
                };
                FrmEditClass frmEdit = new FrmEditClass(this, targetEditClass);
                frmEdit.Show();
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            if (dgvClasses.SelectedRows.Count > 0)
            {
                List<Class> classes = new List<Class>();
                foreach (DataGridViewRow row in dgvClasses.SelectedRows)
                {
                    Class eachSelectedClass = new Class();
                    string selectCode = row.Cells["ClassCode"].Value.ToString();
                    eachSelectedClass.ClassCode = selectCode;
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This class still has a record in use\nCannot be deleted", "Error");
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void btnClassSearch_Click(object sender, EventArgs e)
        {
            querySearch = txtClassSearch.Text;
            LoadClassData();
        }

        private void cbSearchOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryType = cbSearchOption.SelectedValue.ToString();
        }

        private void dgvClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.ColumnIndex == 2)
            {
                string classCode = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                string className = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
                FrmManageMark frmManageMark = new FrmManageMark(
                    new Class() { ClassCode = classCode, ClassName = className }
                    );
                frmManageMark.FormClosed += (s, args) => this.Show();
                this.Hide();
                frmManageMark.Show();
                //MessageBox.Show("EEe" + e.RowIndex);
            }
        }
    }
}
