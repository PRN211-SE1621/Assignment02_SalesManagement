using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetAll();
        public IEnumerable<Order> GetAllIgnore();
        public void Add(Order order);
        public void Delete(Order order);
        public Order? GetById(int id);
    }
}
