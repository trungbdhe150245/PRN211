using OTS.DAO;
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

namespace OTS.ManageClass
{
    public partial class FrmEditClass : Form
    {
        private FrmManageClass parentFormMangageClass;
        private Class editClass;
        public FrmEditClass(FrmManageClass formManageClass, Class targetClass)
        {
            parentFormMangageClass = formManageClass;
            editClass = targetClass;
            InitializeComponent();
        }

        private void LoadEditClass()
        {
            txtClassID.Text = editClass.Id.ToString();
            txtClassName.Text = editClass.Name;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ClassDBContext classDBC = new ClassDBContext();
                if (editClass != null && editClass.Name.Length != 0)
                {
                    if (classDBC.IsClassExist(editClass.Name))
                    {
                        if (classDBC.UpdateClass(editClass) > 0)
                        {
                            MessageBox.Show("Update Successful");
                            this.Close();
                            parentFormMangageClass.LoadClassData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Duplicate class!", "Warring");
                    }
                }
                else
                {
                    MessageBox.Show("Fields are not empty!", "Warring");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void FrmEditClass_Load(object sender, EventArgs e)
        {
            LoadEditClass();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
