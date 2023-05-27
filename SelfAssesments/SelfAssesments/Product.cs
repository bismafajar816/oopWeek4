using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesments
{
    class Product
    {
        public string name;
        public string category;
        public float price;
        public Product(string name, string category, float price)
        {
            this.name = name;
            this.category = category;
            this.price = price;

        }
        public float CalculateTax()
        {
            if(category == "fruit" )
            {
                float tax = (price * 0.2F ) ;
                return tax;
            }
            else
            {
                float tax = (price * 0.1F) ;
                return tax;
            }

        }

    }
}
