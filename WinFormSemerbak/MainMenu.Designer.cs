namespace WinFormSemerbak
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomFacilityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageRoomRepairmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDailyPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageHolidayPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.availbilityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuHolidayPrice1 = new WinFormSemerbak.Menu_Price.MenuHolidayPrice();
            this.menuManageGuest1 = new WinFormSemerbak.Menu_User.MenuManageGuest();
            this.menuManageEmployee1 = new WinFormSemerbak.Menu_User.MenuManageEmployee();
            this.menuManageHolidayPrice1 = new WinFormSemerbak.Menu_Price.MenuManageDailyPrice();
            this.manageRoomRepairment1 = new WinFormSemerbak.Menu_Room.ManageRoomRepairment();
            this.menuManageRoomFacility1 = new WinFormSemerbak.Menu_Room.MenuManageRoomFacility();
            this.menuManageRoom1 = new WinFormSemerbak.Menu_Room.MenuManageRoom();
            this.menuManageRoomType1 = new WinFormSemerbak.Menu_Room.MenuManageRoomType();
            this.manuViewPayment1 = new WinFormSemerbak.Menu_Transaction.ManuViewPayment();
            this.menuManageBooking1 = new WinFormSemerbak.Menu_File.MenuManageBooking();
            this.menuBookingRoom1 = new WinFormSemerbak.Menu_Transaction.MenuBookingRoom();
            this.menuChangePassword1 = new WinFormSemerbak.Menu_File.MenuChangePassword();
            this.menuInputPayment1 = new WinFormSemerbak.Menu_Transaction.MenuInputPayment();
            this.menuManageDailyPrice1 = new WinFormSemerbak.Menu_Price.MenuManageDailyPrice();
            this.manageHolidayPrice1 = new WinFormSemerbak.Menu_Price.MenuHolidayPrice();
            this.menuReportTransaction1 = new WinFormSemerbak.Menu_Report.MenuReportTransaction();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(283, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 35);
            this.label3.TabIndex = 59;
            this.label3.Text = "Menu /";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(368, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 35);
            this.label4.TabIndex = 60;
            this.label4.Text = "Submenu";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.menuReportTransaction1);
            this.panel2.Controls.Add(this.menuHolidayPrice1);
            this.panel2.Controls.Add(this.menuManageGuest1);
            this.panel2.Controls.Add(this.menuManageEmployee1);
            this.panel2.Controls.Add(this.menuManageHolidayPrice1);
            this.panel2.Controls.Add(this.manageRoomRepairment1);
            this.panel2.Controls.Add(this.menuManageRoomFacility1);
            this.panel2.Controls.Add(this.menuManageRoom1);
            this.panel2.Controls.Add(this.menuManageRoomType1);
            this.panel2.Controls.Add(this.manuViewPayment1);
            this.panel2.Controls.Add(this.menuManageBooking1);
            this.panel2.Controls.Add(this.menuBookingRoom1);
            this.panel2.Controls.Add(this.menuChangePassword1);
            this.panel2.Controls.Add(this.menuInputPayment1);
            this.panel2.Controls.Add(this.menuManageDailyPrice1);
            this.panel2.Controls.Add(this.manageHolidayPrice1);
            this.panel2.Location = new System.Drawing.Point(282, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1072, 692);
            this.panel2.TabIndex = 61;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.roomManagementToolStripMenuItem,
            this.priceManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.reportToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(237, 741);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.fileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 7, 7, 15);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(210, 49);
            this.fileToolStripMenuItem.Text = "SBH SYS";
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.transactionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.transactionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.transactionToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(210, 42);
            this.transactionToolStripMenuItem.Text = "File";
            this.transactionToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.TransactionToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.ChangePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(203, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // roomManagementToolStripMenuItem
            // 
            this.roomManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingRoomToolStripMenuItem,
            this.manageBookingToolStripMenuItem,
            this.inputPaymentToolStripMenuItem,
            this.viewPaymentToolStripMenuItem});
            this.roomManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.roomManagementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.roomManagementToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.roomManagementToolStripMenuItem.Name = "roomManagementToolStripMenuItem";
            this.roomManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.roomManagementToolStripMenuItem.Size = new System.Drawing.Size(210, 42);
            this.roomManagementToolStripMenuItem.Text = "Transaction";
            this.roomManagementToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roomManagementToolStripMenuItem.Click += new System.EventHandler(this.RoomManagementToolStripMenuItem_Click);
            // 
            // bookingRoomToolStripMenuItem
            // 
            this.bookingRoomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bookingRoomToolStripMenuItem.Name = "bookingRoomToolStripMenuItem";
            this.bookingRoomToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.bookingRoomToolStripMenuItem.Text = "Booking Room";
            this.bookingRoomToolStripMenuItem.Click += new System.EventHandler(this.BookingRoomToolStripMenuItem_Click);
            // 
            // manageBookingToolStripMenuItem
            // 
            this.manageBookingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageBookingToolStripMenuItem.Name = "manageBookingToolStripMenuItem";
            this.manageBookingToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.manageBookingToolStripMenuItem.Text = "Manage Booking";
            this.manageBookingToolStripMenuItem.Click += new System.EventHandler(this.ManageBookingToolStripMenuItem_Click);
            // 
            // inputPaymentToolStripMenuItem
            // 
            this.inputPaymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.inputPaymentToolStripMenuItem.Name = "inputPaymentToolStripMenuItem";
            this.inputPaymentToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.inputPaymentToolStripMenuItem.Text = "Input Payment";
            this.inputPaymentToolStripMenuItem.Click += new System.EventHandler(this.InputPaymentToolStripMenuItem_Click);
            // 
            // viewPaymentToolStripMenuItem
            // 
            this.viewPaymentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewPaymentToolStripMenuItem.Name = "viewPaymentToolStripMenuItem";
            this.viewPaymentToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.viewPaymentToolStripMenuItem.Text = "View Payment";
            this.viewPaymentToolStripMenuItem.Click += new System.EventHandler(this.ViewPaymentToolStripMenuItem_Click);
            // 
            // priceManagementToolStripMenuItem
            // 
            this.priceManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageRoomTypeToolStripMenuItem,
            this.manageRoomToolStripMenuItem,
            this.manageRoomFacilityToolStripMenuItem,
            this.manageRoomRepairmentToolStripMenuItem});
            this.priceManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.priceManagementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.priceManagementToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.priceManagementToolStripMenuItem.Name = "priceManagementToolStripMenuItem";
            this.priceManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.priceManagementToolStripMenuItem.Size = new System.Drawing.Size(210, 42);
            this.priceManagementToolStripMenuItem.Text = "Room Management";
            this.priceManagementToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.priceManagementToolStripMenuItem.Click += new System.EventHandler(this.PriceManagementToolStripMenuItem_Click);
            // 
            // manageRoomTypeToolStripMenuItem
            // 
            this.manageRoomTypeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageRoomTypeToolStripMenuItem.Name = "manageRoomTypeToolStripMenuItem";
            this.manageRoomTypeToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.manageRoomTypeToolStripMenuItem.Text = "Manage Room Type";
            this.manageRoomTypeToolStripMenuItem.Click += new System.EventHandler(this.ManageRoomTypeToolStripMenuItem_Click);
            // 
            // manageRoomToolStripMenuItem
            // 
            this.manageRoomToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageRoomToolStripMenuItem.Name = "manageRoomToolStripMenuItem";
            this.manageRoomToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.manageRoomToolStripMenuItem.Text = "Manage Room";
            this.manageRoomToolStripMenuItem.Click += new System.EventHandler(this.ManageRoomToolStripMenuItem_Click);
            // 
            // manageRoomFacilityToolStripMenuItem
            // 
            this.manageRoomFacilityToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageRoomFacilityToolStripMenuItem.Name = "manageRoomFacilityToolStripMenuItem";
            this.manageRoomFacilityToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.manageRoomFacilityToolStripMenuItem.Text = "Manage Room Facility";
            this.manageRoomFacilityToolStripMenuItem.Click += new System.EventHandler(this.ManageRoomFacilityToolStripMenuItem_Click);
            // 
            // manageRoomRepairmentToolStripMenuItem
            // 
            this.manageRoomRepairmentToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageRoomRepairmentToolStripMenuItem.Name = "manageRoomRepairmentToolStripMenuItem";
            this.manageRoomRepairmentToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.manageRoomRepairmentToolStripMenuItem.Text = "Manage Room Repairment";
            this.manageRoomRepairmentToolStripMenuItem.Click += new System.EventHandler(this.ManageRoomRepairmentToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDailyPriceToolStripMenuItem,
            this.manageHolidayPriceToolStripMenuItem});
            this.userManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.userManagementToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.userManagementToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(210, 42);
            this.userManagementToolStripMenuItem.Text = "Price Management";
            this.userManagementToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.UserManagementToolStripMenuItem_Click);
            // 
            // manageDailyPriceToolStripMenuItem
            // 
            this.manageDailyPriceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageDailyPriceToolStripMenuItem.Name = "manageDailyPriceToolStripMenuItem";
            this.manageDailyPriceToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.manageDailyPriceToolStripMenuItem.Text = "Manage Daily Price";
            this.manageDailyPriceToolStripMenuItem.Click += new System.EventHandler(this.ManageDailyPriceToolStripMenuItem_Click);
            // 
            // manageHolidayPriceToolStripMenuItem
            // 
            this.manageHolidayPriceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageHolidayPriceToolStripMenuItem.Name = "manageHolidayPriceToolStripMenuItem";
            this.manageHolidayPriceToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.manageHolidayPriceToolStripMenuItem.Text = "Manage Holiday Price";
            this.manageHolidayPriceToolStripMenuItem.Click += new System.EventHandler(this.ManageHolidayPriceToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeToolStripMenuItem,
            this.manageGuestToolStripMenuItem});
            this.reportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.reportToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.reportToolStripMenuItem.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4);
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(210, 42);
            this.reportToolStripMenuItem.Text = "User Management";
            this.reportToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.ReportToolStripMenuItem_Click);
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.ManageEmployeeToolStripMenuItem_Click);
            // 
            // manageGuestToolStripMenuItem
            // 
            this.manageGuestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.manageGuestToolStripMenuItem.Name = "manageGuestToolStripMenuItem";
            this.manageGuestToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.manageGuestToolStripMenuItem.Text = "Manage Guest";
            this.manageGuestToolStripMenuItem.Click += new System.EventHandler(this.ManageGuestToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem1
            // 
            this.reportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transactionToolStripMenuItem1,
            this.availbilityReportToolStripMenuItem});
            this.reportToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.reportToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Window;
            this.reportToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(5);
            this.reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            this.reportToolStripMenuItem1.Padding = new System.Windows.Forms.Padding(4);
            this.reportToolStripMenuItem1.Size = new System.Drawing.Size(214, 42);
            this.reportToolStripMenuItem1.Text = "Report";
            this.reportToolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportToolStripMenuItem1.Click += new System.EventHandler(this.ReportToolStripMenuItem1_Click);
            // 
            // transactionToolStripMenuItem1
            // 
            this.transactionToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.transactionToolStripMenuItem1.Name = "transactionToolStripMenuItem1";
            this.transactionToolStripMenuItem1.Size = new System.Drawing.Size(213, 26);
            this.transactionToolStripMenuItem1.Text = "Transaction Report";
            this.transactionToolStripMenuItem1.Click += new System.EventHandler(this.TransactionToolStripMenuItem1_Click);
            // 
            // availbilityReportToolStripMenuItem
            // 
            this.availbilityReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.availbilityReportToolStripMenuItem.Name = "availbilityReportToolStripMenuItem";
            this.availbilityReportToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.availbilityReportToolStripMenuItem.Text = "Availbility Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(1291, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 63;
            this.label1.Text = "Hotel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(1122, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Semerbak Bunga";
            // 
            // menuHolidayPrice1
            // 
            this.menuHolidayPrice1.BackColor = System.Drawing.SystemColors.Window;
            this.menuHolidayPrice1.Location = new System.Drawing.Point(0, -15);
            this.menuHolidayPrice1.Name = "menuHolidayPrice1";
            this.menuHolidayPrice1.Size = new System.Drawing.Size(1072, 692);
            this.menuHolidayPrice1.TabIndex = 14;
            // 
            // menuManageGuest1
            // 
            this.menuManageGuest1.BackColor = System.Drawing.SystemColors.Window;
            this.menuManageGuest1.Location = new System.Drawing.Point(3, 3);
            this.menuManageGuest1.Name = "menuManageGuest1";
            this.menuManageGuest1.Size = new System.Drawing.Size(1072, 692);
            this.menuManageGuest1.TabIndex = 13;
            // 
            // menuManageEmployee1
            // 
            this.menuManageEmployee1.BackColor = System.Drawing.SystemColors.Window;
            this.menuManageEmployee1.Location = new System.Drawing.Point(6, 3);
            this.menuManageEmployee1.Name = "menuManageEmployee1";
            this.menuManageEmployee1.Size = new System.Drawing.Size(1072, 692);
            this.menuManageEmployee1.TabIndex = 10;
            // 
            // menuManageHolidayPrice1
            // 
            this.menuManageHolidayPrice1.BackColor = System.Drawing.SystemColors.Window;
            this.menuManageHolidayPrice1.Location = new System.Drawing.Point(3, 3);
            this.menuManageHolidayPrice1.Name = "menuManageHolidayPrice1";
            this.menuManageHolidayPrice1.Size = new System.Drawing.Size(1072, 692);
            this.menuManageHolidayPrice1.TabIndex = 9;
            // 
            // manageRoomRepairment1
            // 
            this.manageRoomRepairment1.BackColor = System.Drawing.SystemColors.Window;
            this.manageRoomRepairment1.Location = new System.Drawing.Point(0, 3);
            this.manageRoomRepairment1.Name = "manageRoomRepairment1";
            this.manageRoomRepairment1.Size = new System.Drawing.Size(1072, 692);
            this.manageRoomRepairment1.TabIndex = 8;
            // 
            // menuManageRoomFacility1
            // 
            this.menuManageRoomFacility1.BackColor = System.Drawing.SystemColors.Window;
            this.menuManageRoomFacility1.Location = new System.Drawing.Point(0, 3);
            this.menuManageRoomFacility1.Name = "menuManageRoomFacility1";
            this.menuManageRoomFacility1.Size = new System.Drawing.Size(1072, 692);
            this.menuManageRoomFacility1.TabIndex = 7;
            // 
            // menuManageRoom1
            // 
            this.menuManageRoom1.BackColor = System.Drawing.SystemColors.Window;
            this.menuManageRoom1.Location = new System.Drawing.Point(0, 3);
            this.menuManageRoom1.Name = "menuManageRoom1";
            this.menuManageRoom1.Size = new System.Drawing.Size(1072, 692);
            this.menuManageRoom1.TabIndex = 6;
            // 
            // menuManageRoomType1
            // 
            this.menuManageRoomType1.BackColor = System.Drawing.SystemColors.Window;
            this.menuManageRoomType1.Location = new System.Drawing.Point(-3, 3);
            this.menuManageRoomType1.Name = "menuManageRoomType1";
            this.menuManageRoomType1.Size = new System.Drawing.Size(1072, 692);
            this.menuManageRoomType1.TabIndex = 5;
            // 
            // manuViewPayment1
            // 
            this.manuViewPayment1.BackColor = System.Drawing.SystemColors.Window;
            this.manuViewPayment1.Location = new System.Drawing.Point(-3, 0);
            this.manuViewPayment1.Name = "manuViewPayment1";
            this.manuViewPayment1.Size = new System.Drawing.Size(1072, 692);
            this.manuViewPayment1.TabIndex = 3;
            // 
            // menuManageBooking1
            // 
            this.menuManageBooking1.BackColor = System.Drawing.SystemColors.Window;
            this.menuManageBooking1.Location = new System.Drawing.Point(-3, 3);
            this.menuManageBooking1.Name = "menuManageBooking1";
            this.menuManageBooking1.Size = new System.Drawing.Size(1072, 692);
            this.menuManageBooking1.TabIndex = 2;
            // 
            // menuBookingRoom1
            // 
            this.menuBookingRoom1.BackColor = System.Drawing.SystemColors.Window;
            this.menuBookingRoom1.Location = new System.Drawing.Point(0, 0);
            this.menuBookingRoom1.Name = "menuBookingRoom1";
            this.menuBookingRoom1.Size = new System.Drawing.Size(1072, 692);
            this.menuBookingRoom1.TabIndex = 1;
            // 
            // menuChangePassword1
            // 
            this.menuChangePassword1.BackColor = System.Drawing.SystemColors.Window;
            this.menuChangePassword1.Location = new System.Drawing.Point(-1, 0);
            this.menuChangePassword1.Name = "menuChangePassword1";
            this.menuChangePassword1.Size = new System.Drawing.Size(1072, 692);
            this.menuChangePassword1.TabIndex = 0;
            // 
            // menuInputPayment1
            // 
            this.menuInputPayment1.BackColor = System.Drawing.SystemColors.Window;
            this.menuInputPayment1.Location = new System.Drawing.Point(-3, 3);
            this.menuInputPayment1.Name = "menuInputPayment1";
            this.menuInputPayment1.Size = new System.Drawing.Size(1072, 692);
            this.menuInputPayment1.TabIndex = 4;
            // 
            // menuManageDailyPrice1
            // 
            this.menuManageDailyPrice1.BackColor = System.Drawing.SystemColors.Window;
            this.menuManageDailyPrice1.Location = new System.Drawing.Point(3, -15);
            this.menuManageDailyPrice1.Name = "menuManageDailyPrice1";
            this.menuManageDailyPrice1.Size = new System.Drawing.Size(1072, 692);
            this.menuManageDailyPrice1.TabIndex = 12;
            // 
            // manageHolidayPrice1
            // 
            this.manageHolidayPrice1.BackColor = System.Drawing.SystemColors.Window;
            this.manageHolidayPrice1.Location = new System.Drawing.Point(7, 12);
            this.manageHolidayPrice1.Name = "manageHolidayPrice1";
            this.manageHolidayPrice1.Size = new System.Drawing.Size(1072, 692);
            this.manageHolidayPrice1.TabIndex = 11;
            // 
            // menuReportTransaction1
            // 
            this.menuReportTransaction1.BackColor = System.Drawing.SystemColors.Window;
            this.menuReportTransaction1.Location = new System.Drawing.Point(3, -17);
            this.menuReportTransaction1.Name = "menuReportTransaction1";
            this.menuReportTransaction1.Size = new System.Drawing.Size(1072, 692);
            this.menuReportTransaction1.TabIndex = 15;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomFacilityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageRoomRepairmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDailyPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageHolidayPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem availbilityReportToolStripMenuItem;
        private Menu_File.MenuChangePassword menuChangePassword1;
        private Menu_Transaction.MenuBookingRoom menuBookingRoom1;
        private Menu_File.MenuManageBooking menuManageBooking1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Menu_Transaction.ManuViewPayment manuViewPayment1;
        private Menu_Transaction.MenuInputPayment menuInputPayment1;
        private Menu_Room.MenuManageRoomType menuManageRoomType1;
        private Menu_Room.MenuManageRoom menuManageRoom1;
        private Menu_Room.MenuManageRoomFacility menuManageRoomFacility1;
        private Menu_Room.ManageRoomRepairment manageRoomRepairment1;
        private Menu_Price.MenuManageDailyPrice menuManageHolidayPrice1;
        private Menu_User.MenuManageEmployee menuManageEmployee1;
        private Menu_Price.MenuHolidayPrice manageHolidayPrice1;
        private Menu_Price.MenuManageDailyPrice menuManageDailyPrice1;
        private Menu_User.MenuManageGuest menuManageGuest1;
        private Menu_Price.MenuHolidayPrice menuHolidayPrice1;
        private Menu_Report.MenuReportTransaction menuReportTransaction1;
    }
}