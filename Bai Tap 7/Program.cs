using System;

namespace TinhChuViDienTichTamGiac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of first side is:");
            double canh1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter length of second side is:");
            double canh2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter length of third side is:");
            double canh3 = double.Parse(Console.ReadLine());

            // Kiểm tra xem các cạnh có hợp lệ không
            if (KiemTraHopLe(canh1, canh2, canh3))
            {
                // Tính chu vi
                double chuVi = TinhChuVi(canh1, canh2, canh3);

                // Tính diện tích
                double dienTich = TinhDienTich(canh1, canh2, canh3);

                Console.WriteLine("Perimeter of triangle is: " + chuVi);
                Console.WriteLine("Area of triangle is: " + dienTich);
            }
            else
            {
                Console.WriteLine("All sides is invalid to create triangle.");
            }

            Console.ReadLine();
        }

        // Hàm kiểm tra tính hợp lệ của ba cạnh
        static bool KiemTraHopLe(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Hàm tính chu vi của tam giác
        static double TinhChuVi(double a, double b, double c)
        {
            return a + b + c;
        }

        // Hàm tính diện tích của tam giác bằng công thức Heron
        static double TinhDienTich(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
