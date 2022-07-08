using BusinessObject;
using DataAccess.Repository;
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
                FrmAdmin frmAdmin = new FrmAdmin();
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
                    FrmUser frmUser = new FrmUser(member);
                    frmUser.Show();
                    this.Hide();
                    frmUser.FormClosed += delegate
                    {
                        this.Close();
                    };
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
