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
    public partial class FrmOrdersDetail : Form
    {

        private BindingSource bindingSource;
        private IEnumerable<Product>? products;
        private IProductRepository productRepository;
        private IOrderDetailRepository orderDetailRepository;
        private IOrderRepository orderRepository;
        public List<CartDTO> Cart = new List<CartDTO>();

        public FrmOrdersDetail()
        {
            InitializeComponent();
        }

        private void FrmOrdersDetail_Load(object sender, EventArgs e)
        {
            LoadOrderGridView();
            productRepository = new ProductRepository();
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();

            txtProductID.Enabled = false;
            btnSave.Enabled = false;
            if (Cart.Count == 0)
            {
                btnRemove.Enabled = false;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddOrderDetail()
            {
                TheParent = this
            };
            frm.FormClosing += delegate
            {
                LoadOrderGridView();
            };
            frm.Show();
        }
        private void LoadOrderGridView()
        {
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = Cart;
                dgvProductList.DataSource = bindingSource;
                txtProductID.DataBindings.Clear();
                txtProductID.DataBindings.Add("Text", bindingSource, "ProductId");
                if (Cart.Count == 0)
                {
                    btnRemove.Enabled = false;
                    txtProductID.Text = "";
                }
                else
                {
                    btnRemove.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<OrderDetail> list = new List<OrderDetail>();
                Cart.ForEach(c =>
                {
                    OrderDetail od = new OrderDetail()
                    {
                        ProductId = c.ProductId,
                        UnitPrice = c.UnitPrice,
                        Quantity = c.Quantity,
                    };
                    list.Add(od);
                });
                var order = new Order()
                {
                    MemberId = Int32.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Now,
                    ShippedDate = Convert.ToDateTime(txtShippedDate.Value),
                    RequiredDate = Convert.ToDateTime(txtRequiredDate.Value),
                    Freight = decimal.Parse(txtFreight.Text),
                    OrderDetails = list
                };
                orderRepository.Add(order);

                if (MessageBox.Show("Added successfully!") == DialogResult.OK)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductList_DataSourceChanged(object sender, EventArgs e)
        {
            if (Cart.Count == 0)
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var cartDTO = Cart.ToList().SingleOrDefault(c => c.ProductId == Int32.Parse(txtProductID.Text));
            if (cartDTO != null)
            {
                Cart.Remove(cartDTO);
            }
            LoadOrderGridView();
        }

    }
}
