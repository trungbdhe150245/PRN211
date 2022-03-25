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
            this.ClassCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnClassSearch = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.cbSearchOption = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Class";
            // 
            // txtClassSearch
            // 
            this.txtClassSearch.ForeColor = System.Drawing.Color.Black;
            this.txtClassSearch.Location = new System.Drawing.Point(519, 108);
            this.txtClassSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtClassSearch.Name = "txtClassSearch";
            this.txtClassSearch.Size = new System.Drawing.Size(259, 27);
            this.txtClassSearch.TabIndex = 2;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AllowUserToAddRows = false;
            this.dgvClasses.AllowUserToDeleteRows = false;
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassCode,
            this.ClassName,
            this.View});
            this.dgvClasses.Location = new System.Drawing.Point(39, 174);
            this.dgvClasses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.ReadOnly = true;
            this.dgvClasses.RowHeadersWidth = 51;
            this.dgvClasses.RowTemplate.Height = 25;
            this.dgvClasses.Size = new System.Drawing.Size(832, 324);
            this.dgvClasses.TabIndex = 3;
            this.dgvClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellContentClick);
            // 
            // ClassCode
            // 
            this.ClassCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ClassCode.HeaderText = "ClassCode";
            this.ClassCode.MinimumWidth = 6;
            this.ClassCode.Name = "ClassCode";
            this.ClassCode.ReadOnly = true;
            this.ClassCode.Width = 106;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "ClassName";
            this.ClassName.MinimumWidth = 6;
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            this.ClassName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // View
            // 
            this.View.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.View.HeaderText = "View";
            this.View.MinimumWidth = 6;
            this.View.Name = "View";
            this.View.ReadOnly = true;
            this.View.Width = 47;
            // 
            // btnClassSearch
            // 
            this.btnClassSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClassSearch.Location = new System.Drawing.Point(785, 106);
            this.btnClassSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClassSearch.Name = "btnClassSearch";
            this.btnClassSearch.Size = new System.Drawing.Size(86, 31);
            this.btnClassSearch.TabIndex = 4;
            this.btnClassSearch.Text = "Search";
            this.btnClassSearch.UseVisualStyleBackColor = true;
            this.btnClassSearch.Click += new System.EventHandler(this.btnClassSearch_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddClass.Location = new System.Drawing.Point(261, 532);
            this.btnAddClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(119, 52);
            this.btnAddClass.TabIndex = 5;
            this.btnAddClass.Text = "Add New";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditClass.Location = new System.Drawing.Point(386, 532);
            this.btnEditClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(119, 52);
            this.btnEditClass.TabIndex = 6;
            this.btnEditClass.Text = "Edit";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteClass.Location = new System.Drawing.Point(512, 532);
            this.btnDeleteClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(119, 52);
            this.btnDeleteClass.TabIndex = 7;
            this.btnDeleteClass.Text = "Delete";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);
            // 
            // cbSearchOption
            // 
            this.cbSearchOption.FormattingEnabled = true;
            this.cbSearchOption.Location = new System.Drawing.Point(362, 108);
            this.cbSearchOption.Name = "cbSearchOption";
            this.cbSearchOption.Size = new System.Drawing.Size(151, 28);
            this.cbSearchOption.TabIndex = 8;
            this.cbSearchOption.SelectedIndexChanged += new System.EventHandler(this.cbSearchOption_SelectedIndexChanged);
            // 
            // FrmManageClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.cbSearchOption);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnClassSearch);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.txtClassSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.ComboBox cbSearchOption;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewButtonColumn View;
    }
}