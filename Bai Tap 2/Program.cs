using System;

namespace VariableManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Khai báo một biến n kiểu int
            int n;

            // 2. Gán 100 cho n rồi in ra màn hình
            n = 100;
            Console.WriteLine("Value of n: " + n);

            // 3. Cộng thêm 200 cho n rồi in ra màn hình
            n += 200;
            Console.WriteLine("Value of n after add to 200: " + n);

            Console.ReadLine();
        }
    }
}
