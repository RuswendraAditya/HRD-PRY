using HRD_PRY.Attendance;
using HRD_PRY.Util;
using Syncfusion.Data;
using Syncfusion.WinForms.DataGrid;
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
using DataRow = System.Data.DataRow;

namespace HRD_PRY.Attedance
{
    public partial class FrmAttendanceInquiry : Form
    {
        public FrmAttendanceInquiry()
        {
            InitializeComponent();
			setColumnGrid();


		}
		private void setColumnGrid()

        {

			this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName ="attendance_id"  ,HeaderText="Attendance" ,Visible = false,Width = 100 });
			this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Employee_Number", HeaderText = "Employee Number", Width =120,AllowFiltering = true  });
			this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Employee_Name", HeaderText = "Name", Width =250, AllowFiltering = true });
			this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "unit_name", HeaderText = "Unit", Width = 250, AllowFiltering = true });
			this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Date_attendance", HeaderText = "Date", Width = 120, AllowFiltering = true,Format = "dd-MM-yyyy"});
			this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Clock_in", HeaderText = "Clock In", Width = 120, AllowFiltering = true });
			this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Clock_out", HeaderText = "Clock Out", Width = 120, AllowFiltering = true });
			this.GridAttendance.Columns.Add(new GridTextColumn() { MappingName = "Duration", HeaderText = "Duration", Width = 120, AllowFiltering = true });

			this.GridAttendance.Columns.Add(new GridButtonColumn()
			{
				MappingName = "Photo",
				HeaderText = "Detail Photo",
				AllowDefaultButtonText = true,
				DefaultButtonText = "View Photo",
				Width = 150

			});

			this.GridAttendance.CellButtonClick += GridAttendance_CellButtonClick;


			void GridAttendance_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
			{
				try
				{
					var rowData = (e.Record as Syncfusion.WinForms.DataGrid.DataRow).RowData as DataRowView;
					int id = (int)rowData["attendance_id"];
					if (id > 0)
					{
						FrmAttendancePhotoInquiry_New frmAttendancePhotoInquiry_new = new FrmAttendancePhotoInquiry_New(id);
						frmAttendancePhotoInquiry_new.ShowDialog();
						frmAttendancePhotoInquiry_new.Close();
					}
					else
					{
						MsgBoxUtil.MsgInfo("Data Absen Tidak Ditemukan");
					}

				}
				catch (Exception ex)
				{
					MsgBoxUtil.MsgInfo(ex.Message);
				}


			}
		}
        private void FrmAttendanceInquiry_Load(object sender, EventArgs e)
        {

        }
		private DataTable getAttedance()
		{
			DataTable dt = new DataTable();



			string query = @"SELECT ISNULL(att.attendance_id,0) attendance_id,Employee_Number,Employee_Name, unit.unit_name, att.Date_attendance,att.Clock_in,att.Clock_out,ISNULL(CONVERT(varchar(5), DATEADD(minute, DATEDIFF(MINUTE,  Clock_in,clock_out), 0), 114),'') Duration FROM Employees emp left join Attendance att
							on emp.Employee_id = att.Employee_id LEFT JOIN MST_UNIT unit on unit.unit_id = emp.unit_id
							where ISNULL(att.Date_attendance,@dateAtt) = @dateAtt";
			using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
			{
				cmd.Parameters.AddWithValue("@dateAtt", dtPeriod.Value.ToShortDateString());
				using (SqlDataAdapter da = new SqlDataAdapter(cmd))
				{
					da.Fill(dt);
				}
			}

			return dt;
		}

		private void getAttendanceInquiry()
		{	
			GridAttendance.DataSource = getAttedance();
			
		
		


		}

        private void btnCari_Click(object sender, EventArgs e)
		{
			this.GridAttendance.DataSource = null;
			//this.GridAttendance.Columns.Clear();
			getAttendanceInquiry();
		
		}

        private void GridLocation_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
			if (e.Column.MappingName == "attendance_id")
			{
				e.Column.HeaderText = "Attendance id";
				e.Column.Visible = false;

			}


			if (e.Column.MappingName == "Employee_Number")
			{
				e.Column.HeaderText = "Employee Number";
				e.Column.Width = 200;
				e.Column.AllowFiltering = true;

			}

			if (e.Column.MappingName == "Employee_Name")
			{
				e.Column.HeaderText = "Employee Name";
				e.Column.Width = 2400;
				e.Column.AllowFiltering = true;

			}

			if (e.Column.MappingName == "unit_name")
			{
				e.Column.HeaderText = "Unit";
				e.Column.Width = 150;
				e.Column.AllowFiltering = true;

			}
			if (e.Column.MappingName == "Date_attendance")
			{
				e.Column.HeaderText = "Date";
				e.Column.Width = 120;
				e.Column.Format = "dd-MM-yyyy";

			}
			if (e.Column.MappingName == "Clock_in")
			{
				e.Column.HeaderText = "Clock In";
				e.Column.Width = 100;
				

			}
			if (e.Column.MappingName == "Clock_out")
			{
				e.Column.HeaderText = "Clock Out";
				e.Column.Width = 100;
		

			}
			if (e.Column.MappingName == "Duration")
			{
				e.Column.HeaderText = "Duration";
				e.Column.Width = 100;


			}

		}

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
			ClsUtil.DownloadXLs(GridAttendance);
        }

        private void btnDownloadPhoto_Click(object sender, EventArgs e)
        {
			var folderBrowserDialog1 = new FolderBrowserDialog();

			// Show the FolderBrowserDialog.
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				string folderName = folderBrowserDialog1.SelectedPath;
				saveImageToFolder(folderName);
			  }


		}

		private void saveImageToFolder(string folderName)
        {
            try
            {
				string folder = folderName + "/" + dtPeriod.Value.ToString("dd-MMM-yyyy");
				DataTable dtPhoto = getImageString();
				if (dtPhoto.Rows.Count > 0)
				{
					string employee_number_temp = "";
					int photoSeq = 0;
					if (Directory.Exists(folder))
					{
						clearFolder(folder);
					}
					
					foreach (DataRow row in dtPhoto.Rows)
					{
						photoSeq = photoSeq + 1;
						string employee_name_number = row["employee_number"] + "_" + row["employee_name"];

						string folderfinal = folder + "/" + employee_name_number;
						if (!Directory.Exists(folderfinal))
						{
							Directory.CreateDirectory(folderfinal);
						}

						string filepath = folderfinal + "/" + row["employee_number"] + "_" + photoSeq.ToString() + ".jpeg";


						var bytess = Convert.FromBase64String(row["image_string"].ToString());
						using (var imageFile = new FileStream(filepath, FileMode.Create))
						{
							imageFile.Write(bytess, 0, bytess.Length);
							imageFile.Flush();
						}
						employee_number_temp = row["employee_number"].ToString();
					}

				}
			}
            catch (Exception ex)
            {

				MsgBoxUtil.MsgError(ex.Message.ToString());
            }
			
        }
		private void clearFolder(string FolderName)
		{
			Directory.Delete(FolderName, true);
		}
		private DataTable getImageString()
		{
			DataTable dt = new DataTable();



			string query = @"SELECT ISNULL(att.attendance_id,0) attendance_id,Employee_Number,Employee_Name, photo.* FROM Employees emp left join Attendance att
							on emp.Employee_id = att.Employee_id LEFT JOIN MST_UNIT unit on unit.unit_id = emp.unit_id  JOIN Attendance_Photo photo
							on photo.Attendance_id = att.Attendance_id
							where ISNULL(att.Date_attendance,@date) = @date";
			using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
			{
				cmd.Parameters.AddWithValue("@date", dtPeriod.Value.ToShortDateString());
				using (SqlDataAdapter da = new SqlDataAdapter(cmd))
				{
					da.Fill(dt);
				}
			}

			return dt;
		}

        private void btnDownload_Click(object sender, EventArgs e)
        {
			ClsUtil.DownloadXLs(GridAttendance);
		}
    }
}
