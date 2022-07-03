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
    public partial class FrmUpdateOrder : Form
    {

        private BindingSource bindingSource;
        private IEnumerable<Product>? products;
        private IProductRepository productRepository;
        private IOrderDetailRepository orderDetailRepository;
        private IOrderRepository orderRepository;
        public List<CartDTO> Cart = new List<CartDTO>();
        public Order? Order;

        public FrmUpdateOrder()
        {
            InitializeComponent();
            productRepository = new ProductRepository();
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();
            btnSave.Enabled = false;

        }

        private void FrmOrdersDetail_Load(object sender, EventArgs e)
        {
        }
        private void ShowInfo()
        {
            if (Order != null)
            {
                txtFreight.Text = Order.Freight.ToString();
                txtOrderID.Text = Order.OrderId.ToString();
                txtMemberID.Text = Order.MemberId.ToString();
                txtOrderDate.CustomFormat = Order.MemberId.ToString();
                txtShippedDate.CustomFormat = Order.MemberId.ToString();
                txtRequiredDate.CustomFormat = Order.MemberId.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new FrmAddOrderDetail()
            {

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
                bindingSource.DataSource = Order;
                dgvProductList.DataSource = bindingSource;
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

        private void FrmOrdersDetail_Load_1(object sender, EventArgs e)
        {

        }

        private void FrmUpdateOrder_Load(object sender, EventArgs e)
        {
            ShowInfo();
            LoadOrderGridView();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
