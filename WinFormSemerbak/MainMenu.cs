using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormSemerbak
{
    public partial class MainMenu : Form
    {

        public bool isCollapsed;
        public static string subMenu;
        public MainMenu()
        {
            InitializeComponent();
            label3.Text = "Main Menu";
            label4.Text = "";
        }

        private void TransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "File /";
            label4.Text = "";
        }

        private void RoomManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Transaction /";
            label4.Text = "";
        }

        private void PriceManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Room Management /";
            label4.Text = "";
        }

        private void UserManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Price Management /";
            label4.Text = "";
        }

        private void ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "User Management /";
            label4.Text = "";
        }

        private void ReportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label3.Text = "Report /";
            label4.Text = "";
        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "File /";
            label4.Text = "Change Password";
            menuChangePassword1.BringToFront();
        }

        private void LogOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BookingRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Transaction /";
            label4.Text = "Booking Room";
            menuBookingRoom1.BringToFront();
        }

        private void ManageBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Transaction /";
            label4.Text = "Manage Booking";
            menuManageBooking1.BringToFront();
        }

        private void ViewPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Transaction /";
            label4.Text = "View Payment";
            manuViewPayment1.BringToFront();
        }

        private void InputPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Transaction /";
            label4.Text = "Input Payment";
            menuInputPayment1.BringToFront();
        }

        private void ManageRoomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Room Management /";
            label4.Text = "Manage Room Type";
            menuManageRoomType1.BringToFront();
        }

        private void ManageRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Room Management /";
            label4.Text = "Manage Room";
            menuManageRoom1.BringToFront();
        }

        private void ManageRoomFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Room Management /";
            label4.Text = "Manage Room Facility";
            menuManageRoomFacility1.BringToFront();
        }

        private void ManageRoomRepairmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Room Management /";
            label4.Text = "Manage Room Repairment";
            manageRoomRepairment1.BringToFront();
        }

        private void ManageDailyPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Price Management /";
            label4.Text = "Manage Daily Price";
            menuManageDailyPrice1.BringToFront();
        }

        private void ManageHolidayPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "Price Management /";
            label4.Text = "Manage Holiday Price";
            menuHolidayPrice1.BringToFront();
        }

        private void ManageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "User Management /";
            label4.Text = "Manage Employee";
            menuManageEmployee1.BringToFront();
        }

        private void ManageGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label3.Text = "User Management /";
            label4.Text = "Manage Guest";
            menuManageGuest1.BringToFront();
        }

        private void TransactionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label3.Text = "Report /";
            label4.Text = "Transaction Report";
            menuReportTransaction1.BringToFront();
        }
    }
}
