using System;

namespace CBS___HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Выберите номер домашнего задания (2, 3, 4 - дополнительное)");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {

                /*---Задание 2---*/
                case 2:
                    {

                        decimal operand1;
                        decimal operand2;
                        string sign;

                        Console.WriteLine("Введите число 1");
                        operand1 = Decimal.Parse(Console.ReadLine());

                    number2:
                        {
                            Console.WriteLine("Введите число 2");
                            operand2 = Decimal.Parse(Console.ReadLine());
                        }

                    operation:
                        {
                            Console.WriteLine("Определите математическую операцию (+, -, /, *)");
                            sign = Console.ReadLine();
                        }
                        switch (sign)
                        {
                            case "+":
                                {
                                    Console.WriteLine($"Ответ - {operand1 + operand2}");
                                    break;
                                }
                            case "-":
                                {
                                    Console.WriteLine($"Ответ - {operand1 - operand2}");
                                    break;
                                }
                            case "*":
                                {
                                    Console.WriteLine($"Ответ - {operand1 * operand2}");
                                    break;
                                }
                            case "/":
                                {
                                    if (operand2 == 0)
                                    {
                                        Console.WriteLine("Ошибка деления на ноль! Попробуйте еще раз");
                                        goto number2;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Ответ - {operand1 / operand2}");
                                        break;
                                    }
                                }
                            default:
                                {
                                    Console.WriteLine("Вы выбрали не правильную математическую операцию! Сделайте выбор еще раз");
                                    goto operation;
                                }
                        }
                        break;
                    }

                /*---Задание 3---*/
                case 3:
                    {
                        Console.WriteLine("Введите число от 0 до 100");
                        int myNum = int.Parse(Console.ReadLine());
                        if (myNum >= 0 && myNum <= 14)
                        {
                            Console.WriteLine("Ваше число находится в диапазоне между 0 и 14");
                        }
                        else if (myNum >= 15 && myNum <= 35)
                        {
                            Console.WriteLine("Ваше число находится в диапазоне между 15 и 35");
                        }
                        else if (myNum >= 36 && myNum <= 50)
                        {
                            Console.WriteLine("Ваше число находится в диапазоне между 36 и 50");
                        }
                        else if (myNum >= 50 && myNum <= 100)
                        {
                            Console.WriteLine("Ваше число находится в диапазоне между 50 и 100");
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели число, которое находится вне диапазона");
                        }
                        break;
                    }

                /*---Задание 4---(не успел доработать продолжение и выход по кнопкам*/
                case 4:
                    {
                        Console.WriteLine("Введите слово для перевода");
                        string myWord = Console.ReadLine();

                        switch (myWord)
                        {
                            case "снег":
                                {
                                    Console.WriteLine("Snow");
                                    break;
                                }


                            case "дождь":
                                {
                                    Console.WriteLine("Rain");
                                    break;
                                }

                            case "влажность":
                                {
                                    Console.WriteLine("Humidity");
                                    break;
                                }

                            case "температура":
                                {
                                    Console.WriteLine("Temperature");
                                    break;
                                }
                            case "погода":
                                {
                                    Console.WriteLine("Weather");
                                    break;
                                }
                            case "давление":
                                {
                                    Console.WriteLine("Pressure");
                                    break;
                                }
                            case "солнечно":
                                {
                                    Console.WriteLine("Sunny");
                                    break;
                                }
                            case "холодно":
                                {
                                    Console.WriteLine("Coldly");
                                    break;
                                }
                            case "ветренно":
                                {
                                    Console.WriteLine("Windly");
                                    break;
                                }
                        }
                        break;
                    }

            }
        }
    }
}

