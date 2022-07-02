using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private SalesManagementContext salesManagementContext = new SalesManagementContext();

        public MemberDAO()
        {
        }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Member> GetList() => salesManagementContext.Members.ToList();
        public Member? GetById(int id) => salesManagementContext.Members.Single(m => m.MemberId.Equals(id));

        public void Add(Member member)
        {
            if (GetById(member.MemberId) != null)
            {
                throw new Exception("Product ID existed!");
            }
            salesManagementContext.Members.Add(member);
            salesManagementContext.SaveChanges();
        }

        public void Delete(Member member)
        {
            salesManagementContext.Members.Remove(member);
            salesManagementContext.SaveChanges();
        }

        public void Update(Member member)
        {
            salesManagementContext.Members.Update(member);
            salesManagementContext.SaveChanges();
        }

        public Member? CheckLogin(string email, string password)
            => salesManagementContext.Members.SingleOrDefault(m => (m.Email.Equals(email) && m.Password.Equals(password)));

    }
}
