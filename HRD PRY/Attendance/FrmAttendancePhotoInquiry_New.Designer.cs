
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
            this.lvwBooks = new System.Windows.Forms.ListView();
            this.imlLargeIcons = new System.Windows.Forms.ImageList(this.components);
            this.imlSmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // lvwBooks
            // 
            this.lvwBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwBooks.HideSelection = false;
            this.lvwBooks.Location = new System.Drawing.Point(13, 13);
            this.lvwBooks.Margin = new System.Windows.Forms.Padding(4);
            this.lvwBooks.Name = "lvwBooks";
            this.lvwBooks.Size = new System.Drawing.Size(1392, 532);
            this.lvwBooks.TabIndex = 19;
            this.lvwBooks.UseCompatibleStateImageBehavior = false;
            // 
            // imlLargeIcons
            // 
            this.imlLargeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlLargeIcons.ImageStream")));
            this.imlLargeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlLargeIcons.Images.SetKeyName(0, "1_64x64.png");
            this.imlLargeIcons.Images.SetKeyName(1, "2_64x64.png");
            this.imlLargeIcons.Images.SetKeyName(2, "3_64x64.png");
            this.imlLargeIcons.Images.SetKeyName(3, "4_64x64.png");
            this.imlLargeIcons.Images.SetKeyName(4, "5_64x64.png");
            this.imlLargeIcons.Images.SetKeyName(5, "6_64x64.png");
            this.imlLargeIcons.Images.SetKeyName(6, "7_64x64.png");
            // 
            // imlSmallIcons
            // 
            this.imlSmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlSmallIcons.ImageStream")));
            this.imlSmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imlSmallIcons.Images.SetKeyName(0, "1_32x32.png");
            this.imlSmallIcons.Images.SetKeyName(1, "2_32x32.png");
            this.imlSmallIcons.Images.SetKeyName(2, "3_32x32.png");
            this.imlSmallIcons.Images.SetKeyName(3, "4_32x32.png");
            this.imlSmallIcons.Images.SetKeyName(4, "5_32x32.png");
            this.imlSmallIcons.Images.SetKeyName(5, "6_32x32.png");
            this.imlSmallIcons.Images.SetKeyName(6, "7_32x32.png");
            // 
            // FrmAttendancePhotoInquiry_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 558);
            this.Controls.Add(this.lvwBooks);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAttendancePhotoInquiry_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Photo";
            this.Load += new System.EventHandler(this.FrmAttendancePhotoInquiry_New_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwBooks;
        internal System.Windows.Forms.ImageList imlLargeIcons;
        internal System.Windows.Forms.ImageList imlSmallIcons;
    }
}