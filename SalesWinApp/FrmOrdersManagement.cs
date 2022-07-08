using BusinessObject;
using DataAccess;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class FrmOrdersManagement : Form
    {

        private BindingSource bindingSource;
        private IEnumerable<Order>? orders;
        private IOrderRepository orderRepository;
        public Member Member { get; set; }

        public FrmOrdersManagement()
        {
            InitializeComponent();
        }

        private void FrmOrdersManagement_Load(object sender, EventArgs e)
        {
            orderRepository = new OrderRepository();
            orders = AllOrderInForm();
            LoadOrderGridView(orders);

            if(Member != null)
            {
                btnDelete.Enabled = false;
                //btnUpdate.Enabled = false;
                btnNew.Enabled = false;
            }    
        }

        private IEnumerable<Order> AllOrderInForm()
        {
            return Member == null ? orderRepository.GetAll() : orderRepository.GetAllOfMember(Member.MemberId);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            orders = orderRepository.SortDescByDate();
            LoadOrderGridView(orders);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = txtStartDate.Value;
            DateTime endDate = txtEndDate.Value;
            orders = orderRepository.FilterByDate(startDate, endDate);
            LoadOrderGridView(orders);
            txtStartDate.Value = startDate;
            txtEndDate.Value = endDate;
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            orders = OrderDAO.Instance.GetList();
            LoadOrderGridView(orders);
        }

        private void LoadOrderGridView(IEnumerable<Order> orders)
        {
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = orders;

                ClearBinding();
                if (orders.Count() > 0)
                {
                    txtOrderID.DataBindings.Add("Text", bindingSource, "OrderId");
                    txtMemberID.DataBindings.Add("Text", bindingSource, "MemberId");
                    txtFreight.DataBindings.Add("Text", bindingSource, "Freight");
                    txtRequiredDate.DataBindings.Add("Text", bindingSource, "RequiredDate");
                    txtShippedDate.DataBindings.Add("Text", bindingSource, "ShippedDate");
                    txtOrderDate.DataBindings.Add("Text", bindingSource, "OrderDate");                    
                }
                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = bindingSource;
                dgvOrderList.Columns["Member"].Visible = false;
                dgvOrderList.Columns["OrderDetails"].Visible = false;

                if (orders.Count() == 0)
                {
                    ClearText();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearBinding()
        {
            txtOrderID.DataBindings.Clear();
            txtMemberID.DataBindings.Clear();
            txtFreight.DataBindings.Clear();
            txtRequiredDate.DataBindings.Clear();
            txtShippedDate.DataBindings.Clear();
            txtOrderDate.DataBindings.Clear();
            txtStartDate.DataBindings.Clear();
            txtEndDate.DataBindings.Clear();
        }

        private void ClearText()
        {
            txtOrderID.Text = "";
            txtMemberID.Text = "";
            txtFreight.Text = "";
            txtRequiredDate.Text = "";
            txtShippedDate.Text = "";
            txtOrderDate.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frm = new FrmOrdersDetail();
            frm.Show();
            frm.FormClosed += delegate
            {
                orders = OrderDAO.Instance.GetList();
                LoadOrderGridView(orders);
            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmUpdateOrder frm = new FrmUpdateOrder()
                {
                    Order = orderRepository.GetById(Int32.Parse(txtOrderID.Text)),
                    Member = Member
                };
                frm.Show();
                frm.FormClosed += delegate
                {
                    orders = AllOrderInForm();
                    LoadOrderGridView(orders);
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = orderRepository.GetById(Int32.Parse(txtOrderID.Text));
                if (MessageBox.Show("Do you want to delete this order?", "Delete order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    orderRepository.Delete(order);
                    MessageBox.Show("Deleted successfully?", "Delete order");
                }
                else
                {
                    MessageBox.Show("Delete fail?", "Delete order");
                }
                orders = OrderDAO.Instance.GetList();
                LoadOrderGridView(orders);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
