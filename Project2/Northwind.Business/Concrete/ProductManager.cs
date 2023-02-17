using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            this._productDal = productDal;
        }

        public void Add(Product product)
        {
            try
            {
                ValidationTool.Validate(new ProductValidator(), product);
                _productDal.Add(product);
            }
            catch (ValidationException exception)
            {
                throw new Exception(exception.Message);
            }

        }

        public void Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
            }
            catch (DbUpdateException exception)
            {
                throw new Exception("Ürün Silinemedi!!");
            }
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByCategoryId(int category)
        {
            return _productDal.GetAll(p => p.CategoryId == category);
        }

        public Product GetById(int id)
        {
            return _productDal.Get(p => p.ProductId == id);
        }

        public List<Product> GetByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower())).ToList();
        }

        public void Update(Product product)
        {
            try
            {
                ValidationTool.Validate(new ProductValidator(), product);
                _productDal.Update(product);
            }
            catch (ValidationException exception)
            {
                throw new Exception(exception.Message);
            }


        }
    }
}
