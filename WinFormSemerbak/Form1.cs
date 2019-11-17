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

namespace WinFormSemerbak
{
    public partial class Form1 : Form
    {
        public static string emailUser;
        public static int idUser;
        public Form1()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.TextLength > 0 && tbPassword.TextLength > 0)
            {
                string query = "select * from Karyawan where email='"+tbUsername.Text.Trim()+"' and password='"+tbPassword.Text.Trim()+"'";
                Env.con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(query, Env.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Env.con.Close();

                if (dt.Rows.Count == 1)
                {

                    emailUser = dt.Rows[0]["email"].ToString();
                    idUser = Convert.ToInt32(dt.Rows[0]["IdKaryawan"]);
                    MessageBox.Show("Success");
                    this.Hide();
                    MainMenu main = new MainMenu();
                    main.Show();
                }
            }
        }

        private void TbUsername_MouseClick(object sender, MouseEventArgs e)
        {
            tbUsername.Clear();
        }

        private void TbPassword_MouseClick(object sender, MouseEventArgs e)
        {
            tbPassword.Clear();
        }
    }
}
