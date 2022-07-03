using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> GetAll() => OrderDAO.Instance.GetList();
        public IEnumerable<Order> GetAllIgnore() => OrderDAO.Instance.GetListIgnore();
        public void Add(Order order) => OrderDAO.Instance.Add(order);
    }
}
