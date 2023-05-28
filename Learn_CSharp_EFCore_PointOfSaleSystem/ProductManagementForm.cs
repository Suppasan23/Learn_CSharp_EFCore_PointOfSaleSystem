using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Learn_CSharp_EFCore_PointOfSaleSystem.Models.Db;
using Learn_CSharp_EFCore_PointOfSaleSystem.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Learn_CSharp_EFCore_PointOfSaleSystem
{
    public partial class ProductManagementForm : Form
    {
        LearnCsharpEfcorePointOfSaleSystemDbContext db = new LearnCsharpEfcorePointOfSaleSystemDbContext();
        public ProductManagementForm()
        {
            InitializeComponent();

            ProductIDTextBox.ReadOnly = true;
            BarcodeTextBox.MaxLength = 15;
            ProductNameTextBox.MaxLength = 50;

            DataGridView1.ReadOnly = true;
            DataGridView1.MultiSelect = false;
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView1.Font, FontStyle.Bold);
            DataGridView1.EnableHeadersVisualStyles = false;  // Disable visual styles for headers
            DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            DataGridView1.ClearSelection();
        }


        ///////////////////////////////////////////// Form Load /////////////////////////////////////////////
        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            loadData("");
            HandleCellClick(1);
        }

        ///////////////////////////////////////////// Load Data /////////////////////////////////////////////
        private void loadData(string strKeyword)
        {
            var data = from i in db.Products
                       where i.ProductBarcode.Contains(strKeyword) || i.ProductName.Contains(strKeyword)
                       select new
                       {
                           ที่ = i.ProductId,
                           บาร์โค้ด = i.ProductBarcode,
                           ชื่อสินค้า = i.ProductName,
                           ราคาทุน = i.CostPrice != null ? i.CostPrice.Value.ToString("#,###,##0", System.Globalization.CultureInfo.InvariantCulture) : "",
                           ราคาขาย = i.SellingPrice != null ? i.SellingPrice.Value.ToString("#,###,##0", System.Globalization.CultureInfo.InvariantCulture) : "",
                           จำนวนคงเหลือ = i.UnitInStock,
                           จำนวนรีโหลด = i.ReoderLevel,
                           ประเภทสินค้า = i.CategoryName,
                           หน่วยนับ = i.UnitName,
                           หมายเหตุ = i.Note
                       };

            if (data.Count() > 0)
            {
                DataGridView1.DataSource = data.ToList();
            }
            else
            {
                DataGridView1.DataSource = null;
            }

            AddNewButton.Text = "Add New";
            DataGridView1.Enabled = true;
            KeywordTextBox.Focus();
        }


        ///////////////////////////////////////////// GataGridView Cell Click /////////////////////////////////////////////

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleCellClick(Convert.ToInt32(DataGridView1.SelectedRows[0].Cells[0].Value));
        }

        private void HandleCellClick(int comingID)
        {
            try
            {
                if (comingID > 0)
                {

                    var m = (from i in db.Products
                             where i.ProductId == comingID
                             select i).FirstOrDefault();

                    if (m != null) 
                    {
                        ProductIDTextBox.Text = Convert.ToString(m.ProductId);
                        BarcodeTextBox.Text = Convert.ToString(m.ProductBarcode);
                        ProductNameTextBox.Text = Convert.ToString(m.ProductName);
                        CostPriceTextBox.Text = m.CostPrice != null ? m.CostPrice.Value.ToString("#,###,##0", System.Globalization.CultureInfo.InvariantCulture) : "";
                        SellingPriceTextBox.Text = m.SellingPrice != null ? m.SellingPrice.Value.ToString("#,###,##0", System.Globalization.CultureInfo.InvariantCulture) : "";
                        UnitInStockTextBox.Text = Convert.ToString(m.UnitInStock);
                        ReorderLevelTextBox.Text = Convert.ToString(m.ReoderLevel);
                        CategoryNameTextBox.Text = Convert.ToString(m.CategoryName);
                        UnitNameTextBox.Text = Convert.ToString(m.UnitName);
                        NoteTextBox.Text = Convert.ToString(m.Note);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "DataGridView Selection Changed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ///////////////////////////////////////////// Refresh Button //////////////////////////////////////////////////
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            KeywordTextBox.Clear();
            AddNewButton.Text = "Add New";
            DataGridView1.Enabled = true;
            loadData("");
        }

        ///////////////////////////////////////////// Search Button //////////////////////////////////////////////////
        private void SearchButton_Click(object sender, EventArgs e)
        {
            loadData(KeywordTextBox.Text.Trim());
        }

        //////////////////////////////////////// Keyword Text Box Key down //////////////////////////////////////////
        private void KeywordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; //ปิดเสียง Windows
                loadData(KeywordTextBox.Text.Trim());
            }
        }

        //////////////////////////////////////// Keyword Text Box Double Click //////////////////////////////////////////
        private void KeywordTextBox_DoubleClick(object sender, EventArgs e)
        {
            KeywordTextBox.Clear();
            KeywordTextBox.Focus();
        }

        ///////////////////////////////////////////// Keyword Text Box AutoComplete //////////////////////////////////////////////////
        private void KeywordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        ///////////////////////////////////////////// Add New ////////////////////////////////////////////////////////
        private void AddNewButton_Click(object sender, EventArgs e)
        {
            HandleAddNewButton(AddNewButton.Text.Trim());
        }

        private void HandleAddNewButton(string buttonState)
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string desiredPath = basePath.Substring(0, basePath.LastIndexOf("\\bin\\Debug\\"));
                string imagePath;

                if (buttonState == "Add New")
                {
                    AddNewButton.Text = "Cancel";
                    imagePath = Path.Combine(desiredPath, "Resources", "Oxygen-Icons.org-Oxygen-Actions-document-close.96.png");
                    foreach (var txt in this.Controls.OfType<TextBox>())
                    {
                        txt.Clear();
                    }
                    DataGridView1.Enabled = false;
                    DataGridView1.DataSource = "";
                    BarcodeTextBox.ReadOnly = false;

                    CostPriceTextBox.Text = "0";
                    SellingPriceTextBox.Text = "0";
                    UnitInStockTextBox.Text = "0";
                    ReorderLevelTextBox.Text = "0";
                    CategoryNameTextBox.Text = "";
                    NoteTextBox.Text = "";

                    BarcodeTextBox.Focus();
                }
                else //(== "Cancel")
                {
                    AddNewButton.Text = "Add New";
                    imagePath = Path.Combine(desiredPath, "Resources", "Oxygen-Icons.org-Oxygen-Actions-document-new.96.png");
                    BarcodeTextBox.ReadOnly = true;
                    DataGridView1.Enabled = true;
                    KeywordTextBox.Focus();
                    loadData("");
                    HandleCellClick(1);
                }

                AddNewButton.Image = Image.FromFile(imagePath);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        ///////////////////////////////////////////// Save Button ////////////////////////////////////////////////////////
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(BarcodeTextBox.Text.Trim()) || String.IsNullOrEmpty(ProductNameTextBox.Text.Trim()))
            {
                MessageBox.Show("Please fill in the Barcode and the Name of the Product.", "Error save data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BarcodeTextBox.Focus();
                BarcodeTextBox.SelectAll();
                return;
            }

            int pProductID;
            if (!int.TryParse(ProductIDTextBox.Text.Trim(), out pProductID))
            {
                MessageBox.Show("Cannot get m ID.", "Error save data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CostPriceTextBox.Focus();
                CostPriceTextBox.SelectAll();
                return;
            }

            decimal pCostPrice;
            if (!decimal.TryParse(CostPriceTextBox.Text.Trim(), out pCostPrice))
            {
                MessageBox.Show("Fill the cost price in number only.", "Error save data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                CostPriceTextBox.Focus();
                CostPriceTextBox.SelectAll();
                return;
            }

            decimal pSellingPrice;
            if (!decimal.TryParse(SellingPriceTextBox.Text.Trim(), out pSellingPrice))
            {
                MessageBox.Show("Fill the selling price in number only.", "Error save data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                SellingPriceTextBox.Focus();
                SellingPriceTextBox.SelectAll();
                return;
            }

            int pUnitInStock;
            if (!int.TryParse(UnitInStockTextBox.Text.Trim(), out pUnitInStock))
            {
                MessageBox.Show("Fill the unit in stock in non-fraction number only.", "Error save data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                UnitInStockTextBox.Focus();
                UnitInStockTextBox.SelectAll();
                return;
            }

            byte pReorderLevel;
            if (!byte.TryParse(ReorderLevelTextBox.Text.Trim(), out pReorderLevel))
            {
                MessageBox.Show("Fill the re order level in non-fraction number only.", "Error save data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ReorderLevelTextBox.Focus();
                ReorderLevelTextBox.SelectAll();
                return;
            }

            string pBarcode = Convert.ToString(BarcodeTextBox.Text.Trim());
            string pName = Convert.ToString(ProductNameTextBox.Text.Trim());
            string pCategoryName = Convert.ToString(CategoryNameTextBox.Text.Trim());
            string pUnitName = Convert.ToString(UnitNameTextBox.Text.Trim());
            string pNote = Convert.ToString(NoteTextBox.Text.Trim());

            DialogResult result;

            if (AddNewButton.Text.Trim() == "Cancel") //INSERT INTO
            {
                result = MessageBox.Show("Do you want to add this data?", "Add new m", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var tr = db.Database.BeginTransaction())
                    {
                        Product p = new Product();
                        p.ProductBarcode = pBarcode;
                        p.ProductName = pName;
                        p.CostPrice = pCostPrice;
                        p.SellingPrice = pSellingPrice;
                        p.UnitInStock = pUnitInStock;
                        p.ReoderLevel = pReorderLevel;
                        p.CategoryName = pCategoryName;
                        p.UnitName = pUnitName;
                        p.Note = pNote;

                        db.Products.Add(p);
                        db.SaveChanges();
                        tr.Commit();

                        MessageBox.Show("Record has been added successfully.", "Saving data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HandleAddNewButton(AddNewButton.Text.Trim());
                    }

                }

            }
            else
            {
                result = MessageBox.Show("Do you want to edit this data?", "edit m", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                { 
                    using (var tr = db.Database.BeginTransaction()) 
                    {
                        var p = (from i in db.Products
                                 where i.ProductId == pProductID
                                 select i).FirstOrDefault(); 

                        if(p != null) 
                        {
                            p.ProductBarcode = pBarcode;
                            p.ProductName = pName;
                            p.CostPrice = pCostPrice;
                            p.SellingPrice = pSellingPrice;
                            p.UnitInStock = pUnitInStock;
                            p.ReoderLevel = pReorderLevel;
                            p.CategoryName = pCategoryName;
                            p.UnitName = pUnitName;
                            p.Note = pNote;

                            db.SaveChanges();
                            tr.Commit();

                            MessageBox.Show("Edit has been successfully.", "Edited data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData("");
                            HandleCellClick(pProductID);
                        }
                          
                    }
                    
                }
                
            }
            
        }

    }

}