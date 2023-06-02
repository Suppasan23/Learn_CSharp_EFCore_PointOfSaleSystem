namespace Learn_CSharp_EFCore_PointOfSaleSystem
{
    partial class PointOfSaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            CurrentTimeLabel = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            statusStrip1 = new StatusStrip();
            StatusStripStatusLabel1 = new ToolStripStatusLabel();
            BarcodeSearchLabel = new Label();
            BarcodeTextBox = new TextBox();
            TransactionGroupBox = new GroupBox();
            EmployeeNameTextBox = new TextBox();
            EmployeeIDTextBox = new TextBox();
            TransactionTextBox = new TextBox();
            CurrentDateTextBox = new TextBox();
            EmployeeNameLabel = new Label();
            TransactionLabel = new Label();
            EmployeeIDLabel = new Label();
            CurrentDateLabel = new Label();
            CustomerGroupBox = new GroupBox();
            CustomerNameTextBox = new TextBox();
            CustomerIDTextBox = new TextBox();
            CustomerNameLabel = new Label();
            CustomerIDLabel = new Label();
            ProductGroupBox = new GroupBox();
            QuantityUpDown = new NumericUpDown();
            SellingPriceTextBox = new TextBox();
            ProductIDTextBox = new TextBox();
            UnitInStockTextBox = new TextBox();
            BarcodeShowTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            QuantityLabel = new Label();
            ProductNameLabel = new Label();
            UnitInStockLabel1 = new Label();
            BarcodeShowLabel = new Label();
            SellingPriceLabel = new Label();
            ProductIDLabel = new Label();
            dataGridView1 = new DataGridView();
            NewButton = new Button();
            CloseButton = new Button();
            RemoveButton = new Button();
            SaveButton = new Button();
            TotalAmountLabel = new Label();
            TenderedLabel = new Label();
            ChangeLabel = new Label();
            TotalAmountTextBox = new TextBox();
            TenderedTextBox = new TextBox();
            ChangeTextBox = new TextBox();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            TransactionGroupBox.SuspendLayout();
            CustomerGroupBox.SuspendLayout();
            ProductGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 111);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(529, 81);
            label1.TabIndex = 1;
            label1.Text = "Point Of Sale Form";
            // 
            // CurrentTimeLabel
            // 
            CurrentTimeLabel.AutoSize = true;
            CurrentTimeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentTimeLabel.Location = new Point(14, 131);
            CurrentTimeLabel.Name = "CurrentTimeLabel";
            CurrentTimeLabel.Size = new Size(103, 23);
            CurrentTimeLabel.TabIndex = 1;
            CurrentTimeLabel.Text = "00:00:00 AM";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { StatusStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 1055);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1182, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusStripStatusLabel1
            // 
            StatusStripStatusLabel1.Name = "StatusStripStatusLabel1";
            StatusStripStatusLabel1.Size = new Size(49, 20);
            StatusStripStatusLabel1.Text = "Status";
            // 
            // BarcodeSearchLabel
            // 
            BarcodeSearchLabel.AutoSize = true;
            BarcodeSearchLabel.Location = new Point(522, 133);
            BarcodeSearchLabel.Name = "BarcodeSearchLabel";
            BarcodeSearchLabel.Size = new Size(64, 20);
            BarcodeSearchLabel.TabIndex = 3;
            BarcodeSearchLabel.Text = "Barcode";
            // 
            // BarcodeTextBox
            // 
            BarcodeTextBox.Location = new Point(586, 129);
            BarcodeTextBox.Margin = new Padding(3, 4, 3, 4);
            BarcodeTextBox.Name = "BarcodeTextBox";
            BarcodeTextBox.ReadOnly = true;
            BarcodeTextBox.Size = new Size(401, 27);
            BarcodeTextBox.TabIndex = 4;
            BarcodeTextBox.KeyDown += BarcodeTextBox_KeyDown;
            // 
            // TransactionGroupBox
            // 
            TransactionGroupBox.Controls.Add(EmployeeNameTextBox);
            TransactionGroupBox.Controls.Add(EmployeeIDTextBox);
            TransactionGroupBox.Controls.Add(TransactionTextBox);
            TransactionGroupBox.Controls.Add(CurrentDateTextBox);
            TransactionGroupBox.Controls.Add(EmployeeNameLabel);
            TransactionGroupBox.Controls.Add(TransactionLabel);
            TransactionGroupBox.Controls.Add(EmployeeIDLabel);
            TransactionGroupBox.Controls.Add(CurrentDateLabel);
            TransactionGroupBox.Location = new Point(14, 165);
            TransactionGroupBox.Margin = new Padding(3, 4, 3, 4);
            TransactionGroupBox.Name = "TransactionGroupBox";
            TransactionGroupBox.Padding = new Padding(3, 4, 3, 4);
            TransactionGroupBox.Size = new Size(615, 113);
            TransactionGroupBox.TabIndex = 5;
            TransactionGroupBox.TabStop = false;
            TransactionGroupBox.Text = "Transaction";
            // 
            // EmployeeNameTextBox
            // 
            EmployeeNameTextBox.Location = new Point(424, 67);
            EmployeeNameTextBox.Margin = new Padding(3, 4, 3, 4);
            EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            EmployeeNameTextBox.ReadOnly = true;
            EmployeeNameTextBox.Size = new Size(177, 27);
            EmployeeNameTextBox.TabIndex = 1;
            // 
            // EmployeeIDTextBox
            // 
            EmployeeIDTextBox.Location = new Point(425, 27);
            EmployeeIDTextBox.Margin = new Padding(3, 4, 3, 4);
            EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            EmployeeIDTextBox.ReadOnly = true;
            EmployeeIDTextBox.Size = new Size(177, 27);
            EmployeeIDTextBox.TabIndex = 1;
            // 
            // TransactionTextBox
            // 
            TransactionTextBox.Location = new Point(114, 67);
            TransactionTextBox.Margin = new Padding(3, 4, 3, 4);
            TransactionTextBox.Name = "TransactionTextBox";
            TransactionTextBox.ReadOnly = true;
            TransactionTextBox.Size = new Size(177, 27);
            TransactionTextBox.TabIndex = 1;
            // 
            // CurrentDateTextBox
            // 
            CurrentDateTextBox.Location = new Point(114, 27);
            CurrentDateTextBox.Margin = new Padding(3, 4, 3, 4);
            CurrentDateTextBox.Name = "CurrentDateTextBox";
            CurrentDateTextBox.ReadOnly = true;
            CurrentDateTextBox.Size = new Size(177, 27);
            CurrentDateTextBox.TabIndex = 1;
            // 
            // EmployeeNameLabel
            // 
            EmployeeNameLabel.AutoSize = true;
            EmployeeNameLabel.Location = new Point(304, 77);
            EmployeeNameLabel.Name = "EmployeeNameLabel";
            EmployeeNameLabel.Size = new Size(126, 20);
            EmployeeNameLabel.TabIndex = 0;
            EmployeeNameLabel.Text = "Employee Name :";
            // 
            // TransactionLabel
            // 
            TransactionLabel.AutoSize = true;
            TransactionLabel.Location = new Point(32, 77);
            TransactionLabel.Name = "TransactionLabel";
            TransactionLabel.Size = new Size(91, 20);
            TransactionLabel.TabIndex = 0;
            TransactionLabel.Text = "Transaction :";
            // 
            // EmployeeIDLabel
            // 
            EmployeeIDLabel.AutoSize = true;
            EmployeeIDLabel.Location = new Point(328, 37);
            EmployeeIDLabel.Name = "EmployeeIDLabel";
            EmployeeIDLabel.Size = new Size(101, 20);
            EmployeeIDLabel.TabIndex = 0;
            EmployeeIDLabel.Text = "Employee ID :";
            // 
            // CurrentDateLabel
            // 
            CurrentDateLabel.AutoSize = true;
            CurrentDateLabel.Location = new Point(24, 37);
            CurrentDateLabel.Name = "CurrentDateLabel";
            CurrentDateLabel.Size = new Size(100, 20);
            CurrentDateLabel.TabIndex = 0;
            CurrentDateLabel.Text = "Current Date :";
            // 
            // CustomerGroupBox
            // 
            CustomerGroupBox.Controls.Add(CustomerNameTextBox);
            CustomerGroupBox.Controls.Add(CustomerIDTextBox);
            CustomerGroupBox.Controls.Add(CustomerNameLabel);
            CustomerGroupBox.Controls.Add(CustomerIDLabel);
            CustomerGroupBox.Location = new Point(648, 165);
            CustomerGroupBox.Margin = new Padding(3, 4, 3, 4);
            CustomerGroupBox.Name = "CustomerGroupBox";
            CustomerGroupBox.Padding = new Padding(3, 4, 3, 4);
            CustomerGroupBox.Size = new Size(339, 113);
            CustomerGroupBox.TabIndex = 5;
            CustomerGroupBox.TabStop = false;
            CustomerGroupBox.Text = "Customer";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(145, 67);
            CustomerNameTextBox.Margin = new Padding(3, 4, 3, 4);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.ReadOnly = true;
            CustomerNameTextBox.Size = new Size(177, 27);
            CustomerNameTextBox.TabIndex = 1;
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(145, 27);
            CustomerIDTextBox.Margin = new Padding(3, 4, 3, 4);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.ReadOnly = true;
            CustomerIDTextBox.Size = new Size(177, 27);
            CustomerIDTextBox.TabIndex = 1;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(24, 77);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(123, 20);
            CustomerNameLabel.TabIndex = 0;
            CustomerNameLabel.Text = "Customer Name :";
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Location = new Point(47, 37);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new Size(98, 20);
            CustomerIDLabel.TabIndex = 0;
            CustomerIDLabel.Text = "Customer ID :";
            // 
            // ProductGroupBox
            // 
            ProductGroupBox.Controls.Add(QuantityUpDown);
            ProductGroupBox.Controls.Add(SellingPriceTextBox);
            ProductGroupBox.Controls.Add(ProductIDTextBox);
            ProductGroupBox.Controls.Add(UnitInStockTextBox);
            ProductGroupBox.Controls.Add(BarcodeShowTextBox);
            ProductGroupBox.Controls.Add(ProductNameTextBox);
            ProductGroupBox.Controls.Add(QuantityLabel);
            ProductGroupBox.Controls.Add(ProductNameLabel);
            ProductGroupBox.Controls.Add(UnitInStockLabel1);
            ProductGroupBox.Controls.Add(BarcodeShowLabel);
            ProductGroupBox.Controls.Add(SellingPriceLabel);
            ProductGroupBox.Controls.Add(ProductIDLabel);
            ProductGroupBox.Location = new Point(14, 287);
            ProductGroupBox.Margin = new Padding(3, 4, 3, 4);
            ProductGroupBox.Name = "ProductGroupBox";
            ProductGroupBox.Padding = new Padding(3, 4, 3, 4);
            ProductGroupBox.Size = new Size(974, 120);
            ProductGroupBox.TabIndex = 5;
            ProductGroupBox.TabStop = false;
            ProductGroupBox.Text = "Product";
            // 
            // QuantityUpDown
            // 
            QuantityUpDown.Location = new Point(768, 69);
            QuantityUpDown.Margin = new Padding(3, 4, 3, 4);
            QuantityUpDown.Name = "QuantityUpDown";
            QuantityUpDown.ReadOnly = true;
            QuantityUpDown.Size = new Size(189, 27);
            QuantityUpDown.TabIndex = 2;
            QuantityUpDown.KeyUp += QuantityUpDown_KeyUp;
            QuantityUpDown.MouseUp += QuantityUpDown_MouseUp;
            // 
            // SellingPriceTextBox
            // 
            SellingPriceTextBox.Location = new Point(114, 69);
            SellingPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            SellingPriceTextBox.Name = "SellingPriceTextBox";
            SellingPriceTextBox.ReadOnly = true;
            SellingPriceTextBox.Size = new Size(188, 27);
            SellingPriceTextBox.TabIndex = 1;
            // 
            // ProductIDTextBox
            // 
            ProductIDTextBox.Location = new Point(115, 28);
            ProductIDTextBox.Margin = new Padding(3, 4, 3, 4);
            ProductIDTextBox.Name = "ProductIDTextBox";
            ProductIDTextBox.ReadOnly = true;
            ProductIDTextBox.Size = new Size(188, 27);
            ProductIDTextBox.TabIndex = 1;
            // 
            // UnitInStockTextBox
            // 
            UnitInStockTextBox.Location = new Point(435, 69);
            UnitInStockTextBox.Margin = new Padding(3, 4, 3, 4);
            UnitInStockTextBox.Name = "UnitInStockTextBox";
            UnitInStockTextBox.ReadOnly = true;
            UnitInStockTextBox.Size = new Size(188, 27);
            UnitInStockTextBox.TabIndex = 1;
            // 
            // BarcodeShowTextBox
            // 
            BarcodeShowTextBox.Location = new Point(437, 28);
            BarcodeShowTextBox.Margin = new Padding(3, 4, 3, 4);
            BarcodeShowTextBox.Name = "BarcodeShowTextBox";
            BarcodeShowTextBox.ReadOnly = true;
            BarcodeShowTextBox.Size = new Size(188, 27);
            BarcodeShowTextBox.TabIndex = 1;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(768, 28);
            ProductNameTextBox.Margin = new Padding(3, 4, 3, 4);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.ReadOnly = true;
            ProductNameTextBox.Size = new Size(188, 27);
            ProductNameTextBox.TabIndex = 1;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(693, 80);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(72, 20);
            QuantityLabel.TabIndex = 0;
            QuantityLabel.Text = "Quantity :";
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(657, 39);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(111, 20);
            ProductNameLabel.TabIndex = 0;
            ProductNameLabel.Text = "Product Name :";
            // 
            // UnitInStockLabel1
            // 
            UnitInStockLabel1.AutoSize = true;
            UnitInStockLabel1.Location = new Point(337, 80);
            UnitInStockLabel1.Name = "UnitInStockLabel1";
            UnitInStockLabel1.Size = new Size(99, 20);
            UnitInStockLabel1.TabIndex = 0;
            UnitInStockLabel1.Text = "Unit In Stock :";
            // 
            // BarcodeShowLabel
            // 
            BarcodeShowLabel.AutoSize = true;
            BarcodeShowLabel.Location = new Point(365, 39);
            BarcodeShowLabel.Name = "BarcodeShowLabel";
            BarcodeShowLabel.Size = new Size(71, 20);
            BarcodeShowLabel.TabIndex = 0;
            BarcodeShowLabel.Text = "Barcode :";
            // 
            // SellingPriceLabel
            // 
            SellingPriceLabel.AutoSize = true;
            SellingPriceLabel.Location = new Point(19, 80);
            SellingPriceLabel.Name = "SellingPriceLabel";
            SellingPriceLabel.Size = new Size(97, 20);
            SellingPriceLabel.TabIndex = 0;
            SellingPriceLabel.Text = "Selling Price :";
            // 
            // ProductIDLabel
            // 
            ProductIDLabel.AutoSize = true;
            ProductIDLabel.Location = new Point(29, 39);
            ProductIDLabel.Name = "ProductIDLabel";
            ProductIDLabel.Size = new Size(86, 20);
            ProductIDLabel.TabIndex = 0;
            ProductIDLabel.Text = "Product ID :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 415);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(974, 633);
            dataGridView1.TabIndex = 6;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // NewButton
            // 
            NewButton.BackColor = Color.MintCream;
            NewButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewButton.Location = new Point(997, 129);
            NewButton.Margin = new Padding(3, 4, 3, 4);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(177, 53);
            NewButton.TabIndex = 7;
            NewButton.Text = "New...";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Ivory;
            CloseButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(997, 191);
            CloseButton.Margin = new Padding(3, 4, 3, 4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(177, 53);
            CloseButton.TabIndex = 7;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.MistyRose;
            RemoveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.Location = new Point(997, 252);
            RemoveButton.Margin = new Padding(3, 4, 3, 4);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(177, 53);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DarkGray;
            SaveButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(998, 971);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(174, 77);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Location = new Point(999, 415);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(106, 20);
            TotalAmountLabel.TabIndex = 8;
            TotalAmountLabel.Text = "Total Amount :";
            // 
            // TenderedLabel
            // 
            TenderedLabel.AutoSize = true;
            TenderedLabel.Location = new Point(999, 549);
            TenderedLabel.Name = "TenderedLabel";
            TenderedLabel.Size = new Size(78, 20);
            TenderedLabel.TabIndex = 8;
            TenderedLabel.Text = "Tendered :";
            // 
            // ChangeLabel
            // 
            ChangeLabel.AutoSize = true;
            ChangeLabel.Location = new Point(997, 681);
            ChangeLabel.Name = "ChangeLabel";
            ChangeLabel.Size = new Size(66, 20);
            ChangeLabel.TabIndex = 8;
            ChangeLabel.Text = "Change :";
            // 
            // TotalAmountTextBox
            // 
            TotalAmountTextBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TotalAmountTextBox.Location = new Point(998, 439);
            TotalAmountTextBox.Margin = new Padding(3, 4, 3, 4);
            TotalAmountTextBox.Name = "TotalAmountTextBox";
            TotalAmountTextBox.ReadOnly = true;
            TotalAmountTextBox.Size = new Size(177, 42);
            TotalAmountTextBox.TabIndex = 9;
            TotalAmountTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // TenderedTextBox
            // 
            TenderedTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TenderedTextBox.Location = new Point(999, 573);
            TenderedTextBox.Margin = new Padding(3, 4, 3, 4);
            TenderedTextBox.Name = "TenderedTextBox";
            TenderedTextBox.Size = new Size(177, 39);
            TenderedTextBox.TabIndex = 9;
            TenderedTextBox.TextAlign = HorizontalAlignment.Right;
            TenderedTextBox.KeyDown += TenderedTextBox_KeyDown;
            // 
            // ChangeTextBox
            // 
            ChangeTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeTextBox.Location = new Point(999, 705);
            ChangeTextBox.Margin = new Padding(3, 4, 3, 4);
            ChangeTextBox.Name = "ChangeTextBox";
            ChangeTextBox.ReadOnly = true;
            ChangeTextBox.Size = new Size(177, 39);
            ChangeTextBox.TabIndex = 9;
            ChangeTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // PointOfSaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 1081);
            Controls.Add(ChangeTextBox);
            Controls.Add(TenderedTextBox);
            Controls.Add(TotalAmountTextBox);
            Controls.Add(ChangeLabel);
            Controls.Add(TenderedLabel);
            Controls.Add(TotalAmountLabel);
            Controls.Add(SaveButton);
            Controls.Add(RemoveButton);
            Controls.Add(CloseButton);
            Controls.Add(NewButton);
            Controls.Add(dataGridView1);
            Controls.Add(ProductGroupBox);
            Controls.Add(CustomerGroupBox);
            Controls.Add(TransactionGroupBox);
            Controls.Add(BarcodeTextBox);
            Controls.Add(BarcodeSearchLabel);
            Controls.Add(statusStrip1);
            Controls.Add(CurrentTimeLabel);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PointOfSaleForm";
            Text = "Point Of Sale";
            FormClosing += PointOfSaleForm_FormClosing;
            Load += PointOfSaleForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            TransactionGroupBox.ResumeLayout(false);
            TransactionGroupBox.PerformLayout();
            CustomerGroupBox.ResumeLayout(false);
            CustomerGroupBox.PerformLayout();
            ProductGroupBox.ResumeLayout(false);
            ProductGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuantityUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label CurrentTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel StatusStripStatusLabel1;
        private Label BarcodeSearchLabel;
        private TextBox BarcodeTextBox;
        private GroupBox TransactionGroupBox;
        private GroupBox CustomerGroupBox;
        private GroupBox ProductGroupBox;
        private Label EmployeeNameLabel;
        private Label TransactionLabel;
        private Label EmployeeIDLabel;
        private Label CurrentDateLabel;
        private Label CustomerNameLabel;
        private Label CustomerIDLabel;
        private Label QuantityLabel;
        private Label ProductNameLabel;
        private Label UnitInStockLabel1;
        private Label BarcodeShowLabel;
        private Label SellingPriceLabel;
        private Label ProductIDLabel;
        private TextBox EmployeeNameTextBox;
        private TextBox EmployeeIDTextBox;
        private TextBox TransactionTextBox;
        private TextBox CurrentDateTextBox;
        private TextBox CustomerNameTextBox;
        private TextBox CustomerIDTextBox;
        private NumericUpDown QuantityUpDown;
        private TextBox SellingPriceTextBox;
        private TextBox ProductIDTextBox;
        private TextBox UnitInStockTextBox;
        private TextBox BarcodeShowTextBox;
        private TextBox ProductNameTextBox;
        private DataGridView dataGridView1;
        private Button NewButton;
        private Button CloseButton;
        private Button RemoveButton;
        private Button SaveButton;
        private Label TotalAmountLabel;
        private Label TenderedLabel;
        private Label ChangeLabel;
        private TextBox TotalAmountTextBox;
        private TextBox TenderedTextBox;
        private TextBox ChangeTextBox;
    }
}