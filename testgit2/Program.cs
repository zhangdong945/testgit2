using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testgit2
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine("Press a key to continue...");
            Console.ReadKey();



            using (var db = new BooksContext())
            {

                Console.WriteLine("Please Input Information for a Book.");
                Console.WriteLine("Book Name: ");
                var aname = Console.ReadLine();

                Console.WriteLine("Title:");
                var atitle = Console.ReadLine();

                Console.WriteLine("Price:");
                var aprice = Console.ReadLine();
                var aid = DateTime.Today.ToString().Substring(0,8); 

                var newbook = new book
                {
                    id = aid,
                    name = aname,
                    title = atitle,
                    price = Double.Parse(aprice)
                };
                db.books.Add(newbook);
                db.SaveChanges();

                var query = from b in db.books
                            orderby b.id
                            select b;
                foreach (var item in query)
                {
                    Console.WriteLine("{0} : {1} [ {2} ]", item.id, item.name, item.title);
                    Console.WriteLine("-----------------------------------------------");
                }
            }

            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();

            return 0;
        }
    }
}
