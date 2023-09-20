using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double a, b;
            char z;
            string result;
            Console.WriteLine("Добро пожаловать в калькулятор! Вы можете выполнить операции сложения, вычитания, " +
                "умножения и деление! Пользуйтесь с удовольствием!");
            Console.WriteLine("Введите a ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Принято!");
            Console.WriteLine("Введите действие (+, -, *, /) ");
            z = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите b ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Принято!");
            switch (z)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                    if (b == 0)
                    {
                        Console.WriteLine("Ошибка деления на ноль");
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
            Console.WriteLine("Завершить программу? (y/n)?");
          
            result = Console.ReadLine().ToString();
            if (result == "y")
            {
                Environment.Exit(0);
            }
            if (result == "n")
            {
                Console.WriteLine("Принято!");
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}