using System;
using System.Collections.Generic;

namespace MyErrorClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>
            {
                "Omer", "Zara", "Araz"
            };

            if (isimler.Contains("Ahmet"))
            {
                Console.WriteLine("Record Found");
            }
            else
            {
                throw new Exception("Record not found.");
            }
        }
    }
}
