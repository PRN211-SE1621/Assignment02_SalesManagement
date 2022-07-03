using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetAll() => ProductDAO.Instance.GetList();
        public Product? GetById(int id) => ProductDAO.Instance.GetById(id);

    }
}
