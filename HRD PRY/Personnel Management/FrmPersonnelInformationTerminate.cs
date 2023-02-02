using HRD_PRY.Util;
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

namespace HRD_PRY.Personnel_Management
{
    public partial class FrmPersonnelInformationTerminate : Form
    {
        int empId = 0;
        public FrmPersonnelInformationTerminate()
        {
            InitializeComponent();
        }
        public FrmPersonnelInformationTerminate(int id)
        {
            InitializeComponent();
            empId = id;
            getPersonById();
        }
        private void getPersonById()
        {
            string query = @"SELECT * FROM Employees where Employee_id = @id";
            using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
            {
                cmd.Parameters.AddWithValue("@id", empId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        txtEmployeeNumber.IntegerValue = (int)reader["Employee_Number"];
                        txtEmployeeName.Text = (string)reader["Employee_Name"];
                      


                    }
                    reader.NextResult();

                }
                reader.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateTermination_Click(object sender, EventArgs e)
        {
            if (MsgBoxUtil.MsgUpdateTermination())
            {
                updateTerminate();
            }
        }

        private void updateTerminate()
        {

         
            var dateTimeNow = ClsUtil.getCurrentDate();
            try
            {
                string query = @"
                                UPDATE [dbo].[Employees]
                           SET [termination_date] =@Termination_date
                              ,[updated_date] = @updated_date
                              ,[updated_by] = @updated_by
                         WHERE Employee_id = @emp_id ";
                using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
                {

                    cmd.Parameters.AddWithValue("@Termination_date", dtTermination.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@updated_date", dateTimeNow);
                    cmd.Parameters.AddWithValue("@updated_by", ClsUtil.userLogin);
                    cmd.Parameters.AddWithValue("@emp_id", empId);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MsgBoxUtil.MsgSuccessSave();



                }
            }
            catch (Exception ex)
            {
                MsgBoxUtil.MsgError(ex.Message);
            }


        }
    }
}
