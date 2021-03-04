using HRD_PRY.Attedance;
using HRD_PRY.Master;
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
    public partial class FrmMainMenu : Form
    {

      
        public FrmMainMenu()
        {
            InitializeComponent();
            hideSubMenu();
          
          
        }

        private void hideSubMenu()
        {
            panelMenu1.Visible = false;
            panelMenu2.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void FrmMainMenu_Load(object sender, EventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPersonelManagement_Click(object sender, EventArgs e)
        {

            showSubMenu(panelMenu1);
        }

        private void btnPersonnelInformation_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmPersonnelnformationInquiry());
            //..
            //your codes
            //..
            //hideSubMenu();
        }

        private void btnMasterData_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenu2);
        }

        private void btnLocationInquiry_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmLocationInquiry());
        }

        private void btnTimeManagement_Click(object sender, EventArgs e)
        {

            openChildForm(new FrmAttendanceInquiry());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin frmLogin = new FrmLogin();
            
            frmLogin.ShowDialog();
            Close();

        }
    }
}
