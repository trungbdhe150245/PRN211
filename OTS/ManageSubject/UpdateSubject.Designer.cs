namespace OTS.ManageSubject
{
    partial class UpdateSubject
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
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.lbEditClass = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewSubjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewSubjectCode = new System.Windows.Forms.TextBox();
            this.gdvUpdateSubject = new System.Windows.Forms.DataGridView();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUpdateSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "SubjectName ";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(132, 95);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(195, 23);
            this.txtSubjectName.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "SubjectCode ";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Location = new System.Drawing.Point(132, 66);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(195, 23);
            this.txtSubjectCode.TabIndex = 24;
            // 
            // lbEditClass
            // 
            this.lbEditClass.AutoSize = true;
            this.lbEditClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEditClass.Location = new System.Drawing.Point(171, 15);
            this.lbEditClass.Name = "lbEditClass";
            this.lbEditClass.Size = new System.Drawing.Size(115, 20);
            this.lbEditClass.TabIndex = 23;
            this.lbEditClass.Text = "Update Subject";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(239, 270);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 28);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 270);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "New Subject Name ";
            // 
            // txtNewSubjectName
            // 
            this.txtNewSubjectName.Location = new System.Drawing.Point(132, 227);
            this.txtNewSubjectName.Name = "txtNewSubjectName";
            this.txtNewSubjectName.Size = new System.Drawing.Size(195, 23);
            this.txtNewSubjectName.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "New Subject Code ";
            // 
            // txtNewSubjectCode
            // 
            this.txtNewSubjectCode.Location = new System.Drawing.Point(132, 198);
            this.txtNewSubjectCode.Name = "txtNewSubjectCode";
            this.txtNewSubjectCode.Size = new System.Drawing.Size(195, 23);
            this.txtNewSubjectCode.TabIndex = 29;
            // 
            // gdvUpdateSubject
            // 
            this.gdvUpdateSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvUpdateSubject.Location = new System.Drawing.Point(382, 15);
            this.gdvUpdateSubject.Name = "gdvUpdateSubject";
            this.gdvUpdateSubject.RowTemplate.Height = 25;
            this.gdvUpdateSubject.Size = new System.Drawing.Size(301, 325);
            this.gdvUpdateSubject.TabIndex = 28;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(190, 143);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 28);
            this.btnFind.TabIndex = 33;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // UpdateSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 352);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewSubjectName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNewSubjectCode);
            this.Controls.Add(this.gdvUpdateSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.lbEditClass);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Name = "UpdateSubject";
            this.Text = "UpdateSubject";
            this.Load += new System.EventHandler(this.UpdateSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvUpdateSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.Label lbEditClass;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewSubjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewSubjectCode;
        private System.Windows.Forms.DataGridView gdvUpdateSubject;
        private System.Windows.Forms.Button btnFind;
    }
}