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
            productRepository = new ProductRepository();
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();
        }

        private void FrmOrdersDetail_Load(object sender, EventArgs e)
        {
            LoadOrderGridView();
        }

        private void lbCarName_Click(object sender, EventArgs e)
        {

        }


        private void FrmOrdersDetail_Load_1(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmOrdersDetail_Load_2(object sender, EventArgs e)
        {

        }

        private void FrmOrdersDetail_Load_3(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                        OrderId = Int32.Parse(txtOrderID.Text),
                        ProductId = c.ProductId,
                        UnitPrice = c.UnitPrice,
                        Quantity = c.Quantity,
                    };
                    list.Add(od);
                });
                var order = new Order()
                {
                    MemberId = Int32.Parse(txtMemberID.Text),
                    OrderId = Int32.Parse(txtOrderID.Text),
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
    }
}
