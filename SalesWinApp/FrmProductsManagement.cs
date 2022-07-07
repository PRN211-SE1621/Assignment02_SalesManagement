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
    public partial class FrmProductsManagement : Form
    {
        private FrmLogin loginForm;
        private IProductRepository proRepo;
        private BindingSource bindingSource;
        public FrmProductsManagement()
        {
            InitializeComponent();
            this.proRepo = new ProductRepository();
        }

        public FrmProductsManagement(FrmLogin loginForm)
        {
            this.loginForm = loginForm;
            this.proRepo = new ProductRepository();
        }

        private Product GetProductObject()
        {
            Product product = null;
            try
            {
                proRepo = new ProductRepository();
                product = proRepo.GetProductById(int.Parse(txtProductID.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return product;
        }
        public void ClearText()
        {
            txtProductID.Text = "";
            txtCategoryID.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "";
            txtUnitsInStock.Text = "";
            txtWeight.Text = "";
        }
        private void LoadProductsToGridView(IEnumerable<Product> products)
        {
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = products;

                txtProductID.DataBindings.Clear();
                txtCategoryID.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitsInStock.DataBindings.Clear();
                txtWeight.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", bindingSource, "ProductId");
                txtCategoryID.DataBindings.Add("Text", bindingSource, "CategoryID");
                txtProductName.DataBindings.Add("Text", bindingSource, "ProductName");
                txtUnitPrice.DataBindings.Add("Text", bindingSource, "UnitPrice");
                txtUnitsInStock.DataBindings.Add("Text", bindingSource, "UnitsInStock");
                txtWeight.DataBindings.Add("Text", bindingSource, "Weight");

                dgvProducts.DataSource = null;
                dgvProducts.DataSource = bindingSource;
                if (products.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmProductDetail frmProductDetail = new FrmProductDetail
            {
                Text = "Add Product",
                InsertOrUpdate = false,
                proRepository = proRepo,
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductsToGridView(proRepo.GetAllProducts());
                bindingSource.Position = bindingSource.Count - 1;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProductsToGridView(proRepo.GetAllProducts());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                if (DialogResult.Yes == MessageBox.Show($"Do You Want Delete proruct id: {product.ProductId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    proRepo.DeleteProduct(product.ProductId);
                    LoadProductsToGridView(proRepo.GetAllProducts());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a product");
            }
        }

        private void FrmProductsManagement_Load(object sender, EventArgs e)
        {
            LoadProductsToGridView(proRepo.GetAllProducts());
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmProductDetail frmProductDetail = new FrmProductDetail
            {
                Text = "Update Product",
                InsertOrUpdate = true,
                proRepository = proRepo,
                ProductInfo = GetProductObject()
            };
            if (frmProductDetail.ShowDialog() == DialogResult.OK)
            {
                LoadProductsToGridView(proRepo.GetAllProducts());
                bindingSource.Position = bindingSource.Count - 1;
            }
        }
    }
}
