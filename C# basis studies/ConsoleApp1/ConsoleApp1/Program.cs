using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.FirstName = "Omer";

            string custom = customer.FirstName;

            Console.WriteLine(custom);
            Console.ReadLine();
        }
    
    }

    class Customer
    {
        private string _firstName;
        public string FirstName
        {
            get
            {
                return "Mr." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
    }

}
