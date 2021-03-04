using HRD_PRY.Util;
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

namespace HRD_PRY.Master
{
    public partial class FrmLocationInquiry : Form
    {
        public FrmLocationInquiry()
        {
            InitializeComponent();
            getLocationAll();
        }
		private DataTable getLocation()
		{
			DataTable dt = new DataTable();

			

			string query = @"SELECT * FROM MST_Location";
			using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
			{
				
				using (SqlDataAdapter da = new SqlDataAdapter(cmd))
				{
					da.Fill(dt);
				}
			}

			return dt;
		}
		private void FrmLocationInquiry_Load(object sender, EventArgs e)
        {

        }

        private void  getLocationAll()
        {
			GridLocation.DataSource = getLocation();

			this.GridLocation.Columns.Add(new GridButtonColumn()
			{
				MappingName = "Edit",
				HeaderText = "Edit",
				AllowDefaultButtonText = true,
				DefaultButtonText = "Edit Data"
				
			});

			this.GridLocation.CellButtonClick += sfDataGrid_CellButtonClick;


			void sfDataGrid_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
			{
				var rowData = (e.Record as Syncfusion.WinForms.DataGrid.DataRow).RowData as DataRowView;
				int id = (int)rowData["Location_Id"];
				FrmLocationEdit frmLocationEdit = new FrmLocationEdit(id);

				frmLocationEdit.ShowDialog();
				frmLocationEdit.Close();
			}


		}

		private void GridLocation_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)

        {
			if (e.Column.MappingName == "Location_Name")
			{
				e.Column.HeaderText = "Location Name";
				e.Column.Width = 200;
				e.Column.AllowFiltering = true;
			
			}
			if (e.Column.MappingName == "Location_Id")
			{
				e.Column.HeaderText = "Location Id";
				e.Column.Width = 200;
				e.Column.AllowFiltering = true;
				e.Column.Visible = false;

			}

			if (e.Column.MappingName == "Location_Desc")
			{
				e.Column.HeaderText = "Location Description";
				e.Column.Width = 400;
				e.Column.AllowFiltering = true;

			}

			if (e.Column.MappingName == "is_active")
			{
				e.Column.HeaderText = "Active";
				e.Column.Width = 200;
				e.Column.AllowFiltering = true;

			}
		}

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
			ClsUtil.DownloadXLs(GridLocation);

		}

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
			FrmLocationAdd frmAdd = new FrmLocationAdd();
			frmAdd.Show();
        }
    }
}
