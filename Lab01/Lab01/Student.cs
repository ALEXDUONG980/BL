using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Student: Person
    {
        public float Mark { get; set; }
        public string Faculty { get; set; }

        public Student()
        {
        }

        public Student(string id, string fullName, float mark, string faculty):base(id, fullName)
        {
            Mark = mark;
            Faculty = faculty;
        }

        public void Input()
        {
            base.Input();
            Console.Write("\tNhap Khoa: ");
            Faculty = Console.ReadLine();
            Console.Write("\tNhap Diem: ");
            Mark = float.Parse(Console.ReadLine());
            Console.WriteLine("\t\t--END-- \n");

        }

        public void Output()
        {
            Console.WriteLine("\t\t--------");
            base.Output();
            Console.WriteLine("\tFaculty: {0}\n\tMark: {1}\n", Faculty, Mark);
        }
    }
}
