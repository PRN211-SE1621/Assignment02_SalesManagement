using DataAccess.Repository;
using BusinessObject;

namespace SalesWinApp
{
    public partial class FrmMemberManagement : Form
    {
        private IMemberRepository memberRepo;
        private BindingSource bindingSource;
        public FrmMemberManagement()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (memberRepo.GetAllMembers() != null)
            {
                LoadMembersToGridView(memberRepo.GetAllMembers());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            FrmMemberDetail memberDetails = new FrmMemberDetail
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                MemberRepository = memberRepo
            };
            memberDetails.Show();
            LoadMembersToGridView(memberRepo.GetAllMembers());
            bindingSource.Position = bindingSource.Count - 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var member = GetMemberObject();
                    memberRepo.DeleteMember(member);
                    LoadMembersToGridView(memberRepo.GetAllMembers());
                }
            }    
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a member");
            }
        }

        private void FrmMemberManagement_Load(object sender, EventArgs e)
        {
            memberRepo = new MemberRepository();
            btnDelete.Enabled = false;
            dgvMemberList.CellDoubleClick += dgvMemberList_CellDoubleClick;
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmMemberDetail memberDetails = new FrmMemberDetail
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberRepository = memberRepo,
                MemberInfo = memberRepo.GetMemberById(Int32.Parse(txtMemberId.Text))
            };
            if (memberDetails.ShowDialog() == DialogResult.OK)
            {
                LoadMembersToGridView(memberRepo.GetAllMembers());
                bindingSource.Position = bindingSource.Count - 1;
            }
            LoadMembersToGridView(memberRepo.GetAllMembers());
        }

        public void LoadMembersToGridView(IEnumerable<Member> members)
        {
            try
            {
                bindingSource = new BindingSource();
                bindingSource.DataSource = members;

                txtMemberId.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberId.DataBindings.Add("Text", bindingSource, "MemberId");
                txtCompanyName.DataBindings.Add("Text", bindingSource, "CompanyName");
                txtEmail.DataBindings.Add("Text", bindingSource, "Email");
                txtCity.DataBindings.Add("Text", bindingSource, "City");
                txtCountry.DataBindings.Add("Text", bindingSource, "Country");
                txtPassword.DataBindings.Add("Text", bindingSource, "Password");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = bindingSource;
                dgvMemberList.Columns["Password"].Visible = false;
                dgvMemberList.Columns["Orders"].Visible = false;
                if (members == null || members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ClearText()
        {
            txtMemberId.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
        private Member GetMemberObject()
        {
            Member? mem = null;
            try
            {
                memberRepo = new MemberRepository();
                mem = memberRepo.GetMemberById(Int32.Parse(txtMemberId.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get Member");
            }
            return mem;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
