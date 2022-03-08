namespace OTS
{
    partial class FrmManageClass
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
            this.txtClassSearch = new System.Windows.Forms.TextBox();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.btnClassSearch = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(308, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Class";
            // 
            // txtClassSearch
            // 
            this.txtClassSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtClassSearch.Location = new System.Drawing.Point(244, 87);
            this.txtClassSearch.Name = "txtClassSearch";
            this.txtClassSearch.Size = new System.Drawing.Size(227, 23);
            this.txtClassSearch.TabIndex = 2;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToOrderColumns = true;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(34, 139);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowTemplate.Height = 25;
            this.dgvClasses.Size = new System.Drawing.Size(728, 235);
            this.dgvClasses.TabIndex = 3;
            // 
            // btnClassSearch
            // 
            this.btnClassSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClassSearch.Location = new System.Drawing.Point(477, 87);
            this.btnClassSearch.Name = "btnClassSearch";
            this.btnClassSearch.Size = new System.Drawing.Size(75, 23);
            this.btnClassSearch.TabIndex = 4;
            this.btnClassSearch.Text = "Search";
            this.btnClassSearch.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddClass.Location = new System.Drawing.Point(228, 399);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(104, 39);
            this.btnAddClass.TabIndex = 5;
            this.btnAddClass.Text = "Add New";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditClass.Location = new System.Drawing.Point(338, 399);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(104, 39);
            this.btnEditClass.TabIndex = 6;
            this.btnEditClass.Text = "Edit";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteClass.Location = new System.Drawing.Point(448, 399);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(104, 39);
            this.btnDeleteClass.TabIndex = 7;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            // 
            // FrmManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnClassSearch);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.txtClassSearch);
            this.Controls.Add(this.label1);
            this.Name = "FrmManageClass";
            this.Text = "Manage Class";
            this.Load += new System.EventHandler(this.FrmManageClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClassSearch;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Button btnClassSearch;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnDeleteClass;
    }
}