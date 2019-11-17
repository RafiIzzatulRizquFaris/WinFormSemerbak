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
    public partial class MenuManageBooking : UserControl
    {

        private int id;
        DataTable dt = new DataTable();

        public MenuManageBooking()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            SqlCommand command = new SqlCommand("Select Pemesanan.IdPemesanan, Pemesanan.WaktuMasukHotel, Penghuni.NamaPenghuni, Kamar.NomorKamar, Karyawan.NamaKaryawan from Pemesanan, Penghuni, Kamar, Karyawan where (Pemesanan.IdKaryawan = Karyawan.IdKaryawan and Pemesanan.IdPenghuni = Penghuni.IdPenghuni and Pemesanan.IdKamar = Kamar.IdKamar)", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select Pemesanan.IdPemesanan, Pemesanan.TglPemesanan, Pemesanan.WaktuMasukHotel, Penghuni.NamaPenghuni, Kamar.NomorKamar, Karyawan.NamaKaryawan from Pemesanan, Penghuni, Kamar, Karyawan where (Pemesanan.IdKaryawan = Karyawan.IdKaryawan and Pemesanan.IdPenghuni = Penghuni.IdPenghuni and Pemesanan.IdKamar = Kamar.IdKamar) AND (Karyawan.NamaKaryawan = '"+tbSearch.Text+ "' or Penghuni.NamaPenghuni = '" + tbSearch.Text + "' or Kamar.NomorKamar = '" + tbSearch.Text + "'", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE Pemesanan set Status=@status where Pemesanan.IdPemesanan='" + id + "'", Env.con);
            Env.con.Open();
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@status", "C");
            command.ExecuteNonQuery();
            Env.con.Close();

            GetData();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString());
        }
    }
}
