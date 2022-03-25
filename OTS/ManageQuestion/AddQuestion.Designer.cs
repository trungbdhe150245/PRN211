
namespace OTS.ManageQuestion
{
    partial class AddQuestion
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
            this.Levels = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Subjects = new System.Windows.Forms.ComboBox();
            this.Types = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Content = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Question";
            // 
            // Levels
            // 
            this.Levels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Levels.FormattingEnabled = true;
            this.Levels.Location = new System.Drawing.Point(136, 89);
            this.Levels.Name = "Levels";
            this.Levels.Size = new System.Drawing.Size(151, 28);
            this.Levels.TabIndex = 1;
            this.Levels.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "SubjectCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Type";
            // 
            // Subjects
            // 
            this.Subjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subjects.FormattingEnabled = true;
            this.Subjects.Location = new System.Drawing.Point(456, 89);
            this.Subjects.Name = "Subjects";
            this.Subjects.Size = new System.Drawing.Size(151, 28);
            this.Subjects.TabIndex = 5;
            // 
            // Types
            // 
            this.Types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Types.FormattingEnabled = true;
            this.Types.Location = new System.Drawing.Point(136, 170);
            this.Types.Name = "Types";
            this.Types.Size = new System.Drawing.Size(151, 28);
            this.Types.TabIndex = 6;
            this.Types.SelectedIndexChanged += new System.EventHandler(this.Types_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Content";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 41);
            this.label6.TabIndex = 9;
            this.label6.Text = "Answer :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Add New Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 29);
            this.button3.TabIndex = 24;
            this.button3.Text = "Save Question";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(97, 300);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(353, 264);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // Content
            // 
            this.Content.Location = new System.Drawing.Point(456, 153);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(337, 120);
            this.Content.TabIndex = 27;
            this.Content.Text = "";
            // 
            // AddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 741);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Types);
            this.Controls.Add(this.Subjects);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Levels);
            this.Controls.Add(this.label1);
            this.Name = "AddQuestion";
            this.Text = "AddQuestion";
            this.Load += new System.EventHandler(this.AddQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Levels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Subjects;
        private System.Windows.Forms.ComboBox Types;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RichTextBox Content;
    }
}