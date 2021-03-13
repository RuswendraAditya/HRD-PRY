
namespace HRD_PRY.Attedance
{
    partial class FrmAttendanceInquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttendanceInquiry));
            this.GridAttendance = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.dtPeriod = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCari = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExportExcel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnDownloadPhoto = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // GridAttendance
            // 
            this.GridAttendance.AccessibleName = "Table";
            this.GridAttendance.AllowEditing = false;
            this.GridAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridAttendance.Location = new System.Drawing.Point(13, 63);
            this.GridAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.GridAttendance.Name = "GridAttendance";
            this.GridAttendance.PreviewRowHeight = 35;
            this.GridAttendance.SelectionUnit = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Cell;
            this.GridAttendance.Size = new System.Drawing.Size(1556, 658);
            this.GridAttendance.Style.CellStyle.Font.Facename = "Microsoft YaHei";
            this.GridAttendance.Style.CellStyle.Font.Size = 12F;
            this.GridAttendance.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.GridAttendance.TabIndex = 42;
            this.GridAttendance.Text = "sfDataGrid1";
            this.GridAttendance.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.GridLocation_AutoGeneratingColumn);
            // 
            // dtPeriod
            // 
            this.dtPeriod.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtPeriod.CustomFormat = "dd/MM/yyyy";
            this.dtPeriod.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F);
            this.dtPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPeriod.Location = new System.Drawing.Point(200, 21);
            this.dtPeriod.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtPeriod.Name = "dtPeriod";
            this.dtPeriod.Size = new System.Drawing.Size(189, 32);
            this.dtPeriod.TabIndex = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "Tgl Presensi";
            // 
            // btnCari
            // 
            this.btnCari.AccessibleName = "Button";
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnCari.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(396, 21);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(102, 35);
            this.btnCari.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnCari.Style.ForeColor = System.Drawing.Color.White;
            this.btnCari.TabIndex = 81;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleName = "Button";
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.LightCyan;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportExcel.Location = new System.Drawing.Point(1439, 730);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(130, 42);
            this.btnExportExcel.Style.BackColor = System.Drawing.Color.LightCyan;
            this.btnExportExcel.Style.Image = global::HRD_PRY.Properties.Resources.excel;
            this.btnExportExcel.TabIndex = 82;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnDownloadPhoto
            // 
            this.btnDownloadPhoto.AccessibleName = "Button";
            this.btnDownloadPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownloadPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnDownloadPhoto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadPhoto.ForeColor = System.Drawing.Color.White;
            this.btnDownloadPhoto.Location = new System.Drawing.Point(12, 737);
            this.btnDownloadPhoto.Name = "btnDownloadPhoto";
            this.btnDownloadPhoto.Size = new System.Drawing.Size(176, 35);
            this.btnDownloadPhoto.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnDownloadPhoto.Style.ForeColor = System.Drawing.Color.White;
            this.btnDownloadPhoto.TabIndex = 83;
            this.btnDownloadPhoto.Text = "Download Photo";
            this.btnDownloadPhoto.UseVisualStyleBackColor = false;
            this.btnDownloadPhoto.Click += new System.EventHandler(this.btnDownloadPhoto_Click);
            // 
            // FrmAttendanceInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 789);
            this.Controls.Add(this.btnDownloadPhoto);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.dtPeriod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridAttendance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAttendanceInquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Inquiry";
            this.Load += new System.EventHandler(this.FrmAttendanceInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid GridAttendance;
        private System.Windows.Forms.DateTimePicker dtPeriod;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Controls.SfButton btnCari;
        private Syncfusion.WinForms.Controls.SfButton btnExportExcel;
        private Syncfusion.WinForms.Controls.SfButton btnDownloadPhoto;
    }
}