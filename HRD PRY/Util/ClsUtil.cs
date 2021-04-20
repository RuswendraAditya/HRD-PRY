using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.XlsIO;
using Syncfusion.WinForms.DataGridConverter;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace HRD_PRY.Util
{
  public static  class ClsUtil
    {

        public static DateTime currentDateTime;
        public static string userLogin ;

        public static string GetSetting(string table, string column, string where, string param)
        {
            string result = "";
            SqlDataReader dr;

            string SQLText = "SELECT " + column + " as result from " + table + " where " + where + "='" + param + "'";
            SqlCommand objcommand = new SqlCommand(SQLText, ConnUtil.connection);
            dr = objcommand.ExecuteReader();
            while (dr.Read())
            {
                result = (string)dr["result"];
            }


            dr.Close();
            return result;
        }
        public static DateTime  getCurrentDate()
        {
           
            string query = @"SELECT  getDate() as currentDate " ;
            using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
            {
             
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        currentDateTime = (DateTime)reader["currentDate"];
                    }
                }
                reader.Close();
            }
            return currentDateTime;
        }
        public static IEnumerable<Tuple<DateTime, DateTime>> Split(DateTime start, DateTime end, int chunk)
        {
            DateTime chunkEnd;
            while ((chunkEnd = start.AddDays(chunk)) < end)
            {
                yield return Tuple.Create(start, chunkEnd);
                start = chunkEnd.AddDays(1);
            }
            yield return Tuple.Create(start, start.AddDays(chunk));
        }
        public static void DownloadXLs(SfDataGrid sfDataGrid)
        {
            var options = new ExcelExportingOptions();
            options.ExcelVersion = ExcelVersion.Excel2013;
            foreach (var columns in sfDataGrid.Columns)
            {
                if (!columns.Visible)
                    options.ExcludeColumns.Add(columns.MappingName);
                
            }
            //   options.CellExporting += CellExportingHandler;
            var excelEngine = sfDataGrid.ExportToExcel(sfDataGrid.View, options);
            var workBook = excelEngine.Excel.Workbooks[0];

            SaveFileDialog saveFilterDialog = new SaveFileDialog
            {
                FilterIndex = 2,
                Filter = "Excel 97 to 2003 Files(*.xls)|*.xls|Excel 2007 to 2010 Files(*.xlsx)|*.xlsx|Excel 2013 File(*.xlsx)|*.xlsx"
            };

            if (saveFilterDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (Stream stream = saveFilterDialog.OpenFile())
                {
                    if (saveFilterDialog.FilterIndex == 1)
                        workBook.Version = ExcelVersion.Excel97to2003;
                    else if (saveFilterDialog.FilterIndex == 2)
                        workBook.Version = ExcelVersion.Excel2010;
                    else
                        workBook.Version = ExcelVersion.Excel2013;
                    workBook.SaveAs(stream);
                }

                if (MessageBox.Show(sfDataGrid, "Apakah anda ingin membuka file excel hasil download ?", "Download Sukses!!",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    System.Diagnostics.Process.Start(saveFilterDialog.FileName);
                }
            }
        }
    }
}
