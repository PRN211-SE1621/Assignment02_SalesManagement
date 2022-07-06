using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class FrmProductDetail : Form
    {
        public FrmProductDetail()
        {
            InitializeComponent();
        }
        public IProductRepository  proRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product ProductInfo { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtCategoryID.Text),
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    Weight = txtWeight.Text,
                    UnitsInStock = int.Parse(txtUnitsInStock.Text)
                };
                if (InsertOrUpdate)
                {
                    proRepository.UpdateProduct(product);
                }
                else
                {
                    proRepository.CreateProduct(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new:" : "Update");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)=>this.Close();

        private void FrmProductDetail_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtProductID.Text = ProductInfo.ProductId.ToString();
                txtCategoryID.Text = ProductInfo.CategoryId.ToString();
                txtProductName.Text = ProductInfo.ProductName.ToString();
                txtUnitPrice.Text = ProductInfo.UnitPrice.ToString();
                txtWeight.Text = ProductInfo.Weight.ToString();
                txtUnitsInStock.Text = ProductInfo.UnitsInStock.ToString();
            }
        }
    }
}
