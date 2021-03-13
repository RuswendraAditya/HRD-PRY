using HRD_PRY.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD_PRY.Attendance
{
    public partial class FrmAttendancePhotoInquiry_New : Form
    {
        public int Id { get; }
        public FrmAttendancePhotoInquiry_New()
        {
            InitializeComponent();
        }
        public FrmAttendancePhotoInquiry_New(int id)
        {
            InitializeComponent();

            Id = id;
            // Initialize the ListView.
            lvwBooks.SmallImageList = imlSmallIcons;
            lvwBooks.LargeImageList = imlLargeIcons;

            // Make the column headers.
            lvwBooks.MakeColumnHeaders(
                "Upload Date", 230, HorizontalAlignment.Left
              );
            getImage();


        }

        private void getImage()
        {
            DataTable dtImage = new DataTable();
            dtImage = getImageString();
            int i = 0;
            foreach (DataRow row in dtImage.Rows)
            {
                i = i + 1;


                try

                {
                    byte[] bytes = Convert.FromBase64String(row["image_string"].ToString());
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {

                        Bitmap bm = new Bitmap(Image.FromStream(ms));
                        float source_aspect = bm.Width / (float)bm.Height;
                        AddImageToImageList(imlLargeIcons,
                                bm,i.ToString(),
                                imlLargeIcons.ImageSize.Width,
                                imlLargeIcons.ImageSize.Height);
                    }

                    lvwBooks.AddRow(i.ToString(),row["upload_date"].ToString());  // Year


                }
               
                catch (Exception ex)

                {

                    MsgBoxUtil.MsgError(ex.Message.ToString());

                }
                lvwBooks.View = View.LargeIcon;
            }
        }

      
        private DataTable getImageString()
        {
            DataTable dt = new DataTable();



            string query = @"SELECT * FROM Attendance_Photo where Attendance_id = @id";
            using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
            {
                cmd.Parameters.AddWithValue("@id", Id);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        // Scale the image to fit in the ImageList and add it.
        private void AddImageToImageList(ImageList iml, Bitmap bm,
            string key, float wid, float hgt)
        {
            // Make the bitmap.
            Bitmap iml_bm = new Bitmap(
                iml.ImageSize.Width,
                iml.ImageSize.Height);
            using (Graphics gr = Graphics.FromImage(iml_bm))
            {
                gr.Clear(Color.Transparent);
                gr.InterpolationMode = InterpolationMode.High;

                // See where we need to draw the image to scale it properly.
                RectangleF source_rect = new RectangleF(
                    0, 0, bm.Width, bm.Height);
                RectangleF dest_rect = new RectangleF(
                    0, 0, iml_bm.Width, iml_bm.Height);
                dest_rect = ScaleRect(source_rect, dest_rect);

                // Draw the image.
                gr.DrawImage(bm, dest_rect, source_rect,
                    GraphicsUnit.Pixel);
            }

            // Add the image to the ImageList.
            iml.Images.Add(key, iml_bm);
        }

        // Convert a byte array into an image.
        private Bitmap BytesToImage(byte[] bytes)
        {
            using (MemoryStream image_stream =
                new MemoryStream(bytes))
            {
                Bitmap bm = new Bitmap(image_stream);
                return bm;
            }
        }

        // Scale an image without disorting it.
        // Return a centered rectangle in the destination area.
        private RectangleF ScaleRect(
            RectangleF source_rect, RectangleF dest_rect)
        {
            float source_aspect =
                source_rect.Width / source_rect.Height;
            float wid = dest_rect.Width;
            float hgt = dest_rect.Height;
            float dest_aspect = wid / hgt;

            if (source_aspect > dest_aspect)
            {
                // The source is relatively short and wide.
                // Use all of the available width.
                hgt = wid / source_aspect;
            }
            else
            {
                // The source is relatively tall and thin.
                // Use all of the available height.
                wid = hgt * source_aspect;
            }

            // Center it.
            float x = dest_rect.Left + (dest_rect.Width - wid) / 2;
            float y = dest_rect.Top + (dest_rect.Height - hgt) / 2;
            return new RectangleF(x, y, wid, hgt);
        }
        private void FrmAttendancePhotoInquiry_New_Load(object sender, EventArgs e)
        {

        }
    }
}

