using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComputerizedCarRentalSystem
{
    public partial class MDICarRental : Form
    {
        private string UserType;
        private string Username;
        private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\DbCarRental.accdb;Persist Security Info=True");
        //private OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Project 2016\ComputerizedCarRentalSystem\ComputerizedCarRentalSystem\DbCarRental.accdb;Persist Security Info=True");
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;

        public MDICarRental(string usertype, string username)
        {
            InitializeComponent();
            UserType = usertype;
            Username = username;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            FrmCarRegistration childForm = new FrmCarRegistration();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            FrmEditCarRegistration childForm = new FrmEditCarRegistration();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllRentedCars childForm = new FrmAllRentedCars(UserType, Username);
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllReturnedCars childForm = new FrmAllReturnedCars(UserType, Username);
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllCustomers childForm = new FrmAllCustomers();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MDICarRental_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
            if (UserType == "Administrator")
            {
                AdminUserMenu.Visible = true;
                CarRegistrationMenu.Visible = true;
                bookingMenu.Visible = false;
                settingsMenu.Visible = false;
                tileHorizontalToolStripMenuItem.Visible = true;
            }
            else if (UserType == "Customer")
            {
                AdminUserMenu.Visible = false;
                CarRegistrationMenu.Visible = false;
                bookingMenu.Visible = true;
                settingsMenu.Visible = true;
                tileHorizontalToolStripMenuItem.Visible = false;
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCarBooking childForm = new FrmCarBooking(Username);
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void returnBookedRentedCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkAlreadyRented(Username))
            {
                FrmCarReturn childForm = new FrmCarReturn(Username);
                childForm.MdiParent = this;
                childForm.Show();
            }
            else
            {
                MessageBox.Show("You have not rented any car. No car to return", "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool checkAlreadyRented(string user)
        {
            bool isAlreadyRented = false;
            try
            {
                cn.Open();
                cmd.CommandText = "select BookingStatus from tblCustomer Where (CustomerId = '" + user + "') AND (BookingStatus > 0)";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    isAlreadyRented = true; //the user has already rented a car before
                }
                dr.Close();
                cn.Close();
            }
            catch (Exception Er)
            {
                dr.Close();
                cn.Close();
                MessageBox.Show(Er.Message, "Car Rental App", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isAlreadyRented;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCreateAdminUser childForm = new FrmCreateAdminUser();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void changeCustomerPasswordMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangeCustomerPassword childForm = new FrmChangeCustomerPassword(Username);
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangeAdminPassword childForm = new FrmChangeAdminPassword();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAllRegisteredCars childForm = new FrmAllRegisteredCars();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutCarRentalApp childForm = new AboutCarRentalApp();
            childForm.MdiParent = this;
            childForm.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Application.Exit();
            FrmHomePage home = new FrmHomePage();
            home.Show();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (UserType == "Administrator")
            {
                ShowNewForm(sender, e);
            }
            else if (UserType == "Customer")
            {
                optionsToolStripMenuItem_Click(sender, e);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (UserType == "Administrator")
            {
                OpenFile(sender, e);
            }
            else if (UserType == "Customer")
            {
                returnBookedRentedCarToolStripMenuItem_Click(sender, e);
            }
        }
    }
}
