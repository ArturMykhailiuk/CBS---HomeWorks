using System;

namespace CBS___HomeWork_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---Задание 1---*/
            Console.WriteLine("Задание 1:");
            Console.WriteLine("\nВариант 1");
            {
                int x = 10;
                int y = 12;
                int z = 3;

                x += y - x++ * z;   /*---   результат (-8). x = 10 + 12 - 10 * 3                          ---*/
                Console.WriteLine(x);

                x = 10;
                y = 12;
                z = 3;
                z = --x - y * 5;    /*---   результат (-51). z = 9 - 12 * 5                               ---*/
                Console.WriteLine(z);

                x = 10;
                y = 12;
                z = 3;
                y /= x + 5 % z;     /*---   результат (1). y = 12 / (10 + 5 % 3); y = 12 / 12             ---*/
                Console.WriteLine(y);

                x = 10;
                y = 12;
                z = 3;
                z = x++ + y * 5;   /*---    результат (70). z = 10 + 12 * 5                               ---*/
                Console.WriteLine(z);

                x = 10;
                y = 12;
                z = 3;
                x = y - x++ * z;   /*---    результат (-18). x = 12 - 10 * 3                              ---*/
                Console.WriteLine(x);
            }
            Console.WriteLine("\nВариант 2");   
               
            {
                int x = 10;
                int y = 12;
                int z = 3;

                x += y - x++ * z;   /*---   результат (-8). x = 10 + 12 - 10 * 3                          ---*/
                Console.WriteLine(x);

                z = --x - y * 5;    /*---   результат (-69). z = -9 - 12 * 5                              ---*/
                Console.WriteLine(z);

                y /= x + 5 % z;     /*---   результат (-3). y = 12/ (-9 + 5 % (-69)); y = 12 / (-9 + 5)   ---*/
                Console.WriteLine(y);
               
                z = x++ + y * 5;   /*---    результат (-24). z = -9 + (-3) * 5                            ---*/
                Console.WriteLine(z);
             
                x = y - x++ * z;   /*---    результат (-195). x = -3 -((-8) * (-24))                      ---*/
                Console.WriteLine(x);

            }

            /*---Задание 2---*/

            int a = 2;
            int b = 3;
            int c = 5;

            decimal d;
            d = (decimal)(a + b + c) / 3;
            Console.WriteLine($"\nЗадание 2: Среднее арифметическое - {d}");

            /*Ответ: в даном задании столкнулся с проблемой некоректного отображения результата вычисления среднего арифметического при использовании
                     переменной целочисельного типа (int). В таком случае: d = (2+3+5) / 3; d = 3; - очевидно, что это не правильно. А вот при использовании
                     десятичного типа данных результат верный: d = (2+3+5) / 3; d = 3,3333333333333333333333333333. Также можна использовать
                     вещественные типы даных float и double. Но так как эти типы данных по своему размеру меньше чем decimal - они могут усекать 
                     результат, что также может быть ошибкой.*/


            /*---Задание 3---*/
            {
                const double pi = 3.145d;
                double r = 2.24d;

                double S = pi * Math.Pow(r, 2);

                Console.WriteLine($"\nЗадание 3: Площадь круга - {S}");
            }


            /*---Задание 4---*/
            {
                const double pi = 3.145d;
                double R = 2.2d;
                double h = 3.1d;

                double V = pi * Math.Pow(R, 2) * h;
                double S = 2 * pi * R * (R + h);

                Console.WriteLine($"\nЗадание 4: Объем цилиндра - {V}. \n\t   Площадь поверхности цилиндра - {S}.");

            }


            /*---Задание 5---*/

            /*string uberflu? = "CBS"; ОШИБКА - нельзя использовать знак ?*/
            
            string _Identifier = "CBS";

            string \u006fIdentifier = "CBS";

            /*string &myVar = "CBS"; ОШИБКА - нельзя использовать знак &*/

            string myVariab1le = "CBS"; /*лучшее решение для имени переменной*/

            
            /*---Дополнительное задание---*/

            int f = 7;
            int g = 5;

            Console.WriteLine($"\nДополнительное задание: - деление {(decimal)f/g}\n\t\t        - умножение {f*g} \n\t\t        - вычетание {f-g}\n\t\t        - сложение {f+g}\n\t\t        - остаток от деления {f%g}");

        }
    }
}
