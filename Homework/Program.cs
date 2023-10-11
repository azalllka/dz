//4.По паре координат шахматной доски (каждая координата на отдельной строке) определить,
//возможен ли ход из одной позиции в другую ладьёй (YES|NO)
using System;
namespace Homework
{
    class Program
    {
        static void Main()
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            if (x1 == x2 || y1 == y2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}


//16.Найти длину самой длинной непрерывной цепочки нулей в двоичном представлении
//десятичного натурального числа n (n<=10^18)
using System;
namespace Homework
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int max0 = maxZero(N);
            Console.WriteLine(max0);
        }
        static int maxZero(int N)
        {
            string binaryN = Convert.ToString(N, 2);
            int max0 = 0;
            int count0 = 0;
            foreach (char c in binaryN)
            {
                if (c == '0')
                {
                    count0++;
                }
                else
                {
                    max0 = Math.Max(max0, count0);
                    count0 = 0;
                }
            }
            max0 = Math.Max(max0, count0);
            return max0;

        }
    }
}



//12.Считывая числа пока не встретится 0, найти минимальное число и сколько раз оно
//встречается в последовательности
using System;
namespace Homework
{
    class Program
    {
        static void Main()
        {
            int minNumber = int.MaxValue;
            int count = 0;
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                {
                    break;
                }
                if (number < minNumber)
                {
                    minNumber = number;
                    count = 1;
                }
                else if (number == minNumber)
                {
                    count++;
                }
            }
            Console.WriteLine("Минимальное число");
            Console.WriteLine(minNumber);
            Console.WriteLine("Количество повторений");
            Console.WriteLine(count);
        }
    }
}



//7.По заданному k(от 1 до 20) найти наименьшее целое число, делящееся нацело на все числа
//от 1 до k
using System;
namespace Homework
{
    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= k; i++)
            {
                result = nok(result, i);
            }
            Console.WriteLine(result);
        }
        static int nok(int a, int b)
        {
            return (a * b) / nod(a, b);
        }
        static int nod(int a, int b)
        {
            while (b != 0)
            {
                int ostatok = a % b;
                a = b;
                b = ostatok;
            }
            return a;

        }
    }
}
