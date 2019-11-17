namespace WinFormSemerbak.Menu_Report
{
    partial class MenuReportTransaction
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinFormSemerbak.Menu File.ReportTransact.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(586, 31);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(454, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLoad.Location = new System.Drawing.Point(442, 199);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 35);
            this.btnLoad.TabIndex = 71;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label9.Location = new System.Drawing.Point(30, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 31);
            this.label9.TabIndex = 68;
            this.label9.Text = "Room Type";
            // 
            // dtpBeginDate
            // 
            this.dtpBeginDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpBeginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpBeginDate.Location = new System.Drawing.Point(293, 34);
            this.dtpBeginDate.Name = "dtpBeginDate";
            this.dtpBeginDate.Size = new System.Drawing.Size(250, 29);
            this.dtpBeginDate.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label8.Location = new System.Drawing.Point(30, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 31);
            this.label8.TabIndex = 66;
            this.label8.Text = "End Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(30, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 31);
            this.label7.TabIndex = 65;
            this.label7.Text = "Begin Date";
            // 
            // cbRoomType
            // 
            this.cbRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(293, 139);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(250, 33);
            this.cbRoomType.TabIndex = 73;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtpEndDate.Location = new System.Drawing.Point(293, 85);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(250, 29);
            this.dtpEndDate.TabIndex = 74;
            // 
            // MenuReportTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpBeginDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.reportViewer1);
            this.Name = "MenuReportTransaction";
            this.Size = new System.Drawing.Size(1072, 692);
            this.Load += new System.EventHandler(this.MenuReportTransaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpBeginDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}
