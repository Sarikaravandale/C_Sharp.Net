
namespace Student_Management_System
{
    partial class frm_Add_Course
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
            this.lbl_Add_Course = new System.Windows.Forms.Label();
            this.lbl_Course_Id = new System.Windows.Forms.Label();
            this.lbl_Course_Name = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Course_Id = new System.Windows.Forms.TextBox();
            this.tb_Course_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Add_Course
            // 
            this.lbl_Add_Course.AutoSize = true;
            this.lbl_Add_Course.BackColor = System.Drawing.Color.Linen;
            this.lbl_Add_Course.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_Course.Location = new System.Drawing.Point(316, 45);
            this.lbl_Add_Course.Name = "lbl_Add_Course";
            this.lbl_Add_Course.Size = new System.Drawing.Size(303, 62);
            this.lbl_Add_Course.TabIndex = 0;
            this.lbl_Add_Course.Text = "Add Course";
            // 
            // lbl_Course_Id
            // 
            this.lbl_Course_Id.AutoSize = true;
            this.lbl_Course_Id.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Id.Location = new System.Drawing.Point(177, 255);
            this.lbl_Course_Id.Name = "lbl_Course_Id";
            this.lbl_Course_Id.Size = new System.Drawing.Size(153, 35);
            this.lbl_Course_Id.TabIndex = 1;
            this.lbl_Course_Id.Text = "Course ID";
            // 
            // lbl_Course_Name
            // 
            this.lbl_Course_Name.AutoSize = true;
            this.lbl_Course_Name.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course_Name.Location = new System.Drawing.Point(177, 487);
            this.lbl_Course_Name.Name = "lbl_Course_Name";
            this.lbl_Course_Name.Size = new System.Drawing.Size(198, 35);
            this.lbl_Course_Name.TabIndex = 2;
            this.lbl_Course_Name.Text = "Course Name";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Linen;
            this.btn_Save.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(387, 655);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(150, 54);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Course_Id
            // 
            this.tb_Course_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Id.Location = new System.Drawing.Point(521, 250);
            this.tb_Course_Id.Name = "tb_Course_Id";
            this.tb_Course_Id.Size = new System.Drawing.Size(303, 41);
            this.tb_Course_Id.TabIndex = 4;
            // 
            // tb_Course_Name
            // 
            this.tb_Course_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Course_Name.Location = new System.Drawing.Point(521, 482);
            this.tb_Course_Name.Name = "tb_Course_Name";
            this.tb_Course_Name.Size = new System.Drawing.Size(303, 41);
            this.tb_Course_Name.TabIndex = 5;
            // 
            // frm_Add_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.ControlBox = false;
            this.Controls.Add(this.tb_Course_Name);
            this.Controls.Add(this.tb_Course_Id);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Course_Name);
            this.Controls.Add(this.lbl_Course_Id);
            this.Controls.Add(this.lbl_Add_Course);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_Course";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Course";
            this.Load += new System.EventHandler(this.frm_Add_Course_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_Course;
        private System.Windows.Forms.Label lbl_Course_Id;
        private System.Windows.Forms.Label lbl_Course_Name;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Course_Id;
        private System.Windows.Forms.TextBox tb_Course_Name;
    }
}