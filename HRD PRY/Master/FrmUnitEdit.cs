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
    public partial class FrmUnitEdit : Form
    {
        private int unit_id;
        public FrmUnitEdit()
        {
            InitializeComponent();
        }
        public FrmUnitEdit(int unit)
        {
            InitializeComponent();
            unit_id =unit;
           getDataUnitById(unit_id);
        }

        private void FrmLocationEdit_Load(object sender, EventArgs e)
        {

        }


        private void getDataUnitById(int location_id)
        {

            string query = @"SELECT * FROM MST_Unit where unit_id = @unit_id";
            using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
            {
                cmd.Parameters.AddWithValue("@unit_id", location_id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      
                        txtUnitName.Text = reader["Unit_Name"].ToString();
                     
                    }
                    reader.NextResult();

                }
                reader.Close();
            }


        }

        private void updateUnit()
        {
            try
            {
                string query = @"
                                UPDATE [dbo].[MST_Unit]
                                   SET [unit_name] =@unit_name
                                 WHERE  Unit_Id = @unit_id";
                using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
                {

                    cmd.Parameters.AddWithValue("@unit_name", txtUnitName.Text);
                    cmd.Parameters.AddWithValue("@unit_id", unit_id);
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

        private void btnUpdateLocation_Click(object sender, EventArgs e)
        {

            if (MsgBoxUtil.MsgSave())
            {
                updateUnit();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}