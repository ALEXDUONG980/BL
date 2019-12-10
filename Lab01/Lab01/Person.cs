using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Person
    {
        public string ID { get; set; }
        public string FullNname { get; set; }

        public Person()
        {
        }

        public Person(string iD, string fullNname)
        {
            ID = iD;
            FullNname = fullNname;
        }

        public void Input()
        {
            Console.WriteLine("\n\t\t--BEGIN-- ");
            Console.Write("\tNhap ID: ");
            ID = Console.ReadLine();
            Console.Write("\tNhap Ho Ten: ");
            FullNname = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine("\tID: {0}\n\tHo Ten: {1}", ID, FullNname);
        }
    }
}
