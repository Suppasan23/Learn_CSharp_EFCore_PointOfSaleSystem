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
            panel1.Name = "panel1";
            panel1.Size = new Size(1034, 83);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(422, 65);
            label1.TabIndex = 1;
            label1.Text = "Point Of Sale Form";
            // 
            // CurrentTimeLabel
            // 
            CurrentTimeLabel.AutoSize = true;
            CurrentTimeLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            CurrentTimeLabel.Location = new Point(12, 98);
            CurrentTimeLabel.Name = "CurrentTimeLabel";
            CurrentTimeLabel.Size = new Size(80, 17);
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
            statusStrip1.Location = new Point(0, 789);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1034, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // StatusStripStatusLabel1
            // 
            StatusStripStatusLabel1.Name = "StatusStripStatusLabel1";
            StatusStripStatusLabel1.Size = new Size(39, 17);
            StatusStripStatusLabel1.Text = "Status";
            // 
            // BarcodeSearchLabel
            // 
            BarcodeSearchLabel.AutoSize = true;
            BarcodeSearchLabel.Location = new Point(457, 100);
            BarcodeSearchLabel.Name = "BarcodeSearchLabel";
            BarcodeSearchLabel.Size = new Size(50, 15);
            BarcodeSearchLabel.TabIndex = 3;
            BarcodeSearchLabel.Text = "Barcode";
            // 
            // BarcodeTextBox
            // 
            BarcodeTextBox.Location = new Point(513, 97);
            BarcodeTextBox.Name = "BarcodeTextBox";
            BarcodeTextBox.ReadOnly = true;
            BarcodeTextBox.Size = new Size(351, 23);
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
            TransactionGroupBox.Location = new Point(12, 124);
            TransactionGroupBox.Name = "TransactionGroupBox";
            TransactionGroupBox.Size = new Size(538, 85);
            TransactionGroupBox.TabIndex = 5;
            TransactionGroupBox.TabStop = false;
            TransactionGroupBox.Text = "Transaction";
            // 
            // EmployeeNameTextBox
            // 
            EmployeeNameTextBox.Location = new Point(371, 50);
            EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            EmployeeNameTextBox.ReadOnly = true;
            EmployeeNameTextBox.Size = new Size(155, 23);
            EmployeeNameTextBox.TabIndex = 1;
            // 
            // EmployeeIDTextBox
            // 
            EmployeeIDTextBox.Location = new Point(372, 20);
            EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            EmployeeIDTextBox.ReadOnly = true;
            EmployeeIDTextBox.Size = new Size(155, 23);
            EmployeeIDTextBox.TabIndex = 1;
            // 
            // TransactionTextBox
            // 
            TransactionTextBox.Location = new Point(100, 50);
            TransactionTextBox.Name = "TransactionTextBox";
            TransactionTextBox.ReadOnly = true;
            TransactionTextBox.Size = new Size(155, 23);
            TransactionTextBox.TabIndex = 1;
            // 
            // CurrentDateTextBox
            // 
            CurrentDateTextBox.Location = new Point(100, 20);
            CurrentDateTextBox.Name = "CurrentDateTextBox";
            CurrentDateTextBox.ReadOnly = true;
            CurrentDateTextBox.Size = new Size(155, 23);
            CurrentDateTextBox.TabIndex = 1;
            // 
            // EmployeeNameLabel
            // 
            EmployeeNameLabel.AutoSize = true;
            EmployeeNameLabel.Location = new Point(266, 58);
            EmployeeNameLabel.Name = "EmployeeNameLabel";
            EmployeeNameLabel.Size = new Size(100, 15);
            EmployeeNameLabel.TabIndex = 0;
            EmployeeNameLabel.Text = "Employee Name :";
            // 
            // TransactionLabel
            // 
            TransactionLabel.AutoSize = true;
            TransactionLabel.Location = new Point(28, 58);
            TransactionLabel.Name = "TransactionLabel";
            TransactionLabel.Size = new Size(73, 15);
            TransactionLabel.TabIndex = 0;
            TransactionLabel.Text = "Transaction :";
            // 
            // EmployeeIDLabel
            // 
            EmployeeIDLabel.AutoSize = true;
            EmployeeIDLabel.Location = new Point(287, 28);
            EmployeeIDLabel.Name = "EmployeeIDLabel";
            EmployeeIDLabel.Size = new Size(79, 15);
            EmployeeIDLabel.TabIndex = 0;
            EmployeeIDLabel.Text = "Employee ID :";
            // 
            // CurrentDateLabel
            // 
            CurrentDateLabel.AutoSize = true;
            CurrentDateLabel.Location = new Point(21, 28);
            CurrentDateLabel.Name = "CurrentDateLabel";
            CurrentDateLabel.Size = new Size(80, 15);
            CurrentDateLabel.TabIndex = 0;
            CurrentDateLabel.Text = "Current Date :";
            // 
            // CustomerGroupBox
            // 
            CustomerGroupBox.Controls.Add(CustomerNameTextBox);
            CustomerGroupBox.Controls.Add(CustomerIDTextBox);
            CustomerGroupBox.Controls.Add(CustomerNameLabel);
            CustomerGroupBox.Controls.Add(CustomerIDLabel);
            CustomerGroupBox.Location = new Point(567, 124);
            CustomerGroupBox.Name = "CustomerGroupBox";
            CustomerGroupBox.Size = new Size(297, 85);
            CustomerGroupBox.TabIndex = 5;
            CustomerGroupBox.TabStop = false;
            CustomerGroupBox.Text = "Customer";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(127, 50);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.ReadOnly = true;
            CustomerNameTextBox.Size = new Size(155, 23);
            CustomerNameTextBox.TabIndex = 1;
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(127, 20);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.ReadOnly = true;
            CustomerIDTextBox.Size = new Size(155, 23);
            CustomerIDTextBox.TabIndex = 1;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(21, 58);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(100, 15);
            CustomerNameLabel.TabIndex = 0;
            CustomerNameLabel.Text = "Customer Name :";
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Location = new Point(41, 28);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new Size(79, 15);
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
            ProductGroupBox.Location = new Point(12, 215);
            ProductGroupBox.Name = "ProductGroupBox";
            ProductGroupBox.Size = new Size(852, 90);
            ProductGroupBox.TabIndex = 5;
            ProductGroupBox.TabStop = false;
            ProductGroupBox.Text = "Product";
            // 
            // QuantityUpDown
            // 
            QuantityUpDown.Location = new Point(672, 52);
            QuantityUpDown.Name = "QuantityUpDown";
            QuantityUpDown.ReadOnly = true;
            QuantityUpDown.Size = new Size(165, 23);
            QuantityUpDown.TabIndex = 2;
            QuantityUpDown.KeyUp += QuantityUpDown_KeyUp;
            QuantityUpDown.MouseUp += QuantityUpDown_MouseUp;
            // 
            // SellingPriceTextBox
            // 
            SellingPriceTextBox.Location = new Point(100, 52);
            SellingPriceTextBox.Name = "SellingPriceTextBox";
            SellingPriceTextBox.ReadOnly = true;
            SellingPriceTextBox.Size = new Size(165, 23);
            SellingPriceTextBox.TabIndex = 1;
            // 
            // ProductIDTextBox
            // 
            ProductIDTextBox.Location = new Point(101, 21);
            ProductIDTextBox.Name = "ProductIDTextBox";
            ProductIDTextBox.ReadOnly = true;
            ProductIDTextBox.Size = new Size(165, 23);
            ProductIDTextBox.TabIndex = 1;
            // 
            // UnitInStockTextBox
            // 
            UnitInStockTextBox.Location = new Point(381, 52);
            UnitInStockTextBox.Name = "UnitInStockTextBox";
            UnitInStockTextBox.ReadOnly = true;
            UnitInStockTextBox.Size = new Size(165, 23);
            UnitInStockTextBox.TabIndex = 1;
            // 
            // BarcodeShowTextBox
            // 
            BarcodeShowTextBox.Location = new Point(382, 21);
            BarcodeShowTextBox.Name = "BarcodeShowTextBox";
            BarcodeShowTextBox.ReadOnly = true;
            BarcodeShowTextBox.Size = new Size(165, 23);
            BarcodeShowTextBox.TabIndex = 1;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(672, 21);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.ReadOnly = true;
            ProductNameTextBox.Size = new Size(165, 23);
            ProductNameTextBox.TabIndex = 1;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Location = new Point(606, 60);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(59, 15);
            QuantityLabel.TabIndex = 0;
            QuantityLabel.Text = "Quantity :";
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new Point(575, 29);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new Size(90, 15);
            ProductNameLabel.TabIndex = 0;
            ProductNameLabel.Text = "Product Name :";
            // 
            // UnitInStockLabel1
            // 
            UnitInStockLabel1.AutoSize = true;
            UnitInStockLabel1.Location = new Point(295, 60);
            UnitInStockLabel1.Name = "UnitInStockLabel1";
            UnitInStockLabel1.Size = new Size(80, 15);
            UnitInStockLabel1.TabIndex = 0;
            UnitInStockLabel1.Text = "Unit In Stock :";
            // 
            // BarcodeShowLabel
            // 
            BarcodeShowLabel.AutoSize = true;
            BarcodeShowLabel.Location = new Point(319, 29);
            BarcodeShowLabel.Name = "BarcodeShowLabel";
            BarcodeShowLabel.Size = new Size(56, 15);
            BarcodeShowLabel.TabIndex = 0;
            BarcodeShowLabel.Text = "Barcode :";
            // 
            // SellingPriceLabel
            // 
            SellingPriceLabel.AutoSize = true;
            SellingPriceLabel.Location = new Point(17, 60);
            SellingPriceLabel.Name = "SellingPriceLabel";
            SellingPriceLabel.Size = new Size(77, 15);
            SellingPriceLabel.TabIndex = 0;
            SellingPriceLabel.Text = "Selling Price :";
            // 
            // ProductIDLabel
            // 
            ProductIDLabel.AutoSize = true;
            ProductIDLabel.Location = new Point(25, 29);
            ProductIDLabel.Name = "ProductIDLabel";
            ProductIDLabel.Size = new Size(69, 15);
            ProductIDLabel.TabIndex = 0;
            ProductIDLabel.Text = "Product ID :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 311);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(852, 475);
            dataGridView1.TabIndex = 6;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // NewButton
            // 
            NewButton.BackColor = Color.MintCream;
            NewButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NewButton.Location = new Point(872, 97);
            NewButton.Name = "NewButton";
            NewButton.Size = new Size(155, 40);
            NewButton.TabIndex = 7;
            NewButton.Text = "New...";
            NewButton.UseVisualStyleBackColor = false;
            NewButton.Click += NewButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.BackColor = Color.Ivory;
            CloseButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(872, 143);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(155, 40);
            CloseButton.TabIndex = 7;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.BackColor = Color.MistyRose;
            RemoveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveButton.Location = new Point(872, 189);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(155, 40);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = false;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.DarkGray;
            SaveButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(873, 728);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(152, 58);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            SaveButton.KeyDown += SaveButton_KeyDown;
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Location = new Point(874, 311);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(85, 15);
            TotalAmountLabel.TabIndex = 8;
            TotalAmountLabel.Text = "Total Amount :";
            // 
            // TenderedLabel
            // 
            TenderedLabel.AutoSize = true;
            TenderedLabel.Location = new Point(874, 412);
            TenderedLabel.Name = "TenderedLabel";
            TenderedLabel.Size = new Size(61, 15);
            TenderedLabel.TabIndex = 8;
            TenderedLabel.Text = "Tendered :";
            // 
            // ChangeLabel
            // 
            ChangeLabel.AutoSize = true;
            ChangeLabel.Location = new Point(872, 511);
            ChangeLabel.Name = "ChangeLabel";
            ChangeLabel.Size = new Size(54, 15);
            ChangeLabel.TabIndex = 8;
            ChangeLabel.Text = "Change :";
            // 
            // TotalAmountTextBox
            // 
            TotalAmountTextBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            TotalAmountTextBox.Location = new Point(873, 329);
            TotalAmountTextBox.Name = "TotalAmountTextBox";
            TotalAmountTextBox.ReadOnly = true;
            TotalAmountTextBox.Size = new Size(155, 35);
            TotalAmountTextBox.TabIndex = 9;
            TotalAmountTextBox.TextAlign = HorizontalAlignment.Right;
            TotalAmountTextBox.TextChanged += TotalAmountTextBox_TextChanged;
            // 
            // TenderedTextBox
            // 
            TenderedTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TenderedTextBox.Location = new Point(874, 430);
            TenderedTextBox.Name = "TenderedTextBox";
            TenderedTextBox.Size = new Size(155, 33);
            TenderedTextBox.TabIndex = 9;
            TenderedTextBox.TextAlign = HorizontalAlignment.Right;
            TenderedTextBox.KeyDown += TenderedTextBox_KeyDown;
            // 
            // ChangeTextBox
            // 
            ChangeTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ChangeTextBox.Location = new Point(874, 529);
            ChangeTextBox.Name = "ChangeTextBox";
            ChangeTextBox.ReadOnly = true;
            ChangeTextBox.Size = new Size(155, 33);
            ChangeTextBox.TabIndex = 9;
            ChangeTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // PointOfSaleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 811);
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