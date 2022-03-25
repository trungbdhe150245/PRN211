
namespace OTS.StudenDashBoard
{
    partial class StudentDashBoard
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
            this.Id = new System.Windows.Forms.Label();
            this.StuCode = new System.Windows.Forms.TextBox();
            this.StuName = new System.Windows.Forms.TextBox();
            this.NameStu = new System.Windows.Forms.Label();
            this.StuClass = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ViewResult = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Id.Location = new System.Drawing.Point(10, 53);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(103, 21);
            this.Id.TabIndex = 1;
            this.Id.Text = "Student Code";
            // 
            // StuCode
            // 
            this.StuCode.Enabled = false;
            this.StuCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.StuCode.Location = new System.Drawing.Point(130, 56);
            this.StuCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StuCode.Name = "StuCode";
            this.StuCode.Size = new System.Drawing.Size(135, 23);
            this.StuCode.TabIndex = 2;
            this.StuCode.UseWaitCursor = true;
            // 
            // StuName
            // 
            this.StuName.Enabled = false;
            this.StuName.Location = new System.Drawing.Point(130, 91);
            this.StuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StuName.Name = "StuName";
            this.StuName.Size = new System.Drawing.Size(135, 23);
            this.StuName.TabIndex = 3;
            // 
            // NameStu
            // 
            this.NameStu.AutoSize = true;
            this.NameStu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameStu.Location = new System.Drawing.Point(10, 88);
            this.NameStu.Name = "NameStu";
            this.NameStu.Size = new System.Drawing.Size(109, 21);
            this.NameStu.TabIndex = 4;
            this.NameStu.Text = "Student Name";
            // 
            // StuClass
            // 
            this.StuClass.Enabled = false;
            this.StuClass.Location = new System.Drawing.Point(130, 123);
            this.StuClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StuClass.Name = "StuClass";
            this.StuClass.Size = new System.Drawing.Size(135, 23);
            this.StuClass.TabIndex = 5;
            // 
            // Class
            // 
            this.Class.AutoSize = true;
            this.Class.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Class.Location = new System.Drawing.Point(10, 120);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(46, 21);
            this.Class.TabIndex = 6;
            this.Class.Text = "Class";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(358, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dash Board";
            // 
            // ViewResult
            // 
            this.ViewResult.AutoSize = true;
            this.ViewResult.Font = new System.Drawing.Font("Segoe UI", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ViewResult.Location = new System.Drawing.Point(326, 135);
            this.ViewResult.Name = "ViewResult";
            this.ViewResult.Size = new System.Drawing.Size(171, 37);
            this.ViewResult.TabIndex = 8;
            this.ViewResult.Text = "Recent Tests";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(66, 185);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(786, 308);
            this.dataGridView1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // StudentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 562);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ViewResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.StuClass);
            this.Controls.Add(this.NameStu);
            this.Controls.Add(this.StuName);
            this.Controls.Add(this.StuCode);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudentDashBoard";
            this.Text = "StudentDashBoard";
            this.Load += new System.EventHandler(this.StudentDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox StuCode;
        private System.Windows.Forms.TextBox StuName;
        private System.Windows.Forms.Label NameStu;
        private System.Windows.Forms.TextBox StuClass;
        private System.Windows.Forms.Label Class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ViewResult;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}