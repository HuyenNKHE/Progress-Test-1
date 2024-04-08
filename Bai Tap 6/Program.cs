using System;

namespace TamGiacVuong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập vào độ dài cạnh thứ nhất của tam giác vuông:");
            double canh1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập vào độ dài cạnh thứ hai của tam giác vuông:");
            double canh2 = double.Parse(Console.ReadLine());

            // Tính chu vi
            double chuVi = canh1 + canh2 + Math.Sqrt(Math.Pow(canh1, 2) + Math.Pow(canh2, 2));

            // Tính diện tích
            double dienTich = (canh1 * canh2) / 2;

            Console.WriteLine("Chu vi của tam giác vuông là: " + chuVi);
            Console.WriteLine("Diện tích của tam giác vuông là: " + dienTich);

            Console.ReadLine();
        }
    }
}
