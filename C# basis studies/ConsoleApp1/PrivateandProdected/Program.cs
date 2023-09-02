using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateandProdected
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Database
    {
        protected int sayi;

        public void Add()
        {

        }
    }

    class SQL : Database
    {
        public void Delete()
        {
            sayi = 10;
        }
    }


}
