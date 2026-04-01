using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01_ex3
{
    // Lớp cơ sở
    class Person
    {
        private string fullName;
        private int birthYear;
        private string degree;

        public string FullName { get => fullName; set => fullName = value; }
        public int BirthYear { get => birthYear; set => birthYear = value; }
        public string Degree { get => degree; set => degree = value; }

        public Person()
        {
            FullName = "NO NAME";
            BirthYear = 1900;
            Degree = "Dai hoc";
        }

        public Person(string fullName, int birthYear, string degree)
        {
            FullName = fullName;
            BirthYear = birthYear;
            Degree = degree;
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"Ho ten: {FullName}");
            Console.WriteLine($"Nam sinh: {BirthYear}");
            Console.WriteLine($"Bang cap: {Degree}");
        }

        public override string ToString()
        {
            return $"{FullName} - {BirthYear} - {Degree}";
        }

    }


    // Lớp Student kế thừa Person
    class Student : Person
    {
        private int studentID;
        private string faculty;
        private float mark;

        public int StudentID { get => studentID; set => studentID = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public float Mark { get => mark; set => mark = value; }

        public Student() : base()
        {
            StudentID = 1;
            Faculty = "A";
            Mark = 0;
        }

        public Student(int id, string fullName, int birthYear, string degree,
                       string faculty, float mark)
            : base(fullName, birthYear, degree)
        {
            StudentID = id;
            Faculty = faculty;
            Mark = mark;
        }

        public override void Xuat()
        {
            Console.WriteLine("=================================");
            Console.WriteLine($"MSSV: {StudentID}");
            base.Xuat();
            Console.WriteLine($"Khoa: {Faculty}");
            Console.WriteLine($"Diem TB: {Mark}");
            Console.WriteLine("=================================");
        }

        public override string ToString()
        {
            return $"MSSV: {StudentID} - {FullName} - {Faculty} - {Mark}";
        }

        public void NhapDuLieuTTcuaSV()
        {
            Console.Write("  Ma so sinh viên: ");
            StudentID = int.Parse(Console.ReadLine());

            Console.Write("  Ho ten: ");
            FullName = Console.ReadLine();

            Console.Write("  Nam sinh: ");
            BirthYear = int.Parse(Console.ReadLine());

            Console.Write("  Bang cap: ");
            Degree = Console.ReadLine();

            Console.Write("  Khoa: ");
            Faculty = Console.ReadLine();

            Console.Write("  Điem trung bình: ");
            Mark = float.Parse(Console.ReadLine());
        }
    }

    class Tester
    {
        // Phuong thuc nhap mot sinh vien
        private static Student Nhap1sinhvien(int index)
        {
            Console.WriteLine($"Nhap thong tin sinh vien thu {0}", index);
            Student st = new Student();
            st.NhapDuLieuTTcuaSV();
            return st;
        }

        // Phương thức nhập danh sách sinh viên
        private static ArrayList Nhapds(int n)
        {
            ArrayList students = new ArrayList();
            for (int i = 0; i < n; i++)
            {
                students.Add(Tester.Nhap1sinhvien(i));
            }
            return students;
        }

        // Phương thức xuất danh sách sinh viên
        private static void DisplayStudentList(ArrayList students)
        {
            Console.WriteLine("\n\n====== DANH SÁCH SINH VIÊN ======");
            int i = 1;
            foreach (Student student in students)
            {
                Console.WriteLine($"\n--- Sinh viên thu {i++} ---");
                student.Xuat();
            }

        }

        // Phuong  thuc tinh trung binh tong diem cua ds sinh vien
        private static double CalculateAverageMark(ArrayList students)
        {
            if (students == null || students.Count == 0)
                return 0.0;

            double sum = 0.0;
            foreach (Student st in students)
            {
                sum += st.Mark; // float tự ép sang double
            }

            return sum / students.Count;
        }
        // Tim kiem sinh vien theo ten
        private static Student FindStudentByName(ArrayList students, string namesv)
        {
            if (students == null || students.Count == 0)
                return null;

            foreach (Student sv in students)
            {
                if (sv.FullName.ToUpper().Contains(namesv.ToUpper()))
                {
                    return sv; // tìm thấy thì trả về ngay
                }
            }

            return null; // không tìm thấy
        }

        public static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap vao so luong SV:");
            n = int.Parse(Console.ReadLine());

            // Gọi phương thức
            var DSSV =Nhapds(n);
            DisplayStudentList(DSSV);
            double avg = CalculateAverageMark(DSSV);
            Console.WriteLine($"\nDiem trung binh cua lop: {avg:F2}");

            // ====== TÌM SINH VIÊN THEO TÊN ======
            Console.Write("\nNhap ten sinh vien can tim: ");
            string keyword = Console.ReadLine();

            Student found = FindStudentByName(DSSV, keyword);
            if (found != null)
            {
                Console.WriteLine("\n>>> Tim thay sinh vien:");
                found.Xuat();
            }
            else
            {
                Console.WriteLine("\n>>> Khong tim thay sinh vien!");
            }
            Console.ReadLine();
        }
    }


}