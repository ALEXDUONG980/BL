using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
	class Program
	{
        //1. Tao thuot tinh
        private string studentID; //ma so sinh vien
        private string fullName; //ten sinh vien
        private float averageScore; //diem trung binh
        private string faculty; //khoa

        //2. Tao property
        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }

        public float AverageScore
        {
            get
            {
                return averageScore;
            }
            set
            {
                averageScore = value;
            }
        }

        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }

        //3. Tao contructer khong tham so
        public Program() { 
        }

        //4. Tao contructer co tham so
        public Program( string id, string name, float score, string facultys)
        {
            studentID = id;
            fullName = name;
            averageScore = score;
            faculty = facultys;
        }

        public void Input() 
        {
            Console.Write("Nhap Ma Sinh Vien{0}:");
            StudentID = Console.ReadLine();

            Console.Write("Nhap Ho Ten Sinh Vien{0}:");
            FullName = Console.ReadLine();

            Console.Write("Nhap Score Sinh Vien{0}:");
            AverageScore = float.Parse(Console.ReadLine());

            Console.Write("Nhap Khoa Sinh Vien{0}:");
            Faculty = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine("MASV: {0} \tHoTen: {1} \tFaculty: {2} \tScore: {3}", this.studentID, this.fullName, this.fullName, this.averageScore);
        }

		static void Main(string[] args)
		{
            //Nhap tong so sinh vien, convert kieu du lieu sang bien N kieu int
            Console.Write("Nhap tong so Sinh vien N = ");
            int N = Convert.ToInt32(Console.ReadLine());
            List<Program> listProgram = new List<Program>();
            

            Console.WriteLine("\n===NHAP DAY SO SINH VIEN===");
            for(int i=0; i<N; i++)
            {
                Program temp = new Program();
                temp.Input();
                listProgram.Add(temp); //Doi tuong temp vao list
            }
            Console.WriteLine("\n===XUAT DAY SO SINH VIEN===");
            foreach(Program pr in listProgram)
            {
                pr.Show();
            }
            //1. Truy xuat tim cac sinh vien thuot khoa CNTT
            foreach (Program pr in listProgram)
            {
                List<Program> listSVKhoaCNTT = listProgram.Where(p => p.faculty == "CNTT").ToList();
                if (listSVKhoaCNTT.Count > 0)
                {
                    Console.WriteLine("Danh sach SV thuot khoa CNTT: ");
                }
                else
                {
                    Console.WriteLine("Khong tim thay sinh vien CNTT. ");
                }
            }
            // De dung man hinh 
            Console.ReadKey();

		}
	}
}
