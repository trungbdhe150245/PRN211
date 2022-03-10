namespace OTS.ManageSubject
{
    partial class InsertSubject
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.lbEditClass = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "SubjectCode ";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.Location = new System.Drawing.Point(157, 80);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.Size = new System.Drawing.Size(195, 23);
            this.txtSubjectCode.TabIndex = 17;
            // 
            // lbEditClass
            // 
            this.lbEditClass.AutoSize = true;
            this.lbEditClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEditClass.Location = new System.Drawing.Point(196, 29);
            this.lbEditClass.Name = "lbEditClass";
            this.lbEditClass.Size = new System.Drawing.Size(105, 20);
            this.lbEditClass.TabIndex = 16;
            this.lbEditClass.Text = "Insert Subject";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(262, 158);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 28);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 158);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "SubjectName ";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(157, 109);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(195, 23);
            this.txtSubjectName.TabIndex = 19;
            // 
            // InsertSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubjectCode);
            this.Controls.Add(this.lbEditClass);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCancel);
            this.Name = "InsertSubject";
            this.Text = "InsertSubject";
            this.Load += new System.EventHandler(this.InsertSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.Label lbEditClass;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubjectName;
    }
}