using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD_PRY.Attendance
{
    public partial class FrmAttendancePhotoInquiry : Form
    {
        public int Id { get; }

        public FrmAttendancePhotoInquiry()
        {
            InitializeComponent();
            getImage();
        }

        public FrmAttendancePhotoInquiry(int id)
        {
            InitializeComponent();
          
            Id = id;
            getImage();
        }

        private void FrmAttedancePhotoInquiry_Load(object sender, EventArgs e)
        {

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

        private void getImage()
        {
            ImageList imageList = new ImageList();
            this.imageListView.Items.Clear();
            DataTable dtImage = new DataTable();
            dtImage = getImageString();
            foreach (DataRow row in dtImage.Rows)
            {
            
            

                try

                {
                    byte[] bytes = Convert.FromBase64String(row["image_string"].ToString());
                   using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        imageList.Images.Add(Image.FromStream(ms));
                    }

                  

                }

                catch(Exception ex)

                {

                    MsgBoxUtil.MsgError(ex.Message.ToString());

                }

            }



            imageList.ImageSize = new Size(256, 256);

            this.imageListView.View = View.LargeIcon;
            for (int counter = 0; counter < imageList.Images.Count; counter++)

            {

                ListViewItem item = new ListViewItem();

                item.ImageIndex = counter;

                this.imageListView.Items.Add(item);

            }

            this.imageListView.LargeImageList = imageList;

        }
    }
}
