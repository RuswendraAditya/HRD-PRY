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
    public partial class FrmLocationEdit : Form
    {
        private int loc_id;
        public FrmLocationEdit()
        {
            InitializeComponent();
        }
        public FrmLocationEdit(int location_id)
        {
            InitializeComponent();
            loc_id = location_id;
           getDataLocationById(loc_id);
        }

        private void FrmLocationEdit_Load(object sender, EventArgs e)
        {

        }


        private void getDataLocationById(int location_id)
        {

            string query = @"SELECT * FROM MST_Location where location_id = @location_id";
            using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
            {
                cmd.Parameters.AddWithValue("@location_id", location_id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      
                        txtLocationName.Text = reader["Location_Name"].ToString();
                        txtLatitude.DoubleValue = (double)reader["Lattitude"];
                        txtLongitude.DoubleValue = (double)reader["Longitude"];
                        txtRadius.IntegerValue  = (int)reader["Radius"];
                        txtLocationDesc.Text = reader["Location_Desc"].ToString();
                        chkBoxActive.Checked = (bool)reader["is_active"];
                    }
                    reader.NextResult();

                }
                reader.Close();
            }


        }

        private void updateLocation()
        {
            try
            {
                string query = @"
                                UPDATE [dbo].[MST_Location]
                                   SET [Location_Name] =@location_name
                                      ,[Lattitude] = @lattitude
                                      ,[Longitude] = @longitude
                                      ,[Radius] = @radius
                                      ,[Location_Desc] = @location_desc
                                      ,[is_active] = @is_acitve
                                 WHERE location_id = @location_id";
                using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
                {

                    cmd.Parameters.AddWithValue("@location_name", txtLocationName.Text);
                    cmd.Parameters.AddWithValue("@lattitude", txtLatitude.DoubleValue);
                    cmd.Parameters.AddWithValue("@longitude", txtLongitude.DoubleValue);
                    cmd.Parameters.AddWithValue("@Radius", txtRadius.IntegerValue);
                    cmd.Parameters.AddWithValue("@location_desc", txtLocationDesc.Text);
                    cmd.Parameters.AddWithValue("@is_acitve", chkBoxActive.Checked);
                    cmd.Parameters.AddWithValue("@location_id", loc_id);
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
                updateLocation();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}