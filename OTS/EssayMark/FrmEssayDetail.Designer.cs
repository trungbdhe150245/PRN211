namespace OTS.EssayMark
{
    partial class FrmEssayDetail
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpSubmitTime = new System.Windows.Forms.DateTimePicker();
            this.dtpDuration = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nudFontSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.richtxtSolution = new System.Windows.Forms.RichTextBox();
            this.richtxtQuestion = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(434, 49);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(172, 27);
            this.txtId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Solution";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "SubmitDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(674, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duration";
            // 
            // dtpSubmitTime
            // 
            this.dtpSubmitTime.Enabled = false;
            this.dtpSubmitTime.Location = new System.Drawing.Point(759, 49);
            this.dtpSubmitTime.Name = "dtpSubmitTime";
            this.dtpSubmitTime.Size = new System.Drawing.Size(185, 27);
            this.dtpSubmitTime.TabIndex = 17;
            // 
            // dtpDuration
            // 
            this.dtpDuration.Enabled = false;
            this.dtpDuration.Location = new System.Drawing.Point(759, 95);
            this.dtpDuration.Name = "dtpDuration";
            this.dtpDuration.Size = new System.Drawing.Size(124, 27);
            this.dtpDuration.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(881, 772);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 20;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 50);
            this.label2.TabIndex = 21;
            this.label2.Text = "Essay Review";
            // 
            // nudFontSize
            // 
            this.nudFontSize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudFontSize.Location = new System.Drawing.Point(923, 162);
            this.nudFontSize.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFontSize.Name = "nudFontSize";
            this.nudFontSize.Size = new System.Drawing.Size(47, 27);
            this.nudFontSize.TabIndex = 22;
            this.nudFontSize.ValueChanged += new System.EventHandler(this.nudFontSize_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(881, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Size";
            // 
            // richtxtSolution
            // 
            this.richtxtSolution.Location = new System.Drawing.Point(12, 406);
            this.richtxtSolution.Name = "richtxtSolution";
            this.richtxtSolution.Size = new System.Drawing.Size(963, 349);
            this.richtxtSolution.TabIndex = 24;
            this.richtxtSolution.Text = "";
            // 
            // richtxtQuestion
            // 
            this.richtxtQuestion.Location = new System.Drawing.Point(12, 201);
            this.richtxtQuestion.Name = "richtxtQuestion";
            this.richtxtQuestion.Size = new System.Drawing.Size(963, 148);
            this.richtxtQuestion.TabIndex = 25;
            this.richtxtQuestion.Text = "";
            // 
            // FrmEssayDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 821);
            this.Controls.Add(this.richtxtQuestion);
            this.Controls.Add(this.richtxtSolution);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudFontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpDuration);
            this.Controls.Add(this.dtpSubmitTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmEssayDetail";
            this.Text = "Essay Mark";
            this.Load += new System.EventHandler(this.FrmEssayMark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpSubmitTime;
        private System.Windows.Forms.DateTimePicker dtpDuration;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudFontSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richtxtSolution;
        private System.Windows.Forms.RichTextBox richtxtQuestion;
    }
}