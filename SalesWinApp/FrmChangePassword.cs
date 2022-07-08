using BusinessObject;
using DataAccess.Repository;

namespace SalesWinApp
{
    public partial class FrmChangePassword : Form
    {
        private FrmMemberDetail MemberDetails;
        private Member member;
        private IMemberRepository memberRepo;
        public FrmChangePassword()
        {
            InitializeComponent();
        }
        public FrmChangePassword(FrmMemberDetail memberDetails, Member member)
        {
            InitializeComponent();
            this.MemberDetails = memberDetails;
            this.member = member;
            memberRepo = new MemberRepository();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.Text = "";
            txtNewPassword.Text = "";
            txtOldPassword.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNewPassword.Text.Equals(txtConfirmPassword.Text))
                {
                    DialogResult rs = MessageBox.Show("Password does not match");
                }
                else
                {
                    memberRepo.ChangePassword(member.MemberId, txtOldPassword.Text, txtNewPassword.Text);
                    DialogResult result = MessageBox.Show("Update password success");
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
