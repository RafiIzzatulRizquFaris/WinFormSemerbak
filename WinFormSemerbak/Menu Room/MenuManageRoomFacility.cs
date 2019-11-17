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

namespace WinFormSemerbak.Menu_Room
{
    public partial class MenuManageRoomFacility : UserControl
    {

        DataTable dt = new DataTable();
        private int jumlah = 1;

        public MenuManageRoomFacility()
        {
            InitializeComponent();
            GetData();
            GetRoomType();
            GetFacilityName();
        }

        private void GetFacilityName()
        {
            SqlCommand command = new SqlCommand("select * from Fasilitas", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            cbfacilityName.DataSource = dt;
            cbfacilityName.DisplayMember = "NamaFasilitas";
            cbfacilityName.ValueMember = "IdFasilitas";
        }

        private void GetRoomType()
        {
            SqlCommand command = new SqlCommand("Select * From TipeKamar", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            cbRoomType.ValueMember = "IdTipeKamar";
            cbRoomType.DisplayMember = "NamaTipeKamar";
            cbRoomType.DataSource = dt;
        }

        private void GetData()
        {
            SqlCommand command = new SqlCommand("select kamar.*, Fasilitas.*, FasilitasBerdasarkanTipeKamar.IdFasilitas from Kamar, FasilitasBerdasarkanTipeKamar, Fasilitas where (FasilitasBerdasarkanTipeKamar.idTipeKamar = kamar.idTipekamar and FasilitasBerdasarkanTipeKamar.idfasilitas = fasilitas.idfasilitas)", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select kamar.*, Fasilitas.*, FasilitasBerdasarkanTipeKamar.IdFasilitas from Kamar, FasilitasBerdasarkanTipeKamar, Fasilitas where (FasilitasBerdasarkanTipeKamar.idTipeKamar = kamar.idTipekamar and FasilitasBerdasarkanTipeKamar.idfasilitas = fasilitas.idfasilitas) and ((Kamar.IdKamar = '" + tbSearch.Text + "' or Kamar.NomorKamar = '" + tbSearch.Text + "') or (Fasilitas.IdFasilitas = '" + tbSearch.Text + "' or Fasilitas.NamaFasilitas = '" + tbSearch.Text + "'))", Env.con);
                Env.con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(sdr);
                Env.con.Close();

                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("insert into FasilitasBerdasarkanTipeKamar Values('" + cbfacilityName.SelectedValue.ToString() + "', '" + cbRoomType.SelectedValue.ToString() + "', '" + jumlah + "')", Env.con);
                Env.con.Open();
                command.ExecuteNonQuery();
                Env.con.Close();
                GetData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
