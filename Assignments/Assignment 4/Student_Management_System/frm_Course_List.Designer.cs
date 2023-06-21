
namespace Student_Management_System
{
    partial class frm_Course_List
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
            this.lbl_Course_List = new System.Windows.Forms.Label();
            this.dgv_Course_List = new System.Windows.Forms.DataGridView();
            this.s_Two_Student_Management_SystemDataSet = new Student_Management_System.S_Two_Student_Management_SystemDataSet();
            this.courseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.course_DetailsTableAdapter = new Student_Management_System.S_Two_Student_Management_SystemDataSetTableAdapters.Course_DetailsTableAdapter();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_Two_Student_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Course_List
            // 
            this.lbl_Course_List.AutoSize = true;
            this.lbl_Course_List.BackColor = System.Drawing.Color.DarkSalmon;
            this.lbl_Course_List.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_List.Location = new System.Drawing.Point(333, 51);
            this.lbl_Course_List.Name = "lbl_Course_List";
            this.lbl_Course_List.Size = new System.Drawing.Size(307, 64);
            this.lbl_Course_List.TabIndex = 0;
            this.lbl_Course_List.Text = "Course List";
            // 
            // dgv_Course_List
            // 
            this.dgv_Course_List.AllowUserToAddRows = false;
            this.dgv_Course_List.AllowUserToDeleteRows = false;
            this.dgv_Course_List.AutoGenerateColumns = false;
            this.dgv_Course_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Course_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Course_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Course_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.courseNameDataGridViewTextBoxColumn});
            this.dgv_Course_List.DataSource = this.courseDetailsBindingSource;
            this.dgv_Course_List.Location = new System.Drawing.Point(37, 167);
            this.dgv_Course_List.Name = "dgv_Course_List";
            this.dgv_Course_List.ReadOnly = true;
            this.dgv_Course_List.RowHeadersWidth = 51;
            this.dgv_Course_List.RowTemplate.Height = 24;
            this.dgv_Course_List.Size = new System.Drawing.Size(902, 556);
            this.dgv_Course_List.TabIndex = 1;
            // 
            // s_Two_Student_Management_SystemDataSet
            // 
            this.s_Two_Student_Management_SystemDataSet.DataSetName = "S_Two_Student_Management_SystemDataSet";
            this.s_Two_Student_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseDetailsBindingSource
            // 
            this.courseDetailsBindingSource.DataMember = "Course_Details";
            this.courseDetailsBindingSource.DataSource = this.s_Two_Student_Management_SystemDataSet;
            // 
            // course_DetailsTableAdapter
            // 
            this.course_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseNameDataGridViewTextBoxColumn
            // 
            this.courseNameDataGridViewTextBoxColumn.DataPropertyName = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.HeaderText = "Course_Name";
            this.courseNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseNameDataGridViewTextBoxColumn.Name = "courseNameDataGridViewTextBoxColumn";
            this.courseNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Course_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.ControlBox = false;
            this.Controls.Add(this.dgv_Course_List);
            this.Controls.Add(this.lbl_Course_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Course_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Course List";
            this.Load += new System.EventHandler(this.frm_Course_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Course_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s_Two_Student_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Course_List;
        private System.Windows.Forms.DataGridView dgv_Course_List;
        private S_Two_Student_Management_SystemDataSet s_Two_Student_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource courseDetailsBindingSource;
        private S_Two_Student_Management_SystemDataSetTableAdapters.Course_DetailsTableAdapter course_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseNameDataGridViewTextBoxColumn;
    }
}