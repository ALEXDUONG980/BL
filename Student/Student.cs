using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Student : Person
    {

        public string Faculty { get; set; }
        /*public string Facully { get; set; }*/
        public float Mark { get; set; }
        /*public string Mark { get; set; }*/

        public Student()
        {

        }

        public Student(string studenID,string fullName, float mark, string faculty) : base(studenID, fullName)
        {
            ID = studenID;
            FullName = fullName;
            Mark = mark;
            Faculty = faculty;
        }
        public void Input()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t---Begin---");

            base.Input();

            Console.Write("\tMark = ");
            Mark = float.Parse(Console.ReadLine());

            Console.Write("\tFaculty = ");
            Faculty = Console.ReadLine();

            Console.WriteLine("\t\t---End---");
            Console.WriteLine();
        }
        public void Output()
        {
            Console.WriteLine();
            Console.WriteLine("\t\t---");
            base.Output();
            Console.Write("\tFaculty: {0}\n\tMark: {1}", this.Faculty, this.Mark);
            Console.WriteLine("\n\t\t---");
            Console.WriteLine();
        }

    }
}
