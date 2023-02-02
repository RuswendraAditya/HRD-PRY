
namespace HRD_PRY.Personnel_Management
{
    partial class FrmPersonnelInformationTerminate
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
            this.txtEmployeeNumber = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTermination = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.btnUpdateTermination = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmployeeNumber
            // 
            this.txtEmployeeNumber.BeforeTouchSize = new System.Drawing.Size(105, 29);
            this.txtEmployeeNumber.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtEmployeeNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmployeeNumber.IntegerValue = ((long)(0));
            this.txtEmployeeNumber.Location = new System.Drawing.Point(180, 30);
            this.txtEmployeeNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeNumber.Name = "txtEmployeeNumber";
            this.txtEmployeeNumber.NumberGroupSeparator = "";
            this.txtEmployeeNumber.ReadOnly = true;
            this.txtEmployeeNumber.Size = new System.Drawing.Size(105, 29);
            this.txtEmployeeNumber.TabIndex = 63;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtEmployeeName.Location = new System.Drawing.Point(180, 67);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.ReadOnly = true;
            this.txtEmployeeName.Size = new System.Drawing.Size(324, 29);
            this.txtEmployeeName.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Employee Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 65;
            this.label5.Text = "Employee Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 67;
            this.label2.Text = "Termination Date";
            // 
            // dtTermination
            // 
            this.dtTermination.CustomFormat = "dd-MMM-yyyy";
            this.dtTermination.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dtTermination.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTermination.Location = new System.Drawing.Point(180, 110);
            this.dtTermination.Margin = new System.Windows.Forms.Padding(2);
            this.dtTermination.Name = "dtTermination";
            this.dtTermination.Size = new System.Drawing.Size(181, 29);
            this.dtTermination.TabIndex = 68;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "Button";
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(288, 164);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 41);
            this.btnCancel.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnCancel.Style.ForeColor = System.Drawing.Color.White;
            this.btnCancel.TabIndex = 76;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateTermination
            // 
            this.btnUpdateTermination.AccessibleName = "Button";
            this.btnUpdateTermination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateTermination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnUpdateTermination.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTermination.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTermination.Location = new System.Drawing.Point(158, 164);
            this.btnUpdateTermination.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateTermination.Name = "btnUpdateTermination";
            this.btnUpdateTermination.Size = new System.Drawing.Size(101, 41);
            this.btnUpdateTermination.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnUpdateTermination.Style.ForeColor = System.Drawing.Color.White;
            this.btnUpdateTermination.TabIndex = 75;
            this.btnUpdateTermination.Text = "Update";
            this.btnUpdateTermination.UseVisualStyleBackColor = false;
            this.btnUpdateTermination.Click += new System.EventHandler(this.btnUpdateTermination_Click);
            // 
            // FrmPersonnelInformationTerminate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 216);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateTermination);
            this.Controls.Add(this.dtTermination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmployeeNumber);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Name = "FrmPersonnelInformationTerminate";
            this.Text = "FrmPersonnelInformationTerminate";
            ((System.ComponentModel.ISupportInitialize)(this.txtEmployeeNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtEmployeeNumber;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTermination;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
        private Syncfusion.WinForms.Controls.SfButton btnUpdateTermination;
    }
}