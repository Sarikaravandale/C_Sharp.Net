
namespace Employee_Management_System
{
    partial class frm_From_View_Employee_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_From_View_Employee_List));
            this.lbl_Employee_Detail_List = new System.Windows.Forms.Label();
            this.btn_Add_New_Employee = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Management_SystemDataSet1 = new Employee_Management_System.Employee_Management_SystemDataSet1();
            this.employeeDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_Management_SystemDataSet = new Employee_Management_System.Employee_Management_SystemDataSet();
            this.employee_DetailsTableAdapter = new Employee_Management_System.Employee_Management_SystemDataSetTableAdapters.Employee_DetailsTableAdapter();
            this.employee_DetailsTableAdapter1 = new Employee_Management_System.Employee_Management_SystemDataSet1TableAdapters.Employee_DetailsTableAdapter();
            this.lbl_Username = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Employee_Detail_List
            // 
            this.lbl_Employee_Detail_List.AutoSize = true;
            this.lbl_Employee_Detail_List.BackColor = System.Drawing.Color.PeachPuff;
            this.lbl_Employee_Detail_List.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Detail_List.ForeColor = System.Drawing.Color.Black;
            this.lbl_Employee_Detail_List.Location = new System.Drawing.Point(218, 28);
            this.lbl_Employee_Detail_List.Name = "lbl_Employee_Detail_List";
            this.lbl_Employee_Detail_List.Size = new System.Drawing.Size(429, 50);
            this.lbl_Employee_Detail_List.TabIndex = 0;
            this.lbl_Employee_Detail_List.Text = "Employee Detail List";
            // 
            // btn_Add_New_Employee
            // 
            this.btn_Add_New_Employee.BackColor = System.Drawing.Color.PeachPuff;
            this.btn_Add_New_Employee.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Employee.ForeColor = System.Drawing.Color.Black;
            this.btn_Add_New_Employee.Location = new System.Drawing.Point(303, 663);
            this.btn_Add_New_Employee.Name = "btn_Add_New_Employee";
            this.btn_Add_New_Employee.Size = new System.Drawing.Size(374, 48);
            this.btn_Add_New_Employee.TabIndex = 1;
            this.btn_Add_New_Employee.Text = "Add New Employee";
            this.btn_Add_New_Employee.UseVisualStyleBackColor = false;
            this.btn_Add_New_Employee.Click += new System.EventHandler(this.btn_Add_New_Employee_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_Logout.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_Logout.Location = new System.Drawing.Point(846, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(136, 50);
            this.btn_Logout.TabIndex = 10;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.designationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeeDetailsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(67, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 496);
            this.dataGridView1.TabIndex = 11;
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "Emp_Id";
            this.empIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            this.empIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designationDataGridViewTextBoxColumn
            // 
            this.designationDataGridViewTextBoxColumn.DataPropertyName = "Designation";
            this.designationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.designationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.designationDataGridViewTextBoxColumn.Name = "designationDataGridViewTextBoxColumn";
            this.designationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeDetailsBindingSource1
            // 
            this.employeeDetailsBindingSource1.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource1.DataSource = this.employee_Management_SystemDataSet1;
            // 
            // employee_Management_SystemDataSet1
            // 
            this.employee_Management_SystemDataSet1.DataSetName = "Employee_Management_SystemDataSet1";
            this.employee_Management_SystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeDetailsBindingSource
            // 
            this.employeeDetailsBindingSource.DataMember = "Employee_Details";
            this.employeeDetailsBindingSource.DataSource = this.employee_Management_SystemDataSet;
            // 
            // employee_Management_SystemDataSet
            // 
            this.employee_Management_SystemDataSet.DataSetName = "Employee_Management_SystemDataSet";
            this.employee_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_DetailsTableAdapter
            // 
            this.employee_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // employee_DetailsTableAdapter1
            // 
            this.employee_DetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Mongolian Baiti", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(-1, 0);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(125, 30);
            this.lbl_Username.TabIndex = 12;
            this.lbl_Username.Text = "Username";
            // 
            // frm_From_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_Add_New_Employee);
            this.Controls.Add(this.lbl_Employee_Detail_List);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_From_View_Employee_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Employee List";
            this.Load += new System.EventHandler(this.frm_From_View_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_Management_SystemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employee_Detail_List;
        private System.Windows.Forms.Button btn_Add_New_Employee;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Employee_Management_SystemDataSet employee_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource;
        private Employee_Management_SystemDataSetTableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn designationDataGridViewTextBoxColumn;
        private Employee_Management_SystemDataSet1 employee_Management_SystemDataSet1;
        private System.Windows.Forms.BindingSource employeeDetailsBindingSource1;
        private Employee_Management_SystemDataSet1TableAdapters.Employee_DetailsTableAdapter employee_DetailsTableAdapter1;
        private System.Windows.Forms.Label lbl_Username;
    }
}