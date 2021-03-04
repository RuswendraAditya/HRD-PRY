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
    public partial class FrmLocationAdd : Form
    {
        public FrmLocationAdd()
        {
            InitializeComponent();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (MsgBoxUtil.MsgSave())
            {
                insertLocation();
            }
        }

        private void insertLocation()
        {
            try
            {
                string query = @"INSERT INTO [dbo].[MST_Location]
                               ([Location_Name]
                               ,[Lattitude]
                               ,[Longitude]
                               ,[Radius]
                               ,[Location_Desc]
                               ,[is_active])
                          VALUES
                               (@location_name
                               , @latitude
                               , @longitude
                               , @radius
                               , @location_desc
                               , @is_acitve)";
                using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
                {

                    cmd.Parameters.AddWithValue("@location_name", txtLocationName.Text);
                    cmd.Parameters.AddWithValue("@latitude", txtLatitude.DoubleValue);
                    cmd.Parameters.AddWithValue("@longitude", txtLongitude.DoubleValue);
                    cmd.Parameters.AddWithValue("@Radius", txtRadius.IntegerValue);
                    cmd.Parameters.AddWithValue("@Location_Desc", txtLocationDesc.Text);
                    cmd.Parameters.AddWithValue("@is_acitve", true);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    MsgBoxUtil.MsgSuccessSave();



                }
            }
            catch(Exception ex)
            {
                MsgBoxUtil.MsgError(ex.Message);
            }
           

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
