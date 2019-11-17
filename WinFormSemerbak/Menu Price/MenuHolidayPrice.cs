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
    public partial class MenuHolidayPrice : UserControl
    {

        DataTable dt = new DataTable();

        public MenuHolidayPrice()
        {
            InitializeComponent();
            GetData();
            GetRoomType();
        }

        private void GetData()
        {
            SqlCommand command = new SqlCommand("select TipeKamar.*, HargaFluktuatif.* from TipeKamar, Kamar, HargaFluktuatif where TipeKamar.IdTipeKamar = HargaFluktuatif.IdTipeKamar and TipeKamar.IdTipeKamar = Kamar.IdTipeKamar", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select TipeKamar.*, HargaFluktuatif.* from TipeKamar, Kamar, HargaFluktuatif where (TipeKamar.IdTipeKamar = HargaFluktuatif.IdTipeKamar and TipeKamar.IdTipeKamar = Kamar.IdTipeKamar) and (Kamar.IdKamar = '"+tbSearch.Text+ "' or Kamar.Lantai = '" + tbSearch.Text + "' and Kamar.NomorKamar = '" + tbSearch.Text + "' or TipeKamar.NamaTipeKamar = '" + tbSearch.Text + "')", Env.con);
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
                SqlCommand command = new SqlCommand("insert into HargaFluktuatif Values('"+cbRoomType.SelectedValue.ToString()+ "', '"+tbPercentage.Text+ "', '"+dtpBeginDate.Value.ToString("yyyy-MM-dd")+ "', '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "')", Env.con);
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
