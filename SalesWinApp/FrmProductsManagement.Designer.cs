namespace SalesWinApp
{
    partial class FrmProductsManagement
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtProductNameSearch = new System.Windows.Forms.TextBox();
            this.txtProductIDSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtUnitsInStockSearch = new System.Windows.Forms.TextBox();
            this.txtUnitPriceSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.txtUnitsInStock = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbReleaseYear = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.lbCarName = new System.Windows.Forms.Label();
            this.lbCarID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ádfiaosdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTripMenuItemMemberManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTripMenuItemOrderManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(695, 131);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 31);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtProductNameSearch
            // 
            this.txtProductNameSearch.Location = new System.Drawing.Point(113, 83);
            this.txtProductNameSearch.Name = "txtProductNameSearch";
            this.txtProductNameSearch.Size = new System.Drawing.Size(236, 27);
            this.txtProductNameSearch.TabIndex = 43;
            // 
            // txtProductIDSearch
            // 
            this.txtProductIDSearch.Location = new System.Drawing.Point(112, 41);
            this.txtProductIDSearch.Name = "txtProductIDSearch";
            this.txtProductIDSearch.Size = new System.Drawing.Size(237, 27);
            this.txtProductIDSearch.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Product ID";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.txtUnitsInStockSearch);
            this.groupBoxSearch.Controls.Add(this.txtUnitPriceSearch);
            this.groupBoxSearch.Controls.Add(this.label7);
            this.groupBoxSearch.Controls.Add(this.label6);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.txtProductNameSearch);
            this.groupBoxSearch.Controls.Add(this.txtProductIDSearch);
            this.groupBoxSearch.Controls.Add(this.label5);
            this.groupBoxSearch.Controls.Add(this.label4);
            this.groupBoxSearch.Location = new System.Drawing.Point(169, 258);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSearch.Size = new System.Drawing.Size(827, 169);
            this.groupBoxSearch.TabIndex = 60;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // txtUnitsInStockSearch
            // 
            this.txtUnitsInStockSearch.Location = new System.Drawing.Point(544, 83);
            this.txtUnitsInStockSearch.Name = "txtUnitsInStockSearch";
            this.txtUnitsInStockSearch.Size = new System.Drawing.Size(237, 27);
            this.txtUnitsInStockSearch.TabIndex = 51;
            // 
            // txtUnitPriceSearch
            // 
            this.txtUnitPriceSearch.Location = new System.Drawing.Point(543, 41);
            this.txtUnitPriceSearch.Name = "txtUnitPriceSearch";
            this.txtUnitPriceSearch.Size = new System.Drawing.Size(237, 27);
            this.txtUnitPriceSearch.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(437, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Units In Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Unit Price";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(188, 151);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(364, 27);
            this.txtProductName.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "ProductName";
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(38, 443);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(1076, 283);
            this.dgvMemberList.TabIndex = 56;
            this.dgvMemberList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellContentDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(768, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 43);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(541, 208);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 43);
            this.btnNew.TabIndex = 54;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(318, 208);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 43);
            this.btnLoad.TabIndex = 53;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(188, 104);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(365, 27);
            this.txtCategoryID.TabIndex = 52;
            // 
            // txtUnitsInStock
            // 
            this.txtUnitsInStock.Location = new System.Drawing.Point(712, 151);
            this.txtUnitsInStock.Name = "txtUnitsInStock";
            this.txtUnitsInStock.Size = new System.Drawing.Size(365, 27);
            this.txtUnitsInStock.TabIndex = 51;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(712, 56);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(365, 27);
            this.txtWeight.TabIndex = 50;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(712, 105);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = true;
            this.txtUnitPrice.Size = new System.Drawing.Size(365, 27);
            this.txtUnitPrice.TabIndex = 49;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(188, 55);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(365, 27);
            this.txtProductID.TabIndex = 48;
            // 
            // lbReleaseYear
            // 
            this.lbReleaseYear.AutoSize = true;
            this.lbReleaseYear.Location = new System.Drawing.Point(606, 112);
            this.lbReleaseYear.Name = "lbReleaseYear";
            this.lbReleaseYear.Size = new System.Drawing.Size(72, 20);
            this.lbReleaseYear.TabIndex = 47;
            this.lbReleaseYear.Text = "Unit Price";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(606, 59);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(56, 20);
            this.lbPrice.TabIndex = 46;
            this.lbPrice.Text = "Weight";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(606, 155);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(98, 20);
            this.lbManufacturer.TabIndex = 45;
            this.lbManufacturer.Text = "Units In Stock";
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(73, 104);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(88, 20);
            this.lbCarName.TabIndex = 44;
            this.lbCarName.Text = "Category ID";
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(73, 58);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(79, 20);
            this.lbCarID.TabIndex = 43;
            this.lbCarID.Text = "Product ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ádfiaosdfToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1139, 30);
            this.menuStrip1.TabIndex = 61;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ádfiaosdfToolStripMenuItem
            // 
            this.ádfiaosdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTripMenuItemMemberManagement,
            this.toolTripMenuItemOrderManagement});
            this.ádfiaosdfToolStripMenuItem.Name = "ádfiaosdfToolStripMenuItem";
            this.ádfiaosdfToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.ádfiaosdfToolStripMenuItem.Text = "Management";
            // 
            // toolTripMenuItemMemberManagement
            // 
            this.toolTripMenuItemMemberManagement.Name = "toolTripMenuItemMemberManagement";
            this.toolTripMenuItemMemberManagement.Size = new System.Drawing.Size(240, 26);
            this.toolTripMenuItemMemberManagement.Text = "Member Management";
            // 
            // toolTripMenuItemOrderManagement
            // 
            this.toolTripMenuItemOrderManagement.Name = "toolTripMenuItemOrderManagement";
            this.toolTripMenuItemOrderManagement.Size = new System.Drawing.Size(240, 26);
            this.toolTripMenuItemOrderManagement.Text = "Order Management";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FrmProductsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 759);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.txtUnitsInStock);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lbReleaseYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.lbCarID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmProductsManagement";
            this.Text = "FrmProductsManagement";
            this.Load += new System.EventHandler(this.FrmProductsManagement_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnSearch;
        private TextBox txtProductNameSearch;
        private TextBox txtProductIDSearch;
        private Label label5;
        private Label label4;
        private GroupBox groupBoxSearch;
        private TextBox txtProductName;
        private Label label1;
        private DataGridView dgvMemberList;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private TextBox txtCategoryID;
        private TextBox txtUnitsInStock;
        private TextBox txtWeight;
        private TextBox txtUnitPrice;
        private TextBox txtProductID;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarID;
        private Label label7;
        private Label label6;
        private TextBox txtUnitsInStockSearch;
        private TextBox txtUnitPriceSearch;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ádfiaosdfToolStripMenuItem;
        private ToolStripMenuItem toolTripMenuItemMemberManagement;
        private ToolStripMenuItem toolTripMenuItemOrderManagement;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}