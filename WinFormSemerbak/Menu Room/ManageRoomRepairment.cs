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
    public partial class ManageRoomRepairment : UserControl
    {

        DataTable dt = new DataTable();
        private int id;

        public ManageRoomRepairment()
        {
            InitializeComponent();
            GetData();
            GetRoomNumber();
        }

        private void GetRoomNumber()
        {
            SqlCommand command = new SqlCommand("Select * from Kamar", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            cbRoomNumber.DataSource = dt;
            cbRoomNumber.DisplayMember = "NomorKamar";
            cbRoomNumber.ValueMember = "IdKamar";
        }

        private void GetData()
        {
            SqlCommand command = new SqlCommand("select Kamar.*, PerbaikanKamar.* from Kamar, PerbaikanKamar, TipeKamar where PerbaikanKamar.IdKamar = Kamar.IdKamar and Kamar.IdTipeKamar = TipeKamar.IdTipeKamar", Env.con);
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
                SqlCommand command = new SqlCommand("select Kamar.*, PerbaikanKamar.* from Kamar, PerbaikanKamar, TipeKamar where (PerbaikanKamar.IdKamar = Kamar.IdKamar and Kamar.IdTipeKamar = TipeKamar.IdTipeKamar) and(Kamar.Lantai = '"+tbSearch.Text+"' or Kamar.NomorKamar = '"+tbSearch.Text+"' or Kamar.IdTipeKamar = '"+tbSearch.Text+"' or TipeKamar.NamaTipeKamar = '"+tbSearch.Text+"')", Env.con);
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
                SqlCommand command = new SqlCommand("insert into PerbaikanKamar values('" + cbRoomNumber.SelectedValue.ToString() + "', '" + dtpBeginDate.Value.ToString("yyyy-MM-dd") + "', '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "','"+rtbNote.Text+"','"+Form1.idUser+"')", Env.con);
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
