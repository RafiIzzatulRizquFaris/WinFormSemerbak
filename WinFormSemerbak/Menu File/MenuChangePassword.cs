using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormSemerbak.Menu_File
{
    public partial class MenuChangePassword : UserControl
    {
        public MenuChangePassword()
        {
            InitializeComponent();
            tbOldPassword.PasswordChar = '*';
            tbConfirmPassword.PasswordChar = '*';
            tbNewPassword.Enabled = false;
            tbConfirmPassword.Enabled = false;
            btnConfirm.Enabled = false;
        }

        private void TbOldPassword_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Password from Karyawan where IdKaryawan='" + Form1.idUser + "'", Env.con);
            Env.con.Open();
            string passwordUser = (string)command.ExecuteScalar();
            Env.con.Close();

            if (tbOldPassword.Text == passwordUser)
            {
                label4.Text = "Your Password is True AF";
                label4.ForeColor = Color.DarkGreen;
                tbNewPassword.Enabled = true;
                tbConfirmPassword.Enabled = true;
                btnConfirm.Enabled = true;
            }
            else
            {
                label4.Text = "Your Password is Wrong";
                label4.ForeColor = Color.DarkRed;
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if(tbNewPassword.Text == tbConfirmPassword.Text)
            {
                SqlCommand command = new SqlCommand("update Karyawan set Password='"+tbNewPassword.Text+"' where IdKaryawan='"+Form1.idUser+"'", Env.con);
                Env.con.Open();
                command.ExecuteNonQuery();
                Env.con.Close();

                tbOldPassword.Clear();
                tbNewPassword.Clear();
                tbConfirmPassword.Clear();
                label4.Text = "";

                MessageBox.Show("Your Password is Updated");
            }
            else
            {
                MessageBox.Show("Your new and confirmation password is not same");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
