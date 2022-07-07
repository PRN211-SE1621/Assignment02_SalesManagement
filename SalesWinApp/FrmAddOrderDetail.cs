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
    public partial class FrmAddOrderDetail : Form
    {
        private BindingSource bindingSource;
        private IEnumerable<Product>? products;
        private IProductRepository productRepository;
        public FrmOrdersDetail TheParent;
        public FrmAddOrderDetail()
        {
            InitializeComponent();
        }

        private void FrmAddOrderDetail_Load(object sender, EventArgs e)
        {
            productRepository = new ProductRepository();
            products = productRepository.GetAll();
            LoadOrderGridView(products);
            txtProductID.Enabled = false;
        }


        private void LoadOrderGridView(IEnumerable<Product> products)
        {
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = products;
                dgvProductList.DataSource = bindingSource;
                txtProductID.DataBindings.Clear();
                txtProductID.DataBindings.Add("Text", bindingSource, "ProductId");
                if (products.Count() == 0)
                {
                    txtProductID.Text = "";
                }
                dgvProductList.Columns["OrderDetails"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var product = productRepository.GetById(int.Parse(txtProductID.Text));
            if (product == null)
            {
                return;
            }
            CartDTO? cart = this.TheParent.Cart.SingleOrDefault(c => c.ProductId == product.ProductId);
            if (cart == null)
            {
                CartDTO cartTmp = new CartDTO()
                {
                    ProductId = product.ProductId,
                    UnitPrice = product.UnitPrice,
                    Discount = 0,
                    Quantity = 1
                };
                this.TheParent.Cart.Add(cartTmp);
            }
            else
            {
                cart.Quantity++;
            }

            if (MessageBox.Show("Do you want to continue?", "Add success!", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
