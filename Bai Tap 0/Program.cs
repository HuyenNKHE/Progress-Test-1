using System;

namespace NumberConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comment when you want to run specific each part of Bai tap 0 (1, 2, 3)
            /* int decimalNumber = 2021;
             Console.WriteLine("1: ");

             // Chuyển đổi sang hệ 2 (binary)
             string binaryNumber = Convert.ToString(decimalNumber, 2);
             Console.WriteLine("Binary: " + binaryNumber);

             // Chuyển đổi sang hệ 8 (octal)
             string octalNumber = Convert.ToString(decimalNumber, 8);
             Console.WriteLine("Octal: " + octalNumber);

             // Chuyển đổi sang hệ 16 (hexadecimal)
             string hexadecimalNumber = Convert.ToString(decimalNumber, 16);
             Console.WriteLine("Hexadecimal: " + hexadecimalNumber);

             Console.ReadLine();*/

            /* Console.WriteLine("2: ");
             string binaryNumber = "101111001010111001110";

             // Chuyển đổi sang hệ 10 (decimal)
             int decimalNumber = Convert.ToInt32(binaryNumber, 2);
             Console.WriteLine("Decimal: " + decimalNumber);

             // Chuyển đổi sang hệ 8 (octal)
             string octalNumber = Convert.ToString(decimalNumber, 8);
             Console.WriteLine("Octal: " + octalNumber);

             // Chuyển đổi sang hệ 16 (hexadecimal)
             string hexadecimalNumber = Convert.ToString(decimalNumber, 16);
             Console.WriteLine("Hexadecimal: " + hexadecimalNumber);

             Console.ReadLine();*/

            Console.WriteLine("3: ");

            string hexadecimalNumber = "6DA3F9";

            // Chuyển đổi sang hệ 2 (binary)
            string binaryNumber = Convert.ToString(Convert.ToInt32(hexadecimalNumber, 16), 2);
            Console.WriteLine("Binary: " + binaryNumber);

            // Chuyển đổi sang hệ 8 (octal)
            string octalNumber = Convert.ToString(Convert.ToInt32(hexadecimalNumber, 16), 8);
            Console.WriteLine("Octal: " + octalNumber);

            // Chuyển đổi sang hệ 10 (decimal)
            int decimalNumber = Convert.ToInt32(hexadecimalNumber, 16);
            Console.WriteLine("Decimal: " + decimalNumber);

            Console.ReadLine();

        }
    }
}
