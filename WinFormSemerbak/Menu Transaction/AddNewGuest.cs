using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSemerbak.Menu_Transaction
{
    public partial class AddNewGuest : Form
    {
        public AddNewGuest()
        {
            InitializeComponent();
            GetVehicleType();
        }

        private void GetVehicleType()
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM TipeKendaraan", Env.con);

            Env.con.Open();
            SqlDataReader reader = sqlCommand.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            Env.con.Close();

            cbVehicletype.DisplayMember = dataTable.Columns[1].ToString();
            cbVehicletype.ValueMember = dataTable.Columns[0].ToString();
            cbVehicletype.DataSource = dataTable;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Penghuni VALUES (@nama, @ktp, @email, @hp, @plat, @tipekendaraan)", Env.con);
                Env.con.Open();
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@nama", tbGuestName.Text);
                command.Parameters.AddWithValue("@ktp", tbIdCard.Text);
                command.Parameters.AddWithValue("@email", tbEmail.Text);
                command.Parameters.AddWithValue("@hp", tbPhone.Text);
                command.Parameters.AddWithValue("@plat", tbVehicleLicense.Text);
                command.Parameters.AddWithValue("@tipekendaraan", cbVehicletype.SelectedValue.ToString());

                command.ExecuteNonQuery();
                Env.con.Close();
                MessageBox.Show("Success Add Data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
