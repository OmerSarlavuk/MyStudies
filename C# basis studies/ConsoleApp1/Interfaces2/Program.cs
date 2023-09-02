using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();

            insan.Oksijen();
            insan.Terleme();

            Kopek kopek = new Kopek();

            kopek.Oksijen();
            kopek.Terleme();

            Console.ReadLine();
        }
    }

    interface IOrganlar
    {
        string Goz { get; }
        string Kulak { get; }
        string Dil { get; }
        string Burun { get; }
        string Deri { get; }

        void Oksijen();
        void Terleme();
    }

    class Insan : IOrganlar
    {
        public string Goz { get; set; }
        public string Kulak { get; set; }
        public string Dil { get; set; }
        public string Burun { get; set; }
        public string Deri { get; set; } 

        public void Oksijen()
        {
            Console.WriteLine("Oksijen alindi");
        }

        public void Terleme()
        {
            Console.WriteLine("Terleme yapildi");
        }
    }

    class Kopek : IOrganlar
    {
        public string Goz { get; set; }

        public string Kulak { get; set; }

        public string Dil { get; set; }

        public string Burun { get; set; }

        public string Deri { get; set; }

        public void Oksijen()
        {
            Console.WriteLine("Oksijen alindi");
        }

        public void Terleme()
        {
            Console.WriteLine("Terleme yapildi");
        }
    }

}
