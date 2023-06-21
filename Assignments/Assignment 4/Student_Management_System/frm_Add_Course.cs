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

namespace Student_Management_System
{
    public partial class frm_Add_Course : Form
    {
        public frm_Add_Course()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=S_Two_Student_Management_System;Integrated Security=True");
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
        void Auto_Incr()
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) from Course_Details";

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if (Cnt > 0)
            {
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Course_Id) from Course_Details";

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

                Cnt = Cnt + 1;
            }
            else
            {
                Cnt = 101;
            }

            tb_Course_Id.Text = Convert.ToString(Cnt);

            Con_Close();
        }
        void Clear_Controls()
        {
            tb_Course_Id.Clear();
            tb_Course_Name.Clear();

            Auto_Incr();
        }
        private void frm_Add_Course_Load(object sender, EventArgs e)
        {
            Auto_Incr();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();

            if (tb_Course_Id.Text != "" && tb_Course_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Course_Details values(@Id, @Nm)";

                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = tb_Course_Id.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.NVarChar).Value = tb_Course_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("First Fill All Fields", "Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Clear_Controls();

            Con_Close();
        }

    }
}
