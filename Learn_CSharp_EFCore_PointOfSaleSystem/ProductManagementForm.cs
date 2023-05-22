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
        }

        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            loadData("");
        }

        private void loadData(string strKeyword)
        {
            var data = from i in db.Products
                       where i.ProductBarcode.Contains(strKeyword) || i.ProductName.Contains(strKeyword)
                       select new
                       {
                           ที่ = i.ProductId,
                           บาร์โค้ด = i.ProductBarcode,
                           ชื่อสินค้า = i.ProductName,
                           ราคาทุน = i.CostPrice.Value.ToString("#,###,##0",System.Globalization.CultureInfo.InvariantCulture),
                           ราคาขาย = i.SellingPrice.Value.ToString("#,###,##0", System.Globalization.CultureInfo.InvariantCulture),
                           จำนวนคงเหลือ = i.UnitInStock,
                           จำนวนรีโหลด = i.ReoderLevel,
                           ประเภทสินค้า = i.CategoryName,
                           หน่วยนับ = i.UnitName,
                           หมายเหตุ = i.Note
                       };

            if(data.Count() > 0 ) 
            {
                DataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView1.Font, FontStyle.Bold);
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
    }
}
