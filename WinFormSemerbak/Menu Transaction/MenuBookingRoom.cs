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
    public partial class MenuBookingRoom : UserControl
    {
        public MenuBookingRoom()
        {
            InitializeComponent();
            GetRoomType();
            GetRoomFloor();
            GetBookingType();
            GetAddFacility();
            Console.WriteLine(dtpAvailability.Value.ToString("yyyy-MM-dd H:mm:ss.fff"));
        }

        DataTable dtAvailableRoom = new DataTable();
        private int roomId, roomTypeId, roomPrice, breakFast, totalRoomPrice;
        private int fluck = 1;
        private string idFacility, quantity, priceItem, totalPriceItem;
        private string statusBook = "B";

        private void GetAddFacility()
        {
            SqlCommand command = new SqlCommand("Select * From FasilitasTambahan", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            cbAddFacility.DataSource = dt;
            cbAddFacility.ValueMember = "IdFasilitasTambahan";
            cbAddFacility.DisplayMember = "NamaFasilitasTambahan";
        }

        private void GetBookingType()
        {
            SqlCommand command = new SqlCommand("Select * From JenisPemesanan", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            cbBookingType.DataSource = dt;
            cbBookingType.ValueMember = "IdJenisPemesanan";
            cbBookingType.DisplayMember = "NamaJenisPemesanan";
        }

        private void GetRoomFloor()
        {
            SqlCommand command = new SqlCommand("Select * From Kamar", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            cbFloor.DataSource = dt;
            cbFloor.ValueMember = "Lantai";
            cbFloor.DisplayMember = "Lantai";
        }

        private void GetRoomType()
        {
            SqlCommand command = new SqlCommand("Select * From TipeKamar", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            cbRoomType.DataSource = dt;
            cbRoomType.ValueMember = "IdTipeKamar";
            cbRoomType.DisplayMember = "NamaTipeKamar";
        }

        private void LlAddNewGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddNewGuest newGuest = new AddNewGuest();
            newGuest.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select FasilitasTambahan.HargaFasilitasTambahan from FasilitasTambahan where FasilitasTambahan.IdFasilitasTambahan='"+cbAddFacility.SelectedValue.ToString()+"'", Env.con);
            Env.con.Open();
            int harga = Convert.ToInt32(command.ExecuteScalar());
            Env.con.Close();
            int totalHargaFasilitasTambahan = harga * Convert.ToInt32(tbQty.Text);
            dataGridView1.Rows.Add(cbAddFacility.SelectedValue.ToString(), tbQty.Text, harga, totalHargaFasilitasTambahan);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT Kamar.IdKamar, Kamar.IdTipeKamar, Kamar.Lantai, Kamar.NomorKamar FROM Kamar LEFT OUTER JOIN Pemesanan ON Kamar.IdKamar = Pemesanan.IdKamar WHERE(DATEADD(DAY, Pemesanan.LamaTinggal, Pemesanan.TglPemesanan) < '"+dtpAvailability.Value.ToString("yyyy-MM-dd")+"' or Pemesanan.IdKamar IS NULL) AND (Kamar.IdTipeKamar = '"+cbRoomType.SelectedValue.ToString()+"' and Kamar.Lantai = '"+cbFloor.SelectedValue.ToString()+"')", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dtAvailableRoom = new DataTable();
            dtAvailableRoom.Load(sdr);
            Env.con.Close();

            dataGridView2.DataSource = dtAvailableRoom;
        }

        private void TbGuestId_TextChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from Penghuni where Penghuni.NomorKTP ='"+tbGuestId.Text+"'", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            cbEmailGuest.DisplayMember = "Email";
            cbEmailGuest.ValueMember = "IdPenghuni";
            cbEmailGuest.DataSource = dt;
        }

        private void LlRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tbGuestId.Clear();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idFacility = dataGridView1.Rows[0].Cells[0].Value.ToString();
            quantity = dataGridView1.Rows[0].Cells[1].Value.ToString();
            priceItem = dataGridView1.Rows[0].Cells[2].Value.ToString();
            totalPriceItem = dataGridView1.Rows[0].Cells[3].Value.ToString();

            tbAddFacilityPrice.Text = totalPriceItem.ToString();

            if(tbAddFacilityPrice.TextLength > 0 && tbRoomPrice.TextLength > 0)
            {
                int totalMega = Convert.ToInt32(tbAddFacilityPrice.Text) + Convert.ToInt32(tbRoomPrice.Text);
                tbTotalPrice.Text = totalMega.ToString();
            }
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomId = Convert.ToInt32(dataGridView2.Rows[0].Cells[0].Value.ToString());
            roomTypeId = Convert.ToInt32(dataGridView2.Rows[0].Cells[1].Value.ToString());

            SqlCommand commandHarga = new SqlCommand("select HargaKamar.HargaKamar from HargaKamar where HargaKamar.IdTipeKamar='" + roomTypeId + "'", Env.con);
            Env.con.Open();
            roomPrice = Convert.ToInt32(commandHarga.ExecuteScalar());
            Env.con.Close();

            SqlCommand commandSarapan = new SqlCommand("select HargaKamar.HargaKamar from HargaKamar where HargaKamar.IdTipeKamar='" + roomTypeId + "'", Env.con);
            Env.con.Open();
            breakFast = Convert.ToInt32(commandSarapan.ExecuteScalar());
            Env.con.Close();

            totalRoomPrice = roomPrice + breakFast;
            tbRoomPrice.Text = totalRoomPrice.ToString();

            if (tbAddFacilityPrice.TextLength > 0 && tbRoomPrice.TextLength > 0)
            {
                int totalMega = Convert.ToInt32(tbAddFacilityPrice.Text) + Convert.ToInt32(tbRoomPrice.Text);
                tbTotalPrice.Text = totalMega.ToString();
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            SqlCommand commandIdPemesanan = new SqlCommand("select Pemesanan.IdPemesanan from Pemesanan where Pemesanan.IdPenghuni='" + cbEmailGuest.SelectedValue.ToString() + "'", Env.con);
            Env.con.Open();
            int idPemesanan = Convert.ToInt32(commandIdPemesanan.ExecuteScalar());
            Env.con.Close();

            SqlCommand commandInsertPemesanan = new SqlCommand("insert into Pemesanan values(@jenisbooking, @tglPemesanan, @tglMasuk, @idPenghuni, @idKamar, @totalHargaKamar, @fluck, @idFacility, @quantity, @longStay, @statusBook, @idKaryawan)", Env.con);
            Env.con.Open();
            commandInsertPemesanan.CommandType = CommandType.Text;
            commandInsertPemesanan.Parameters.AddWithValue("@jenisbooking", cbBookingType.SelectedValue.ToString());
            commandInsertPemesanan.Parameters.AddWithValue("@tglPemesanan", dtpAvailability.Value.ToString("yyyy-MM-dd"));
            commandInsertPemesanan.Parameters.AddWithValue("@tglMasuk", dtpMasuk.Value.ToString("yyyy-MM-dd"));
            commandInsertPemesanan.Parameters.AddWithValue("@idPenghuni", cbEmailGuest.SelectedValue.ToString());
            commandInsertPemesanan.Parameters.AddWithValue("@idKamar", roomId);
            commandInsertPemesanan.Parameters.AddWithValue("@totalHargaKamar", totalRoomPrice);
            commandInsertPemesanan.Parameters.AddWithValue("@fluck", fluck);
            commandInsertPemesanan.Parameters.AddWithValue("@idFacility", idFacility);
            commandInsertPemesanan.Parameters.AddWithValue("@quantity", quantity);
            commandInsertPemesanan.Parameters.AddWithValue("@longStay", tbLongStay.Text);
            commandInsertPemesanan.Parameters.AddWithValue("@statusBook", statusBook);
            commandInsertPemesanan.Parameters.AddWithValue("@idKaryawan", Form1.idUser);
            commandInsertPemesanan.ExecuteNonQuery();
            Env.con.Close();

            SqlCommand commandInsertDetail = new SqlCommand("insert into PemesananDetail values('" + idPemesanan + "', '" + idFacility + "', '" + quantity + "', '" + priceItem + "')", Env.con);
            Env.con.Open();
            commandInsertDetail.ExecuteNonQuery();
            Env.con.Close();

            SqlCommand commandInsertDate = new SqlCommand("Insert into WaktuTanggal values(Convert(datetime, @MyDate))", Env.con);
            Env.con.Open();
            commandInsertDate.CommandType = CommandType.Text;
            commandInsertDate.Parameters.AddWithValue("@MyDate", dtpMasuk.Value.ToLocalTime());
            commandInsertDate.ExecuteNonQuery();
            Env.con.Close();

            MessageBox.Show("Success Booking Room");
        }
    }
}
