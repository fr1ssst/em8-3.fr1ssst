using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть 1 чило");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ведіть 2 чило");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Добуток: {number1 * number2}" +
                $"\nСума: {number1 + number2}" +
                $"\nРiзниця: {number1 - number2}" +
                $"\nЗалишок вiд дiлення: {number1 % number2}" +
                $"\nСереднє арифметичне: {(number1 + number2) / 2}");

            Console.ReadLine();
        }
    }
}
