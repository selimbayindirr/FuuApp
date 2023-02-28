﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> getproducts()
        {
            return _productDal.GetAll();

        }
        public List<Product> getAllByCategory(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);

        }

        public List<Product> getByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min&&p.UnitPrice<=max);
        }
    }
}
