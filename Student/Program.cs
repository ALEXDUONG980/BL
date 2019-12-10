using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// DUONG THANH TOAN
/// TRAN THI ANH THU 
/// TRUONG THANH TUYEN
/// BL
/// 1. Tim sinh vien CNTT trong list
/// </summary>
namespace StudentApp
{
    class Program
    {
        static Person[] personList = new Person[numOfStudent];
        static Student[] studentList;
        static Teacher[] teacherList;
        static int numOfStudent;
        static void Main(string[] args)
        {
            //lay so luong sinh vien do nguoi dung nhap
            //ctrl + k + c: comment
            //ctrl + k + u: uncomment
            //ctrl + k + d: lam dep code, format code
            do
            {
                Console.Write("Number of Student = ");
            } while (!int.TryParse(Console.ReadLine(), out numOfStudent));

            InputList(numOfStudent);

            Console.WriteLine("Danh sach sinh vien: ");
            OutputList(studentList);

            OutputITList();

            Console.WriteLine("Danh sach sinh vien co diem trung binh tang dan: ");
            SortMaxMark(numOfStudent);
            OutputList(studentList);

            MaxITList();

            Min5ITList();

            Search();

            //dung man hinh de xem ket qua
            Console.ReadKey();
        }

        private static void InputList(int numOfStudent)
        {
            //tao mang danh sach sinh vien
            studentList = new Student[numOfStudent];
            for (int i = 0; i < numOfStudent; i++)
            {
                Student student = new Student();
                student.Input();
                personList[i] = student;
            }
            //tao mang danh sach giao vien
            teacherList = new Teacher[numOfStudent];
            for (int i = 0; i < numOfStudent; i++)
            {
                Teacher teacher = new Teacher();
                teacher.Input();
                personList[i] = teacher;
            }
        }

        private static void OutputList(Student[] studentList)
        {
            //nhap tung phan tu cho danh sach
            foreach (Person item in personList)
            {
                if (item is Student)
                { 
                    ((Student)item).Output();
                }
                if(item is Teacher)
                {
                    ((Teacher)item).Output();
                }
            }
        }

        public static void OutputITList()
        {
            Student[] listKQ = new Student[numOfStudent];
            listKQ = studentList.Where(p => p.Faculty == "cntt" || p.Faculty == "CNTT").ToArray();
            if (listKQ.Count() > 0)
            {
                Console.WriteLine("Danh sach sinh vien CNTT: ");
                OutputList(listKQ);
            }
            else
            {
                Console.WriteLine("Khong co sinh vien CNTT.");
            }
        }

        public static void SortMaxMark(int numOfStudent)
        {
            for (int i = 0; i < numOfStudent; i++)
                for (int j = i + 1; j < numOfStudent; j++)
                    if (studentList[i].Mark > studentList[j].Mark)
                    {
                        Student tam = studentList[i];
                        studentList[i] = studentList[j];
                        studentList[j] = tam;
                    }
        }

        public static void MaxITList()
        {
            float Max = studentList.Max(p => (p as Student).Mark);
            Student[] listKQ = new Student[numOfStudent];
            listKQ = studentList.Where(p => p.Mark == Max && p.Faculty == "cntt" || p.Faculty == "CNTT").ToArray();
            if (listKQ.Count() > 0)
            {
                Console.WriteLine("Danh sach sinh vien Mark Max va Khoa CNTT: ");
                OutputList(listKQ);
            }
            else
                Console.WriteLine("Khong co sinh vien Mark Max va Khoa CNTT.");
        }

        public static void Min5ITList()
        {
            Student[] listKQ = new Student[numOfStudent];
            listKQ = studentList.Where(p => p.Mark < 5 && p.Faculty == "cntt" || p.Faculty == "CNTT").ToArray();
            if (listKQ.Count() > 0)
            {
                Console.WriteLine("Danh sach sinh vien Min 5 va Khoa CNTT: ");
                OutputList(listKQ);
            }
            else
                Console.WriteLine("Khong co sinh vien Min 5 va Khoa CNTT.");
        }

        public static void Search()
        {
            string ten;
            Console.Write("Nhap FullName ban muon Tim: ");
            ten = Console.ReadLine();

            Student[] listKQ = new Student[numOfStudent];
            listKQ = studentList.Where(p => p.FullName == ten).ToArray();
            if (listKQ.Count() > 0)
            {
                Console.WriteLine("Thong tin ban muon tim: ");
                OutputList(listKQ);
            }
            else
                Console.WriteLine("Khong co Thong tin ban muon tim.");
        }


    }
}
