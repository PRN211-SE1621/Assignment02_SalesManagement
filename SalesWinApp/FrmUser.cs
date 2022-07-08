using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class FrmUser : Form
    {
        public Member member;
        public FrmUser(Member member)
        {
            InitializeComponent();
            this.member = member;
        }
        
        private void FrmUser_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMemberDetail frmMemberDetail = new FrmMemberDetail
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberRepository = new MemberRepository(),
                MemberInfo = member,
            };
            frmMemberDetail.MdiParent = this;
            frmMemberDetail.Show();
        }

        private void orderHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOrdersManagement frmOrdersManagement = new FrmOrdersManagement()
            {
                Member = member
            };
            frmOrdersManagement.MdiParent = this;
            frmOrdersManagement.Show();
        }
    }
}
