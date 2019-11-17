namespace WinFormSemerbak.Menu_Transaction
{
    partial class AddNewGuest
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbVehicletype = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbVehicleLicense = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGuestName = new System.Windows.Forms.TextBox();
            this.tbIdCard = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAdd.Location = new System.Drawing.Point(30, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // cbVehicletype
            // 
            this.cbVehicletype.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbVehicletype.FormattingEnabled = true;
            this.cbVehicletype.Location = new System.Drawing.Point(276, 264);
            this.cbVehicletype.Name = "cbVehicletype";
            this.cbVehicletype.Size = new System.Drawing.Size(250, 24);
            this.cbVehicletype.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 25);
            this.label10.TabIndex = 59;
            this.label10.Text = "Vehicle Type";
            // 
            // tbVehicleLicense
            // 
            this.tbVehicleLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbVehicleLicense.Location = new System.Drawing.Point(276, 221);
            this.tbVehicleLicense.Name = "tbVehicleLicense";
            this.tbVehicleLicense.Size = new System.Drawing.Size(250, 23);
            this.tbVehicleLicense.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "Vehicle License Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "ID Card Number";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbEmail.Location = new System.Drawing.Point(276, 102);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(250, 23);
            this.tbEmail.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Guest Name";
            // 
            // tbGuestName
            // 
            this.tbGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbGuestName.Location = new System.Drawing.Point(276, 62);
            this.tbGuestName.Name = "tbGuestName";
            this.tbGuestName.Size = new System.Drawing.Size(250, 23);
            this.tbGuestName.TabIndex = 62;
            // 
            // tbIdCard
            // 
            this.tbIdCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbIdCard.Location = new System.Drawing.Point(276, 142);
            this.tbIdCard.Name = "tbIdCard";
            this.tbIdCard.Size = new System.Drawing.Size(250, 23);
            this.tbIdCard.TabIndex = 63;
            // 
            // tbPhone
            // 
            this.tbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbPhone.Location = new System.Drawing.Point(276, 183);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(250, 23);
            this.tbPhone.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 65;
            this.label1.Text = "Add New Guest";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnClose.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btnClose.Location = new System.Drawing.Point(494, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 43);
            this.btnClose.TabIndex = 66;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // AddNewGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(556, 350);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbIdCard);
            this.Controls.Add(this.tbGuestName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbVehicletype);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbVehicleLicense);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewGuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbVehicletype;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbVehicleLicense;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbGuestName;
        private System.Windows.Forms.TextBox tbIdCard;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
    }
}