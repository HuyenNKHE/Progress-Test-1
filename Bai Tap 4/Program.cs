using System;

namespace SeparateDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n (0 < n < 1000):");
            int n = int.Parse(Console.ReadLine());

            // Kiểm tra n có nằm trong khoảng yêu cầu không
            if (n <= 0 || n >= 1000)
            {
                Console.WriteLine("This number is invalid.");
                return;
            }

            Console.WriteLine("The digits of " + n + " is:");
            // Tách và in ra từng chữ số của số n
            int temp = n;
            int digit;
            int divisor = 100;
            while (divisor > 0)
            {
                digit = temp / divisor;
                Console.WriteLine(digit);
                temp %= divisor;
                divisor /= 10;
            }

            Console.ReadLine();
        }
    }
}
