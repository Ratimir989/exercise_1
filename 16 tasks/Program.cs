using System;

namespace _16_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("ВВедите число num1 и num2");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("num1 больше num 2");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("num2 больше num 1");
            }
            else
            {
                Console.WriteLine("num1 равно num 2");
            }
        }
    }
}
