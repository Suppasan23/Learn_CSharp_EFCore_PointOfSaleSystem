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
            DataGridView1.AllowUserToResizeRows = false;
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
            DataGridView1.ClearSelection(); //Selected no row
            DataGridView1.Rows[0].Selected = true; //Selected first row
        }

        ///////////////////////////////////////////// Load Data /////////////////////////////////////////////
        private void loadData(string strKeyword)
        {
            DataGridView1.DataSource = null;
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


        ///////////////////////////////////////////// GataGridView Cell SelectChange , Key up , Key down  /////////////////////////////////////////////
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView1.Rows.Count > 0 && DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = DataGridView1.SelectedRows[0];
                HandleCellSelectChange(selectedRow);
            }
            else
            {
                ProductIDTextBox.Clear();
                BarcodeTextBox.Clear();
                ProductNameTextBox.Clear();
                CostPriceTextBox.Clear();
                SellingPriceTextBox.Clear();
                UnitInStockTextBox.Clear();
                ReorderLevelTextBox.Clear();
                CategoryNameTextBox.Clear();
                UnitNameTextBox.Clear();
                NoteTextBox.Clear();
            }
        }

        private void HandleCellSelectChange(DataGridViewRow receiveSelectedRow)
        {
            ProductIDTextBox.Clear();
            BarcodeTextBox.Clear();
            ProductNameTextBox.Clear();
            CostPriceTextBox.Clear();
            SellingPriceTextBox.Clear();
            UnitInStockTextBox.Clear();
            ReorderLevelTextBox.Clear();
            CategoryNameTextBox.Clear();
            UnitNameTextBox.Clear();
            NoteTextBox.Clear();
            try
            {
                ProductIDTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[0].Value);
                BarcodeTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[1].Value);
                ProductNameTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[2].Value);
                CostPriceTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[3].Value);
                SellingPriceTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[4].Value);
                UnitInStockTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[5].Value);
                ReorderLevelTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[6].Value);
                CategoryNameTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[7].Value);
                UnitNameTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[8].Value);
                NoteTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[9].Value);
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
            DataGridView1.ClearSelection(); //Selected no row
            DataGridView1.Rows[0].Selected = true; //Selected first row
        }

        ///////////////////////////////////////////// Search Button //////////////////////////////////////////////////
        private void SearchButton_Click(object sender, EventArgs e)
        {
            loadData(KeywordTextBox.Text.Trim());
            DataGridView1.ClearSelection(); //Selected no row
            DataGridView1.Rows[0].Selected = true; //Selected first row
        }

        //////////////////////////////////////// Keyword Text Box Key down //////////////////////////////////////////
        private void KeywordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; //ปิดเสียง Windows
                loadData(KeywordTextBox.Text.Trim());
                DataGridView1.ClearSelection(); //Selected no row
                DataGridView1.Rows[0].Selected = true; //Selected first row
            }
        }

        //////////////////////////////////////// Keyword Text Box Double SelectChange //////////////////////////////////////////
        private void KeywordTextBox_DoubleSelectChange(object sender, EventArgs e)
        {
            KeywordTextBox.Clear();
            KeywordTextBox.Focus();
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
                    BarcodeTextBox.ReadOnly = false;
                    DataGridView1.DataSource = "";

                    SearchButton.Enabled = false;
                    RefreshButton.Enabled = false;
                    DeleteButton.Enabled = false;

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
                    SearchButton.Enabled = true;
                    RefreshButton.Enabled = true;
                    DeleteButton.Enabled = true;
                    KeywordTextBox.Focus();
                    loadData("");
                    DataGridView1.ClearSelection(); //Selected no row
                    DataGridView1.Rows[0].Selected = true; //Selected first row
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
                pProductID = 0;
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

            if ((AddNewButton.Text.Trim() == "Cancel") && (pProductID == 0)) //INSERT INTO
            {
                result = MessageBox.Show("Do you want to add this data?", "Add new Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var tr = db.Database.BeginTransaction())
                    {
                        try
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
                            

                            pProductID = p.ProductId;

                            MessageBox.Show("Record has been added successfully.", "Saving data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Saving Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            tr.Commit();
                            loadData("");
                            DataGridView1.ClearSelection(); //Selected no row
                            DataGridView1.Rows[DataGridView1.Rows.Count - 1].Selected = true; //Selected last row
                        }
                    }
                }
            }
            else //EDIT DATA
            {
                result = MessageBox.Show("Do you want to edit this data?", "edit Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    using (var tr = db.Database.BeginTransaction())
                    {
                        try
                        {
                            var p = (from i in db.Products
                                     where i.ProductId == pProductID
                                     select i).FirstOrDefault();

                            if (p != null)
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


                                MessageBox.Show("Edit has been successfully.", "Edited data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Editing Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            tr.Commit();
                            int rowIndex = DataGridView1.SelectedRows[0].Index;
                            loadData("");
                            DataGridView1.ClearSelection(); //Selected no row
                            DataGridView1.Rows[rowIndex].Selected = true; //Selected current row
                        }
                    }
                }
            }
        }

        ///////////////////////////////////////////// Delete Button ////////////////////////////////////////////////////////
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int pProductID;
            if (!int.TryParse(ProductIDTextBox.Text.Trim(), out pProductID))
            {
                MessageBox.Show("No data have selected", "Deleteing Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result;

            result = MessageBox.Show("Do you want to delete this data?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var tr = db.Database.BeginTransaction())
                {
                    try
                    {
                        var p = (from i in db.Products
                                 where i.ProductId == pProductID
                                 select i).FirstOrDefault();

                        if (p != null)
                        {
                            db.Products.Remove(p);
                            db.SaveChanges();

                            MessageBox.Show("Delete data successfully.", "Delete data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Deleteing Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        tr.Commit();
                        loadData("");
                        DataGridView1.ClearSelection(); //Selected no row
                    }
                }
            }
        }
    }
}