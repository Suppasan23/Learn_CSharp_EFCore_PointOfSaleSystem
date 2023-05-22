using System;
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
    public partial class ProductManagementForm : Form
    {
        LearnCsharpEfcorePointOfSaleSystemDbContext db = new LearnCsharpEfcorePointOfSaleSystemDbContext();
        public ProductManagementForm()
        {
            InitializeComponent();
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
        }


        ////////////////////////////////////// Form Load ////////////////////////////////////////////////////////
        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        ////////////////////////////////////// Load Data ////////////////////////////////////////////////////////
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


        ////////////////////////////////////// GataGridView Cell Click /////////////////////////////////////////
        private int selectedID = 0; 
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if(DataGridView1.SelectedRows.Count > 0) 
            {
                selectedID = Convert.ToInt32(DataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                DataGridViewRow row = DataGridView1.SelectedRows[0];

                ProductIDTextBox.Text = row.Cells[0].Value.ToString();
                BarcodeTextBox.Text = row.Cells[1].Value.ToString();
                ProductNameTextBox.Text = row.Cells[2].Value.ToString();
                CostPriceTextBox.Text = row.Cells[3].Value.ToString();
                SellingPriceTextBox.Text = row.Cells[4].Value.ToString();
                UnitInStockTextBox.Text = row.Cells[5].Value.ToString();
                ReorderLevelTextBox.Text = row.Cells[6].Value.ToString();
                CategoryNameTextBox.Text = row.Cells[7].Value.ToString();
                UnitNameTextBox.Text = row.Cells[8].Value.ToString();
                NoteTextBox.Text = row.Cells[9].Value.ToString();
            }

        }

    }

}
