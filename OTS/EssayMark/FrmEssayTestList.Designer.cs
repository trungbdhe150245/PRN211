﻿namespace OTS.EssayMark
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
            this.nudMark = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTestDetail = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richtxtNote = new System.Windows.Forms.RichTextBox();
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
            this.txtTestId.Location = new System.Drawing.Point(365, 95);
            this.txtTestId.Name = "txtTestId";
            this.txtTestId.ReadOnly = true;
            this.txtTestId.Size = new System.Drawing.Size(110, 27);
            this.txtTestId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TestId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Subject";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(365, 48);
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
            // nudMark
            // 
            this.nudMark.DecimalPlaces = 2;
            this.nudMark.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMark.Location = new System.Drawing.Point(711, 224);
            this.nudMark.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMark.Name = "nudMark";
            this.nudMark.Size = new System.Drawing.Size(77, 27);
            this.nudMark.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(655, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mark";
            // 
            // btnTestDetail
            // 
            this.btnTestDetail.Location = new System.Drawing.Point(488, 94);
            this.btnTestDetail.Name = "btnTestDetail";
            this.btnTestDetail.Size = new System.Drawing.Size(89, 29);
            this.btnTestDetail.TabIndex = 9;
            this.btnTestDetail.Text = "Test Detail";
            this.btnTestDetail.UseVisualStyleBackColor = true;
            this.btnTestDetail.Click += new System.EventHandler(this.btnTestDetail_Click);
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
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(26, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 50);
            this.label5.TabIndex = 22;
            this.label5.Text = "Essay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(106, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 50);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mark";
            // 
            // richtxtNote
            // 
            this.richtxtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richtxtNote.Location = new System.Drawing.Point(628, 12);
            this.richtxtNote.Name = "richtxtNote";
            this.richtxtNote.Size = new System.Drawing.Size(162, 193);
            this.richtxtNote.TabIndex = 24;
            this.richtxtNote.Text = "";
            // 
            // FrmEssayTestList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 562);
            this.Controls.Add(this.richtxtNote);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnTestDetail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTestId);
            this.Controls.Add(this.dgvSolution);
            this.Name = "FrmEssayTestList";
            this.Text = "Essay Mark";
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
        private System.Windows.Forms.NumericUpDown nudMark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTestDetail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richtxtNote;
    }
}