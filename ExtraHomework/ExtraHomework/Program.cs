using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ExtraHomework
{
    class MessageHelper
    {
        static public string getString(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        static public int getInt(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            return Convert.ToInt32(MessageHelper.getString(message));
        }

        static public double getDouble(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            return Convert.ToDouble(MessageHelper.getString(message));
        }

        static public bool getBool(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            return Convert.ToBoolean(MessageHelper.getString(message));
        }
        public void showText(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(text);

            Console.WriteLine();
        }
    }
    class Task
    {
        MessageHelper mh = null;
        public void NumberOne()
        {
            mh = new MessageHelper();
            string numbers = MessageHelper.getString("Введіть цифри:", ConsoleColor.Green);

            mh.showText("Список з унікальними цифри:", ConsoleColor.Yellow);
            var i = numbers.Split(' ');
            var unique_numbers = new HashSet<string>(i);
            foreach (string n in unique_numbers)
            { 
                Console.WriteLine(n); 
            }
        }
        public void NumberTwo()
        { 
            mh = new MessageHelper();

            string word = MessageHelper.getString("Напишіть слово(На українській мові):", ConsoleColor.Blue);
            int vowels = 0;
            int consonants = 0;
            int len = word.Length;

            for (int i = 0; i < len; i++)
            {               
                if (word[i] == 'а' || word[i] == 'е' ||
                    word[i] == 'є' || word[i] == 'и' ||
                    word[i] == 'і' || word[i] == 'ї' ||
                    word[i] == 'й' || word[i] == 'о' ||
                    word[i] == 'у' || word[i] == 'ь' || 
                    word[i] == 'ю' || word[i] == 'я')
                {

                    vowels++;
                }
                else if ((word[i] >= 'а' && word[i] <= 'я') ||
                         (word[i] >= 'А' && word[i] <= 'Я'))
                {
                    consonants++;
                }
            }
            mh.showText($"Кількість голосних = {vowels}", ConsoleColor.Yellow);
            mh.showText($"Кількість приголосних = {consonants}", ConsoleColor.Cyan);
        }
        public void NumberThree()
        {
            mh = new MessageHelper();
            int sum = 0;

            int numbes = MessageHelper.getInt("Напишіть число(ціле):", ConsoleColor.Magenta);
            while (numbes != 0)
            {
                sum += numbes % 10;
                numbes /= 10;
            }
            mh.showText($"Сума цифр зазначеного цілого числа: {sum}", ConsoleColor.DarkYellow);
        }
        public void NumberFour() 
        {
            mh = new MessageHelper();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            MessageHelper mh = new MessageHelper();
            Task task = new Task();

            mh.showText("Виберіть завдання:", ConsoleColor.White);
            mh.showText("[1] Завдання №1", ConsoleColor.Cyan);
            mh.showText("[2] Завдання №2", ConsoleColor.Green);
            mh.showText("[3] Завдання №3", ConsoleColor.Yellow);
            //mh.showText("[4] Завдання №4", ConsoleColor.Blue);
            mh.showText("[0] Вихід з програми", ConsoleColor.Red);
            int menuM = MessageHelper.getInt("");

            Console.Clear();

            switch (menuM)
            {
                case 0:
                    mh.showText("Вихід із програми...", ConsoleColor.DarkRed);
                    Thread.Sleep(1000);
                    return;
                case 1:
                    mh.showText("Умова:" +
                        "\n1)Створіть програму, яка приймає на вхід список " +
                        "чисел і повертає новий список, що містить лише " +
                        "унікальні числа з початкового списку, без повторень.", ConsoleColor.Gray);
                    task.NumberOne();
                    break;
                case 2:
                    mh.showText("Умова:" +
                        "\n2)Напишіть програму, яка приймає на вхід рядок і " +
                        "повертає кількість голосних і приголосних літер у " +
                        "цьому рядку.", ConsoleColor.Gray);
                    task.NumberTwo();
                    break;
                case 3:
                    mh.showText("Умова:" +
                        "\n3)Створіть програму, яка приймає на вхід число " +
                        "і повертає суму всіх цифр цього числа.", ConsoleColor.Gray);
                    task.NumberThree();
                    break;
                /*case 4:
                   mh.showText("Умова:" +
                        "\n4)", ConsoleColor.Gray);
                    task.NumberFour();
                    break;*/
                default:
                    mh.showText("Виберіть завдання:", ConsoleColor.White);
                    mh.showText("[1] Завдання №1", ConsoleColor.Cyan);
                    mh.showText("[2] Завдання №2", ConsoleColor.Green);
                    mh.showText("[3] Завдання №3", ConsoleColor.Yellow);
                    //mh.showText("[4] Завдання №4", ConsoleColor.Blue);
                    mh.showText("[0] Вихід з програми", ConsoleColor.Red);
                    menuM = MessageHelper.getInt("");


                    Console.Clear();
                    break;
            }
            Console.ReadLine();       
        }
    }
}
