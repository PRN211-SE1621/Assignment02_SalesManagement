using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repossitory;
using BusinessObject;

namespace SalesWinApp
{
    public partial class FrmMemberDetail : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member MemberInfo { get; set; }
        public FrmMemberDetail()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text.Equals("") || txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Email or Password is empty");
                }
                else
                {
                    if (!InsertOrUpdate)
                    {
                        MemberInfo = new ();
                        MemberInfo.Password = txtPassword.Text;
                        MemberInfo.MemberId = int.Parse(txtMemberId.Text);
                    }

                    MemberInfo.CompanyName = txtCompanyName.Text;
                    MemberInfo.City = txtCity.Text;
                    MemberInfo.Country = txtCountry.Text;
                    MemberInfo.Email = txtEmail.Text;

                    if (InsertOrUpdate)
                    {
                        MemberRepository.UpdateMember(MemberInfo);
                        MessageBox.Show("Update successfully.");
                    }
                    else
                    {
                        MemberRepository.CreateMember(MemberInfo);
                        MessageBox.Show("Add successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("input"))
                {
                    MessageBox.Show("The id must be a number", InsertOrUpdate == false ? "Add a new member" : "Update a member");
                }
                else
                {
                    MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new member" : "Update a member");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var member = new Member
            {
                MemberId = int.Parse(txtMemberId.Text),
                CompanyName = txtCompanyName.Text,
                Email = txtEmail.Text,
                Country = txtCountry.Text,
                City = txtCity.Text,
                Password = txtPassword.Text
            };
            FrmChangePassword changePassword = new FrmChangePassword(this, member);
            this.Hide();
            changePassword.ShowDialog();
        }

        private void FrmMemberDetail_Load(object sender, EventArgs e)
        {
            txtMemberId.Enabled = !InsertOrUpdate;
            txtPassword.Enabled = !InsertOrUpdate;
            txtEmail.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                if(MemberInfo != null)
                {
                    txtMemberId.Text = MemberInfo.MemberId.ToString();
                    txtEmail.Text = MemberInfo.Email.ToString();
                    txtCompanyName.Text = MemberInfo.CompanyName.ToString();
                    txtCountry.Text = MemberInfo.Country.ToString();
                    txtPassword.Text = "******";
                    txtCity.Text = MemberInfo.City.ToString();
                }    
          
            }
            else
            {
                btnChangePassword.Enabled = false;
            }
        }
    }
}
