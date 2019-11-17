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
    public partial class MenuInputPayment : UserControl
    {

        DataTable dt = new DataTable();
        private string statusBooking = "B";
        private string statusPaid = "I";

        public MenuInputPayment()
        {
            InitializeComponent();
            GetBooking();
            tbRemainingPayment.Enabled = false;
            tbBalance.Enabled = false;
        }

        private void GetBooking()
        {
            SqlCommand command = new SqlCommand("select * from Pemesanan where Pemesanan.Status='" + statusBooking + "'", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            cbBookingId.DisplayMember = "IdPemesanan";
            cbBookingId.ValueMember = "IdPemesanan";
            cbBookingId.DataSource = dt;
        }

        int hargaPerMalam, lamaTinggal, jumlahFasilitas, hargaFasilitas, dibayar, kembalian, totalPembayaran;

        private void CbBookingId_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand commandMalam = new SqlCommand("SELECT Pemesanan.HargaPerMalam from Pemesanan where Pemesanan.IdPemesanan = '"+cbBookingId.SelectedValue.ToString()+"'", Env.con);
            Env.con.Open();
            hargaPerMalam = Convert.ToInt32(commandMalam.ExecuteScalar());
            Env.con.Close();

            SqlCommand commandLama = new SqlCommand("SELECT Pemesanan.LamaTinggal from Pemesanan where Pemesanan.IdPemesanan = '" + cbBookingId.SelectedValue.ToString() + "'", Env.con);
            Env.con.Open();
            lamaTinggal = Convert.ToInt32(commandLama.ExecuteScalar());
            Env.con.Close();

            SqlCommand commandJumlahFasilitas = new SqlCommand("SELECT PemesananDetail.JumlahFasilitasTambahan from PemesananDetail, Pemesanan where PemesananDetail.IdPemesanan = '" + cbBookingId.SelectedValue.ToString() + "'", Env.con);
            Env.con.Open();
            jumlahFasilitas = Convert.ToInt32(commandJumlahFasilitas.ExecuteScalar());
            Env.con.Close();

            SqlCommand commandHargaFasilitas = new SqlCommand("SELECT PemesananDetail.HargaSatuan from PemesananDetail where PemesananDetail.IdPemesanan = '" + cbBookingId.SelectedValue.ToString() + "'", Env.con);
            Env.con.Open();
            hargaFasilitas = Convert.ToInt32(commandHargaFasilitas.ExecuteScalar());
            Env.con.Close();

            totalPembayaran = (hargaPerMalam * lamaTinggal) + (jumlahFasilitas * hargaFasilitas);

            tbRemainingPayment.Text = totalPembayaran.ToString();
        }

        private void TbPayment_TextChanged(object sender, EventArgs e)
        {
            dibayar = Convert.ToInt32(tbPayment.Text);
            kembalian = dibayar - totalPembayaran;
            tbBalance.Text = kembalian.ToString();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into Pembayaran values ('" + dtpPaymentDate.Value.ToString("yyyy-MM-dd") + "', '" + cbBookingId.SelectedValue.ToString() + "', '" + Form1.idUser + "', '" + totalPembayaran + "')", Env.con);
                Env.con.Open();
                command.ExecuteNonQuery();
                Env.con.Close();

                SqlCommand command1 = new SqlCommand("update Pemesanan set Status='" + statusPaid + "' where Pemesanan.IdPemesanan='" + cbBookingId.SelectedValue.ToString() + "'", Env.con);
                Env.con.Open();
                command1.ExecuteNonQuery();
                Env.con.Close();

                MessageBox.Show("Success");
                GetBooking();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
