
namespace OTS.ManageQuestion
{
    partial class ListQuestionBank
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchQues = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addQues = new System.Windows.Forms.Button();
            this.editQues = new System.Windows.Forms.Button();
            this.delQues = new System.Windows.Forms.Button();
            this.dataQuestion = new System.Windows.Forms.DataGridView();
            this.checkType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(869, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Question Bank";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 27);
            this.textBox1.TabIndex = 1;
            // 
            // searchQues
            // 
            this.searchQues.Location = new System.Drawing.Point(180, 109);
            this.searchQues.Name = "searchQues";
            this.searchQues.Size = new System.Drawing.Size(98, 27);
            this.searchQues.TabIndex = 2;
            this.searchQues.Text = "Search";
            this.searchQues.UseVisualStyleBackColor = true;
            this.searchQues.Click += new System.EventHandler(this.searchQues_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(279, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Question Bank List";
            // 
            // addQues
            // 
            this.addQues.Location = new System.Drawing.Point(180, 407);
            this.addQues.Name = "addQues";
            this.addQues.Size = new System.Drawing.Size(129, 35);
            this.addQues.TabIndex = 5;
            this.addQues.Text = "New Question";
            this.addQues.UseVisualStyleBackColor = true;
            this.addQues.Click += new System.EventHandler(this.addQues_Click);
            // 
            // editQues
            // 
            this.editQues.Location = new System.Drawing.Point(340, 407);
            this.editQues.Name = "editQues";
            this.editQues.Size = new System.Drawing.Size(129, 35);
            this.editQues.TabIndex = 6;
            this.editQues.Text = "Edit";
            this.editQues.UseVisualStyleBackColor = true;
            // 
            // delQues
            // 
            this.delQues.Location = new System.Drawing.Point(498, 407);
            this.delQues.Name = "delQues";
            this.delQues.Size = new System.Drawing.Size(129, 35);
            this.delQues.TabIndex = 7;
            this.delQues.Text = "Delete";
            this.delQues.UseVisualStyleBackColor = true;
            // 
            // dataQuestion
            // 
            this.dataQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataQuestion.Location = new System.Drawing.Point(12, 200);
            this.dataQuestion.Name = "dataQuestion";
            this.dataQuestion.RowHeadersWidth = 51;
            this.dataQuestion.RowTemplate.Height = 29;
            this.dataQuestion.Size = new System.Drawing.Size(869, 188);
            this.dataQuestion.TabIndex = 9;
            // 
            // checkType
            // 
            this.checkType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checkType.FormattingEnabled = true;
            this.checkType.Items.AddRange(new object[] {
            "Multiple-choice",
            "Essay"});
            this.checkType.Location = new System.Drawing.Point(683, 143);
            this.checkType.Name = "checkType";
            this.checkType.Size = new System.Drawing.Size(162, 28);
            this.checkType.TabIndex = 10;
            this.checkType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(692, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type of question";
            // 
            // ListQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 760);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkType);
            this.Controls.Add(this.dataQuestion);
            this.Controls.Add(this.delQues);
            this.Controls.Add(this.editQues);
            this.Controls.Add(this.addQues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchQues);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ListQuestionBank";
            this.Text = "ListQuestionBank";
            this.Load += new System.EventHandler(this.ListQuestionBank_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataQuestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button searchQues;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addQues;
        private System.Windows.Forms.Button editQues;
        private System.Windows.Forms.Button delQues;
        private System.Windows.Forms.DataGridView dataQuestion;
        private System.Windows.Forms.ComboBox checkType;
        private System.Windows.Forms.Label label3;
    }
}