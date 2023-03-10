using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByProductName(string productName);
        Product GetById(int id);
        List<Product> GetByCategoryId(int category);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
