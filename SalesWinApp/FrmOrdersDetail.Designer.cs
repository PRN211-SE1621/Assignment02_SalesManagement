namespace SalesWinApp
{
    partial class FrmOrdersDetail
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lbReleaseYear = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbManufacturer = new System.Windows.Forms.Label();
            this.lbCarName = new System.Windows.Forms.Label();
            this.lbCarID = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 243);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 55);
            this.btnCancel.TabIndex = 89;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(334, 243);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 55);
            this.btnSave.TabIndex = 88;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(189, 108);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(294, 27);
            this.txtMemberID.TabIndex = 85;
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(189, 168);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(294, 27);
            this.txtFreight.TabIndex = 84;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(189, 49);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(294, 27);
            this.txtOrderID.TabIndex = 81;
            // 
            // lbReleaseYear
            // 
            this.lbReleaseYear.AutoSize = true;
            this.lbReleaseYear.Location = new System.Drawing.Point(529, 115);
            this.lbReleaseYear.Name = "lbReleaseYear";
            this.lbReleaseYear.Size = new System.Drawing.Size(100, 20);
            this.lbReleaseYear.TabIndex = 80;
            this.lbReleaseYear.Text = "Shipped Date";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Location = new System.Drawing.Point(529, 53);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(105, 20);
            this.lbPrice.TabIndex = 79;
            this.lbPrice.Text = "Required Date";
            // 
            // lbManufacturer
            // 
            this.lbManufacturer.AutoSize = true;
            this.lbManufacturer.Location = new System.Drawing.Point(57, 172);
            this.lbManufacturer.Name = "lbManufacturer";
            this.lbManufacturer.Size = new System.Drawing.Size(55, 20);
            this.lbManufacturer.TabIndex = 78;
            this.lbManufacturer.Text = "Freight";
            // 
            // lbCarName
            // 
            this.lbCarName.AutoSize = true;
            this.lbCarName.Location = new System.Drawing.Point(57, 108);
            this.lbCarName.Name = "lbCarName";
            this.lbCarName.Size = new System.Drawing.Size(84, 20);
            this.lbCarName.TabIndex = 77;
            this.lbCarName.Text = "Member ID";
            this.lbCarName.Click += new System.EventHandler(this.lbCarName_Click);
            // 
            // lbCarID
            // 
            this.lbCarID.AutoSize = true;
            this.lbCarID.Location = new System.Drawing.Point(57, 53);
            this.lbCarID.Name = "lbCarID";
            this.lbCarID.Size = new System.Drawing.Size(66, 20);
            this.lbCarID.TabIndex = 76;
            this.lbCarID.Text = "Order ID";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(662, 51);
            this.txtRequiredDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(294, 27);
            this.txtRequiredDate.TabIndex = 91;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(662, 111);
            this.txtShippedDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(294, 27);
            this.txtShippedDate.TabIndex = 92;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // dgvProductList
            // 
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductList.Location = new System.Drawing.Point(57, 329);
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.RowHeadersWidth = 51;
            this.dgvProductList.RowTemplate.Height = 29;
            this.dgvProductList.Size = new System.Drawing.Size(899, 164);
            this.dgvProductList.TabIndex = 93;
            this.dgvProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(599, 243);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(217, 55);
            this.btnAdd.TabIndex = 94;
            this.btnAdd.Text = "Add New Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmOrdersDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 571);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.lbReleaseYear);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbManufacturer);
            this.Controls.Add(this.lbCarName);
            this.Controls.Add(this.lbCarID);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOrdersDetail";
            this.Text = "FrmOrdersDetail";
            this.Load += new System.EventHandler(this.FrmOrdersDetail_Load_3);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtMemberID;
        private TextBox txtFreight;
        private TextBox txtOrderID;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarID;
        private DateTimePicker txtRequiredDate;
        private DateTimePicker txtShippedDate;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dgvProductList;
        private Button btnAdd;
    }
}
