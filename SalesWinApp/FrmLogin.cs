using BusinessObject;
using DataAccess.Repossitory;
using Microsoft.Extensions.Configuration;

namespace SalesWinApp
{
    public partial class FrmLogin : Form
    {
        IMemberRepository memberRepo = new MemberRepository();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtGmail.Text;
            string password = txtPassword.Text;

            if (IsDefaultAdmin(email, password))
            {
                FrmAdmin frmAdmin = new FrmAdmin(this);
                frmAdmin.Show();
                this.Hide();
                frmAdmin.FormClosed += delegate
                {
                    this.Close();
                };
            }
            else
            {
                Member member = memberRepo.CheckLogin(email, password);

                if (member == null)
                {
                    MessageBox.Show("Incorrect user name or password");
                }
                else
                {
                    /*MemberDetails memberDetails = new MemberDetails(this)
                    {
                        MemberInfo = member,
                        MemberRepository = memberRepo,
                        InsertOrUpdate = true,
                        IsAdmin = false
                    };
                    this.Hide();
                    memberDetails.Show();
                    */
                }
            }
        }
        private bool IsDefaultAdmin(string email, string password)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            if (email == config["AdminAccount:Email"] && password == config["AdminAccount:Password"])
            {
                return true;
            }
            return false;
        }
    }
}
