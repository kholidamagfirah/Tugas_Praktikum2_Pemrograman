using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204003
{
    class Program
    
        {
            static void Main(string[] args)
            {
                // Product_1204003 myProduct = new Product_1204003();

                // myProduct.MyType = "DVD";

                // Console.WriteLine(myProduct.MyType);


                Book_1204003 mybook = new Book_1204003("Book", "C# Object Oriented Solution", "300");
                Dvd_1204003 dvd = new Dvd_1204003("Ethernal Sunshine Of The Spotless Mind", "145");

                Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", mybook.MyType, mybook.MyTitle, mybook.PageCount);
                Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} minutes duration", dvd.MyType, dvd.MyTitle, dvd.Duration);
            }
        }
}

