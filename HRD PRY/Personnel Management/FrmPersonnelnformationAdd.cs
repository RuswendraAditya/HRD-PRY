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
    public partial class FrmPersonnelnformationAdd : Form
    {
        public FrmPersonnelnformationAdd()
        {
            InitializeComponent();
            loadPosition();
            loadUnit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {   
            if(txtEmployeeNumber.Text == "")
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
                insertPEA();
            }
        }

        private void insertPEA()
        {   
            DateTime now = ClsUtil.getCurrentDate();
            var password = EncodeDecode.Encrypt(txtPassword.Text);
            var unitId = cmbUnit.SelectedValue;
            var positionId = cmbPosition.SelectedValue;
            var gender = cmbGender.Text;

            try
            {
                string query = @"
                                INSERT INTO [dbo].[Employees]
                                           ([Employee_Number]
                                           ,[Employee_Name]
                                           ,[Gender]
                                           ,[Hire_Date]
                                           ,[Birth_Date]
                                           ,[Unit_Id]
                                           ,[Position_id]
                                           ,[created_date]
                                           ,[created_by]
                                           ,[Password])
                                     VALUES
                                           (@Employee_Number
                                           ,@Employee_Name
                                           ,@Gender
                                           ,@Hire_Date
                                           ,@Birth_Date
                                           ,@Unit_Id
                                           ,@Position_id
                                           ,@created_date
                                           ,@created_by
                                           ,@Password)";
                using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
                {

                    cmd.Parameters.AddWithValue("@Employee_Number", txtEmployeeNumber.IntegerValue);
                    cmd.Parameters.AddWithValue("@Employee_Name", txtEmployeeName.Text);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Hire_Date",dtHireDate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Birth_Date", dtBirthDate.Value.ToShortDateString());
                    cmd.Parameters.AddWithValue("@Unit_Id", unitId);
                    cmd.Parameters.AddWithValue("@Position_id", positionId);
                    cmd.Parameters.AddWithValue("@created_date",ClsUtil.currentDateTime);
                    cmd.Parameters.AddWithValue("@created_by", ClsUtil.userLogin);
                    cmd.Parameters.AddWithValue("@Password", password);
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

        private void FrmPersonnelnformationAdd_Load(object sender, EventArgs e)
        {

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
    }
}
