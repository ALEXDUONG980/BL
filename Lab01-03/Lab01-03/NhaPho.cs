using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class NhaPho : Dat
    {
        public int NamXD { get; set; }
        public string SoTang { get; set; }
        public NhaPho()
        {
        }
        public NhaPho(string diaDiem, double giaBan, double dienTich, int namXD, string soTang):base( diaDiem, giaBan, dienTich)
        {
            NamXD = namXD;
            SoTang = soTang;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Nhap Nam Xay Dung: ");
            NamXD = int.Parse(Console.ReadLine());
            Console.Write("So Tang: ");
            SoTang = Console.ReadLine();
            Console.WriteLine("\t---------------");
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("\tNam XD: {0}\n\tSo Tang: {1}", NamXD, SoTang);
        }
    }
}
