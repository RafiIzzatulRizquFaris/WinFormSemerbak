namespace WinFormSemerbak.Menu_Transaction
{
    partial class MenuInputPayment
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbPayment = new System.Windows.Forms.TextBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRemainingPayment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBookingId = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSubmit.Location = new System.Drawing.Point(453, 313);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 35);
            this.btnSubmit.TabIndex = 64;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // tbPayment
            // 
            this.tbPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbPayment.Location = new System.Drawing.Point(304, 146);
            this.tbPayment.Name = "tbPayment";
            this.tbPayment.Size = new System.Drawing.Size(250, 32);
            this.tbPayment.TabIndex = 63;
            this.tbPayment.TextChanged += new System.EventHandler(this.TbPayment_TextChanged);
            // 
            // tbBalance
            // 
            this.tbBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbBalance.Location = new System.Drawing.Point(304, 200);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(250, 32);
            this.tbBalance.TabIndex = 60;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.Location = new System.Drawing.Point(41, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 31);
            this.label9.TabIndex = 59;
            this.label9.Text = "Payment Date";
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpPaymentDate.Location = new System.Drawing.Point(304, 251);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(250, 29);
            this.dtpPaymentDate.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(41, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 31);
            this.label8.TabIndex = 57;
            this.label8.Text = "Balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(41, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 31);
            this.label7.TabIndex = 55;
            this.label7.Text = "Payment";
            // 
            // tbRemainingPayment
            // 
            this.tbRemainingPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tbRemainingPayment.Location = new System.Drawing.Point(304, 98);
            this.tbRemainingPayment.Name = "tbRemainingPayment";
            this.tbRemainingPayment.Size = new System.Drawing.Size(250, 32);
            this.tbRemainingPayment.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.Location = new System.Drawing.Point(41, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 31);
            this.label6.TabIndex = 51;
            this.label6.Text = "Remaining Payment";
            // 
            // cbBookingId
            // 
            this.cbBookingId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbBookingId.FormattingEnabled = true;
            this.cbBookingId.Location = new System.Drawing.Point(304, 47);
            this.cbBookingId.Name = "cbBookingId";
            this.cbBookingId.Size = new System.Drawing.Size(250, 33);
            this.cbBookingId.TabIndex = 50;
            this.cbBookingId.SelectedIndexChanged += new System.EventHandler(this.CbBookingId_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.Location = new System.Drawing.Point(41, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 31);
            this.label5.TabIndex = 49;
            this.label5.Text = "Booking ID";
            // 
            // MenuInputPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbPayment);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbRemainingPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbBookingId);
            this.Controls.Add(this.label5);
            this.Name = "MenuInputPayment";
            this.Size = new System.Drawing.Size(1072, 692);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbPayment;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRemainingPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBookingId;
        private System.Windows.Forms.Label label5;
    }
}
