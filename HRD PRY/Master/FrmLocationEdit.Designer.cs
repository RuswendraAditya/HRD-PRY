
namespace HRD_PRY.Master
{
    partial class FrmLocationEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocationEdit));
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLocationDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRadius = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.txtLongitude = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.txtLatitude = new Syncfusion.Windows.Forms.Tools.DoubleTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkBoxActive = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateLocation = new Syncfusion.WinForms.Controls.SfButton();
            this.btnCancel = new Syncfusion.WinForms.Controls.SfButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLatitude)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocationName
            // 
            this.txtLocationName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtLocationName.Location = new System.Drawing.Point(232, 35);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.Size = new System.Drawing.Size(610, 34);
            this.txtLocationName.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 27);
            this.label5.TabIndex = 49;
            this.label5.Text = "Location Name";
            // 
            // txtLocationDesc
            // 
            this.txtLocationDesc.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtLocationDesc.Location = new System.Drawing.Point(232, 77);
            this.txtLocationDesc.Multiline = true;
            this.txtLocationDesc.Name = "txtLocationDesc";
            this.txtLocationDesc.Size = new System.Drawing.Size(610, 73);
            this.txtLocationDesc.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 27);
            this.label1.TabIndex = 47;
            this.label1.Text = "Location Desc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRadius);
            this.groupBox1.Controls.Add(this.txtLongitude);
            this.groupBox1.Controls.Add(this.txtLatitude);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 170);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordinate";
            // 
            // txtRadius
            // 
            this.txtRadius.BeforeTouchSize = new System.Drawing.Size(125, 34);
            this.txtRadius.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtRadius.IntegerValue = ((long)(1));
            this.txtRadius.Location = new System.Drawing.Point(183, 113);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(198, 34);
            this.txtRadius.TabIndex = 9;
            this.txtRadius.Text = "1";
            // 
            // txtLongitude
            // 
            this.txtLongitude.BeforeTouchSize = new System.Drawing.Size(125, 34);
            this.txtLongitude.DoubleValue = 1D;
            this.txtLongitude.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtLongitude.Location = new System.Drawing.Point(183, 68);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.NumberDecimalDigits = 6;
            this.txtLongitude.Size = new System.Drawing.Size(125, 34);
            this.txtLongitude.TabIndex = 8;
            this.txtLongitude.Text = "1.000000";
            // 
            // txtLatitude
            // 
            this.txtLatitude.BeforeTouchSize = new System.Drawing.Size(125, 34);
            this.txtLatitude.DoubleValue = 1D;
            this.txtLatitude.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.txtLatitude.Location = new System.Drawing.Point(183, 29);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.NumberDecimalDigits = 6;
            this.txtLatitude.Size = new System.Drawing.Size(125, 34);
            this.txtLatitude.TabIndex = 7;
            this.txtLatitude.Text = "1.000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Radius (Meter)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Latitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Longitude";
            // 
            // chkBoxActive
            // 
            this.chkBoxActive.AutoSize = true;
            this.chkBoxActive.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.chkBoxActive.Location = new System.Drawing.Point(232, 156);
            this.chkBoxActive.Name = "chkBoxActive";
            this.chkBoxActive.Size = new System.Drawing.Size(66, 31);
            this.chkBoxActive.TabIndex = 52;
            this.chkBoxActive.Text = "Yes";
            this.chkBoxActive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(44, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 27);
            this.label6.TabIndex = 53;
            this.label6.Text = "Is Active ?";
            // 
            // btnUpdateLocation
            // 
            this.btnUpdateLocation.AccessibleName = "Button";
            this.btnUpdateLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnUpdateLocation.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLocation.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLocation.Location = new System.Drawing.Point(272, 388);
            this.btnUpdateLocation.Name = "btnUpdateLocation";
            this.btnUpdateLocation.Size = new System.Drawing.Size(135, 50);
            this.btnUpdateLocation.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(109)))), ((int)(((byte)(254)))));
            this.btnUpdateLocation.Style.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLocation.TabIndex = 44;
            this.btnUpdateLocation.Text = "Update";
            this.btnUpdateLocation.UseVisualStyleBackColor = false;
            this.btnUpdateLocation.Click += new System.EventHandler(this.btnUpdateLocation_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "Button";
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(432, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 50);
            this.btnCancel.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.btnCancel.Style.ForeColor = System.Drawing.Color.White;
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmLocationEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdateLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkBoxActive);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLocationDesc);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLocationEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Location";
            this.Load += new System.EventHandler(this.FrmLocationEdit_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLatitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLocationDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox txtRadius;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtLongitude;
        private Syncfusion.Windows.Forms.Tools.DoubleTextBox txtLatitude;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkBoxActive;
        private System.Windows.Forms.Label label6;
        private Syncfusion.WinForms.Controls.SfButton btnUpdateLocation;
        private Syncfusion.WinForms.Controls.SfButton btnCancel;
    }
}