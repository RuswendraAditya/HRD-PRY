
namespace HRD_PRY
{
    partial class FrmPersonnelnformationInquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonnelnformationInquiry));
            this.gridPersonnelInformations = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new Syncfusion.WinForms.Controls.SfButton();
            this.btnExportExcel = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonnelInformations)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPersonnelInformations
            // 
            this.gridPersonnelInformations.AccessibleName = "Table";
            this.gridPersonnelInformations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridPersonnelInformations.Location = new System.Drawing.Point(12, 64);
            this.gridPersonnelInformations.Name = "gridPersonnelInformations";
            this.gridPersonnelInformations.PreviewRowHeight = 35;
            this.gridPersonnelInformations.Size = new System.Drawing.Size(1691, 576);
            this.gridPersonnelInformations.TabIndex = 0;
            this.gridPersonnelInformations.Text = "sfDataGrid1";
            this.gridPersonnelInformations.AutoGeneratingColumn += new Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnEventHandler(this.gridPersonnelInformations_AutoGeneratingColumn);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personnel Information ";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.AccessibleName = "Button";
            this.btnAddEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnAddEmployee.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddEmployee.Location = new System.Drawing.Point(12, 646);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(135, 50);
            this.btnAddEmployee.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnAddEmployee.Style.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddEmployee.TabIndex = 43;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.AccessibleName = "Button";
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnExportExcel.Location = new System.Drawing.Point(1412, 646);
            this.btnExportExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(112, 50);
            this.btnExportExcel.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.btnExportExcel.Style.Image = global::HRD_PRY.Properties.Resources.excel;
            this.btnExportExcel.TabIndex = 61;
            this.btnExportExcel.Text = "Excel";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // FrmPersonnelnformationInquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1715, 703);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPersonnelInformations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonnelnformationInquiry";
            this.Text = "Personnel Information Inquiry";
            this.Load += new System.EventHandler(this.FrmPersonnelnformationInquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPersonnelInformations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid gridPersonnelInformations;
        private System.Windows.Forms.Label label1;
        private Syncfusion.WinForms.Controls.SfButton btnAddEmployee;
        private Syncfusion.WinForms.Controls.SfButton btnExportExcel;
    }
}