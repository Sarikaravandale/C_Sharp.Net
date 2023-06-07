using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_System
{
    public partial class frm_Add_Employee_Details : Form
    {
        public frm_Add_Employee_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Employee_Management_System;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
       

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }

        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Employee_Details";

            Cnt = Convert.ToInt32( Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Emp_id) from Employee_Details";

                Cnt = Convert.ToInt32( Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 101;
            }
            tb_ID.Text = Convert.ToString(Cnt);
            Con_Close();
        }
        void Clear_Controls()
        {
            tb_ID.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            dtp_DOB.Text = "01-01-2009";
            cmb_Designation.SelectedIndex = -1;

            tb_ID.Focus();
        }

        private void frm_Add_Employee_Details_Load(object sender, EventArgs e)
        {
            lbl_Username.Text = Common_Content.UName;
            Auto_Incr();
            tb_ID.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_ID.Text != "" && tb_Name.Text != "" && tb_Mob_No.Text != "" && cmb_Designation.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Employee_Details Values(@Id,@Nm,@MobNo,@Dob,@Des)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_ID.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Value.Date;
                Cmd.Parameters.Add("Des", SqlDbType.NVarChar).Value = cmb_Designation.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Con_Close();
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Auto_Incr();
            tb_ID.Focus();
        }

        private void btn_Employee_List_Click(object sender, EventArgs e)
        {
            frm_From_View_Employee_List Obj = new frm_From_View_Employee_List();
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
