using System;
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
    public partial class MDI_Student_App : Form
    {
        public MDI_Student_App()
        {
            InitializeComponent();
        }
        private void MDI_Student_App_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = Common_Content.UName;
        }
        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Add_Student_Details obj = new frm_Add_Student_Details();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }
        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frm_Search_Student_Details obj = new frm_Search_Student_Details();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }
        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Update_Student_Details obj = new frm_Update_Student_Details();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }
        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_View_Student_List obj = new frm_View_Student_List ();
            obj.MdiParent = this;
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You want To Logout???", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if(Res == DialogResult.Yes)
            {
                frm_Login obj = new frm_Login();
                obj.Show();
                this.Hide();
            }
        }
    }
}