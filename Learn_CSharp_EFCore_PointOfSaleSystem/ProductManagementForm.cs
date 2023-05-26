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
                           ราคาทุน = i.CostPrice.Value.ToString("#,###,##0", System.Globalization.CultureInfo.InvariantCulture),
                           ราคาขาย = i.SellingPrice.Value.ToString("#,###,##0", System.Globalization.CultureInfo.InvariantCulture),
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
        private int selectedID = 0;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridView1.SelectedRows.Count > 0)
                {
                    selectedID = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells[0].Value);

                    DataGridViewRow row = DataGridView1.SelectedRows[0];

                    ProductIDTextBox.Text = row.Cells[0].Value != null ? Convert.ToString(row.Cells[0].Value) : "";
                    BarcodeTextBox.Text = row.Cells[1].Value != null ? Convert.ToString(row.Cells[1].Value) : "";
                    ProductNameTextBox.Text = row.Cells[2].Value != null ? Convert.ToString(row.Cells[2].Value) : "";
                    CostPriceTextBox.Text = row.Cells[3].Value != null ? Convert.ToString(row.Cells[3].Value) : "";
                    SellingPriceTextBox.Text = row.Cells[4].Value != null ? Convert.ToString(row.Cells[4].Value) : "";
                    UnitInStockTextBox.Text = row.Cells[5].Value != null ? Convert.ToString(row.Cells[5].Value) : "";
                    ReorderLevelTextBox.Text = row.Cells[6].Value != null ? Convert.ToString(row.Cells[6].Value) : "";
                    CategoryNameTextBox.Text = row.Cells[7].Value != null ? Convert.ToString(row.Cells[7].Value) : "";
                    UnitNameTextBox.Text = row.Cells[8].Value != null ? Convert.ToString(row.Cells[8].Value) : "";
                    NoteTextBox.Text = row.Cells[9].Value != null ? Convert.ToString(row.Cells[9].Value) : "";
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
            try
            {
                if (AddNewButton.Text.Trim() == "Add New")
                {
                    AddNewButton.Text = "Cancel";
                    AddNewButton.Image = Image.FromFile("C:\\Users\\SUPPASAN\\Desktop\\Learn_CSharp_EFCore_PointOfSaleSystem\\Learn_CSharp_EFCore_PointOfSaleSystem\\Resources\\Oxygen-Icons.org-Oxygen-Actions-document-close.96.png");
                }
                else
                {
                    AddNewButton.Text = "Add New";
                    AddNewButton.Image = Image.FromFile("C:\\Users\\SUPPASAN\\Desktop\\Learn_CSharp_EFCore_PointOfSaleSystem\\Learn_CSharp_EFCore_PointOfSaleSystem\\Resources\\Oxygen-Icons.org-Oxygen-Actions-document-new.96 .png");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Add New", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}
