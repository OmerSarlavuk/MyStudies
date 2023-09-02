using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTORinjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(new SQL());

            customer.Add();

            Console.ReadLine();
        }
    }

    interface ILogger
    {
        void Add();
    }

    class SQL : ILogger
    {
        public void Add()
        {
            Console.WriteLine("Added by SQL");
        }
    }

    class Oracle : ILogger
    {
        public void Add()
        {
            Console.WriteLine("Added by Oracle");
        }
    }

    class Customer
    {
        private ILogger _logger;
        public Customer(ILogger logger)
        {
            _logger = logger;
        }

        public void Add() 
        {
            _logger.Add();
        }

    }

}
