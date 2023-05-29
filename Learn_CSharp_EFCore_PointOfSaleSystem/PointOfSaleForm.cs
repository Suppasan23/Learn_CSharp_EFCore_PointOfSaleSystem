﻿using System;
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
    public partial class PointOfSaleForm : Form
    {
        public PointOfSaleForm()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        }


        ///////////////////////////////////////Form Load///////////////////////////////////////
        private void PointOfSaleForm_Load(object sender, EventArgs e)
        {
            CurrentDateTextBox.Text = DateTime.Now.ToLongDateString();

            //Login
            EmployeeIDTextBox.Text = "1";
            EmployeeNameTextBox.Text = "Employee1";

            CustomerIDTextBox.Text = "1";
            CustomerNameTextBox.Text = "Customer1";

            StatusStripStatusLabel1.Text = String.Format("Hello, {0}", EmployeeNameTextBox.Text);

            string[] header = new[] { "ID", "Barcode", "product", "Product Name", "Selling Price", "Quantity", "Subtotal" };
            dataGridView1.ColumnCount = header.Length; //6

            for (var i = 0; i < header.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = header[i];
                dataGridView1.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 165;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 150;

        }

        ///////////////////////////////////////timer1 Tick///////////////////////////////////////
        private void timer1_Tick(object sender, EventArgs e)
        {
            CurrentTimeLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        ///////////////////////////////////////Close Button Click///////////////////////////////////////
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PointOfSaleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Do you want to close this form?";
            string caption = "Closing form";
            MessageBoxButtons btn = MessageBoxButtons.YesNo;
            MessageBoxIcon ico = MessageBoxIcon.Question;

            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult result = MessageBox.Show(msg, caption, btn, ico);

                if (result == DialogResult.Yes) //Yes
                {
                    e.Cancel = false;
                }
                else //No
                {
                    e.Cancel = true;
                }

            }
            else 
            {
                e.Cancel = false;
            }
        }
    }
}