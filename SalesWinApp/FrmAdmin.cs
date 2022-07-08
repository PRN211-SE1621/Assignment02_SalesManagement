namespace SalesWinApp
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void toolTripMenuItemProductManagement_Click(object sender, EventArgs e)
        {
            FrmProductsManagement frmProductsManagement = new FrmProductsManagement();
            frmProductsManagement.MdiParent = this;
            frmProductsManagement.Show();
        }

        private void toolTripMenuItemOrderManagement_Click(object sender, EventArgs e)
        {
            FrmOrdersManagement frmOrdersManagement = new FrmOrdersManagement();
            frmOrdersManagement.MdiParent = this;
            frmOrdersManagement.Show();
        }

        private void memberManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMemberManagement frmMemberManagement = new FrmMemberManagement();
            frmMemberManagement.MdiParent = this;
            frmMemberManagement.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
