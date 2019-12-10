using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Teacher: Person
    {
        public string Address { get; set; }

        public Teacher()
        {
        }

        public Teacher(string iD, string fullName, string address):base(iD, fullName)
        {
            Address = address;
        }

        public void Input()
        {
            base.Input();
            Console.Write("\tNhap Dia Chi: ");
            Address = Console.ReadLine();
            Console.WriteLine("\t\t--END-- \n");
        }

        public void Output()
        {
            Console.WriteLine("\t\t--------");
            base.Output();
            Console.WriteLine("\tDia Chi: {0}\n", Address);
        }
    }
}
