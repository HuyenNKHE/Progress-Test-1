using System;

namespace DiemTongKet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nhập điểm từ người dùng cho 3 cột điểm
            Console.WriteLine("Enter first mark:");
            double diemThiLan1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter online mark:");
            double diemOnline = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter final mark:");
            double diemThiCuoiKy = double.Parse(Console.ReadLine());

            // Tính điểm tổng kết
            double diemTongKet = (diemThiLan1 * 0.25) + (diemOnline * 0.25) + (diemThiCuoiKy * 0.5);

            // In điểm tổng kết ra màn hình
            Console.WriteLine("Average mark: " + diemTongKet);

            Console.ReadLine();
        }
    }
}
