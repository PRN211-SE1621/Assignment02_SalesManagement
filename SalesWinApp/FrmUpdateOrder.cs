using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class FrmUpdateOrder : Form
    {

        private BindingSource bindingSource;
        private IOrderRepository orderRepository = new OrderRepository();
        public Order? Order;
        public Member Member { get; set; }

        public FrmUpdateOrder()
        {
            InitializeComponent();
        }
        private void FrmUpdateOrder_Load(object sender, EventArgs e)
        {
            ShowInfo();
            LoadOrderGridView();
            if(Member != null) btnSave.Enabled = false;
        }

        private void ShowInfo()
        {
            if (Order != null)
            {
                txtFreight.Text = Order.Freight.ToString();
                txtOrderID.Text = Order.OrderId.ToString();
                txtMemberID.Text = Order.MemberId.ToString();
                txtOrderDate.CustomFormat = Order.MemberId.ToString();
                txtShippedDate.Value = Order.ShippedDate.Value;
                txtRequiredDate.Value = Order.RequiredDate.Value;
                txtOrderID.Enabled = false;
                txtMemberID.Enabled = false;
                txtOrderDate.Enabled = false;
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
                bindingSource.DataSource = Order?.OrderDetails;
                dgvProductList.DataSource = bindingSource;
                dgvProductList.Columns["Order"].Visible = false;
                dgvProductList.Columns["Product"].Visible = false;
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
                var or = orderRepository.GetById(Int32.Parse(txtOrderID.Text));

                if (or != null)
                {
                    or.OrderDate = Convert.ToDateTime(txtOrderDate.Value);
                    or.Freight = decimal.Parse(txtFreight.Text);
                    or.ShippedDate = Convert.ToDateTime(txtShippedDate.Value);
                    or.RequiredDate = Convert.ToDateTime(txtRequiredDate.Value);
                    orderRepository.Update(or);
                  
                    if (MessageBox.Show("Update successfully!") == DialogResult.OK)
                    {
                        this.Close();
                    }
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
