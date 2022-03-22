namespace OTS.ViewTest
{
    partial class FrmCreateTest
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
            this.nudQuestions = new System.Windows.Forms.NumericUpDown();
            this.nudEasy = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudMedium = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudHard = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.checkReview = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpDuration = new System.Windows.Forms.DateTimePicker();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.dtpTestDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvTest = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Review = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHard)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(387, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CREATE A TEST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(60, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of questions:";
            // 
            // nudQuestions
            // 
            this.nudQuestions.Location = new System.Drawing.Point(269, 65);
            this.nudQuestions.Name = "nudQuestions";
            this.nudQuestions.Size = new System.Drawing.Size(120, 27);
            this.nudQuestions.TabIndex = 2;
            // 
            // nudEasy
            // 
            this.nudEasy.Location = new System.Drawing.Point(269, 115);
            this.nudEasy.Name = "nudEasy";
            this.nudEasy.Size = new System.Drawing.Size(120, 27);
            this.nudEasy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(60, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Easy:";
            // 
            // nudMedium
            // 
            this.nudMedium.Location = new System.Drawing.Point(269, 165);
            this.nudMedium.Name = "nudMedium";
            this.nudMedium.Size = new System.Drawing.Size(120, 27);
            this.nudMedium.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(60, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Medium:";
            // 
            // nudHard
            // 
            this.nudHard.Location = new System.Drawing.Point(269, 211);
            this.nudHard.Name = "nudHard";
            this.nudHard.Size = new System.Drawing.Size(120, 27);
            this.nudHard.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(60, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hard:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpStartTime);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.checkReview);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dtpDuration);
            this.groupBox1.Controls.Add(this.cbClass);
            this.groupBox1.Controls.Add(this.cbSubject);
            this.groupBox1.Controls.Add(this.dtpTestDate);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nudHard);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudMedium);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudEasy);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nudQuestions);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 365);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set up test";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "HH:mm:ss";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(677, 208);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(229, 27);
            this.dtpStartTime.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(493, 213);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Start time:";
            // 
            // checkReview
            // 
            this.checkReview.AutoSize = true;
            this.checkReview.Location = new System.Drawing.Point(269, 271);
            this.checkReview.Name = "checkReview";
            this.checkReview.Size = new System.Drawing.Size(15, 14);
            this.checkReview.TabIndex = 21;
            this.checkReview.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Review:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(518, 316);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 32);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(339, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpDuration
            // 
            this.dtpDuration.CustomFormat = "HH:mm:ss";
            this.dtpDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDuration.Location = new System.Drawing.Point(677, 258);
            this.dtpDuration.Name = "dtpDuration";
            this.dtpDuration.Size = new System.Drawing.Size(229, 27);
            this.dtpDuration.TabIndex = 17;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(677, 164);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(229, 28);
            this.cbClass.TabIndex = 16;
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(677, 114);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(229, 28);
            this.cbSubject.TabIndex = 15;
            // 
            // dtpTestDate
            // 
            this.dtpTestDate.CustomFormat = "yyyy-MM-dd";
            this.dtpTestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTestDate.Location = new System.Drawing.Point(677, 62);
            this.dtpTestDate.Name = "dtpTestDate";
            this.dtpTestDate.Size = new System.Drawing.Size(229, 27);
            this.dtpTestDate.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(493, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Class:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Subject:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(493, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Test date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Duration:";
            // 
            // dgvTest
            // 
            this.dgvTest.AllowUserToResizeRows = false;
            this.dgvTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ClassCode,
            this.StartTime,
            this.TestDate,
            this.Duration,
            this.SubjectCode,
            this.CreateDate,
            this.Review});
            this.dgvTest.Location = new System.Drawing.Point(24, 475);
            this.dgvTest.Name = "dgvTest";
            this.dgvTest.RowTemplate.Height = 25;
            this.dgvTest.Size = new System.Drawing.Size(986, 330);
            this.dgvTest.TabIndex = 11;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ClassCode
            // 
            this.ClassCode.HeaderText = "Code";
            this.ClassCode.Name = "ClassCode";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            // 
            // TestDate
            // 
            this.TestDate.HeaderText = "TestDate";
            this.TestDate.Name = "TestDate";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // SubjectCode
            // 
            this.SubjectCode.HeaderText = "SubjectCode";
            this.SubjectCode.Name = "SubjectCode";
            // 
            // CreateDate
            // 
            this.CreateDate.HeaderText = "CreateDate";
            this.CreateDate.Name = "CreateDate";
            // 
            // Review
            // 
            this.Review.HeaderText = "Review";
            this.Review.Name = "Review";
            this.Review.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FrmCreateTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 831);
            this.Controls.Add(this.dgvTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCreateTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCreateTest";
            this.Load += new System.EventHandler(this.FrmCreateTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuestions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudQuestions;
        private System.Windows.Forms.NumericUpDown nudEasy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMedium;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudHard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpTestDate;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.DateTimePicker dtpDuration;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Review;
        private System.Windows.Forms.CheckBox checkReview;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label label11;
    }
}