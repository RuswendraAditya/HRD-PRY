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
    public partial class FrmPersonnelInformationEdit : Form
    {
        int empId = 0;
        public FrmPersonnelInformationEdit(int id)
        {
            InitializeComponent();
            empId = id;
            loadPosition();
            loadUnit();
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
                         cmbGender.SelectedItem = (string)reader["Gender"];
                         cmbUnit.SelectedValue = (int)reader["Unit_Id"];
                         cmbPosition.SelectedValue = (int)reader["Position_Id"];
                          if (reader["Password"].ToString().Length > 0)
                             {
                            var passwordEnc = (string)reader["Password"];
                            var passwordDec = EncodeDecode.Decrypt(passwordEnc);
                            txtPassword.Text = passwordDec;
                               }
                          
                       
                    }
                    reader.NextResult();

                }
                reader.Close();
            }
        }
        private void loadUnit()
        {
            cmbUnit.DisplayMember = "Text";
            cmbUnit.ValueMember = "Value";
            DataTable tb = new DataTable();
            tb.Columns.Add("Text", typeof(string));
            tb.Columns.Add("Value", typeof(int));
            string strsql = "SELECT unit_name,unit_id FROM [MST_Unit] order by unit_name asc";
            SqlCommand objcommand = new SqlCommand(strsql, ConnUtil.connection);
            SqlDataReader objdatareader;
            objdatareader = objcommand.ExecuteReader();
            while (objdatareader.Read())
            {
                tb.Rows.Add(objdatareader[0], objdatareader[1]);
            }

            cmbUnit.DataSource = tb;
            objdatareader.Close();

        }

        private void loadPosition()
        {
            cmbPosition.DisplayMember = "Text";
            cmbPosition.ValueMember = "Value";
            DataTable tb = new DataTable();
            tb.Columns.Add("Text", typeof(string));
            tb.Columns.Add("Value", typeof(int));
            string strsql = "SELECT position_name,position_id FROM [MST_Position] order by position_name asc";
            SqlCommand objcommand = new SqlCommand(strsql, ConnUtil.connection);
            SqlDataReader objdatareader;
            objdatareader = objcommand.ExecuteReader();
            while (objdatareader.Read())
            {
                tb.Rows.Add(objdatareader[0], objdatareader[1]);
            }

            cmbPosition.DataSource = tb;
            objdatareader.Close();

        }
        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            if (txtEmployeeNumber.Text == "")
            {
                MsgBoxUtil.MsgInfo("Employee Number Belum Diisi!!");
                return;
            }
            if (txtEmployeeName.Text == "")
            {
                MsgBoxUtil.MsgInfo("Employee Name Belum Diisi!!");
                return;
            }
            if (txtPassword.Text == "")
            {
                MsgBoxUtil.MsgInfo("Password Belum Diisi!!");
                return;
            }
            if (cmbGender.Text == "")
            {
                MsgBoxUtil.MsgInfo("Gender Belum Diisi!!");
                return;
            }
            if (MsgBoxUtil.MsgSave())
            {
                updatePEA();
            }
        }

        private void updatePEA()
        {
            var password = EncodeDecode.Encrypt(txtPassword.Text);
            var unitId = cmbUnit.SelectedValue;
            var positionId = cmbPosition.SelectedValue;
            var gender = cmbGender.Text;
            var dateTimeNow = ClsUtil.getCurrentDate();
            try
            {
                string query = @"
                                UPDATE [dbo].[Employees]
                           SET [Employee_Number] =@Employee_Number
                              ,[Employee_Name] = @Employee_Name
                              ,[Gender] = @Gender
                              ,[Hire_Date] =@Hire_Date
                              ,[Birth_Date] =@Birth_Date
                              ,[Unit_Id] = @Unit_Id
                              ,[Position_id] = @Position_id
                              ,[Password] = @Password
                              ,[updated_date] = @updated_date
                              ,[updated_by] = @updated_by
                         WHERE Employee_id = @emp_id ";
                using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
                {

                    cmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.IntegerValue);
                    cmd.Parameters.AddWithValue("@Employee_Name", txtEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Hire_Date", dtHireDate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Birth_Date", dtBirthDate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Unit_Id", unitId);
                    cmd.Parameters.AddWithValue("@Position_id", positionId);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@updated_date", ClsUtil.currentDateTime);
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

        private void FrmPersonnelInformationEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
