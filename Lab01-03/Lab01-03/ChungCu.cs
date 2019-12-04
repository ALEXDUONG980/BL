using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class ChungCu:Dat
    {
        public string Tang { get; set; }
        public ChungCu()
        {
        }
        public ChungCu(string diaDem, double giaBan, double dienTich, string tang):base(diaDem, giaBan, dienTich)
        {
            Tang = tang;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Tang: ");
            Tang = Console.ReadLine();
            Console.WriteLine("\t---------------");
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("\tTang: {0}", Tang);
        }
    }
}
