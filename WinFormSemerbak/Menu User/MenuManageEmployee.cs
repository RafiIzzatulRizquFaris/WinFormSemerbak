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

namespace WinFormSemerbak.Menu_User
{
    public partial class MenuManageEmployee : UserControl
    {

        private string gender;
        DataTable dt = new DataTable();

        public MenuManageEmployee()
        {
            InitializeComponent();
            tbEmployeeId.Enabled = false;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select * From Karyawan where Karyawan.NamaKaryawan='" + tbSearch.Text.Trim() + "'or Karyawan.Email='" + tbSearch.Text.Trim() + "'", Env.con);
                Env.con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(sdr);
                Env.con.Close();

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into Karyawan values(@nama, @email, @password, @lahir, @kelamin)", Env.con);
                Env.con.Open();
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@nama", tbEmployeeName.Text);
                command.Parameters.AddWithValue("@email", tbEmail.Text);
                command.Parameters.AddWithValue("@password", tbPassword.Text);
                command.Parameters.AddWithValue("@lahir", dtpBirthday.Value.ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@kelamin", gender);
                command.ExecuteNonQuery();
                Env.con.Close();
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void GetData()
        {
            SqlCommand command = new SqlCommand("Select * From Karyawan", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbEmployeeId.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            tbEmployeeName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            tbEmail.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            tbPassword.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE Karyawan where IdKaryawan='"+tbEmployeeId.Text+"'", Env.con);
            Env.con.Open();
            command.ExecuteNonQuery();
            Env.con.Close();
            GetData();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE Karyawan set NamaKaryawan=@nama, Email=@email, Password=@password, TglLahir=@lahir, JenisKelamin=@kelamin WHERE IdKaryawan'"+tbEmployeeId.Text+"'", Env.con);
            Env.con.Open();
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@nama", tbEmployeeName.Text);
            command.Parameters.AddWithValue("@email", tbEmail.Text);
            command.Parameters.AddWithValue("@password", tbPassword.Text);
            command.ExecuteNonQuery();
            Env.con.Close();
            GetData();
        }

        private void RbMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void RbFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }
    }
}
