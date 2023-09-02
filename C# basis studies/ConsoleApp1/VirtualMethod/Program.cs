using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SQLServer sQLServer = new SQLServer();
            Oracle oracle = new Oracle();

            sQLServer.Add();
            sQLServer.Delete();
            oracle.Add();
            oracle.Delete();

            Console.ReadLine();
        }
    }

    class Process
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Delete() 
        {
            Console.WriteLine("Added by default");
        }

    }

    class SQLServer : Process
    {
        public override void Add()
        {
            Console.WriteLine("Added by sqlserver");
        }
    }

    class Oracle : Process
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracleserver");
        }
    }

}
