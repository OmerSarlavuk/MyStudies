using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayatta
{
    public class CustomerProcess
    {
        public void Add(IPerson person)
        {
            person.Add();
        }
    }

    class SqlServer : IPerson
    {
        public void Add()
        {
            Console.WriteLine("SqlServer added");
        }

        public void Delete()
        {
            Console.WriteLine("SqlServer deleted");
        }

        public void Update()
        {
            Console.WriteLine("SqlServer updated");
        }
    }

    class Oracle : IPerson
    {
        public void Add()
        {
            Console.WriteLine("Oracle server Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle server Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle server Updated");
        }
    }

}
