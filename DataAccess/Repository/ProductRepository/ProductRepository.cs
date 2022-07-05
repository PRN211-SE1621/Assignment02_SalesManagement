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
        public void CreateProduct(Product p) => ProductDAO.Instance.Add(p);

        public void DeleteProduct(int id)=>ProductDAO.Instance.Delete(GetProductById(id));

        public IEnumerable<Product> GetAllProducts() => ProductDAO.Instance.GetList();

        public Product GetProductById(int id) => ProductDAO.Instance.GetById(id);

        public List<Product> SearchProductByName(string name)
        {
            List<Product> resultList = new List<Product>();
            foreach (Product product in ProductDAO.Instance.GetList())
            {
                if (product.ProductName.Contains(name))
                {
                    resultList.Add(product);
                }
            }
            return resultList;
        }
        public void UpdateProduct(Product updatedProductInfo)
        {
            ProductDAO.Instance.Update(updatedProductInfo);
        }

        public List<Product> SearchProductById(string id)
        {
            List<Product> result = new List<Product>();
            try
            {
                int intId = int.Parse(id);
                if (GetProductById(intId) != null)
                    result.Add(GetProductById(intId));
                foreach (Product product in ProductDAO.Instance.GetList())
                {
                    if (product.ProductId.ToString().Contains(id) && !product.ProductId.ToString().Equals(id))
                    {
                        result.Add(product);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        public List<Product> SearchProductByIdAndName(string searchName, string searchId)
        {
            List<Product> resultList = new List<Product>();
            if (searchName == null || searchName.Equals(""))
            {
                if (searchId == null || searchId.Equals(""))
                {
                    resultList.AddRange(GetAllProducts());
                }
                else
                {
                    resultList.AddRange(SearchProductById(searchId));
                }
            }
            else
            {
                if (searchId == null || searchId.Equals(""))
                {
                    resultList.AddRange(SearchProductByName(searchName));
                }
                else
                {
                    foreach (Product p in SearchProductById(searchId))
                    {
                        if (p.ProductId.ToString().Contains(searchId))
                        {
                            resultList.Add(p);
                        }
                    }
                }
            }
            return resultList;
        }
    }
}
