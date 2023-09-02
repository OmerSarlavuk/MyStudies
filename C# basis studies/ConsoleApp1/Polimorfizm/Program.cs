using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfizm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPerson[] person = new IPerson[2]
            {
                new SqlServer(),
                new Oracle()
            };

            foreach(var Person in person)
            {
                Person.Add();
                Person.Delete();
            }

            Console.ReadLine();
        }
    }

    class SqlServer : IPerson
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }
    }

    class Oracle : IPerson
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }
    }
}
