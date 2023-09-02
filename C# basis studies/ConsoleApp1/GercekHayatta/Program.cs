using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GercekHayatta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerProcess customerProcess = new CustomerProcess();

            customerProcess.Add(new SqlServer());

            Console.ReadLine();
        }
    }
}
