using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            NewButton.Text = "New...";
            TransactionTextBox.Clear();
            dataGridView1.Rows.Clear();
            BarcodeTextBox.Enabled = false;
            BarcodeTextBox.ReadOnly = true;
            QuantityUpDown.Enabled = false;
            QuantityUpDown.ReadOnly = true;
            QuantityUpDown.Maximum = 1000;
            QuantityUpDown.Value = 0;
            ProductIDTextBox.Clear();
            ProductIDTextBox.ReadOnly = true;
            BarcodeShowTextBox.Clear();
            BarcodeShowTextBox.ReadOnly = true;
            ProductNameTextBox.Clear();
            ProductNameTextBox.ReadOnly = true;
            SellingPriceTextBox.Clear();
            SellingPriceTextBox.ReadOnly = true;
            UnitInStockTextBox.Clear();
            UnitInStockTextBox.ReadOnly = true;
            TotalAmountTextBox.Clear();
            TotalAmountTextBox.ReadOnly = true;
            TenderedTextBox.Clear();
            TenderedTextBox.ReadOnly = true;
            ChangeTextBox.Clear();
            ChangeTextBox.ReadOnly = true;
            SaveButton.Enabled = false;
            SaveButton.BackColor = Color.DarkGray;

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

            string[] header = new[] { "ID", "Barcode", "Product Name", "UnitInStock", "Selling Price", "Quantity", "Subtotal" };
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
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Width = 165;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 150;
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
                    dataGridView1.Rows.Clear();
                    BarcodeTextBox.Enabled = true;
                    BarcodeTextBox.ReadOnly = false;
                    QuantityUpDown.Enabled = false;
                    QuantityUpDown.ReadOnly = true;
                    QuantityUpDown.Maximum = 1000;
                    QuantityUpDown.Value = 0;
                    ProductIDTextBox.Clear();
                    ProductIDTextBox.ReadOnly = true;
                    BarcodeShowTextBox.Clear();
                    BarcodeShowTextBox.ReadOnly = true;
                    ProductNameTextBox.Clear();
                    ProductNameTextBox.ReadOnly = true;
                    SellingPriceTextBox.Clear();
                    SellingPriceTextBox.ReadOnly = true;
                    UnitInStockTextBox.Clear();
                    UnitInStockTextBox.ReadOnly = true;
                    TotalAmountTextBox.Clear();
                    TotalAmountTextBox.ReadOnly = true;
                    TenderedTextBox.Clear();
                    TenderedTextBox.ReadOnly = true;
                    ChangeTextBox.Clear();
                    ChangeTextBox.ReadOnly = true;
                    SaveButton.Enabled = false;
                    SaveButton.BackColor = Color.DarkGray;
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
                    QuantityUpDown.Maximum = 1000;
                    QuantityUpDown.Value = 0;
                    ProductIDTextBox.Clear();
                    ProductIDTextBox.ReadOnly = true;
                    BarcodeShowTextBox.Clear();
                    BarcodeShowTextBox.ReadOnly = true;
                    ProductNameTextBox.Clear();
                    ProductNameTextBox.ReadOnly = true;
                    SellingPriceTextBox.Clear();
                    SellingPriceTextBox.ReadOnly = true;
                    UnitInStockTextBox.Clear();
                    UnitInStockTextBox.ReadOnly = true;
                    TotalAmountTextBox.Clear();
                    TotalAmountTextBox.ReadOnly = true;
                    TenderedTextBox.Clear();
                    TenderedTextBox.ReadOnly = true;
                    ChangeTextBox.Clear();
                    ChangeTextBox.ReadOnly = true;
                    SaveButton.Enabled = false;
                    SaveButton.BackColor = Color.DarkGray;
                }
                BarcodeTextBox.Clear();
                BarcodeTextBox.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "New Button", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ///////////////////////////////////////Gererate Sale ID///////////////////////////////////////
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

        ////////////////////////////////////////////Calculate total amount///////////////////////////////////////
        private void calculateTotalAmount()
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    double amount = 0;

                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        amount += Convert.ToDouble(dataGridView1.Rows[i].Cells[6].Value);
                    }

                    TotalAmountTextBox.Text = amount.ToString("#,###,##0");
                }
                else
                {
                    TotalAmountTextBox.Clear();
                    TenderedTextBox.Clear();
                    ChangeTextBox.Clear();
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Calculate amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        ////////////////////////////////////////Barcode Serach KeyDown///////////////////////////////////
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

                    addProduct(BarcodeTextBox.Text.Trim());
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Barcode KeyDown", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////////////////dataGridView1 Selection Change///////////////////////////////////
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                searchProduct(selectedRow);
            }
            else
            {
                ProductIDTextBox.Clear();
                BarcodeShowTextBox.Clear();
                ProductNameTextBox.Clear();
                UnitInStockTextBox.Clear();
                SellingPriceTextBox.Clear();

                QuantityUpDown.Value = 0;
                QuantityUpDown.Enabled = false;
                QuantityUpDown.ReadOnly = true;
            }
        }

        ////////////////////////////////////////Show Product List to textBox///////////////////////////////////
        private void searchProduct(DataGridViewRow receiveSelectedRow)
        {
            try
            {
                // ID, Barcode, Product Name, UnitInStock, Selling Price, "Quantity", "Subtotal"

                ProductIDTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[0].Value);
                BarcodeShowTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[1].Value);
                ProductNameTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[2].Value);
                UnitInStockTextBox.Text = Convert.ToString(receiveSelectedRow.Cells[3].Value);
                SellingPriceTextBox.Text = Convert.ToDouble(receiveSelectedRow.Cells[4].Value).ToString("#,###,##0");

                QuantityUpDown.Value = Convert.ToInt32(receiveSelectedRow.Cells[5].Value);
                QuantityUpDown.Enabled = true;
                QuantityUpDown.ReadOnly = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Barcode Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ////////////////////////////////////////Add product to DataGridView///////////////////////////////////
        private void addProduct(string barcode)
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
                    int barcodeExist = -1;

                    for (int i = 0; i < dataGridView1.Rows.Count; i++) // Loop to find exist barcode
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value != null && dataGridView1.Rows[i].Cells[1].Value.ToString() == barcode.Trim())
                        {
                            barcodeExist = i;
                            break;
                        }
                    }

                    if (barcodeExist < 0) // Barcode not exists : Add new row
                    {
                        int id = Convert.ToInt32(data.ProductID);
                        string showBarcode = Convert.ToString(data.ProductBarcode);
                        string productName = Convert.ToString(data.ProductName);
                        int maxUnit = Convert.ToInt32(data.UnitInStock);
                        double price = Convert.ToDouble(data.SellingPrice);

                        int qty = 1;

                        double subTotal = price * qty;

                        dataGridView1.Rows.Add(id, showBarcode, productName, maxUnit, price.ToString("#,###,##0"), qty, subTotal.ToString("#,###,##0"));
                        dataGridView1.ClearSelection(); //Selected no row
                        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Selected = true; //Selected last row
                    }
                    else // Barcode exists : Stack existing row
                    {
                        double price = Convert.ToDouble(dataGridView1.Rows[barcodeExist].Cells[4].Value);
                        int qty = Convert.ToInt32(dataGridView1.Rows[barcodeExist].Cells[5].Value);

                        qty += 1;

                        double subTotal = price * qty;

                        dataGridView1.Rows[barcodeExist].Cells[5].Value = qty;
                        dataGridView1.Rows[barcodeExist].Cells[6].Value = subTotal.ToString("#,###,##0");
                        dataGridView1.ClearSelection(); //Selected no row
                        dataGridView1.Rows[barcodeExist].Selected = true; //Selected existing row
                    }
                }
                else//Not found
                {
                    MessageBox.Show("Product not found", "Barcode Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    center.focusTecxbox(BarcodeTextBox);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Product add", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                calculateTotalAmount();
                BarcodeTextBox.Clear();
                BarcodeTextBox.Focus();
            }

        }

        ////////////////////////////////////Numneric Updown Value Change////////////////////////////////
        private void QuantityUpDown_KeyUp(object sender, KeyEventArgs e)
        {
            QuantityUpDownValueChanged();
        }
        private void QuantityUpDown_MouseUp(object sender, MouseEventArgs e)
        {
            QuantityUpDownValueChanged();
        }
        private void QuantityUpDownValueChanged()
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0 && !string.IsNullOrEmpty(BarcodeShowTextBox.Text.Trim()))
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    if (Convert.ToString(selectedRow.Cells[1].Value) == BarcodeShowTextBox.Text.Trim())
                    {
                        double price = Convert.ToDouble(selectedRow.Cells[4].Value);
                        int qty = Convert.ToInt32(QuantityUpDown.Value);

                        double subTotal = price * qty;

                        selectedRow.Cells[5].Value = qty;
                        selectedRow.Cells[6].Value = subTotal.ToString("#,###,##0");
                        selectedRow.Selected = true; //Selected existing row
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Quantity Up-Down", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                calculateTotalAmount();
                QuantityUpDown.Focus();
            }
        }

        ////////////////////////////////////////////Remove Button///////////////////////////////////////////////
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count != 0 && !string.IsNullOrEmpty(BarcodeShowTextBox.Text.Trim()))
                {

                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    if (Convert.ToString(selectedRow.Cells[1].Value) == BarcodeShowTextBox.Text.Trim())
                    {
                        dataGridView1.Rows.RemoveAt(selectedRow.Index);
                        dataGridView1.ClearSelection(); //Selected no row
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Delete product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                calculateTotalAmount();
                BarcodeTextBox.Clear();
                BarcodeTextBox.Focus();
            }
        }

        ///////////////////////////////////////TotalAmountTextBox has change///////////////////////////////////////
        private void TotalAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TotalAmountTextBox.Text))
            {
                TenderedTextBox.ReadOnly = false;
            }
            else
            {
                TenderedTextBox.ReadOnly = true;
            }
            resetTenderedAndChange(-1);
        }

        ///////////////////////////////////////Tendered Keydown///////////////////////////////////////
        private void TenderedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if ((!string.IsNullOrEmpty(TotalAmountTextBox.Text)) && (!string.IsNullOrEmpty(TenderedTextBox.Text)))
                {
                    if (double.TryParse(TotalAmountTextBox.Text.Trim(), out double totalAmount) && double.TryParse(TenderedTextBox.Text.Trim(), out double tenderedMoney))
                    {
                        if (tenderedMoney >= totalAmount)
                        {
                            //Disable Windows Sound
                            e.SuppressKeyPress = true;
                            resetTenderedAndChange(tenderedMoney - totalAmount);
                        }
                        else
                        {
                            resetTenderedAndChange(-1);
                            return;
                        }
                    }
                    else
                    {
                        resetTenderedAndChange(-1);
                        return;
                    }
                }
                else
                {
                    resetTenderedAndChange(-1);
                    return;
                }
            }
            else
            {
                return;
            }
        }

        ///////////////////////////////////////Show tendered and change///////////////////////////////////////
        private void resetTenderedAndChange(double changeMoney)
        {
            if (changeMoney >= 0)
            {
                ChangeTextBox.Text = (changeMoney).ToString("#,###,##0");
                SaveButton.BackColor = Color.LimeGreen;
                SaveButton.Enabled = true;
                SaveButton.Focus();
            }
            else
            {
                TenderedTextBox.Clear();
                ChangeTextBox.Clear();
                SaveButton.BackColor = Color.DarkGray;
                SaveButton.Enabled = false;
            }
        }


        ///////////////////////////////////////Save Button Click & Enter///////////////////////////////////////

        private void SaveButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveData();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveData();
        }

        private void saveData()
        {
            if (SaveButton.Enabled == true)
            {
                using (var tr = db.Database.BeginTransaction())
                {
                    try
                    {
                        DialogResult result;
                        result = MessageBox.Show("Do you want to continue?", "Save data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            //Add data to "Sale" table
                            center.saleReceiptID = TransactionTextBox.Text.Trim();
                            center.saleReferenceNo = Convert.ToInt32(referenceNo);
                            center.employeeID = Convert.ToInt32(EmployeeIDTextBox.Text.Trim());
                            center.customerID = Convert.ToInt32(CustomerIDTextBox.Text.Trim());
                            decimal total = Convert.ToDecimal(TotalAmountTextBox.Text.Trim());
                            decimal tendered = Convert.ToDecimal(TenderedTextBox.Text.Trim());
                            decimal change = Convert.ToDecimal(ChangeTextBox.Text.Trim());

                            Sale saleReceipt = new Sale();

                            saleReceipt.SaleId = center.saleReceiptID;
                            saleReceipt.SaleReferenceNo = center.saleReferenceNo;
                            saleReceipt.EmployeeId = center.employeeID;
                            saleReceipt.CustomerId = center.customerID;
                            saleReceipt.SaleTotal = total;
                            saleReceipt.SaleReceive = tendered;
                            saleReceipt.SaleChange = change;

                            db.Sales.Add(saleReceipt);


                            //Add data to "SaleDetail" table
                            foreach (DataGridViewRow row in dataGridView1.Rows)
                            {
                                int proID = Convert.ToInt32(row.Cells[0].Value.ToString());
                                string proBarcode = row.Cells[1].Value?.ToString() ?? "unknow";
                                string proName = row.Cells[2].Value?.ToString() ?? "unknow";
                                decimal proPrice = Convert.ToDecimal(row.Cells[4].Value.ToString());
                                int proQuantity = Convert.ToInt32(row.Cells[5].Value.ToString());
                                decimal proSubtotal = Convert.ToDecimal(row.Cells[6].Value.ToString());

                                SaleDetail saleDetail = new SaleDetail();

                                saleDetail.SaleId = center.saleReceiptID;
                                saleDetail.ProductId = proID;
                                saleDetail.ProductName = proName;
                                saleDetail.ProductPrice = proPrice;
                                saleDetail.ProductQuantity = proQuantity;
                                saleDetail.SubTotal = proSubtotal;

                                cutStock(saleDetail);
                                db.SaleDetails.Add(saleDetail);
                            }

                            db.SaveChanges();
                            tr.Commit();

                            MessageBox.Show("Saved successfully!", "Save data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            NewButton.PerformClick();
                        }
                        else
                        {
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Save data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                return;
            }
        }



        ///////////////////////////////////////Cut stock methode//////////////////////////////////////////////
        private void cutStock(SaleDetail receiveSaleDetail)
        {
            var proData = (from p in db.Products
                           where p.ProductId == receiveSaleDetail.ProductId
                           select p).FirstOrDefault();
            if (proData != null)
            {
                proData.UnitInStock = proData.UnitInStock - receiveSaleDetail.ProductQuantity;
            }
            else
            {
                return;
            }

        }



        ///////////////////////////////////////timer1 Tick//////////////////////////////////////////////
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