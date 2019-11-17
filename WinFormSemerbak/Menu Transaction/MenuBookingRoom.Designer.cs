namespace WinFormSemerbak.Menu_Transaction
{
    partial class MenuBookingRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbAddFacility = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbLongStay = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbEmailGuest = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.llRefresh = new System.Windows.Forms.LinkLabel();
            this.llAddNewGuest = new System.Windows.Forms.LinkLabel();
            this.tbGuestId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBookingType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbAddFacilityPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbRoomPrice = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.IdFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceFacility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpAvailability = new System.Windows.Forms.DateTimePicker();
            this.dtpMasuk = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.dtpAvailability);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.cbRoomType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(56, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 135);
            this.panel1.TabIndex = 0;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCheck.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCheck.Location = new System.Drawing.Point(448, 94);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(90, 35);
            this.btnCheck.TabIndex = 35;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // cbRoomType
            // 
            this.cbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(169, 41);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(250, 32);
            this.cbRoomType.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Check-In Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Check Room Availbility";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.cbFloor);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(692, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 407);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 107);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(330, 297);
            this.dataGridView2.TabIndex = 49;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // cbFloor
            // 
            this.cbFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Location = new System.Drawing.Point(120, 41);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(202, 32);
            this.cbFloor.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 25);
            this.label13.TabIndex = 31;
            this.label13.Text = "Floor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 29);
            this.label12.TabIndex = 28;
            this.label12.Text = "Room Map";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel3.Controls.Add(this.dtpMasuk);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.tbQty);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cbAddFacility);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.tbLongStay);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.cbEmailGuest);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.llRefresh);
            this.panel3.Controls.Add(this.llAddNewGuest);
            this.panel3.Controls.Add(this.tbGuestId);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cbBookingType);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(56, 154);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(560, 538);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFacility,
            this.qty,
            this.pricePerItem,
            this.priceFacility});
            this.dataGridView1.Location = new System.Drawing.Point(3, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(554, 145);
            this.dataGridView1.TabIndex = 48;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(327, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbQty.Location = new System.Drawing.Point(166, 352);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(125, 29);
            this.tbQty.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "QTY";
            // 
            // cbAddFacility
            // 
            this.cbAddFacility.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbAddFacility.FormattingEnabled = true;
            this.cbAddFacility.Location = new System.Drawing.Point(166, 301);
            this.cbAddFacility.Name = "cbAddFacility";
            this.cbAddFacility.Size = new System.Drawing.Size(250, 32);
            this.cbAddFacility.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 25);
            this.label10.TabIndex = 43;
            this.label10.Text = "Add. Facility";
            // 
            // tbLongStay
            // 
            this.tbLongStay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbLongStay.Location = new System.Drawing.Point(166, 252);
            this.tbLongStay.Name = "tbLongStay";
            this.tbLongStay.Size = new System.Drawing.Size(125, 29);
            this.tbLongStay.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "Long Stay";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "Check-In Date";
            // 
            // cbEmailGuest
            // 
            this.cbEmailGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbEmailGuest.FormattingEnabled = true;
            this.cbEmailGuest.Location = new System.Drawing.Point(166, 147);
            this.cbEmailGuest.Name = "cbEmailGuest";
            this.cbEmailGuest.Size = new System.Drawing.Size(250, 32);
            this.cbEmailGuest.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Email Guest";
            // 
            // llRefresh
            // 
            this.llRefresh.AutoSize = true;
            this.llRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.llRefresh.Location = new System.Drawing.Point(456, 102);
            this.llRefresh.Name = "llRefresh";
            this.llRefresh.Size = new System.Drawing.Size(75, 24);
            this.llRefresh.TabIndex = 36;
            this.llRefresh.TabStop = true;
            this.llRefresh.Text = "Refresh";
            this.llRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlRefresh_LinkClicked);
            // 
            // llAddNewGuest
            // 
            this.llAddNewGuest.AutoSize = true;
            this.llAddNewGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.llAddNewGuest.Location = new System.Drawing.Point(297, 102);
            this.llAddNewGuest.Name = "llAddNewGuest";
            this.llAddNewGuest.Size = new System.Drawing.Size(153, 24);
            this.llAddNewGuest.TabIndex = 35;
            this.llAddNewGuest.TabStop = true;
            this.llAddNewGuest.Text = "Add New Guest..";
            this.llAddNewGuest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlAddNewGuest_LinkClicked);
            // 
            // tbGuestId
            // 
            this.tbGuestId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbGuestId.Location = new System.Drawing.Point(166, 99);
            this.tbGuestId.Name = "tbGuestId";
            this.tbGuestId.Size = new System.Drawing.Size(125, 29);
            this.tbGuestId.TabIndex = 34;
            this.tbGuestId.TextChanged += new System.EventHandler(this.TbGuestId_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Guest ID";
            // 
            // cbBookingType
            // 
            this.cbBookingType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbBookingType.FormattingEnabled = true;
            this.cbBookingType.Location = new System.Drawing.Point(166, 48);
            this.cbBookingType.Name = "cbBookingType";
            this.cbBookingType.Size = new System.Drawing.Size(250, 32);
            this.cbBookingType.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Booking Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Booking Room";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(915, 643);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 35);
            this.btnSubmit.TabIndex = 48;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // tbAddFacilityPrice
            // 
            this.tbAddFacilityPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbAddFacilityPrice.Location = new System.Drawing.Point(900, 502);
            this.tbAddFacilityPrice.Name = "tbAddFacilityPrice";
            this.tbAddFacilityPrice.Size = new System.Drawing.Size(125, 29);
            this.tbAddFacilityPrice.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(687, 491);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 50);
            this.label14.TabIndex = 49;
            this.label14.Text = "Total Additional\r\nFacility Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(855, 506);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 25);
            this.label15.TabIndex = 51;
            this.label15.Text = "Rp";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(858, 555);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 25);
            this.label16.TabIndex = 54;
            this.label16.Text = "Rp";
            // 
            // tbTax
            // 
            this.tbTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbTax.Location = new System.Drawing.Point(900, 553);
            this.tbTax.Name = "tbTax";
            this.tbTax.Size = new System.Drawing.Size(125, 29);
            this.tbTax.TabIndex = 53;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(687, 553);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 25);
            this.label17.TabIndex = 52;
            this.label17.Text = "Tax";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(855, 605);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 25);
            this.label18.TabIndex = 57;
            this.label18.Text = "Rp";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbTotalPrice.Location = new System.Drawing.Point(900, 603);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(125, 29);
            this.tbTotalPrice.TabIndex = 56;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(687, 603);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(115, 25);
            this.label19.TabIndex = 55;
            this.label19.Text = "Total Price";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(855, 456);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(39, 25);
            this.label20.TabIndex = 60;
            this.label20.Text = "Rp";
            // 
            // tbRoomPrice
            // 
            this.tbRoomPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbRoomPrice.Location = new System.Drawing.Point(900, 454);
            this.tbRoomPrice.Name = "tbRoomPrice";
            this.tbRoomPrice.Size = new System.Drawing.Size(125, 29);
            this.tbRoomPrice.TabIndex = 59;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(687, 454);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 25);
            this.label21.TabIndex = 58;
            this.label21.Text = "Room Price";
            // 
            // IdFacility
            // 
            this.IdFacility.HeaderText = "Id Facility";
            this.IdFacility.Name = "IdFacility";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // pricePerItem
            // 
            this.pricePerItem.HeaderText = "Price per Item";
            this.pricePerItem.Name = "pricePerItem";
            // 
            // priceFacility
            // 
            this.priceFacility.HeaderText = "Total Price";
            this.priceFacility.Name = "priceFacility";
            // 
            // dtpAvailability
            // 
            this.dtpAvailability.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpAvailability.Location = new System.Drawing.Point(169, 97);
            this.dtpAvailability.Name = "dtpAvailability";
            this.dtpAvailability.Size = new System.Drawing.Size(250, 29);
            this.dtpAvailability.TabIndex = 36;
            // 
            // dtpMasuk
            // 
            this.dtpMasuk.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpMasuk.Location = new System.Drawing.Point(167, 200);
            this.dtpMasuk.Name = "dtpMasuk";
            this.dtpMasuk.Size = new System.Drawing.Size(250, 29);
            this.dtpMasuk.TabIndex = 49;
            // 
            // MenuBookingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbRoomPrice);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbTax);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbAddFacilityPrice);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuBookingRoom";
            this.Size = new System.Drawing.Size(1072, 692);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbAddFacility;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbLongStay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEmailGuest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel llRefresh;
        private System.Windows.Forms.LinkLabel llAddNewGuest;
        private System.Windows.Forms.TextBox tbGuestId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBookingType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbAddFacilityPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbRoomPrice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFacility;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceFacility;
        private System.Windows.Forms.DateTimePicker dtpAvailability;
        private System.Windows.Forms.DateTimePicker dtpMasuk;
    }
}
