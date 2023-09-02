using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staticler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students.Name = "Omer";
            Students.Id = 1;

            Console.WriteLine("isim: {0}", Students.Name + "   -----   " +
                "Id: " + Students.Id);

            Db.Add();

            Console.ReadLine();
        }
    }

    static class Students
    {
        public static int Id { get; set; }
        public static string Name { get; set; }
    }

    static class Db
    {
        public static void Add()
        {
            Console.WriteLine("Added by default");
        }
    }

}
