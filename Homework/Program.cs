using System;
namespace Homework
{
    class Program
    {
        static void Main()
        {
            int n;
            bool f;
            f = false;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= Math.Sqrt(n); i++)
            {
                if (Math.Pow(3, i) == n)
                {
                    f = true;
                }
            }
            if (f)
            {
                Console.WriteLine("Число является степенью тройки");
            }
            else
            {
                Console.WriteLine("Число не является степенью тройки");
            }
        }
    }
}


