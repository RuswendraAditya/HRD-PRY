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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRD_PRY.Attedance
{
    public partial class FrmAttendanceInquiry : Form
    {
        public FrmAttendanceInquiry()
        {
            InitializeComponent();
        }

        private void FrmAttendanceInquiry_Load(object sender, EventArgs e)
        {

        }
		private DataTable getAttedance()
		{
			DataTable dt = new DataTable();



			string query = @"SELECT ISNULL(att.attendance_id,0) attendance_id,Employee_Number,Employee_Name, unit.unit_name, att.Date_attendance,att.Clock_in,att.Clock_out FROM Employees emp left join Attendance att
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
			
		
			this.GridAttendance.Columns.Add(new GridButtonColumn()
			{
				MappingName = "Photo",
				HeaderText = "Detail Photo",
				AllowDefaultButtonText = true,
				DefaultButtonText = "View Photo",
				Width = 150

			});

			this.GridAttendance.CellButtonClick += sfDataGrid_CellButtonClick;


			void sfDataGrid_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
			{
				try
				{ 
					var rowData = (e.Record as Syncfusion.WinForms.DataGrid.DataRow).RowData as DataRowView;
					int id = (int)rowData["attendance_id"];
					if(id > 0)
                    {
						FrmAttendancePhotoInquiry frmAttendancePhotoInquiry = new FrmAttendancePhotoInquiry(id);
						frmAttendancePhotoInquiry.ShowDialog();
						frmAttendancePhotoInquiry.Close();
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

        private void btnCari_Click(object sender, EventArgs e)
		{
			GridAttendance.DataSource = null;
			this.GridAttendance.Columns.Clear();
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
				e.Column.Width = 300;
				e.Column.AllowFiltering = true;

			}

			if (e.Column.MappingName == "unit_name")
			{
				e.Column.HeaderText = "Unit";
				e.Column.Width = 300;
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
		}

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
			ClsUtil.DownloadXLs(GridAttendance);
        }
    }
}
