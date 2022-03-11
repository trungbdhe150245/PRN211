
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
            this.advancedDataGridView1 = new ADGV.AdvancedDataGridView();
            this.Idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 73);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(171, 10);
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(252, 152);
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
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AutoGenerateContextFilters = true;
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idd,
            this.Content,
            this.Level,
            this.Type,
            this.Answer});
            this.advancedDataGridView1.DateWithTime = false;
            this.advancedDataGridView1.Location = new System.Drawing.Point(12, 200);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RowHeadersWidth = 51;
            this.advancedDataGridView1.RowTemplate.Height = 29;
            this.advancedDataGridView1.Size = new System.Drawing.Size(869, 188);
            this.advancedDataGridView1.TabIndex = 8;
            this.advancedDataGridView1.TimeFilter = false;
            // 
            // Idd
            // 
            this.Idd.HeaderText = "No.";
            this.Idd.MinimumWidth = 22;
            this.Idd.Name = "Idd";
            this.Idd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Idd.Width = 125;
            // 
            // Content
            // 
            this.Content.HeaderText = "Content";
            this.Content.MinimumWidth = 22;
            this.Content.Name = "Content";
            this.Content.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Content.Width = 125;
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.MinimumWidth = 22;
            this.Level.Name = "Level";
            this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Level.Width = 125;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 22;
            this.Type.Name = "Type";
            this.Type.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Type.Width = 125;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Answer";
            this.Answer.MinimumWidth = 22;
            this.Answer.Name = "Answer";
            this.Answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Answer.Width = 125;
            // 
            // ListQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 760);
            this.Controls.Add(this.advancedDataGridView1);
            this.Controls.Add(this.delQues);
            this.Controls.Add(this.editQues);
            this.Controls.Add(this.addQues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchQues);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Name = "ListQuestionBank";
            this.Text = "ListQuestionBank";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
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
        private ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
    }
}