using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class FrmOrderHistory : Form
    {
        private BindingSource bindingSource;
        private IOrderRepository orderRepository;
        public Order? Order;

        public FrmOrderHistory()
        {
            InitializeComponent();
        }

        private void LoadOrderGridView()
        {
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = Order?.OrderDetails;
                dgvProductList.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
