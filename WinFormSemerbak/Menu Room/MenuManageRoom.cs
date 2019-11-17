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
    public partial class MenuManageRoom : UserControl
    {

        DataTable dt = new DataTable();

        public MenuManageRoom()
        {
            InitializeComponent();
            tbRoomId.Enabled = false;
            GetRoomType();
            GetData();
        }

        private void GetData()
        {
            SqlCommand command = new SqlCommand("select * from Kamar", Env.con);
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

            cbRoomTypeName.DataSource = dt;
            cbRoomTypeName.ValueMember = "IdTipeKamar";
            cbRoomTypeName.DisplayMember = "NamaTipeKamar";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("Select Kamar.* from Kamar, TipeKamar where (Kamar.IdTipeKamar = TipeKamar.IdTipeKamar) and (TipeKamar.NamaTipeKamar='"+tbSearch.Text+"' or TipeKamar.Deskripsi='"+tbSearch.Text+"' or TipeKamar.IdTipeKamar='"+tbSearch.Text+"')", Env.con);
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
                SqlCommand command = new SqlCommand("insert into Kamar values('" + tbRoomNumber.Text + "', '" + tbFloor.Text + "', '" + cbRoomTypeName.SelectedValue.ToString() + "')", Env.con);
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("update Kamar set '" + tbRoomNumber.Text + "', '" + tbFloor.Text + "', '" + cbRoomTypeName.SelectedValue.ToString() + "' where Kamar.IdKamar='" + tbRoomId.Text + "'", Env.con);
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE Kamar WHERE Kamar.IdKamar='" + tbRoomId.Text + "'", Env.con);
            Env.con.Open();
            command.ExecuteNonQuery();
            Env.con.Close();
            GetData();
        }
    }
}
