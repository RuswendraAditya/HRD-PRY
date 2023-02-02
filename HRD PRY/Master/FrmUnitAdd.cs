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
    public partial class FrmUnitAdd : Form
    {
        public FrmUnitAdd()
        {
            InitializeComponent();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (MsgBoxUtil.MsgSave())
            {
                insertUnit();
            }
        }

        private void insertUnit()
        {
            try
            {
                string query = @"INSERT INTO [dbo].[MST_Unit]
                               ([unit_name])
                          VALUES
                               (@unit_name
                                    )";
                using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
                {

                    cmd.Parameters.AddWithValue("@unit_name", txtUnitName.Text);
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
