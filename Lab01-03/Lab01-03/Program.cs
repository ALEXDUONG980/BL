using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class Program
    {
        static List<Dat> datList = new List<Dat>();
        static int Number;
        static void Main(string[] args)89
        {
            do
            {
                Console.Write("Nhap so luong Khu Dat: ");
            } while (!int.TryParse(Console.ReadLine(), out Number));


            int chon;
            do
            {
                Console.WriteLine("1. Nhap Danh sach Khu Dat: ");
                Console.WriteLine("2. Xuat Danh sach Khu Dat: ");
                /*Console.WriteLine("3. Sap xep Danh sach Khu Dat Tang dan: ");
                Console.WriteLine("4. Danh sach Khu Dat be hon 1 ty va lon hon 60 m2: ");
                Console.WriteLine("5. Don gia trung binh 1 m2 khu đat có dien tich lon hon 1000 m2: ");*/
                Console.WriteLine("0. Thoat: ");
                Console.Write("Nhap chon: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        InputList();
                        break;
                    case 2:
                        Console.WriteLine("Danh sach Khu Dat la: ");
                        OutputList(datList);
                        break;
                        /*case 3:
                            Console.WriteLine("Sap xep Khu Dat Tang dan. ");
                            SortDienTich();
                            break;
                        case 4:
                            BeTyLon60();
                            break;
                        case 5:
                            TrungBinh();
                            break;*/
                }
            } while (chon != 0);
            Console.ReadKey();
        }

        public static void InputList()
        {
            for (int i = 0; i < Number; i++)
            {
                Console.Write("1. Khu Dat.\n2. Nha Pho.\n3. Chung Cu.\nCHON: ");
                int chon;
                chon = int.Parse(Console.ReadLine());
                if (chon == 1)
                {
                    KhuDat KD = new KhuDat();
                    KD.Input();
                    datList.Add(KD);
                }
                else if (chon == 2)
                {
                    NhaPho NP = new NhaPho();
                    NP.Input();
                    datList.Add(NP);
                }
                else
                {
                    ChungCu CC = new ChungCu();
                    CC.Input();
                    datList.Add(CC);
                }
            }
        }

        public static void OutputList(List<Dat> datList)
        {
            foreach (Dat D in datList)
            {
                if (D is KhuDat)
                {
                    (D as KhuDat).Output();
                    Console.Write("\t-----------------");
                }
                else if (D is NhaPho)
                {
                    (D as NhaPho).Output();
                    Console.Write("\t-----------------");
                }
                else
                {
                    (D as ChungCu).Output();
                    Console.Write("\t-----------------");
                }
            }
        }

        /*public static void SortDienTich()
        {
            var listKQ = datList.OrderBy(p => p.DienTich).ToList();
            OutputList(listKQ);
        }

        public static void BeTyLon60()
        {
            var listKQ1 = datList.Where(p => p.GiaBan < 1000000000 && p.DienTich >= 60).ToList();
            if (listKQ1.Count > 0)
            {
                Console.WriteLine("Danh sach khu dat be 1 ty va lon hon 60 m2. ");
                OutputList(listKQ1);
            }
            else
                Console.WriteLine("Khong co khu dat nao be hon 1 ty va lon hon 60 m2.");
        }

        public static void TrungBinh()
        {
            double listKQ2 = datList.Average(p => p.GiaBan / p.DienTich);
            foreach (KhuDat kd in datList)
            {
                if (kd.DienTich > 1000)
                {
                    Console.WriteLine("Dien Tich trung binh : " + listKQ2);
                }
                else
                    Console.WriteLine("Khong co khu dat lon ho 1000 m2 nen khong tinh.");
            }
        }*/
        ///Xuất tổng giá bán cho 3 loại(Khu đất, Nhà phố, Chung Cư) của công ty D.  
        public static void Tong() {
            double listKQ1 = datList.Sum(p => p.GiaBan);
            foreach (Dat D in datList)
            {
                if (D is KhuDat)
                    Console.WriteLine("Tong : " + listKQ1);
                else if (D is NhaPho)
                    Console.WriteLine("Tong : " + listKQ1);
                else
                    Console.WriteLine("Tong : " + listKQ1);
            }
        }
        ///Danh sácH khu đất diện tích > 100 m2 nhà phố mà có diện tích > 60 m2 và năm xây dựng >= 2019.  
        public static void BeTyLon602019()
        {
            var listKQ = datList.Where(p => p.DienTich < 100 && p.DienTich > 60 && (p is NhaPho) && (p as NhaPho).NamXD >= 2019).ToList();
            if (listKQ.Count > 0)
            {
                Console.WriteLine("Danh sach khu dat dien tich be 100 m2 va lon 60 m2 nam la lon hon bang 2019. ");
                OutputList(listKQ);
            }
            else
                Console.WriteLine("Khong co khu dat dien tich be 100 m2 va lon 60 m2 nam la lon hon bang 2019.");
        }
        ///Nhập vào các thông tin cần tìm kiếm (địa điểm, giá, diện tích). 
        ///Có địa điểm chứa chuỗi tìm kiếm không phân biệt hoa thường, có giá <= giá tìm kiếm, và diện tích >= diện tích cần tìm kiếm
        public static void Search()
        {
            string diachi;
            double giaban, dientich;
            Console.WriteLine("Nhap Dia Chi ban muon tim: ");
            diachi = Console.ReadLine();
            Console.WriteLine("Nhap Gia Ban ban muon tim: ");
            giaban = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap Dien Tich ban muon tim: ");
            dientich = double.Parse(Console.ReadLine());
            foreach (Dat D in datList)
            {
                if (string.Compare(D.DiaDiem, diachi, true) == 0 && D.GiaBan < giaban && D.DienTich > dientich)
                {
                    if (D is KhuDat)
                        ((KhuDat)D).Output();
                    else if(D is NhaPho)
                        ((NhaPho)D).Output();
                    else
                        ((ChungCu)D).Output();
                }
            }
        }
    }
}
