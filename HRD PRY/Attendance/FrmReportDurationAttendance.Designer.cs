
namespace HRD_PRY.Attendance
{
    partial class FrmReportDurationAttendance
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
            this.btnCari = new Syncfusion.WinForms.Controls.SfButton();
            this.GridAttendance = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnDownload = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCari
            // 
            this.btnCari.AccessibleName = "Button";
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnCari.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(230, 11);
            this.btnCari.Margin = new System.Windows.Forms.Padding(2);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(76, 28);
            this.btnCari.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnCari.Style.ForeColor = System.Drawing.Color.White;
            this.btnCari.TabIndex = 82;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // GridAttendance
            // 
            this.GridAttendance.AccessibleName = "Table";
            this.GridAttendance.AllowEditing = false;
            this.GridAttendance.AllowResizingColumns = true;
            this.GridAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridAttendance.Location = new System.Drawing.Point(12, 44);
            this.GridAttendance.Name = "GridAttendance";
            this.GridAttendance.PreviewRowHeight = 35;
            this.GridAttendance.SelectionUnit = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Cell;
            this.GridAttendance.Size = new System.Drawing.Size(1130, 482);
            this.GridAttendance.Style.CellStyle.Font.Facename = "Microsoft YaHei";
            this.GridAttendance.Style.CellStyle.Font.Size = 10F;
            this.GridAttendance.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.GridAttendance.TabIndex = 83;
            this.GridAttendance.Text = "sfDataGrid1";
            this.GridAttendance.Click += new System.EventHandler(this.GridAttendance_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MMM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 84;
            // 
            // btnDownload
            // 
            this.btnDownload.AccessibleName = "Button";
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnDownload.Location = new System.Drawing.Point(13, 533);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(86, 28);
            this.btnDownload.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.btnDownload.Style.Image = global::HRD_PRY.Properties.Resources.excel;
            this.btnDownload.TabIndex = 85;
            this.btnDownload.Text = "Excel";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // FrmReportDurationAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 565);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.GridAttendance);
            this.Controls.Add(this.btnCari);
            this.Name = "FrmReportDurationAttendance";
            this.Text = "Laporan Akumulasi Jam Kerja";
            ((System.ComponentModel.ISupportInitialize)(this.GridAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton btnCari;
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridAttendance;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Syncfusion.WinForms.Controls.SfButton btnDownload;
    }
}