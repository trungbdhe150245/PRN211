namespace OTS.ManageSubmission
{
    partial class FrmManageSubmission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTestCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dgvSubmission = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.submitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.review = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmission)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Submission";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Test Code:";
            // 
            // txtTestCode
            // 
            this.txtTestCode.Location = new System.Drawing.Point(93, 94);
            this.txtTestCode.Name = "txtTestCode";
            this.txtTestCode.Size = new System.Drawing.Size(218, 23);
            this.txtTestCode.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class:";
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(423, 94);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(163, 23);
            this.cbClass.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(678, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Student Code:";
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(766, 94);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(177, 23);
            this.txtStudentCode.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(381, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnCancel);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Location = new System.Drawing.Point(12, 63);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(943, 120);
            this.gbSearch.TabIndex = 8;
            this.gbSearch.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(499, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgvSubmission
            // 
            this.dgvSubmission.AllowUserToAddRows = false;
            this.dgvSubmission.AllowUserToDeleteRows = false;
            this.dgvSubmission.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubmission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubmission.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.testCode,
            this.classCode,
            this.subjectCode,
            this.studentId,
            this.fullName,
            this.submitDate,
            this.mark,
            this.review});
            this.dgvSubmission.Location = new System.Drawing.Point(12, 201);
            this.dgvSubmission.Name = "dgvSubmission";
            this.dgvSubmission.ReadOnly = true;
            this.dgvSubmission.RowTemplate.Height = 25;
            this.dgvSubmission.Size = new System.Drawing.Size(943, 318);
            this.dgvSubmission.TabIndex = 9;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // testCode
            // 
            this.testCode.HeaderText = "TestCode";
            this.testCode.Name = "testCode";
            // 
            // classCode
            // 
            this.classCode.HeaderText = "ClassCode";
            this.classCode.Name = "classCode";
            // 
            // subjectCode
            // 
            this.subjectCode.HeaderText = "SubjectCode";
            this.subjectCode.Name = "subjectCode";
            // 
            // studentId
            // 
            this.studentId.HeaderText = "StudentCode";
            this.studentId.Name = "studentId";
            // 
            // fullName
            // 
            this.fullName.HeaderText = "FullName";
            this.fullName.Name = "fullName";
            // 
            // submitDate
            // 
            this.submitDate.HeaderText = "SubmitDate";
            this.submitDate.Name = "submitDate";
            // 
            // mark
            // 
            this.mark.HeaderText = "Mark";
            this.mark.Name = "mark";
            // 
            // review
            // 
            this.review.HeaderText = "Review";
            this.review.Name = "review";
            // 
            // FrmManageSubmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 544);
            this.Controls.Add(this.dgvSubmission);
            this.Controls.Add(this.txtStudentCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTestCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSearch);
            this.Name = "FrmManageSubmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageSubmissions";
            this.Load += new System.EventHandler(this.FrmManageSubmission_Load);
            this.gbSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubmission)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTestCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.DataGridView dgvSubmission;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn testCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn classCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn mark;
        private System.Windows.Forms.DataGridViewButtonColumn review;
    }
}