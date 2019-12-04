using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    abstract class Dat
    {
        public string DiaDiem { get; set; }
        public double GiaBan { get; set; }
        public double DienTich { get; set; }

        public Dat()
        {
        }

        public Dat(string diaDiem, double giaBan, double dienTich)
        {
            DiaDiem = diaDiem;
            GiaBan = giaBan;
            DienTich = dienTich;
        }

        public virtual void Input()
        {
            Console.WriteLine("\t---------------");
            Console.WriteLine ("Nhap Dia Diem: ");
            DiaDiem = Console.ReadLine();
            Console.Write("Nhap Gia Ban: ");
            GiaBan = double.Parse(Console.ReadLine());
            Console.Write("Nhap Dien Tich: ");
            DienTich = double.Parse(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.WriteLine("\tDia Diem: {0}\n\tGia Ban: {1} VND\n\tDien Tich: {2} m2", DiaDiem, GiaBan, DienTich);
        }
    }
}
