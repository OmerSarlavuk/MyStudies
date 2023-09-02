using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTOr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(10);
        }
    }

    class Student
    {
        private int _Id;
        public Student(int Id)
        {
            _Id = Id;
        }
        public string Name { get; set; }
        public string Description { get; set; }
    }

}
