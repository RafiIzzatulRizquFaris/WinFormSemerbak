using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace WinFormSemerbak.Menu_Report
{
    public partial class MenuReportTransaction : UserControl
    {
        public MenuReportTransaction()
        {
            InitializeComponent();
            GetRoomType();
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

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //Reset
            reportViewer1.Reset();

            DataTable dataTable = GetData();
            ReportDataSource rds = new ReportDataSource("reportTransaction.xsd", dataTable);

            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.LocalReport.ReportPath = "ReportTransact.rdlc";

            //Refresh
            reportViewer1.LocalReport.Refresh();
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();
            string query = "select SUM(Pembayaran.TotalPembayaran) as Pembayaran, Pembayaran.TglPembayaran as Tanggal FROM Kamar, Pemesanan, Pembayaran WHERE Kamar.IDKamar = Pemesanan.IDKamar and Kamar.IDTipeKamar = '" + cbRoomType.SelectedValue.ToString() + "' and Pemesanan.IDPemesanan = Pembayaran.IDPemesanan and Pemesanan.TglPemesanan >= '" + dtpBeginDate.Value.ToString("yyyy-MM-dd") + "' and Pemesanan.TglPemesanan <= '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' GROUP BY Pembayaran.TglPembayaran";
            Env.con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Env.con);
            sda.Fill(dt);
            Env.con.Close();

            return dt;
        }

        private void MenuReportTransaction_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
