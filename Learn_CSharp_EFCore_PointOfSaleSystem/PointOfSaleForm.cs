﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Learn_CSharp_EFCore_PointOfSaleSystem.Models.Db;

namespace Learn_CSharp_EFCore_PointOfSaleSystem
{
    public partial class PointOfSaleForm : Form
    {

        LearnCsharpEfcorePointOfSaleSystemDbContext db = new LearnCsharpEfcorePointOfSaleSystemDbContext();

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


        ///////////////////////////////////////Add New Button///////////////////////////////////////
        string referenceNo = "";

        private void NewButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NewButton.Text.Trim() == "New...")//New...
                {
                    NewButton.Text = "Cancel";
                    GererateCustomSalesID();
                    BarcodeTextBox.Enabled = true;
                    BarcodeTextBox.ReadOnly = false;
                    QuantityUpDown.Enabled = true;
                    QuantityUpDown.ReadOnly = false;
                }
                else//Cancel
                {
                    NewButton.Text = "New...";
                    TransactionTextBox.Clear();
                    dataGridView1.Rows.Clear();
                    BarcodeTextBox.Enabled = false;
                    BarcodeTextBox.ReadOnly = true;
                    QuantityUpDown.Enabled = false;
                    QuantityUpDown.ReadOnly = true;
                    ProductIDTextBox.Clear();
                    BarcodeShowTextBox.Clear();
                    ProductNameTextBox.Clear();
                    SellingPriceTextBox.Clear();
                    UnitInStockTextBox.Clear();
                    QuantityUpDown.Value = 0;
                    QuantityUpDown.Maximum = 0;
                }
                BarcodeTextBox.Clear();
                BarcodeTextBox.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "New Button", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GererateCustomSalesID()
        {
            string currentDate = DateTime.Now.ToString("ddMMyyyy");
            var group = from s in db.Sales
                        where s.SaleDate.Value.Year == DateTime.Now.Year
                        group s by s.SaleDate.Value.Year into g
                        select new
                        {
                            sDate = g.Key,
                            MaxRefID = g.Max(s => s.SaleReferenceNo)
                        };
            if (group != null)
            {
                if (group.Count() > 0)
                {
                    int conID = group.FirstOrDefault().MaxRefID;
                    conID += 1;
                    TransactionTextBox.Text = "Sale" + currentDate + conID.ToString("000000");
                    referenceNo = Convert.ToString(conID);
                }
                else
                {
                    int iniID = 1;
                    TransactionTextBox.Text = "Sale" + currentDate + iniID.ToString("000000");
                    referenceNo = Convert.ToString(iniID);
                }
            }
        }


        ////////////////////////////////////////Barcode KeyDown///////////////////////////////////
        private void BarcodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    //Disable Windows Sound
                    e.SuppressKeyPress = true;

                    if (string.IsNullOrEmpty(BarcodeTextBox.Text.Trim()))
                    {
                        return;
                    }

                    if (string.IsNullOrEmpty(TransactionTextBox.Text.Trim()))
                    {
                        return;
                    }

                    searchProduct(BarcodeTextBox.Text.Trim(), false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Barcode KeyDown", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchProduct(string barcode, bool b)
        {
            try
            {

                var data = (from i in db.Products
                            where i.ProductBarcode.Trim() == barcode.Trim()
                            select new
                            {
                                ProductID = i.ProductId,
                                ProductBarcode = i.ProductBarcode,
                                ProductName = i.ProductName,
                                SellingPrice = i.SellingPrice,
                                UnitInStock = i.UnitInStock
                            }).FirstOrDefault();

                if (data != null)//Found
                {
                    ProductIDTextBox.Text = Convert.ToString(data.ProductID);
                    BarcodeShowTextBox.Text = Convert.ToString(data.ProductBarcode);
                    ProductNameTextBox.Text = Convert.ToString(data.ProductName);

                    double priceFormat = Convert.ToDouble(data.SellingPrice);
                    SellingPriceTextBox.Text = priceFormat.ToString("##,##0.00");

                    int maxUnit = Convert.ToInt32(data.UnitInStock);
                    UnitInStockTextBox.Text = Convert.ToString(maxUnit);

                    QuantityUpDown.Maximum = maxUnit;

                    if (maxUnit > 0)
                    {
                        QuantityUpDown.Value = 1;
                    }

                }
                else//Not found
                {
                    ProductIDTextBox.Clear();
                    BarcodeShowTextBox.Clear();
                    ProductNameTextBox.Clear();
                    SellingPriceTextBox.Clear();
                    UnitInStockTextBox.Clear();
                    QuantityUpDown.Value = 0;
                    QuantityUpDown.Maximum = 0;

                    MessageBox.Show("Product not found", "Barcode Search", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BarcodeTextBox.Focus();
                    BarcodeTextBox.Select();
                    BarcodeTextBox.SelectAll();

                    return;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Barcode Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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