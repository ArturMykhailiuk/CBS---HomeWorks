using System;
using System.Security.Cryptography;

namespace CBS___HomeWork_6
{
    class Program
    {
        public static int z;
        public static string str;

        static void Main(string[] args)
        {
              Console.WriteLine("Задание 2");
              Console.WriteLine("\nВведите первое число");
              int a = int.Parse(Console.ReadLine());
              Console.WriteLine("Введите второе число");
              int b = int.Parse(Console.ReadLine());
              if (a >= b)
              {
                  Console.WriteLine("Второе число должно быть больше первого");
                  Environment.Exit(0);
              }

              for (int i = a; i <= b; i++)
              {
                  if (i != a && i != b)
                  {
                      z += i;

                      if (i % 2 != 0)
                      {
                          if (str == null)
                          {
                              str = Convert.ToString(i);
                          }
                          else
                          {
                              str += ", " + i;
                          }                       
                      }                 
                  }
              }
              Console.WriteLine("Сумма чисел между {0} и {1} равна {2}", a, b, z);
              Console.WriteLine("Между числами {0} и {1} расположены следующии нечетные: {2}", a, b, str);

              Console.ReadKey();

            Console.WriteLine("\nЗадание 3");

            Console.WriteLine("\nПрямоугольник");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");

            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write("\n*");

                for (int j = 0; j < 8; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
            }

            Console.Write("\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write("*");

            }

            Console.ReadKey();

            Console.WriteLine("\nПрямоугольний треугольник");

            for (int i = 0; i < 8; i++)
            {
                if (i == 0)
                {
                    Console.Write("\n*");
                }

                else
                {
                    Console.Write("\n*");
                    Console.Write("*".PadLeft(i));
                }
            }

            Console.Write("\n");

            for (int i = 0; i <= 8; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();

            Console.WriteLine("\nРавносторонний треугольник");           

            for (int i = 0; i < 12; i++)
            {
                if (i == 0)
                {
                    Console.Write("*".PadLeft(13));
                }
                else
                {
                    Console.Write("\n");
                    Console.Write("*".PadLeft(13 - i));
                    Console.Write("*".PadLeft(i + i));
                }
            }

            Console.Write("\n");

            for (int i = 0; i <= 24; i++)
            {
                Console.Write("*");
            }

            Console.ReadKey();

            Console.WriteLine("\nРомб");

            for (int i = 0; i <= 10; i++)
            {
                if (i >= 0 && i <= 4)
                {
                    if (i == 0)
                    {
                        Console.Write("*".PadLeft(13));
                    }
                    else
                    {
                        Console.Write("\n");
                        Console.Write("*".PadLeft(13 - i));
                        Console.Write("*".PadLeft(i + i));
                    }
                }
                else
                {
                    if (i == 10)
                    {
                        Console.Write("\n");
                        Console.Write("*".PadLeft(13));
                    }
                    else
                    {
                        Console.Write("\n");
                        Console.Write("*".PadLeft(3 + i));
                        Console.Write("*".PadLeft(19 - (i + (i-1))));
                    }
                }
               
            }

            Console.ReadKey();

            Console.WriteLine("\nЗадание 4");
            Console.WriteLine("Введите количество клиентов");

            int n = int.Parse(Console.ReadLine());
            int clients = n;
            int factorial = 1;
            do
            {
                factorial *= n; 
                n--; 
            } while (n != 0);

            Console.WriteLine("Количество возможных вариантов доставки для {0} клиентов равно {1}", clients, factorial);

            Console.ReadKey();

            Console.WriteLine("\nДополнительное задание");

            Console.WriteLine("\nПроизвольный прямоугольник");

            Console.WriteLine("\nЗадайте высоту");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine("Задайте широту");
            int l = int.Parse(Console.ReadLine());


            for (int i = 0; i < l; i++)
            {
                Console.Write("*");

            }

            for (int i = 0; i < h - 2; i++)
            {
                Console.Write("\n*");

                for (int k = 0; k < l - 2; k++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
            }

            Console.Write("\n");

            for (int i = 0; i < l; i++)
            {
                Console.Write("*");

            }

        }
    }
}
