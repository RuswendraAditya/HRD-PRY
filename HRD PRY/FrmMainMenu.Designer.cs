
namespace HRD_PRY
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMenu2 = new System.Windows.Forms.Panel();
            this.btnUnitInquiry = new System.Windows.Forms.Button();
            this.btnLocationInquiry = new System.Windows.Forms.Button();
            this.btnMasterData = new System.Windows.Forms.Button();
            this.panelMenu1 = new System.Windows.Forms.Panel();
            this.btnTimeManagement = new System.Windows.Forms.Button();
            this.btnPersonnelInformation = new System.Windows.Forms.Button();
            this.btnPersonelManagement = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnPositionInquiry = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelMenu2.SuspendLayout();
            this.panelMenu1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(98)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panelMenu2);
            this.panel1.Controls.Add(this.btnMasterData);
            this.panel1.Controls.Add(this.panelMenu1);
            this.panel1.Controls.Add(this.btnPersonelManagement);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 937);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(0, 529);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(333, 74);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Log Off(Exit)";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelMenu2
            // 
            this.panelMenu2.Controls.Add(this.btnPositionInquiry);
            this.panelMenu2.Controls.Add(this.btnUnitInquiry);
            this.panelMenu2.Controls.Add(this.btnLocationInquiry);
            this.panelMenu2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu2.Location = new System.Drawing.Point(0, 369);
            this.panelMenu2.Name = "panelMenu2";
            this.panelMenu2.Size = new System.Drawing.Size(333, 160);
            this.panelMenu2.TabIndex = 0;
            // 
            // btnUnitInquiry
            // 
            this.btnUnitInquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btnUnitInquiry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnitInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnitInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUnitInquiry.ForeColor = System.Drawing.Color.White;
            this.btnUnitInquiry.Location = new System.Drawing.Point(0, 52);
            this.btnUnitInquiry.Name = "btnUnitInquiry";
            this.btnUnitInquiry.Size = new System.Drawing.Size(333, 52);
            this.btnUnitInquiry.TabIndex = 1;
            this.btnUnitInquiry.Text = "Unit";
            this.btnUnitInquiry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnitInquiry.UseVisualStyleBackColor = false;
            this.btnUnitInquiry.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLocationInquiry
            // 
            this.btnLocationInquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btnLocationInquiry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLocationInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocationInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnLocationInquiry.ForeColor = System.Drawing.Color.White;
            this.btnLocationInquiry.Location = new System.Drawing.Point(0, 0);
            this.btnLocationInquiry.Name = "btnLocationInquiry";
            this.btnLocationInquiry.Size = new System.Drawing.Size(333, 52);
            this.btnLocationInquiry.TabIndex = 0;
            this.btnLocationInquiry.Text = "Location";
            this.btnLocationInquiry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLocationInquiry.UseVisualStyleBackColor = false;
            this.btnLocationInquiry.Click += new System.EventHandler(this.btnLocationInquiry_Click);
            // 
            // btnMasterData
            // 
            this.btnMasterData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasterData.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMasterData.Location = new System.Drawing.Point(0, 295);
            this.btnMasterData.Name = "btnMasterData";
            this.btnMasterData.Size = new System.Drawing.Size(333, 74);
            this.btnMasterData.TabIndex = 2;
            this.btnMasterData.Text = "Master Data";
            this.btnMasterData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterData.UseVisualStyleBackColor = true;
            this.btnMasterData.Click += new System.EventHandler(this.btnMasterData_Click);
            // 
            // panelMenu1
            // 
            this.panelMenu1.Controls.Add(this.btnTimeManagement);
            this.panelMenu1.Controls.Add(this.btnPersonnelInformation);
            this.panelMenu1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu1.Location = new System.Drawing.Point(0, 189);
            this.panelMenu1.Name = "panelMenu1";
            this.panelMenu1.Size = new System.Drawing.Size(333, 106);
            this.panelMenu1.TabIndex = 0;
            // 
            // btnTimeManagement
            // 
            this.btnTimeManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btnTimeManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTimeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeManagement.ForeColor = System.Drawing.Color.White;
            this.btnTimeManagement.Location = new System.Drawing.Point(0, 52);
            this.btnTimeManagement.Name = "btnTimeManagement";
            this.btnTimeManagement.Size = new System.Drawing.Size(333, 52);
            this.btnTimeManagement.TabIndex = 1;
            this.btnTimeManagement.Text = "Time Attendance";
            this.btnTimeManagement.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimeManagement.UseVisualStyleBackColor = false;
            this.btnTimeManagement.Click += new System.EventHandler(this.btnTimeManagement_Click);
            // 
            // btnPersonnelInformation
            // 
            this.btnPersonnelInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btnPersonnelInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonnelInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnelInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnelInformation.ForeColor = System.Drawing.Color.White;
            this.btnPersonnelInformation.Location = new System.Drawing.Point(0, 0);
            this.btnPersonnelInformation.Name = "btnPersonnelInformation";
            this.btnPersonnelInformation.Size = new System.Drawing.Size(333, 52);
            this.btnPersonnelInformation.TabIndex = 0;
            this.btnPersonnelInformation.Text = "Personnel Information";
            this.btnPersonnelInformation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPersonnelInformation.UseVisualStyleBackColor = false;
            this.btnPersonnelInformation.Click += new System.EventHandler(this.btnPersonnelInformation_Click);
            // 
            // btnPersonelManagement
            // 
            this.btnPersonelManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonelManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonelManagement.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPersonelManagement.Location = new System.Drawing.Point(0, 115);
            this.btnPersonelManagement.Name = "btnPersonelManagement";
            this.btnPersonelManagement.Size = new System.Drawing.Size(333, 74);
            this.btnPersonelManagement.TabIndex = 0;
            this.btnPersonelManagement.Text = "Personnel Management";
            this.btnPersonelManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonelManagement.UseVisualStyleBackColor = true;
            this.btnPersonelManagement.Click += new System.EventHandler(this.btnPersonelManagement_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(333, 115);
            this.panelLogo.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(333, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1201, 937);
            this.panelChildForm.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HRD_PRY.Properties.Resources.PRY_Logo_OnlyJPG;
            this.pictureBox2.Location = new System.Drawing.Point(40, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(254, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnPositionInquiry
            // 
            this.btnPositionInquiry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(64)))), ((int)(((byte)(122)))));
            this.btnPositionInquiry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPositionInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPositionInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnPositionInquiry.ForeColor = System.Drawing.Color.White;
            this.btnPositionInquiry.Location = new System.Drawing.Point(0, 104);
            this.btnPositionInquiry.Name = "btnPositionInquiry";
            this.btnPositionInquiry.Size = new System.Drawing.Size(333, 52);
            this.btnPositionInquiry.TabIndex = 2;
            this.btnPositionInquiry.Text = "Position";
            this.btnPositionInquiry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPositionInquiry.UseVisualStyleBackColor = false;
            this.btnPositionInquiry.Click += new System.EventHandler(this.btnPositionInquiry_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1534, 937);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HRMS Pusat Rehabilitasi Yakkum";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panelMenu2.ResumeLayout(false);
            this.panelMenu1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPersonelManagement;
        private System.Windows.Forms.Panel panelMenu1;
        private System.Windows.Forms.Button btnPersonnelInformation;
        private System.Windows.Forms.Button btnTimeManagement;
        private System.Windows.Forms.Button btnMasterData;
        private System.Windows.Forms.Panel panelMenu2;
        private System.Windows.Forms.Button btnLocationInquiry;
        private System.Windows.Forms.Button btnUnitInquiry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPositionInquiry;
    }
}