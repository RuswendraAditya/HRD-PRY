
namespace HRD_PRY.Master
{
    partial class FrmPositionInquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPositionInquiry));
            this.label1 = new System.Windows.Forms.Label();
            this.GridLocation = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnAddLocation = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExportExcel = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(723, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Position Master";
            // 
            // GridLocation
            // 
            this.GridLocation.AccessibleName = "Table";
            this.GridLocation.AllowEditing = false;
            this.GridLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridLocation.Location = new System.Drawing.Point(15, 68);
            this.GridLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GridLocation.Name = "GridLocation";
            this.GridLocation.PreviewRowHeight = 35;
            this.GridLocation.SelectionUnit = Syncfusion.WinForms.DataGrid.Enums.SelectionUnit.Cell;
            this.GridLocation.Size = new System.Drawing.Size(1349, 556);
            this.GridLocation.Style.CellStyle.Font.Facename = "Microsoft YaHei";
            this.GridLocation.Style.CellStyle.Font.Size = 12F;
            this.GridLocation.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.GridLocation.TabIndex = 41;
            this.GridLocation.Text = "sfDataGrid1";
            this.GridLocation.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.GridLocation_AutoGeneratingColumn);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.AccessibleName = "Button";
            this.btnAddLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnAddLocation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLocation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddLocation.Location = new System.Drawing.Point(15, 632);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(152, 63);
            this.btnAddLocation.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnAddLocation.Style.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddLocation.TabIndex = 42;
            this.btnAddLocation.Text = "Add Unit";
            this.btnAddLocation.UseVisualStyleBackColor = false;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleName = "Button";
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportExcel.Location = new System.Drawing.Point(1041, 635);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(6);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(129, 52);
            this.btnExportExcel.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.btnExportExcel.Style.Image = global::HRD_PRY.Properties.Resources.excel;
            this.btnExportExcel.TabIndex = 60;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // FrmPositionInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1392, 711);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.GridLocation);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPositionInquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location Master";
            this.Load += new System.EventHandler(this.FrmLocationInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLocation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid GridLocation;
        private Syncfusion.WinForms.Controls.SfButton btnAddLocation;
        private Syncfusion.WinForms.Controls.SfButton btnExportExcel;
    }
}