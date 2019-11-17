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
    public partial class MenuManageRoomType : UserControl
    {

        DataTable dt = new DataTable();

        public MenuManageRoomType()
        {
            InitializeComponent();
            tbRoomTypeId.Enabled = false;
            GetData();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int MyInt;
            if (int.TryParse(tbSearch.Text, out MyInt))
            {
                SqlCommand command = new SqlCommand("select * from TipeKamar where TipeKamar.IdTipeKamar='" + Convert.ToInt32(tbSearch.Text) + "'", Env.con);
                Env.con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(sdr);
                Env.con.Close();

                dataGridView1.DataSource = dt;
            }
            else
            {
                SqlCommand command = new SqlCommand("select * from TipeKamar where TipeKamar.NamaTipeKamar='" + tbSearch.Text + "'", Env.con);
                Env.con.Open();
                SqlDataReader sdr = command.ExecuteReader();
                dt = new DataTable();
                dt.Load(sdr);
                Env.con.Close();

                dataGridView1.DataSource = dt;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbRoomTypeId.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            tbRoomTypeName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            rtbDescription.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TipeKamar values('" + tbRoomTypeName.Text + "', '" + rtbDescription.Text + "')", Env.con);
            Env.con.Open();
            command.ExecuteNonQuery();
            Env.con.Close();
            GetData();
        }

        private void GetData()
        {
            SqlCommand command = new SqlCommand("Select * From TipeKamar", Env.con);
            Env.con.Open();
            SqlDataReader sdr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            Env.con.Close();

            dataGridView1.DataSource = dt;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("update TipeKamar set '" + tbRoomTypeName.Text + "', '" + rtbDescription.Text + "' where TipeKamar.IdTipeKamar='" + tbRoomTypeId.Text + "'", Env.con);
            Env.con.Open();
            command.ExecuteNonQuery();
            Env.con.Close();
            GetData();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("delete TipeKamar where TipeKamar.IdTipeKamar='" + tbRoomTypeId.Text + "'", Env.con);
            Env.con.Open();
            command.ExecuteNonQuery();
            Env.con.Close();
            GetData();
        }
    }
}
