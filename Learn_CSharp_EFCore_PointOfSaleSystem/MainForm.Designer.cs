namespace Learn_CSharp_EFCore_PointOfSaleSystem
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            userManagementToolStripMenuItem = new ToolStripMenuItem();
            productManagementToolStripMenuItem = new ToolStripMenuItem();
            pointOfSaleSystemToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutApplicationToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            UserManagementToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ProductManagementToolStripButton = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            PointOfSaleToolStripButton = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            LogoutToolStripButton = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            ExitToolStripButton = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { userManagementToolStripMenuItem, productManagementToolStripMenuItem, pointOfSaleSystemToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.Image = Properties.Resources.Graphicloads_Business_Profile_96;
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new Size(190, 22);
            userManagementToolStripMenuItem.Text = "User Management";
            userManagementToolStripMenuItem.Click += userManagementToolStripMenuItem_Click;
            // 
            // productManagementToolStripMenuItem
            // 
            productManagementToolStripMenuItem.Image = Properties.Resources.Dtafalonso_Android_Lollipop_Aptoide_96;
            productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            productManagementToolStripMenuItem.Size = new Size(190, 22);
            productManagementToolStripMenuItem.Text = "Product Management";
            productManagementToolStripMenuItem.Click += productManagementToolStripMenuItem_Click;
            // 
            // pointOfSaleSystemToolStripMenuItem
            // 
            pointOfSaleSystemToolStripMenuItem.Image = Properties.Resources.Graphicloads_Flat_Finance_Statistics_market_96;
            pointOfSaleSystemToolStripMenuItem.Name = "pointOfSaleSystemToolStripMenuItem";
            pointOfSaleSystemToolStripMenuItem.Size = new Size(190, 22);
            pointOfSaleSystemToolStripMenuItem.Text = "Point Of Sale System";
            pointOfSaleSystemToolStripMenuItem.Click += pointOfSaleSystemToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Image = Properties.Resources.Papirus_Team_Papirus_Apps_Android_file_transfer_96;
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(190, 22);
            logoutToolStripMenuItem.Text = "Log-out";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.Everaldo_Crystal_Clear_Action_exit_96;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(190, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutApplicationToolStripMenuItem });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "About";
            // 
            // aboutApplicationToolStripMenuItem
            // 
            aboutApplicationToolStripMenuItem.Image = Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_help_about_96;
            aboutApplicationToolStripMenuItem.Name = "aboutApplicationToolStripMenuItem";
            aboutApplicationToolStripMenuItem.Size = new Size(171, 22);
            aboutApplicationToolStripMenuItem.Text = "About Application";
            aboutApplicationToolStripMenuItem.Click += aboutApplicationToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 839);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripStatusLabel1.ForeColor = Color.OrangeRed;
            toolStripStatusLabel1.Image = Properties.Resources.Graphicloads_Flat_Finance_Statistics_market_96;
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(56, 17);
            toolStripStatusLabel1.Text = "Status";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Left;
            toolStrip1.Items.AddRange(new ToolStripItem[] { UserManagementToolStripButton, toolStripSeparator1, ProductManagementToolStripButton, toolStripSeparator2, PointOfSaleToolStripButton, toolStripSeparator3, LogoutToolStripButton, toolStripSeparator4, ExitToolStripButton, toolStripSeparator5 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(140, 815);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // UserManagementToolStripButton
            // 
            UserManagementToolStripButton.Image = Properties.Resources.Graphicloads_Business_Profile_96;
            UserManagementToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            UserManagementToolStripButton.ImageTransparentColor = Color.Magenta;
            UserManagementToolStripButton.Margin = new Padding(2, 0, 0, 0);
            UserManagementToolStripButton.Name = "UserManagementToolStripButton";
            UserManagementToolStripButton.Padding = new Padding(5);
            UserManagementToolStripButton.Size = new Size(135, 125);
            UserManagementToolStripButton.Text = "User Management";
            UserManagementToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            UserManagementToolStripButton.Click += UserManagementToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(137, 6);
            // 
            // ProductManagementToolStripButton
            // 
            ProductManagementToolStripButton.Image = Properties.Resources.Dtafalonso_Android_Lollipop_Aptoide_96;
            ProductManagementToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            ProductManagementToolStripButton.ImageTransparentColor = Color.Magenta;
            ProductManagementToolStripButton.Margin = new Padding(2, 0, 0, 0);
            ProductManagementToolStripButton.Name = "ProductManagementToolStripButton";
            ProductManagementToolStripButton.Padding = new Padding(5);
            ProductManagementToolStripButton.Size = new Size(135, 125);
            ProductManagementToolStripButton.Text = "Product Management";
            ProductManagementToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ProductManagementToolStripButton.Click += ProductManagementToolStripButton_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(137, 6);
            // 
            // PointOfSaleToolStripButton
            // 
            PointOfSaleToolStripButton.Image = Properties.Resources.Graphicloads_Flat_Finance_Statistics_market_96;
            PointOfSaleToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            PointOfSaleToolStripButton.ImageTransparentColor = Color.Magenta;
            PointOfSaleToolStripButton.Margin = new Padding(2, 0, 0, 0);
            PointOfSaleToolStripButton.Name = "PointOfSaleToolStripButton";
            PointOfSaleToolStripButton.Padding = new Padding(5);
            PointOfSaleToolStripButton.Size = new Size(135, 125);
            PointOfSaleToolStripButton.Text = "Point Of Sale";
            PointOfSaleToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            PointOfSaleToolStripButton.Click += PointOfSaleToolStripButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(137, 6);
            // 
            // LogoutToolStripButton
            // 
            LogoutToolStripButton.Image = Properties.Resources.Papirus_Team_Papirus_Apps_Android_file_transfer_96;
            LogoutToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            LogoutToolStripButton.ImageTransparentColor = Color.Magenta;
            LogoutToolStripButton.Margin = new Padding(2, 0, 0, 0);
            LogoutToolStripButton.Name = "LogoutToolStripButton";
            LogoutToolStripButton.Padding = new Padding(5);
            LogoutToolStripButton.Size = new Size(135, 125);
            LogoutToolStripButton.Text = "Log Out";
            LogoutToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            LogoutToolStripButton.Click += LogoutToolStripButton_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(137, 6);
            // 
            // ExitToolStripButton
            // 
            ExitToolStripButton.Image = Properties.Resources.Everaldo_Crystal_Clear_Action_exit_96;
            ExitToolStripButton.ImageScaling = ToolStripItemImageScaling.None;
            ExitToolStripButton.ImageTransparentColor = Color.Magenta;
            ExitToolStripButton.Margin = new Padding(2, 0, 0, 0);
            ExitToolStripButton.Name = "ExitToolStripButton";
            ExitToolStripButton.Padding = new Padding(5);
            ExitToolStripButton.Size = new Size(135, 125);
            ExitToolStripButton.Text = "Exit";
            ExitToolStripButton.TextImageRelation = TextImageRelation.ImageAboveText;
            ExitToolStripButton.Click += ExitToolStripButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(137, 6);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 861);
            ControlBox = false;
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem userManagementToolStripMenuItem;
        private ToolStripMenuItem productManagementToolStripMenuItem;
        private ToolStripMenuItem pointOfSaleSystemToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutApplicationToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolStrip1;
        private ToolStripButton UserManagementToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ProductManagementToolStripButton;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton PointOfSaleToolStripButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton LogoutToolStripButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton ExitToolStripButton;
        private ToolStripSeparator toolStripSeparator5;
    }
}