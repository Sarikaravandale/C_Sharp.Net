using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_From_View_Employee_List : Form
    {
        public frm_From_View_Employee_List()
        {
            InitializeComponent();
        }

        private void frm_From_View_Employee_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employee_Management_SystemDataSet1.Employee_Details' table. You can move, or remove it, as needed.
            this.employee_DetailsTableAdapter1.Fill(this.employee_Management_SystemDataSet1.Employee_Details);

            lbl_Username.Text = Common_Content.UName;

        }

        private void btn_Add_New_Employee_Click(object sender, EventArgs e)
        { 
                frm_Add_Employee_Details Obj = new frm_Add_Employee_Details();
                Obj.Show();
                this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
             frm_Login Obj = new frm_Login();
             Obj.Show();
             this.Hide();
        }
    }
}
