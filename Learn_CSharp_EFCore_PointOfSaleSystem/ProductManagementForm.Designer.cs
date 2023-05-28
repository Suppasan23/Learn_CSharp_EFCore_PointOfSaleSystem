namespace Learn_CSharp_EFCore_PointOfSaleSystem
{
    partial class ProductManagementForm
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
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            SearchButton = new Button();
            KeywordTextBox = new TextBox();
            AddNewButton = new Button();
            SaveButton = new Button();
            DeleteButton = new Button();
            RefreshButton = new Button();
            statusStrip1 = new StatusStrip();
            DataGridView1 = new DataGridView();
            ProductIDTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            BarcodeTextBox = new TextBox();
            label4 = new Label();
            ProductNameTextBox = new TextBox();
            label5 = new Label();
            CostPriceTextBox = new TextBox();
            label6 = new Label();
            SellingPriceTextBox = new TextBox();
            label7 = new Label();
            NoteTextBox = new TextBox();
            label8 = new Label();
            UnitNameTextBox = new TextBox();
            label9 = new Label();
            CategoryNameTextBox = new TextBox();
            label10 = new Label();
            ReorderLevelTextBox = new TextBox();
            label11 = new Label();
            UnitInStockTextBox = new TextBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
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
            label1.Size = new Size(764, 81);
            label1.TabIndex = 0;
            label1.Text = "Product Management Form";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientActiveCaption;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 571F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(SearchButton, 1, 0);
            tableLayoutPanel1.Controls.Add(KeywordTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(AddNewButton, 3, 0);
            tableLayoutPanel1.Controls.Add(SaveButton, 4, 0);
            tableLayoutPanel1.Controls.Add(DeleteButton, 5, 0);
            tableLayoutPanel1.Controls.Add(RefreshButton, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 111);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1182, 53);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Dock = DockStyle.Fill;
            SearchButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_preview_archive1;
            SearchButton.Location = new Point(574, 4);
            SearchButton.Margin = new Padding(3, 4, 3, 4);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(108, 45);
            SearchButton.TabIndex = 1;
            SearchButton.Text = "Search";
            SearchButton.TextAlign = ContentAlignment.MiddleRight;
            SearchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // KeywordTextBox
            // 
            KeywordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            KeywordTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            KeywordTextBox.Location = new Point(3, 7);
            KeywordTextBox.Margin = new Padding(3, 4, 3, 4);
            KeywordTextBox.Name = "KeywordTextBox";
            KeywordTextBox.Size = new Size(565, 39);
            KeywordTextBox.TabIndex = 0;
            KeywordTextBox.TextChanged += KeywordTextBox_TextChanged;
            KeywordTextBox.DoubleClick += KeywordTextBox_DoubleClick;
            KeywordTextBox.KeyDown += KeywordTextBox_KeyDown;
            // 
            // AddNewButton
            // 
            AddNewButton.Dock = DockStyle.Fill;
            AddNewButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_new_96;
            AddNewButton.Location = new Point(802, 4);
            AddNewButton.Margin = new Padding(3, 4, 3, 4);
            AddNewButton.Name = "AddNewButton";
            AddNewButton.Size = new Size(108, 45);
            AddNewButton.TabIndex = 3;
            AddNewButton.Text = "Add New";
            AddNewButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            AddNewButton.UseVisualStyleBackColor = true;
            AddNewButton.Click += AddNewButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Dock = DockStyle.Fill;
            SaveButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_games_endturn_96;
            SaveButton.Location = new Point(916, 4);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(108, 45);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Dock = DockStyle.Fill;
            DeleteButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_document_close_96;
            DeleteButton.Location = new Point(1030, 4);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(108, 45);
            DeleteButton.TabIndex = 5;
            DeleteButton.Text = "Delete";
            DeleteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // RefreshButton
            // 
            RefreshButton.Dock = DockStyle.Fill;
            RefreshButton.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_games_solve_96;
            RefreshButton.Location = new Point(688, 4);
            RefreshButton.Margin = new Padding(3, 4, 3, 4);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(108, 45);
            RefreshButton.TabIndex = 2;
            RefreshButton.Text = "Refresh";
            RefreshButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 1059);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1182, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // DataGridView1
            // 
            DataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Location = new Point(3, 365);
            DataGridView1.Margin = new Padding(3, 4, 3, 4);
            DataGridView1.MultiSelect = false;
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.RowTemplate.Height = 25;
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridView1.Size = new Size(1175, 683);
            DataGridView1.TabIndex = 3;
            DataGridView1.CellClick += DataGridView1_CellClick;
            // 
            // ProductIDTextBox
            // 
            ProductIDTextBox.Location = new Point(126, 172);
            ProductIDTextBox.Margin = new Padding(3, 4, 3, 4);
            ProductIDTextBox.Name = "ProductIDTextBox";
            ProductIDTextBox.Size = new Size(457, 27);
            ProductIDTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 176);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 5;
            label2.Text = "Product ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 215);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 7;
            label3.Text = "Barcode :";
            // 
            // BarcodeTextBox
            // 
            BarcodeTextBox.Location = new Point(126, 211);
            BarcodeTextBox.Margin = new Padding(3, 4, 3, 4);
            BarcodeTextBox.Name = "BarcodeTextBox";
            BarcodeTextBox.Size = new Size(457, 27);
            BarcodeTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 253);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 9;
            label4.Text = "Product Name :";
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(126, 249);
            ProductNameTextBox.Margin = new Padding(3, 4, 3, 4);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(457, 27);
            ProductNameTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(43, 292);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 11;
            label5.Text = "Cost Price :";
            // 
            // CostPriceTextBox
            // 
            CostPriceTextBox.Location = new Point(126, 288);
            CostPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            CostPriceTextBox.Name = "CostPriceTextBox";
            CostPriceTextBox.Size = new Size(457, 27);
            CostPriceTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 330);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 13;
            label6.Text = "Selling Price :";
            // 
            // SellingPriceTextBox
            // 
            SellingPriceTextBox.Location = new Point(126, 327);
            SellingPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            SellingPriceTextBox.Name = "SellingPriceTextBox";
            SellingPriceTextBox.Size = new Size(457, 27);
            SellingPriceTextBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(670, 331);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 23;
            label7.Text = "Note :";
            // 
            // NoteTextBox
            // 
            NoteTextBox.Location = new Point(721, 327);
            NoteTextBox.Margin = new Padding(3, 4, 3, 4);
            NoteTextBox.Name = "NoteTextBox";
            NoteTextBox.Size = new Size(457, 27);
            NoteTextBox.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(634, 292);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 21;
            label8.Text = "Unit Name :";
            // 
            // UnitNameTextBox
            // 
            UnitNameTextBox.Location = new Point(721, 288);
            UnitNameTextBox.Margin = new Padding(3, 4, 3, 4);
            UnitNameTextBox.Name = "UnitNameTextBox";
            UnitNameTextBox.Size = new Size(457, 27);
            UnitNameTextBox.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(645, 253);
            label9.Name = "label9";
            label9.Size = new Size(76, 20);
            label9.TabIndex = 19;
            label9.Text = "Category :";
            // 
            // CategoryNameTextBox
            // 
            CategoryNameTextBox.Location = new Point(721, 249);
            CategoryNameTextBox.Margin = new Padding(3, 4, 3, 4);
            CategoryNameTextBox.Name = "CategoryNameTextBox";
            CategoryNameTextBox.Size = new Size(457, 27);
            CategoryNameTextBox.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(612, 215);
            label10.Name = "label10";
            label10.Size = new Size(107, 20);
            label10.TabIndex = 17;
            label10.Text = "Reorder Level :";
            // 
            // ReorderLevelTextBox
            // 
            ReorderLevelTextBox.Location = new Point(721, 211);
            ReorderLevelTextBox.Margin = new Padding(3, 4, 3, 4);
            ReorderLevelTextBox.Name = "ReorderLevelTextBox";
            ReorderLevelTextBox.Size = new Size(457, 27);
            ReorderLevelTextBox.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(620, 176);
            label11.Name = "label11";
            label11.Size = new Size(99, 20);
            label11.TabIndex = 15;
            label11.Text = "Unit in Stock :";
            // 
            // UnitInStockTextBox
            // 
            UnitInStockTextBox.Location = new Point(721, 172);
            UnitInStockTextBox.Margin = new Padding(3, 4, 3, 4);
            UnitInStockTextBox.Name = "UnitInStockTextBox";
            UnitInStockTextBox.Size = new Size(457, 27);
            UnitInStockTextBox.TabIndex = 14;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 1081);
            Controls.Add(label7);
            Controls.Add(NoteTextBox);
            Controls.Add(label8);
            Controls.Add(UnitNameTextBox);
            Controls.Add(label9);
            Controls.Add(CategoryNameTextBox);
            Controls.Add(label10);
            Controls.Add(ReorderLevelTextBox);
            Controls.Add(label11);
            Controls.Add(UnitInStockTextBox);
            Controls.Add(label6);
            Controls.Add(SellingPriceTextBox);
            Controls.Add(label5);
            Controls.Add(CostPriceTextBox);
            Controls.Add(label4);
            Controls.Add(ProductNameTextBox);
            Controls.Add(label3);
            Controls.Add(BarcodeTextBox);
            Controls.Add(label2);
            Controls.Add(ProductIDTextBox);
            Controls.Add(DataGridView1);
            Controls.Add(statusStrip1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductManagementForm";
            Text = "Product Management";
            Load += ProductManagementForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox KeywordTextBox;
        private Button AddNewButton;
        private Button SaveButton;
        private Button DeleteButton;
        private Button RefreshButton;
        private StatusStrip statusStrip1;
        private DataGridView DataGridView1;
        private TextBox ProductIDTextBox;
        private Label label2;
        private Label label3;
        private TextBox BarcodeTextBox;
        private Label label4;
        private TextBox ProductNameTextBox;
        private Label label5;
        private TextBox CostPriceTextBox;
        private Label label6;
        private TextBox SellingPriceTextBox;
        private Label label7;
        private TextBox NoteTextBox;
        private Label label8;
        private TextBox UnitNameTextBox;
        private Label label9;
        private TextBox CategoryNameTextBox;
        private Label label10;
        private TextBox ReorderLevelTextBox;
        private Label label11;
        private TextBox UnitInStockTextBox;
        private Button SearchButton;
    }
}