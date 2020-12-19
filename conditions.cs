using System;

namespace Homework2
{
    class conditions
    {
        static void Main(string[] args)
        {
            // Задание 1

            /* 
            Random rnd = new Random();
            int a = rnd.Next(0, 4);
            int b = rnd.Next(0, 4);

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} - четное");
            }
            else
            {
                Console.WriteLine($"{a} - нечетное");
            }

            if (b % 2 == 0)
            {
                Console.WriteLine($"{b} - четное");
            }
            else
            {
                Console.WriteLine($"{b} - нечетное");
            }
            */
            // Задание 2

            /*
            int a, b, c;

            Console.WriteLine("Введите три числа : ");

            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if ((a >= b) && (a >= c))
            {
                Console.WriteLine($"{b} - наибольшое число");
            }
            else
            if ((b >= a) && (b >= c))
            {
                Console.WriteLine($"{b} - наибольшое число");
            }
            else
            if ((c >= a) && (c >= b))
            {
                Console.WriteLine($"{c} - наибольшое число");
            };

            */

            // Задание 4

            /*
            Console.WriteLine("Введите радиус:");
            string str1 = Console.ReadLine();
            int R = int.Parse(str1);

            Console.WriteLine("Введите X координату:");
            string str2 = Console.ReadLine();
            int x = int.Parse(str2);

            Console.WriteLine("Введите Y координату:");
            string str3 = Console.ReadLine();
            int y = int.Parse(str3);

            if ((x * x) + (y * y) == R * R)
            {
                Console.WriteLine("Заданная точка лежит на окружности");
            }
            else if ((x * x) + (y * y) < R * R)
            {
                Console.WriteLine("Заданная точка находится внутри круга");
            }
            else if ((x * x) + (y * y) > R * R)
            {
                Console.WriteLine("Заданная точка находится за пределами круга");
            }

            */

            // Задание 5

            Random rnd = new Random();
            int a = rnd.Next(0, 30);

            switch (a)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                Console.WriteLine($"{a} в 1 диапозоне");
                break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                Console.WriteLine($"{a} в 2 диапозоне");
                break;
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                Console.WriteLine($"{a} в 3 диапозоне");
                break;
            }
        }
    }
}
