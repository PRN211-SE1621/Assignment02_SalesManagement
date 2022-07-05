namespace SalesWinApp
{
    partial class FrmMemberManagement
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
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMemberList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lbReleaseYear = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.lbCompanyName = new System.Windows.Forms.Label();
            this.lbCarID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ádfiaosdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTripMenuItemProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTripMenuItemOrderManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(225, 136);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(364, 27);
            this.txtCountry.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Country";
            // 
            // dgvMemberList
            // 
            this.dgvMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberList.Location = new System.Drawing.Point(49, 277);
            this.dgvMemberList.Name = "dgvMemberList";
            this.dgvMemberList.ReadOnly = true;
            this.dgvMemberList.RowHeadersWidth = 51;
            this.dgvMemberList.RowTemplate.Height = 29;
            this.dgvMemberList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMemberList.Size = new System.Drawing.Size(1231, 344);
            this.dgvMemberList.TabIndex = 55;
            this.dgvMemberList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberList_CellDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(805, 193);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 43);
            this.btnDelete.TabIndex = 54;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(578, 193);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 43);
            this.btnNew.TabIndex = 53;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(355, 193);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 43);
            this.btnLoad.TabIndex = 52;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(225, 89);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(365, 27);
            this.txtCompanyName.TabIndex = 51;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(821, 136);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(365, 27);
            this.txtCity.TabIndex = 50;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(821, 40);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(365, 27);
            this.txtEmail.TabIndex = 49;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(821, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(365, 27);
            this.txtPassword.TabIndex = 48;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(225, 40);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(365, 27);
            this.txtMemberId.TabIndex = 47;
            // 
            // lbReleaseYear
            // 
            this.lbReleaseYear.AutoSize = true;
            this.lbReleaseYear.Location = new System.Drawing.Point(735, 89);
            this.lbReleaseYear.Name = "lbReleaseYear";
            this.lbReleaseYear.Size = new System.Drawing.Size(70, 20);
            this.lbReleaseYear.TabIndex = 46;
            this.lbReleaseYear.Text = "Password";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(735, 43);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 20);
            this.lbPrice.TabIndex = 45;
            this.lbPrice.Text = "Email";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(735, 139);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(34, 20);
            this.lbManufacturer.TabIndex = 44;
            this.lbManufacturer.Text = "City";
            // 
            // lbCompanyName
            // 
            this.lbCompanyName.AutoSize = true;
            this.lbCompanyName.Location = new System.Drawing.Point(110, 89);
            this.lbCompanyName.Name = "lbCompanyName";
            this.lbCompanyName.Size = new System.Drawing.Size(116, 20);
            this.lbCompanyName.TabIndex = 43;
            this.lbCompanyName.Text = "Company Name";
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(110, 43);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(84, 20);
            this.lbCarID.TabIndex = 42;
            this.lbCarID.Text = "Member ID";
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
            this.menuStrip1.Size = new System.Drawing.Size(1319, 30);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ádfiaosdfToolStripMenuItem
            // 
            this.ádfiaosdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolTripMenuItemProductManagement,
            this.toolTripMenuItemOrderManagement});
            this.ádfiaosdfToolStripMenuItem.Name = "ádfiaosdfToolStripMenuItem";
            this.ádfiaosdfToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.ádfiaosdfToolStripMenuItem.Text = "Management";
            // 
            // toolTripMenuItemProductManagement
            // 
            this.toolTripMenuItemProductManagement.Name = "toolTripMenuItemProductManagement";
            this.toolTripMenuItemProductManagement.Size = new System.Drawing.Size(235, 26);
            this.toolTripMenuItemProductManagement.Text = "Product Management";
            // 
            // toolTripMenuItemOrderManagement
            // 
            this.toolTripMenuItemOrderManagement.Name = "toolTripMenuItemOrderManagement";
            this.toolTripMenuItemOrderManagement.Size = new System.Drawing.Size(235, 26);
            this.toolTripMenuItemOrderManagement.Text = "Order Management";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FrmMemberManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 671);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMemberList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lbReleaseYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.lbCompanyName);
            this.Controls.Add(this.lbCarID);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMemberManagement";
            this.Text = "FrmMemberManagement";
            this.Load += new System.EventHandler(this.FrmMemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtCountry;
        private Label label1;
        private DataGridView dgvMemberList;
        private Button btnDelete;
        private Button btnNew;
        private Button btnLoad;
        private TextBox txtCompanyName;
        private TextBox txtCity;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtMemberId;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCompanyName;
        private Label lbCarID;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ádfiaosdfToolStripMenuItem;
        private ToolStripMenuItem toolTripMenuItemProductManagement;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolTripMenuItemOrderManagement;
    }
}