using HRD_PRY.Personnel_Management;
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

namespace HRD_PRY
{
    public partial class FrmPersonnelnformationInquiry : Form
    {
        public FrmPersonnelnformationInquiry()
        {
            InitializeComponent();
            getPEA();
            gridPersonnelInformations.AllowEditing = false;
        }

        private void FrmPersonnelnformationInquiry_Load(object sender, EventArgs e)
        {

        }

        private void getPEA()
        {
            gridPersonnelInformations.DataSource =getData();
            this.gridPersonnelInformations.Columns.Add(new GridButtonColumn()
            {
                MappingName = "Edit",
                HeaderText = "Edit",
                AllowDefaultButtonText = true,
                DefaultButtonText = "Edit Data"

            });
            this.gridPersonnelInformations.Columns.Add(new GridButtonColumn()
            {
                MappingName = "Terminate",
                HeaderText = "Terminate",
                AllowDefaultButtonText = true,
                DefaultButtonText = "Terminate"

            });
            this.gridPersonnelInformations.CellButtonClick += sfDataGrid_CellButtonClick;


            void sfDataGrid_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
            {
                var rowData = (e.Record as Syncfusion.WinForms.DataGrid.DataRow).RowData as DataRowView;
                int id = (int)rowData["Employee_id"];
                
                if(e.DisplayText == "Edit Data")
                {
                    FrmPersonnelInformationEdit frmLocationEdit = new FrmPersonnelInformationEdit(id);

                    frmLocationEdit.ShowDialog();
                    frmLocationEdit.Close();
                }
                else
                {

                    FrmPersonnelInformationTerminate frmLocationEdit = new FrmPersonnelInformationTerminate(id);

                    frmLocationEdit.ShowDialog();
                    frmLocationEdit.Close();
                }

            }
              
        }

        private object getData()
        {
            DataTable dt = new DataTable();



            string query = @"SELECT Employee_id,Employee_Number,Employee_Name,Gender,Hire_Date,Birth_Date ,unit.unit_name as Unit,Position_Name as Position  from EMPLOYEES emp
                                join MST_Unit unit 
                                on unit.unit_id = emp.Unit_Id  JOIN MST_Position position on position.position_id = emp.position_id where ISNULL(Termination_Date,'') = ''";
            using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
            {

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }

        private void gridPersonnelInformations_AutoGeneratingColumn(object sender, Syncfusion.WinForms.DataGrid.Events.AutoGeneratingColumnArgs e)
        {
            if (e.Column.MappingName == "Employee_id")
            {
                e.Column.Visible = false;

            }
            if (e.Column.MappingName == "Employee_Number")
            {
                e.Column.HeaderText = "Employee Number";
                e.Column.Width = 160;
                e.Column.AllowFiltering = true;

            }

            if (e.Column.MappingName == "Employee_Name")
            {
                e.Column.HeaderText = "Employee Name";
                e.Column.Width = 200;
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "Hire_Date")
            {
                e.Column.HeaderText = "Hire Date";
                e.Column.Format = "dd-MMM-yyyy";
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "Birth_Date")
            {
                e.Column.HeaderText = "Birth Date";
                e.Column.Format = "dd-MMM-yyyy";
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "Unit")
            {
                e.Column.Width = 200;
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "Position")
            {
                e.Column.Width = 200;
                e.Column.AllowFiltering = true;

            }
            if (e.Column.MappingName == "Gender")
            {
                e.Column.Width = 100;
                e.Column.AllowFiltering = true;

            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            FrmPersonnelnformationAdd personnelnformationAdd = new FrmPersonnelnformationAdd();
            personnelnformationAdd.ShowDialog();
            personnelnformationAdd.Close();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ClsUtil.DownloadXLs(gridPersonnelInformations);
        }
    }
}
