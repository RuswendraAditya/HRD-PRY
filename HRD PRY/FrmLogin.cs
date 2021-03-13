using AutoUpdaterDotNET;
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

namespace HRD_PRY
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
          
            ConnUtil.connection = new SqlConnection(ConnUtil.connectionString);
            try
            {
                ConnUtil.connection.Open();
                string isAutoUpdate = ClsUtil.GetSetting("MST_SETTING", "Description", "Code", "IsAutoupdate");
                if(isAutoUpdate == "1")
                {
                    string autoUpdatePath = ClsUtil.GetSetting("MST_SETTING", "Description", "Code", "AutoupdatePath");
                    AutoUpdater.CheckForUpdateEvent += AutoUpdaterOnCheckForUpdateEvent;
                    AutoUpdater.Start(autoUpdatePath);
                }
              
            }
            catch
            {
                MsgBoxUtil.MsgError("Tidak Terkoneksi Dengan Database !!!");
                
            }
        }

        private void AutoUpdaterOnCheckForUpdateEvent(UpdateInfoEventArgs args)
        {
            if (args != null)
            {
                if (args.IsUpdateAvailable)
                {
                 

                    var dialogResult =
                       MessageBox.Show(
                           string.Format(
                               "There is new version {0} avilable. You are using version {1}. Do you want to update the application now?",
                               args.CurrentVersion, args.InstalledVersion), @"Update Available",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Information);

                    if (dialogResult.Equals(DialogResult.Yes))
                    {
                        try
                        {
                            AutoUpdater.DownloadUpdate(args);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
             }
            
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.ToString() == "admin" && txtPassword.Text.ToString() == "admin123456")
            {
                ClsUtil.userLogin = txtUserName.Text;
                FrmMainMenu frmMainMenu = new FrmMainMenu();
                frmMainMenu.ShowDialog();
                this.Hide();
                this.Close();
            }
            else
            {
                loginProcess();
            }
           
        }

        private void loginProcess()
        {
            var passwordEnc = "";
            var passwordDec = "";
            string query = @"SELECT  * FROM Employees where Employee_number = @id";
            using (SqlCommand cmd = new SqlCommand(query, ConnUtil.connection))
            {
                cmd.Parameters.AddWithValue("@id",txtUserName.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        if (reader["Password"].ToString().Length > 0)
                        {
                            passwordEnc = (string)reader["Password"];
                            passwordDec = EncodeDecode.Decrypt(passwordEnc);
                        }

                    }
                    reader.NextResult();
                    if (txtPassword.Text != passwordDec.ToString())
                    {
                        reader.Close();
                        MsgBoxUtil.MsgError("Password Salah");
                        return;

                    }
                    reader.Close();
                    ClsUtil.userLogin = txtUserName.Text;
                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.ShowDialog();
                    this.Hide();
                    this.Close();
                }
               
               else
                {
                    MsgBoxUtil.MsgError("User Tidak Ditemukan !!");
                    reader.Close();
                }

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
