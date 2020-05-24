using System;

namespace CBS___HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*---Задание 2---*/
            
            Double pi = 3.141592653d;                         /*---float - не подходит, так как обрежет результат и в итоге будет - 3.1415927. 
                                                                   Назначения типа данных Decimal даст правильный результат, но не оправдано ---*/
            
            Decimal e = 2.7182818284590452m;                  /*---float - не подходит, так как обрежет результат и в итоге будет - 2.7182818
                                                                  Double - не подходит, так как обрежет результат и в итоге будет - 2.718281828459045 ---*/
            Console.WriteLine(pi);
            Console.WriteLine(e);

            
            /*---Задание 3---*/

            String str1 = "\nмоя строка 1";                   /*---перевод на новою строчку---*/
            String str2 = "\tмоя строка 2";                   /*---табуляция------------------*/
            String str3 = "\aмоя строка 3";                   /*---сигнал---------------------*/

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);

            
            /*---Задание 4---*/
            
            /* https://docs.microsoft.com/ru-ru/previous-versions/visualstudio/visual-studio-2008/ya5y69ds%28v%3dvs.90%29 - Таблица встроеных типов (Справочник по С#) ---*/


}
}
}
