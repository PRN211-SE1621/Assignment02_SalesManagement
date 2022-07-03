using BusinessObject;
using DataAccess;
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
    public partial class FrmOrdersManagement : Form
    {

        private BindingSource bindingSource;
        private IEnumerable<Order>? orders;
        private IOrderRepository orderRepository;

        public FrmOrdersManagement()
        {
            InitializeComponent();
            orderRepository = new OrderRepository();
            orders = orderRepository.GetAll();
            LoadOrderGridView(orders);
        }


        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtRequiredDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

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

                txtOrderID.DataBindings.Add("Text", bindingSource, "OrderId");
                txtMemberID.DataBindings.Add("Text", bindingSource, "MemberId");
                txtFreight.DataBindings.Add("Text", bindingSource, "Freight");
                txtRequiredDate.DataBindings.Add("Text", bindingSource, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", bindingSource, "ShippedDate");
                txtOrderDate.DataBindings.Add("Text", bindingSource, "OrderDate");

                dgvOrderList.DataSource = null;
                dgvOrderList.DataSource = bindingSource;
                ;
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
                    Order = orderRepository.GetById(Int32.Parse(txtOrderID.Text))
                };
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
