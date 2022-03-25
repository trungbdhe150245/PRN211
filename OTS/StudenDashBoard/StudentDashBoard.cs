﻿using OTS.DAO;
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
using System.Windows.Forms.VisualStyles;

namespace OTS.StudenDashBoard
{
    public partial class StudentDashBoard : Form
    {
        public StudentDashBoard()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            StudentDBContext sDb = new StudentDBContext();
            SubmissionDBContext smDB = new SubmissionDBContext();
            Dictionary<Submission, Mark> recentTest = smDB.viewListResult(4);
            Student s = sDb.getStudent(4);
            var list = recentTest.Select(l => new
            {
                Code = l.Key.Test.Code,
                SubDate = l.Key.SubmitDate,
                CodeSub = l.Value.Test.Subject.SubjectName,
                Class = l.Value.Student.Class.ClassName,
                Mark = l.Value.Grade,
                IsReview = l.Key.Test.IsReview,
            }).ToList();
            dataGridView1.DataSource = list.ToList();
            StuCode.Text = s.StudentCode;
            StuName.Text = s.FullName;
            StuClass.Text = s.Class.ClassName;
            //DataGridViewButtonColumn dgvbt = new DataGridViewButtonColumn();
            //dgvbt.HeaderText = "Review";
            //dgvbt.Text = "Review";                        // works also when bound
            //dgvbt.UseColumnTextForButtonValue = true;
            //dataGridView1.Columns.Add(dgvbt);//
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            DataGridViewDisableButtonColumn but = new DataGridViewDisableButtonColumn();
            but.Name = "Review";
            but.HeaderText = "Review";
            dataGridView1.Columns.Insert(6, but);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells["Review"].Value = "Review";
            }
            this.dataGridView1.Columns[5].Visible = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewDisableButtonCell Review = (DataGridViewDisableButtonCell)dataGridView1.Rows[i].Cells["Review"];
                if (!list[i].IsReview)
                {
                    Review.Enabled = false;
                }
                else
                {
                    Review.Enabled = true;
                }
            }
            
            dataGridView1.Invalidate();
        }



        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Review")
            {
                DataGridViewDisableButtonCell buttonCell = (DataGridViewDisableButtonCell)dataGridView1.Rows[e.RowIndex].Cells["Review"];
                if (buttonCell.Enabled)
                {
                    StudentDBContext sDb = new StudentDBContext();
                    SubmissionDBContext smDB = new SubmissionDBContext();
                    Dictionary<Submission, Mark> recentTest = smDB.viewListResult(4);
                    Student s = sDb.getStudent(4);
                    formReviewDetail fRD = new formReviewDetail(s, recentTest);
                    fRD.Show();
                }
            }

        }

        private void StudentDashBoard_Load(object sender, EventArgs e)
        {

            LoadData();
        }
    }

    public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
    {
        public DataGridViewDisableButtonColumn()
        {
            this.CellTemplate = new DataGridViewDisableButtonCell();
        }
    }

    public class DataGridViewDisableButtonCell : DataGridViewButtonCell
    {
        private bool enabledValue;
        public bool Enabled
        {
            get
            {
                return enabledValue;
            }
            set
            {
                enabledValue = value;
            }
        }

        public override object Clone()
        {
            DataGridViewDisableButtonCell cell = (DataGridViewDisableButtonCell)base.Clone();
            cell.Enabled = this.Enabled;
            return cell;
        }

        public DataGridViewDisableButtonCell()
        {
            this.enabledValue = true;
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState,
                                        object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle,
                                        DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            if (!this.enabledValue)
            {
                if ((paintParts & DataGridViewPaintParts.Background) == DataGridViewPaintParts.Background)
                {
                    SolidBrush cellBackground = new SolidBrush(cellStyle.BackColor);
                    graphics.FillRectangle(cellBackground, cellBounds);
                    cellBackground.Dispose();
                }

                if ((paintParts & DataGridViewPaintParts.Border) == DataGridViewPaintParts.Border)
                {
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
                }

                Rectangle buttonArea = cellBounds;
                Rectangle buttonAdjustment = this.BorderWidths(advancedBorderStyle);
                buttonArea.X += buttonAdjustment.X;
                buttonArea.Y += buttonAdjustment.Y;
                buttonArea.Height -= buttonAdjustment.Height;
                buttonArea.Width -= buttonAdjustment.Width;

                ButtonRenderer.DrawButton(graphics, buttonArea, PushButtonState.Disabled);

                if (this.FormattedValue is String)
                {
                    TextRenderer.DrawText(graphics, (string)this.FormattedValue, this.DataGridView.Font, buttonArea, SystemColors.GrayText);
                }
            }
            else
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);
            }
        }
    }
}

