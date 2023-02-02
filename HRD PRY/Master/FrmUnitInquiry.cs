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
    public partial class FrmUnitInquiry : Form
    {
        public FrmUnitInquiry()
        {
            InitializeComponent();
            getUnitAll();
        }
		private DataTable getUnit()
		{
			DataTable dt = new DataTable();

			

			string query = @"SELECT * FROM MST_UNIT";
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

        private void  getUnitAll()
        {
			GridLocation.DataSource = getUnit();

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
				int id = (int)rowData["Unit_Id"];
				FrmUnitEdit frmUnitEdit = new FrmUnitEdit(id);

				frmUnitEdit.ShowDialog();
				frmUnitEdit.Close();
			}


		}

		private void GridLocation_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)

        {
			if (e.Column.MappingName == "unit_name")
			{
				e.Column.HeaderText = "Unit Name";
				e.Column.Width = 200;
				e.Column.AllowFiltering = true;
			
			}
			if (e.Column.MappingName == "Unit_Id")
			{
				e.Column.HeaderText = "Unit Id";
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
			FrmUnitAdd frmAdd = new FrmUnitAdd();
			frmAdd.Show();
        }
    }
}
