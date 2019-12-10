using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Person 
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        

        public Person()
        {
                            
        }

        public Person(string id, string fullName)
        {
            ID = id;
            FullName = fullName;
        }

        public void Input()
        {
            Console.Write("\tID = ");
            ID = Console.ReadLine();
            Console.Write("\tFullName = ");
            FullName = Console.ReadLine();
        }

        public void Output()
        {
            Console.WriteLine("\tID: {0}\n\tFullName: {1}", this.ID, this.FullName);
        }
    }
}
