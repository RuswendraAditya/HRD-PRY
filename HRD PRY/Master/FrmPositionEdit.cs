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
    public partial class FrmPositionEdit : Form
    {
        private int pos_id;
        public FrmPositionEdit()
        {
            InitializeComponent();
        }
        public FrmPositionEdit(int pos)
        {
            InitializeComponent();
             pos_id =pos;
            getDataPosById(pos_id);
        }

        private void FrmLocationEdit_Load(object sender, EventArgs e)
        {

        }


        private void getDataPosById(int position_id)
        {

            string query = @"SELECT * FROM MST_POSITION where Position_id = @pos_id";
            using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
            {
                cmd.Parameters.AddWithValue("@pos_id", position_id);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      
                        txtPositionName.Text = reader["Position_Name"].ToString();
                     
                    }
                    reader.NextResult();

                }
                reader.Close();
            }


        }

        private void updatePosition()
        {
            try
            {
                string query = @"
                                UPDATE [dbo].[MST_POSITION]
                                   SET [Position_Name] =@Position_Name
                                 WHERE  Position_id = @Position_id";
                using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
                {

                    cmd.Parameters.AddWithValue("@Position_Name", txtPositionName.Text);
                    cmd.Parameters.AddWithValue("@Position_id", pos_id);
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
                updatePosition();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}