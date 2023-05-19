using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class E
    {
        public void showText(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(text);

            Console.WriteLine();
        }
        public void NumberOne()
        {
            showText("•Введіть свій зріст:", ConsoleColor.Cyan);
            double h_cen = Convert.ToDouble(Console.ReadLine());

            showText("•Введіть масу свого тіла:", ConsoleColor.DarkYellow);
            double m = Convert.ToDouble(Console.ReadLine());

            double h_meters = h_cen / 100;
            double imt = m / Math.Pow(h_meters, 2);

            showText($"•Твій IMT: {imt}", ConsoleColor.Green);
            showText($"---------------------------------", ConsoleColor.White);
            if (imt < 18.5)
            {
                showText("•У вас недостатня маса", ConsoleColor.Magenta);
            }
            else if (imt > 18.5 && imt < 25)
            {
                showText("•У вас нормальна маса", ConsoleColor.Green);
            }
            else if (imt > 24.9 && imt < 30)
            {
                showText("•У вас передожиріння (гладкість)", ConsoleColor.Yellow);
            }
            else if (imt > 29.9 && imt < 35)
            {
                showText("•У вас ожиріння I ступеня", ConsoleColor.DarkYellow);
            }
            else if (imt > 34.9 && imt < 40)
            {
                showText("•У вас ожиріння II ступеня", ConsoleColor.Red);
            }
            else if (imt > 40)
            {
                showText("•У вас ожиріння III ступеня", ConsoleColor.DarkRed);
            }
            showText($"---------------------------------", ConsoleColor.White);
        }
        public void NumberTwo()
        {
            showText("Виберіть одиниці виммірювання:", ConsoleColor.Cyan);
            showText("[1] Часу", ConsoleColor.Cyan);
            showText("[2] Довжини", ConsoleColor.Cyan);
            showText("[3] Маси", ConsoleColor.Cyan);
            int menu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            showText("Напишіть число", ConsoleColor.Green);
            int num = Convert.ToInt32(Console.ReadLine());
            showText("-------------------------------", ConsoleColor.White);

            switch (menu)
            {
                case 1:
                    showText($"{num} хв = {num * 60} секунд", ConsoleColor.Yellow);
                    showText($"{num} год = {num * 60} хв", ConsoleColor.Green);
                    showText($"{num} доб = {num * 24} год", ConsoleColor.Cyan);
                    showText($"{num} тиж = {num * 7} діб", ConsoleColor.Magenta);
                    showText($"{num} міс = {num * 31} діб", ConsoleColor.Red);
                    showText($"{num} рік = {num * 365} діб", ConsoleColor.Blue);
                    break;
                case 2:
                    showText($"{num} см = {num * 10} мм", ConsoleColor.Yellow);
                    showText($"{num} дм = {num * 10} см", ConsoleColor.Green);
                    showText($"{num} м = {num * 10} дм", ConsoleColor.Cyan);
                    showText($"{num} м = {num * 100} см", ConsoleColor.Magenta);
                    showText($"{num} км = {num * 1000} м", ConsoleColor.Red);
                    showText($"{num} см = {num * 0.393701} дюйм", ConsoleColor.Blue);
                    break;
                case 3:
                    showText($"{num} кг = {num * 1000} г", ConsoleColor.Yellow);
                    showText($"{num} ц = {num * 100} кг", ConsoleColor.Green);
                    showText($"{num} т = {num * 10} ц", ConsoleColor.Cyan);
                    showText($"{num} т = {num * 1000} кг", ConsoleColor.Magenta);
                    break;
                default:
                    showText($"{num} т = {num * 1000} кг", ConsoleColor.DarkRed);
                    break;
            }
            showText("-------------------------------", ConsoleColor.White);
        }
        public void NumberThree()
        {
            int menu = 0;
            int module = 0;

            double number1 = 0;
            double number2 = 0;

            showText("--Дробові числа писати через кому---");
            showText("---Потрібно використовувати значення по модулю?---" +
                "\n------------------(1 - Так; 2 - Ні)-------------------");
            module = Convert.ToChar(Console.ReadLine());

            switch (module)
            {
                case '1':
                    showText("---Добре! Ви вибрали що будете використовувати значення по модулю---", ConsoleColor.Green);
                    break;
                case '2':
                    showText("---Добре! Ви вибрали що не будете використовувати значення по модулю---", ConsoleColor.Red);
                    break;
                default:
                    showText("---Такого варіанту відповід не має---", ConsoleColor.DarkRed);
                    break;
            }

            showText("---Введіть перше число---", ConsoleColor.Cyan);
            number1 = Convert.ToDouble(Console.ReadLine());

            showText("---Введіть друге число---", ConsoleColor.Magenta);
            number2 = Convert.ToDouble(Console.ReadLine());

            showText("---Яку операцію Ви хочете зробити? Можливі операції:---" +
                "\n------------------Додавання - 1------------------------" +
                "\n------------------Віднімання - 2-----------------------" +
                "\n------------------Множення - 3-------------------------" +
                "\n------------------Ділення - 4--------------------------" +
                "\n------------------Корінь числа - 5---------------------" +
                "\n------------------Зведення числа в ступінь - 6---------" +
                "\n------------------Відсоток від числа - 7---------------");
            showText("---Оберіть пункт операції яку ви хочете виконати---", ConsoleColor.Blue);
            menu = Convert.ToInt32(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    showText($"•Ви зробили операцію додавання. Результат операції: {number1} + {number2} = {number1 + number2}", ConsoleColor.Yellow);
                    break;
                case 2:
                    showText($"•Ви зробили операцію віднімання. Результат операції: {number1} - {number2} = {number1 - number2}", ConsoleColor.Cyan);
                    break;
                case 3:
                    showText($"•Ви зробили операцію множення. Результат операції: {number1} * {number2} = {number1 * number2}", ConsoleColor.DarkYellow);
                    break;
                case 4:
                    if (number2 == 0)
                    {
                        showText("•Неможливо ділити на нуль", ConsoleColor.DarkRed);
                    }
                    else
                    {
                        showText($"•Ви зробили операцію ділення. Результат операції: {number1} / {number2} = {number1 / number2}", ConsoleColor.DarkGreen);
                    }
                    break;
                case 5:
                    if (number1 < 0 || number2 < 0)
                    {
                        showText("•Неможливо винести корінь із від'ємного числа!", ConsoleColor.DarkRed);
                    }
                    else
                    {
                        showText($"•Ви зробили операцію корінь із числа. Результат операції: Корінь із першого числа: {Math.Sqrt(number1)} Корінь із другого числа: {Math.Sqrt(number2)}", ConsoleColor.Yellow);
                    }
                    break;
                case 6:
                    showText($"•Ви зробили операцію зведення числа в ступінь. Результат операції: {number1} ^ {number2} = {Math.Pow(number1, number2)}", ConsoleColor.DarkYellow);
                    break;
                case 7:
                    if (number2 < 0)
                    {
                        showText("•Відсоток не може бути від'ємним!", ConsoleColor.DarkRed);
                    }
                    else
                    {
                        showText($"•Ви зробили операцію відсоток від числа. Результат операції: {number2} відсотків від числа {number1} = {number1 / 100 * number2}", ConsoleColor.Cyan);
                    }
                    break;
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            E e = new E();

            e.showText("Виберіть завдання:", ConsoleColor.White);
            e.showText("[1] Завдання №1", ConsoleColor.Cyan);
            e.showText("[2] Завдання №2", ConsoleColor.Green);
            e.showText("[3] Завдання №3", ConsoleColor.Yellow);
            int menuM = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (menuM)
            {
                case 1:
                    e.NumberOne();
                    break;
                case 2:
                    e.NumberTwo();
                    break;
                case 3:
                    e.NumberThree();
                    break;
                default:
                    e.showText("Виберіть завдання:", ConsoleColor.White);
                    e.showText("[1] Завдання №1", ConsoleColor.Cyan);
                    e.showText("[2] Завдання №2", ConsoleColor.Green);
                    e.showText("[3] Завдання №3", ConsoleColor.Yellow);
                    menuM = Convert.ToInt32(Console.ReadLine());


                    Console.Clear();
                    break;
            }
            Console.ReadLine();
        }
    }
}
