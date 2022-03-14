namespace OTS.EssayMark
{
    partial class FrmEssayTestList
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
            this.dgvSolution = new System.Windows.Forms.DataGridView();
            this.EssayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtTestId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.nudMark = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTestDetail = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMark)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSolution
            // 
            this.dgvSolution.AllowUserToAddRows = false;
            this.dgvSolution.AllowUserToDeleteRows = false;
            this.dgvSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EssayID,
            this.Question,
            this.Detail});
            this.dgvSolution.Location = new System.Drawing.Point(12, 267);
            this.dgvSolution.Name = "dgvSolution";
            this.dgvSolution.ReadOnly = true;
            this.dgvSolution.RowHeadersWidth = 51;
            this.dgvSolution.RowTemplate.Height = 29;
            this.dgvSolution.Size = new System.Drawing.Size(776, 234);
            this.dgvSolution.TabIndex = 0;
            this.dgvSolution.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSolution_CellContentClick);
            // 
            // EssayID
            // 
            this.EssayID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EssayID.HeaderText = "ID";
            this.EssayID.MinimumWidth = 6;
            this.EssayID.Name = "EssayID";
            this.EssayID.ReadOnly = true;
            this.EssayID.Width = 53;
            // 
            // Question
            // 
            this.Question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Question.HeaderText = "Question";
            this.Question.MinimumWidth = 6;
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            // 
            // Detail
            // 
            this.Detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Detail.HeaderText = "View";
            this.Detail.MinimumWidth = 6;
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 47;
            // 
            // txtTestId
            // 
            this.txtTestId.Location = new System.Drawing.Point(367, 79);
            this.txtTestId.Name = "txtTestId";
            this.txtTestId.ReadOnly = true;
            this.txtTestId.Size = new System.Drawing.Size(110, 27);
            this.txtTestId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TestId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(367, 32);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.ReadOnly = true;
            this.txtSubject.Size = new System.Drawing.Size(212, 27);
            this.txtSubject.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(628, 12);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(160, 193);
            this.txtNote.TabIndex = 5;
            // 
            // nudMark
            // 
            this.nudMark.DecimalPlaces = 2;
            this.nudMark.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMark.Location = new System.Drawing.Point(711, 224);
            this.nudMark.Name = "nudMark";
            this.nudMark.Size = new System.Drawing.Size(77, 27);
            this.nudMark.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(655, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mark";
            // 
            // btnTestDetail
            // 
            this.btnTestDetail.Location = new System.Drawing.Point(490, 78);
            this.btnTestDetail.Name = "btnTestDetail";
            this.btnTestDetail.Size = new System.Drawing.Size(89, 29);
            this.btnTestDetail.TabIndex = 9;
            this.btnTestDetail.Text = "Test Detail";
            this.btnTestDetail.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(699, 521);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 29);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(580, 521);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmEssayTestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 562);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTestDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTestId);
            this.Controls.Add(this.dgvSolution);
            this.Name = "FrmEssayTestList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmEssayTestList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSolution;
        private System.Windows.Forms.TextBox txtTestId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EssayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewButtonColumn Detail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.NumericUpDown nudMark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTestDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}