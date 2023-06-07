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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            lbl_Note.Text = "Enter Valid Username && Password";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if(tb_Username.Text == "a" && tb_Password.Text == "a")
            {
                MessageBox.Show("Login Successful");

                frm_Add_Employee_Details Obj = new frm_Add_Employee_Details();
                Obj.Show();
                this.Hide();
            }
            else
            {
                lbl_Note.Text = "Incooret Username And Password !!!";
                lbl_Note.ForeColor = Color.Red;
            }
            tb_Username.Clear();
            tb_Password.Clear();
        }
    }
}
