
namespace HRD_PRY.Attendance
{
    partial class FrmAttendancePhotoInquiry_New
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAttendancePhotoInquiry_New));
            this.listViewImage = new System.Windows.Forms.ListView();
            this.listImage = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // listViewImage
            // 
            this.listViewImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewImage.HideSelection = false;
            this.listViewImage.Location = new System.Drawing.Point(13, 13);
            this.listViewImage.Margin = new System.Windows.Forms.Padding(4);
            this.listViewImage.Name = "listViewImage";
            this.listViewImage.Size = new System.Drawing.Size(1392, 532);
            this.listViewImage.TabIndex = 19;
            this.listViewImage.UseCompatibleStateImageBehavior = false;
            // 
            // listImage
            // 
            this.listImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("listImage.ImageStream")));
            this.listImage.TransparentColor = System.Drawing.Color.Transparent;
            this.listImage.Images.SetKeyName(0, "1_64x64.png");
            this.listImage.Images.SetKeyName(1, "2_64x64.png");
            this.listImage.Images.SetKeyName(2, "3_64x64.png");
            this.listImage.Images.SetKeyName(3, "4_64x64.png");
            this.listImage.Images.SetKeyName(4, "5_64x64.png");
            this.listImage.Images.SetKeyName(5, "6_64x64.png");
            this.listImage.Images.SetKeyName(6, "7_64x64.png");
            // 
            // FrmAttendancePhotoInquiry_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 558);
            this.Controls.Add(this.listViewImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAttendancePhotoInquiry_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Photo";
            this.Load += new System.EventHandler(this.FrmAttendancePhotoInquiry_New_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewImage;
        internal System.Windows.Forms.ImageList listImage;
    }
}