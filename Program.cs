using System;

namespace projectname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите x:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите y:");
                double y = Convert.ToDouble(Console.ReadLine());
                int R = 1;

                if ((x >= 0) && (y <= 0) && (x * x + y * y <= R * R))
                {
                    Console.WriteLine("Попадание");
                }
                else
                {
                    Console.WriteLine("Промах");
                }

            }
        }
    }
}