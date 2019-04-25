using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class SinhVien
    {
        public String name;
        public int age;
        public int mark; 

        public SinhVien()
        {
            this.NhapThongTin();
            this.InThongTin();
            this.BaoKetQua();
        }

        public SinhVien(int x)
        {
            Console.WriteLine("Đây là constructor có tham số");
        }

        public void NhapThongTin()
        {
            Console.WriteLine("Nhập tên: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập tuổi: ");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nhập điểm thi: ");
            mark = Convert.ToInt32(Console.ReadLine());
        }

        public void InThongTin()
        {
            Console.WriteLine("Tên: " + name);
            Console.WriteLine("Tuổi: " + age);
            Console.WriteLine("Điểm thi: " + mark);
        }

        public void BaoKetQua()
        {
            if (mark >= 4)
            {
                Console.WriteLine("Sinh viên đã qua môn");
                return;
            }
            Console.WriteLine("Sinh viên không qua môn");
        }

        public static void Main(String[] args)
        {
            SinhVien sv = new SinhVien(2);
        }
    }
}
