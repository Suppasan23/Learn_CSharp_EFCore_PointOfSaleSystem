using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learn_CSharp_EFCore_PointOfSaleSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ControlBox = false;
            WindowState = FormWindowState.Maximized;
        }

        private List<Form> openedForms = new List<Form>();

        private void openChildForms(Form f)
        {
            // Check if the form is already open
            foreach (Form showingForm in openedForms) 
            { 
                if (showingForm.GetType() == f.GetType()) 
                {
                    showingForm.Activate();
                    return;
                }
            }

            // Add the form to the list of opened forms
            openedForms.Add(f);

            // Set the form properties and show it
            f.MdiParent = this;
            f.FormClosed += (sender, args) => openedForms.Remove(f);
            f.StartPosition = FormStartPosition.Manual;
            f.Left = 3;
            f.Top = 3;
            f.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagementToolStripButton.PerformClick();
        }

        private void productManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductManagementToolStripButton.PerformClick();
        }

        private void pointOfSaleSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PointOfSaleToolStripButton.PerformClick();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitToolStripButton.PerformClick();
        }

        private void aboutApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.MinimizeBox = false;
            f.MaximizeBox = false;
            openChildForms(f);
        }

        private void UserManagementToolStripButton_Click(object sender, EventArgs e)
        {
            UserManagementForm f = new UserManagementForm();
            f.MinimizeBox = false;
            f.MaximizeBox = false;
            openChildForms(f);
        }

        private void ProductManagementToolStripButton_Click(object sender, EventArgs e)
        {
            ProductManagementForm f = new ProductManagementForm();
            f.MinimizeBox= false;
            f.MaximizeBox= false;
            openChildForms(f);
        }

        private void PointOfSaleToolStripButton_Click(object sender, EventArgs e)
        {
            PointOfSaleForm f = new PointOfSaleForm();
            f.MinimizeBox = false;
            f.MaximizeBox = false;
            openChildForms(f);
        }

        private void LogoutToolStripButton_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
