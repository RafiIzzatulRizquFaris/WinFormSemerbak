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
    public partial class MenuManageGuest : UserControl
    {
        public MenuManageGuest()
        {
            InitializeComponent();
            GetData();
            GetVehicleType();
        }

        private int id;
        DataTable dt = new DataTable();

        private void GetVehicleType()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TipeKendaraan", Env.con);

            Env.con.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            Env.con.Close();

            cbVehicleType.DisplayMember = dataTable.Columns[1].ToString();
            cbVehicleType.ValueMember = dataTable.Columns[0].ToString();
            cbVehicleType.DataSource = dataTable;
        }

        private void GetData()
        {
            SqlCommand command = new SqlCommand("Select Penghuni.*, TipeKendaraan.NamaTipeKendaraan from Penghuni, TipeKendaraan WHERE Penghuni.IdTipeKendaraan = TipeKendaraan.IdTipeKendaraan", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Masuk Add");
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Penghuni VALUES (@nama, @ktp, @email, @hp, @plat, @tipekendaraan)", Env.con);
                Env.con.Open();
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@nama", tbGuestName.Text);
                command.Parameters.AddWithValue("@ktp", tbIdCardNumber.Text);
                command.Parameters.AddWithValue("@email", tbEmail.Text);
                command.Parameters.AddWithValue("@hp", tbPhoneNumber.Text);
                command.Parameters.AddWithValue("@plat", tbVehicleLicenseNumber.Text);
                command.Parameters.AddWithValue("@tipekendaraan", cbVehicleType.SelectedValue.ToString());

                command.ExecuteNonQuery();
                Env.con.Close();
                GetData();
                MessageBox.Show("Success Add Data");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE Penghuni SET NamaPenghuni=@nama, NomorKTP=@ktp, Email=@email, NomorHP=@hp, PlatNoKendaraan=@plat, IdTipeKendaraan=@tipekendaraan WHERE IdPenghuni=@id", Env.con);
            Env.con.Open();
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@nama", tbGuestName.Text);
            command.Parameters.AddWithValue("@ktp", tbIdCardNumber.Text);
            command.Parameters.AddWithValue("@email", tbEmail.Text);
            command.Parameters.AddWithValue("@hp", tbPhoneNumber.Text);
            command.Parameters.AddWithValue("@plat", tbVehicleLicenseNumber.Text);
            command.Parameters.AddWithValue("@tipekendaraan", cbVehicleType.SelectedValue.ToString());

            command.ExecuteNonQuery();
            Env.con.Close();
            GetData();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString());
            tbGuestName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            tbIdCardNumber.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            tbEmail.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            tbPhoneNumber.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            tbVehicleLicenseNumber.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete Penghuni where IdPenghuni='" + id + "'", Env.con);
            Env.con.Open();
            command.ExecuteNonQuery();
            Env.con.Close();
            GetData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select Penghuni.*, TipeKendaraan.NamaTipeKendaraan From Penghuni, TipeKendaraan where (Penghuni.IdTipeKendaraan = TipeKendaraan.IdTipeKendaraan) AND (NamaPenghuni='" + tbSearch.Text.Trim() + "'or Email='" + tbSearch.Text.Trim() + "'or NomorHP='" + tbSearch.Text.Trim() + "')", Env.con);
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
    }
}
