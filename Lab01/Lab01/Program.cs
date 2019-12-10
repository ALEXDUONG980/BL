using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        static int Number;
        static List<Person> personList = new List<Person>();
        static List<Student> studentList = new List<Student>();
        static List<Teacher> teacherList = new List<Teacher>();

        static void Main(string[] args)
        {
            Console.Write("Nhap So Luong SV: ");
            Number = int.Parse(Console.ReadLine());

            InputList(Number);
            Console.WriteLine("\n===DANH SACH SINH VIEN===");
            OutputList(personList);

            //1 Cach 1. Tim danh sach SV thuot CNTT.
            var listKQ = personList.Where(p => (p is Student) && (p as Student).Faculty == "CNTT" || (p is Student) && (p as Student).Faculty == "cntt").ToList();
            if (listKQ.Count > 0)
            {
                Console.WriteLine("Danh sach SV CNTT: ");
                OutputList(listKQ);
            }
            else
                Console.WriteLine("Khong co SV CNTT: ");

            //1 Cach 2. Tim danh sach SV thuot CNTT.
            foreach (Student SV in studentList)
            {
                if (string.Compare(SV.Faculty, "cntt", true) == 0)
                {
                    if (SV is Student)
                        ((Student)SV).Output();
                    else
                        Console.WriteLine("Khong co SV khoa CNTT.");
                }
            }

            //2. Tim tat ca giao vien o go vap
            var listKQ2 = personList.Where(p => (p is Teacher) && (p as Teacher).Address == "go vap" || (p is Teacher) && (p as Teacher).Address == "GO VAP").ToList();
            if (listKQ2.Count > 0)
            {
                Console.WriteLine("Danh sach GV o Go Vap: ");
                OutputList(listKQ2);
            }
            else
                Console.WriteLine("Khong co GV o Go Vap CNTT: ");

            //3. Sap xep SV diem be 5 va khoa CNTT
            var listKQ3 = personList.Where(p => (p is Student) && (p as Student).Mark < 5 && (p is Student) && (p as Student).Faculty == "CNTT" || (p is Student) && (p as Student).Faculty == "cntt").ToList();
            if (listKQ3.Count > 0)
            {
                Console.WriteLine("Danh sach SV co Mark > 5 va Khoa CNTT: ");
                OutputList(listKQ2);
            }
            else
                Console.WriteLine("Khong co SV co Mark > 5 va Khoa CNTT: ");

            //4. Nhap Ten tim kiem, xuat ra
            string TEN;
            Console.WriteLine("Nhap Ten ban muon tim: ");
            TEN = Console.ReadLine();
            foreach (Person PR in personList)
            {
                if (string.Compare(PR.FullNname, TEN, true) == 0)
                {
                    if (PR is Student)
                        ((Student)PR).Output();
                    else
                        ((Teacher)PR).Output();
                }
            }

            /*//3. Tim danh sach SV co diem cao nhat va thuot CNTT.
            var diemCaoNhat = studentList.Where(p => p.Faculty == "CNTT" || p.Faculty == "cntt").Max(p => p.Mark);
            var listKQ3 = studentList.Where(p => p.Faculty == "CNTT" || p.Faculty == "cntt" && p.Mark == diemCaoNhat).ToList();
            if (listKQ3.Count > 0)
            {
                Console.WriteLine("Danh sach SV co diem cao nhat va khoa CNTT: ");
                OutputList(listKQ3);
            }
            else
                Console.WriteLine("Khong co SV co diem cao nhat va khoa CNTT: ");*/

            Console.ReadKey();
        }

        private static void InputList(int Number)
        {
            for (int i = 0; i < Number; i++)
            {
                Console.Write("1. Nhap Sinh Vien.\n2. Nhap Giao Vien.\nCHON: ");
                int chon = int.Parse(Console.ReadLine());
                if (chon == 1)
                {
                    Student student = new Student();
                    student.Input();
                    personList.Add(student);
                }
                else
                {
                    Teacher teacher = new Teacher();
                    teacher.Input();
                    personList.Add(teacher);
                }
            }
        }

        private static void OutputList(List<Person> personList)
        {
            foreach (Person PR in personList)
            {
                if (PR is Student)
                    (PR as Student).Output();
                else
                    (PR as Teacher).Output();
            }
        }
    }
}
