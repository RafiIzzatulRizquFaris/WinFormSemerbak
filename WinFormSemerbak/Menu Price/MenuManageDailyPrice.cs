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

namespace WinFormSemerbak.Menu_Price
{
    public partial class MenuManageDailyPrice : UserControl
    {

        DataTable dt = new DataTable();

        public MenuManageDailyPrice()
        {
            InitializeComponent();
            GetData();
            GetRoomTypeName();
            GetDayTypeName();
        }

        private void GetDayTypeName()
        {
            SqlCommand command = new SqlCommand("Select * From TipeHari", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            cbDayTypeName.DataSource = dt;
            cbDayTypeName.ValueMember = "IdTipeHari";
            cbDayTypeName.DisplayMember = "NamaTipeHari";
        }

        private void GetRoomTypeName()
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

        private void GetData()
        {
            SqlCommand command = new SqlCommand("select TipeKamar.*, HargaKamar.HargaKamar, HargaKamar.HargaSarapan, TipeHari.NamaTipeHari from TipeKamar, HargaKamar, TipeHari, Kamar where HargaKamar.IdTipeKamar = TipeKamar.IdTipeKamar and HargaKamar.IdTipeHari = TipeHari.IdTipeHari and Kamar.IdTipeKamar = TipeKamar.IdTipeKamar", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select TipeKamar.*, HargaKamar.HargaKamar, HargaKamar.HargaSarapan, TipeHari.NamaTipeHari from TipeKamar, HargaKamar, TipeHari, Kamar where (HargaKamar.IdTipeKamar = TipeKamar.IdTipeKamar and HargaKamar.IdTipeHari = TipeHari.IdTipeHari and Kamar.IdTipeKamar = TipeKamar.IdTipeKamar) and (Kamar.IdKamar = '"+tbSearch.Text+"' or Kamar.NomorKamar ='"+tbSearch.Text+"' or Kamar.Lantai = '"+tbSearch.Text+"' or TipeKamar.NamaTipeKamar = '"+tbSearch.Text+"')", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into HargaKamar Values ('"+cbRoomType.SelectedValue.ToString()+"', '"+cbDayTypeName.SelectedValue.ToString()+"', '"+tbRoomPrice.Text+"', '"+tbBreakfastPrice.Text+"')", Env.con);
                Env.con.Open();
                command.ExecuteNonQuery();
                Env.con.Close();
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
