using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace BookDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            
            WorkWithEF();

            Console.WriteLine();
            Console.WriteLine();

            WorkWithDapper();
            Console.ReadLine();
        }

        public static void WorkWithEF()
        {
            EFDb efDb = new EFDb();

            Console.WriteLine("Entity Framework");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Get All Authors");
            efDb.GetAllAuthors();

            Console.WriteLine("*******************************************************************");

            Console.WriteLine("Enter author's surname, please");
            var surname = Console.ReadLine();
            Console.WriteLine("All books by surname {0}: ", surname);
            efDb.FindBooks(surname);
        }

        public static void WorkWithDapper()
        {
            DapperDB dapperDb = new DapperDB();

            Console.WriteLine("Dapper");
            Console.WriteLine("*******************************************************************");
            Console.WriteLine("Get All Authors");
            dapperDb.GetAllAuthors();
            Console.WriteLine("*******************************************************************");

            Console.WriteLine("Enter author's surname, please");
            var surname = Console.ReadLine();
            Console.WriteLine("All books by surname {0}: ", surname);
            dapperDb.FindBooks(surname);
        }
    }
}
