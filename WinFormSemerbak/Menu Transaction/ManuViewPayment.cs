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

namespace WinFormSemerbak.Menu_Transaction
{
    public partial class ManuViewPayment : UserControl
    {

        DataTable dt = new DataTable();

        public ManuViewPayment()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            SqlCommand command = new SqlCommand("select Pembayaran.IdPembayaran, Pembayaran.TotalPembayaran, Pembayaran.TglPembayaran, Pemesanan.LamaTinggal, Pemesanan.WaktuMasukHotel, Penghuni.NamaPenghuni, Karyawan.NamaKaryawan, Kamar.NomorKamar, Pemesanan.Status From Pembayaran, Pemesanan, Karyawan, Penghuni, Kamar where (Pembayaran.IdPemesanan = Pemesanan.IdPemesanan and Pemesanan.IdKamar = Kamar.IdKamar and Pemesanan.IdKaryawan = Karyawan.IdKaryawan and Pemesanan.IdPenghuni = Penghuni.IdPenghuni)", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select Pembayaran.IdPembayaran, Pembayaran.TotalPembayaran, Pembayaran.TglPembayaran, Pemesanan.LamaTinggal, Pemesanan.WaktuMasukHotel, Penghuni.NamaPenghuni, Karyawan.NamaKaryawan, Kamar.NomorKamar, Pemesanan.Status From Pembayaran, Pemesanan, Karyawan, Penghuni, Kamar where (Pembayaran.IdPemesanan = Pemesanan.IdPemesanan and Pemesanan.IdKamar = Kamar.IdKamar and Pemesanan.IdKaryawan = Karyawan.IdKaryawan and Pemesanan.IdPenghuni = Penghuni.IdPenghuni) and (Kamar.NomorKamar = '" + tbSearch.Text+ "' or Karyawan.NamaKaryawan = '" + tbSearch.Text + "' or Penghuni.NamaPenghuni = '" + tbSearch.Text + "')", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
        }
    }
}
