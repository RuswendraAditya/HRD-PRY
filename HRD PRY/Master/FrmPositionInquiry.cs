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
    public partial class FrmPositionInquiry : Form
    {
        public FrmPositionInquiry()
        {
            InitializeComponent();
            getPositionAll();
        }
		private DataTable getPosition()
		{
			DataTable dt = new DataTable();

			

			string query = @"SELECT * FROM MST_POSITION";
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

        private void  getPositionAll()
        {
			GridLocation.DataSource = getPosition();

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
				int id = (int)rowData["Position_id"];
				FrmPositionEdit frmPositionEdit = new FrmPositionEdit(id);

				frmPositionEdit.ShowDialog();
				frmPositionEdit.Close();
			}


		}

		private void GridLocation_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)

        {
			if (e.Column.MappingName == "Position_Name")
			{
				e.Column.HeaderText = "Position Name";
				e.Column.Width = 200;
				e.Column.AllowFiltering = true;
			
			}
			if (e.Column.MappingName == "Position_id")
			{
				e.Column.HeaderText = "Position Id";
				e.Column.Width = 200;
				e.Column.AllowFiltering = true;
				e.Column.Visible = false;

			}

			
		}

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
			ClsUtil.DownloadXLs(GridLocation);

		}

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
			FrmPositionAdd frmAdd = new FrmPositionAdd();
			frmAdd.Show();
        }
    }
}
