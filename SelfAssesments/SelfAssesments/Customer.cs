using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesments
{
    class Customer
    {
        public string name;
        public string address;
        public string contact;
        public List<Product> purchasedProducts = new List<Product>();
        public Customer(string name, string address, string contact)
        {
            this.address = address;
            this.contact = contact;
            this.name = name;
        }
        public void AddProductToList(Product p)
        {
            purchasedProducts.Add(p);
        }
        public List<Product> GetAllProducts()
        {
            return purchasedProducts;
        }
    }
}
