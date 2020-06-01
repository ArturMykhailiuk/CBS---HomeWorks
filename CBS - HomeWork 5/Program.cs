using System;

namespace CBS___HomeWork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*---Задание 2---*/

            Console.WriteLine("******Задание 2******");
            Console.WriteLine("---Вариант 1--- (Конъюкция)");
            /*---Для определения явлеется ли число четным можна пременить логическое умножение на 3. Если результатом такого умножения будет 
             *   число 2 и 0, то тогда число которое умножаеться будет парным. Если результатом такого умножения будет 
             *   число 3 и 1, то тогда число которое умножаеться будет непарным.---*/
            
            Console.WriteLine($"Результат: - {6 & 3}"); /*     0110                                    
                                                             * 0011
                                                               ----
                                                               0010     Результат 2 - число четное    */


            Console.WriteLine($"Результат: - {7 & 3}"); /*     0110                                    
                                                             * 0011
                                                               ----
                                                               0010     Результат 3 - число нечетное    */

            Console.WriteLine("---Вариант 2--- (Дизъюнкция)"); /*---тут с обяснением все сложно. Я понял, что если первый бит после операции сложении
                                                                    0 то тогда четное, а если 1, то нечетное  */     

            Console.WriteLine($"Результат: 6 (первый бит = 0) - {6 | 2}"); /*      0110                                    
                                                                                 + 0010
                                                                                   ----
                                                                                   0110     Результат 0 - число парное    */


            Console.WriteLine($"Результат: 7 (первый бит = 1) - {7 | 2}"); /*      0111                                    
                                                                                 + 0011
                                                                                   ----
                                                                                   0111     Результат 1 - число непарное    */



            Console.WriteLine("******Задание 3******");
            {
                int x = 5, y = 10, z = 15;
              
                Console.WriteLine(x += y >> x++ * z);   /*Результат 5 : x += 10 >> 75 ; x = 5 + 0; x = 5 */
            }

            {
                int x = 5, y = 10, z = 15;
               
                Console.WriteLine(z = ++x & y * 5);     /*Результат 2: z = 6 & 10 * 5; z = 6 & 50; z = 2; */
            }

            {
                int x = 5, y = 10, z = 15;
                Console.WriteLine(y /= x + 5 | z);      /*Результат 0: y /= 5 + 5 | 15; y /= 10 | 15; y = 10 / 15; y = 0; (0 потому что тип int) */
            }

            {
                int x = 5, y = 10, z = 15;
                Console.WriteLine(z = x++ & y * 5);     /*Результат 0: z = 5 & 10 * 5; z = 5 & 50; z = 0; */
            }

            {
                int x = 5, y = 10, z = 15;
                Console.WriteLine(x = y << x++ ^ z);    /*Результат 335: x = 10 << 5 ^ 15  x = 320 ^ 15; x = 335; */
            }



            Console.WriteLine("******Задание 4******");

            double salary = 10000;
            int exp = 10;

            Console.WriteLine("Трудовой стаж - {0} лет", exp);
            Console.WriteLine("Заработная плата - {0} грн.", salary);
            if (exp < 5) Console.WriteLine(salary * 0.1);
            else if (exp >= 5 && exp < 10) Console.WriteLine("Премия - {0}", salary * 0.15); 
            else if (exp >= 10 && exp < 15) Console.WriteLine("Премия - {0}", salary * 0.25); 
            else if (exp >= 15 && exp < 20) Console.WriteLine("Премия - {0}", salary * 0.35);
            else if (exp >= 20 && exp < 25) Console.WriteLine("Премия - {0}", salary * 0.45);
            else if (exp >= 25) Console.WriteLine("Премия - {0}", salary * 0.5);


            Console.WriteLine("******Дополнительное задание 1******");

            Console.WriteLine("\nВведите число - ");
            int num = int.Parse(Console.ReadLine());
            int value;
            value = num & (num - 1);
            if (value == 0) Console.WriteLine("Число {0} являеться степенью числа 2", num);
            else Console.WriteLine("Число {0} не являеться степенью числа 2", num);

            Console.WriteLine("******Дополнительное задание 2(ТУТ СОВСЕМ НЕ ПОНЯЛ)******");

            bool A = true;
            bool B = true;

            if (A || B)
                Console.WriteLine("A || B = {0}", A || B);
            else
                Console.WriteLine("A || B = {0}", A || B);

            // Условие после применения теоремы Де Моргана. 
            if (!(!A && !B))
                Console.WriteLine("(!A && !B) = {0}", !(!A && !B));
            else
                Console.WriteLine("(!A && !B) = {0}", !(!A && !B));





        }
    }
}
