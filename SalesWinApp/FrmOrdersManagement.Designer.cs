namespace SalesWinApp
{
    partial class FrmOrdersManagement
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
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbReleaseYear = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.lbCarName = new System.Windows.Forms.Label();
            this.lbCarID = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ádfiaosdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTripMenuItemMemberManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTripMenuItemOrderManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.btnFilter);
            this.groupBoxSearch.Location = new System.Drawing.Point(113, 276);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxSearch.Size = new System.Drawing.Size(506, 132);
            this.groupBoxSearch.TabIndex = 78;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Report statistics sales";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(403, 68);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(86, 31);
            this.btnFilter.TabIndex = 44;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(236, 363);
            this.txtEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(262, 27);
            this.txtEndDate.TabIndex = 80;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(236, 316);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(262, 27);
            this.txtStartDate.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Start Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Order Date";
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Location = new System.Drawing.Point(113, 433);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(818, 265);
            this.dgvOrderList.TabIndex = 74;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(271, 227);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 43);
            this.btnNew.TabIndex = 72;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(113, 226);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 43);
            this.btnLoad.TabIndex = 71;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(213, 123);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(262, 27);
            this.txtMemberID.TabIndex = 70;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(213, 168);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(262, 27);
            this.txtFreight.TabIndex = 69;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(213, 72);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(262, 27);
            this.txtOrderID.TabIndex = 66;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // lbReleaseYear
            // 
            this.lbReleaseYear.AutoSize = true;
            this.lbReleaseYear.Location = new System.Drawing.Point(555, 123);
            this.lbReleaseYear.Name = "lbReleaseYear";
            this.lbReleaseYear.Size = new System.Drawing.Size(100, 20);
            this.lbReleaseYear.TabIndex = 65;
            this.lbReleaseYear.Text = "Shipped Date";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(555, 76);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(105, 20);
            this.lbPrice.TabIndex = 64;
            this.lbPrice.Text = "Required Date";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(113, 168);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(55, 20);
            this.lbManufacturer.TabIndex = 63;
            this.lbManufacturer.Text = "Freight";
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(113, 123);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(84, 20);
            this.lbCarName.TabIndex = 62;
            this.lbCarName.Text = "Member ID";
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(113, 76);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(66, 20);
            this.lbCarID.TabIndex = 61;
            this.lbCarID.Text = "Order ID";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(697, 311);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(170, 77);
            this.btnSort.TabIndex = 83;
            this.btnSort.Text = "Sort Sales In Descending Order";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(995, 30);
            this.menuStrip1.TabIndex = 84;
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(814, 722);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 43);
            this.btnCancel.TabIndex = 85;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(682, 123);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(262, 27);
            this.txtShippedDate.TabIndex = 88;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(682, 168);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(262, 27);
            this.txtOrderDate.TabIndex = 87;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(682, 72);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(262, 27);
            this.txtRequiredDate.TabIndex = 86;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(436, 227);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 43);
            this.btnUpdate.TabIndex = 89;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(605, 226);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 43);
            this.btnDelete.TabIndex = 90;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmOrdersManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 803);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbReleaseYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.lbCarID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOrdersManagement";
            this.Text = "FrmOrdersManagement";
            this.groupBoxSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBoxSearch;
        private Button btnFilter;
        private Label label5;
        private Label label4;
        private Label label1;
        private DataGridView dgvOrderList;
        private Button btnNew;
        private Button btnLoad;
        private TextBox txtMemberID;
        private TextBox txtFreight;
        private TextBox txtOrderID;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarID;
        private DateTimePicker txtEndDate;
        private DateTimePicker txtStartDate;
        private Button btnSort;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ádfiaosdfToolStripMenuItem;
        private ToolStripMenuItem toolTripMenuItemMemberManagement;
        private ToolStripMenuItem toolTripMenuItemOrderManagement;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnCancel;
        private TextBox txtShippedDate;
        private TextBox txtOrderDate;
        private TextBox txtRequiredDate;
        private Button btnUpdate;
        private Button btnDelete;
    }
}