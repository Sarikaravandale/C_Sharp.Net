﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management_System
{
    public partial class frm_Course_List : Form
    {
        public frm_Course_List()
        {
            InitializeComponent();
        }

        private void frm_Course_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 's_Two_Student_Management_SystemDataSet.Course_Details' table. You can move, or remove it, as needed.
            this.course_DetailsTableAdapter.Fill(this.s_Two_Student_Management_SystemDataSet.Course_Details);

        }
    }
}
