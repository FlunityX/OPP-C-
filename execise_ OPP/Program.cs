using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execise__OPP
{
    //
    /// <summary>

   //Đề bài: Quản lý học sinh

// Hãy xây dựng một chương trình quản lý học sinh sử dụng các khái niệm của lập trình hướng đối tượng.Mỗi học sinh có các thuộc tính như tên, tuổi, điểm trung bình, và một phương thức để in thông tin học sinh.

// Xây dựng một lớp Student để đại diện cho học sinh. Lớp này nên có các thuộc tính như tên, tuổi, điểm trung bình.

// Viết phương thức PrintInfo() trong lớp Student để in ra thông tin của học sinh.

// Tạo một lớp HighSchool để quản lý danh sách các học sinh. Lớp này nên có một danh sách các đối tượng Student.

// Viết phương thức PrintAllStudents() trong lớp HighSchool để in ra thông tin của tất cả học sinh trong danh sách.

// Trong phương thức Main() của lớp chương trình, tạo một đối tượng HighSchool, thêm một số học sinh vào danh sách, và sau đó in ra thông tin của tất cả học sinh.
    /// </summary>
     public class hocsinh
    {
        public string ten;
        public int tuoi;
        public double diemtrungbinh;
        public hocsinh() {
            ten = "";
            tuoi = 0;
            diemtrungbinh = 0;

        }
        public hocsinh(string ten , int tuoi, double diemtrungbinh)
        {
            this.ten = ten;
            this.tuoi = tuoi;
            this.diemtrungbinh = diemtrungbinh;
        }
        public void nhap()
        {
            Console.WriteLine(" nhap ten :");
            ten = Console.ReadLine();
            Console.WriteLine(" nhap tuoi :");
            tuoi = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap diem trung binh :");
            diemtrungbinh = double.Parse(Console.ReadLine());
        }
        public void PrintInfo()
        {
            Console.WriteLine("ten hoc sinh :{0} , tuoi :{1} , diem trung binh :{2} ", ten, tuoi, diemtrungbinh);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<hocsinh> dshocsinh = new List<hocsinh>();
            Console.WriteLine(" nhap so luong hoc sinh ");
            int n = int.Parse(Console.ReadLine()) ;
            for (int i= 0; i < n ;i++)
            {
                hocsinh hs1 = new hocsinh();
                Console.WriteLine("nhap thong tin hoc sinh {0}", i + 1);
                hs1.nhap();
                dshocsinh.Add(hs1);
            }
            Console.WriteLine(" danh sach hoc sinh ");
            foreach(var i in dshocsinh)
            {
                i.PrintInfo();
            }
            Console.ReadLine();
        }
    }
}
