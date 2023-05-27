using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelfAssesments;

namespace SelfAssesments
{
    class Program
    {
        static void Main(string[] args)
        {
            //First self assesment Task
            Student s = new Student("Ali", "22", 3.6F, 1040, 1044, 350, "swl", true, false);

            /*   float percentage = s.CalculateMerit();
               if (s.IsEligibleForScholarship(percentage)== true && s.isTakingScholarship == false)
               {
                   Console.WriteLine("Eligible his merit is  " + percentage +" and his previous scholarship status "+ s.isTakingScholarship );
               }
               else
               {
                   Console.WriteLine("Not eligible " + percentage + " his previous scholarship status " + s.isTakingScholarship);
               }
               Console.ReadKey();*/
            // Second Assement Task

            Book b = new Book("ABC", 300, 250, 1000);
            b.AddChapterToList("sum");
            b.AddChapterToList("Products");
            b.AddChapterToList("division");
            b.AddChapterToList("factorization");
            Console.WriteLine("Chapter name: " + b.GetChapter(1));
            Console.WriteLine("Book mark is on page : " + b.GetBookMark());
            b.SetBookMark(100);
            Console.WriteLine("Price : " + b.Getprice());
            b.SetBookPrice(1100);
            Console.ReadKey();

            //third assesment task
            Product p = new Product("kiwi", "fruit", 200.0F);
            Product p1 = new Product("egg", "grocery", 24.6F);
            Console.WriteLine( "Tax: " +p.CalculateTax());
            Console.WriteLine("Tax: " + p1.CalculateTax());
            Customer c = new Customer("ali", "swl", "001");
            c.AddProductToList(p);
            c.AddProductToList(p1);
            List<Product> purchases = c.GetAllProducts();
            foreach(Product x in purchases)
            {
                Console.WriteLine("Price: " + x.price);
            }
            Console.ReadKey();


        }
    }
}
