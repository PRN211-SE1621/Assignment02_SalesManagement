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
    public partial class FrmAdmin : Form
    {
        private Form parentForm;
        public FrmAdmin()
        {
            InitializeComponent();
        }
        public FrmAdmin(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnMemberManagement_Click(object sender, EventArgs e)
        {
            FrmMemberManagement frmMemberManagement = new FrmMemberManagement();
            frmMemberManagement.Show();
            frmMemberManagement.FormClosing += delegate
            {
                this.Show();
            };
            this.Hide();
        }

        private void btnProductManagement_Click(object sender, EventArgs e)
        {
            FrmProductsManagement frmProductsManagement = new FrmProductsManagement();
            frmProductsManagement.Show();
            frmProductsManagement.FormClosing += delegate
            {
                this.Show();
            };
            this.Hide();
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            FrmOrdersManagement frmOrdersManagement = new FrmOrdersManagement();
            frmOrdersManagement.Show();
            frmOrdersManagement.FormClosing += delegate
            {
                this.Show();
            };
            this.Hide();
        }
    }
}
