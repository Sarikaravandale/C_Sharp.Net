﻿
namespace Student_Management_System
{
    partial class frm_Search_Student_Details
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
            this.lbl_Search_Student_Details = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mob_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Search_Student_Details
            // 
            this.lbl_Search_Student_Details.AutoSize = true;
            this.lbl_Search_Student_Details.BackColor = System.Drawing.Color.Pink;
            this.lbl_Search_Student_Details.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Search_Student_Details.Location = new System.Drawing.Point(196, 51);
            this.lbl_Search_Student_Details.Name = "lbl_Search_Student_Details";
            this.lbl_Search_Student_Details.Size = new System.Drawing.Size(577, 64);
            this.lbl_Search_Student_Details.TabIndex = 0;
            this.lbl_Search_Student_Details.Text = "Search Student Details";
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCA",
            "BBA",
            "BSC",
            "MCA",
            "MBA"});
            this.cmb_Course.Location = new System.Drawing.Point(443, 494);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(386, 50);
            this.cmb_Course.TabIndex = 5;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(443, 424);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(386, 49);
            this.dtp_DOB.TabIndex = 4;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(443, 266);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(386, 49);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(443, 341);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(386, 49);
            this.tb_Mob_No.TabIndex = 3;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(443, 195);
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(386, 49);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Pink;
            this.btn_Refresh.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(373, 610);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(187, 55);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click_1);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Pink;
            this.btn_Search.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(835, 196);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(118, 42);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbl_Course.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(142, 509);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(110, 35);
            this.lbl_Course.TabIndex = 17;
            this.lbl_Course.Text = "Course";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbl_DOB.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(146, 429);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(85, 35);
            this.lbl_DOB.TabIndex = 15;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Mob_No
            // 
            this.lbl_Mob_No.AutoSize = true;
            this.lbl_Mob_No.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbl_Mob_No.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mob_No.Location = new System.Drawing.Point(142, 346);
            this.lbl_Mob_No.Name = "lbl_Mob_No";
            this.lbl_Mob_No.Size = new System.Drawing.Size(127, 35);
            this.lbl_Mob_No.TabIndex = 13;
            this.lbl_Mob_No.Text = "Mob No";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbl_Name.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(146, 271);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(95, 35);
            this.lbl_Name.TabIndex = 11;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.Color.MediumAquamarine;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Mongolian Baiti", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.Location = new System.Drawing.Point(146, 196);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(121, 35);
            this.lbl_Roll_No.TabIndex = 9;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // frm_Search_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.ControlBox = false;
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Mob_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Search_Student_Details);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Search_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Search_Student_Details;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mob_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
    }
}