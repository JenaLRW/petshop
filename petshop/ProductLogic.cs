using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petshop
{
    internal class ProductLogic
    {
        private List<Product> _products;

        public void AddProducts(Product product)
        {
            _products.Add(product);
        }

        public ProductLogic()
        {
            _products = new List<Product>();


        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
