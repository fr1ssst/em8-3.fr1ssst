using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtraHomework
{
    class EH
    {
        public void showText(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(text);

            Console.WriteLine();
        }
        public void NumberOne()
        {
            string str = "";
            str = Convert.ToString(Console.ReadLine());

            string[] words = str.Split(new[] { ' ' }, StringSplitOptions.None);

            string word = "";
            int c = 0;

            foreach(string strR in words) 
            {
                if(str.Length > c) 
                { 
                    word = strR;
                    c = strR.Length;
                }
            }

            Console.WriteLine(word);
        }
        public void NumberTwo()
        {
            var text = "123, 67, 456, 22";
            var sum =
                text
                    .Split(new[] { ',' })
                    .Select(x => int.Parse(x.Trim()))
                    .Sum();
            Console.WriteLine(sum);
        }
        public void NumberThree()
        {
            string str1 = "";
            string str2 = "";

            str1 = Convert.ToString(Console.ReadLine());
            str2 = Convert.ToString(Console.ReadLine());
        }
        public void NumberFour() 
        {
            int n = 0;
            int flag = 0;
            showText("Напишіть число:", ConsoleColor.Magenta);
            n = Convert.ToInt32(Console.ReadLine());

            for( int i = 2; i <= n/2; i++ ) 
            { 
                if(n % 2 == 0) 
                {
                    flag = 1;
                }
            }
            if(flag == 1) 
            {
                showText($"Число {n} не просте число", ConsoleColor.Red);
            }
            else 
            {
                showText($"Число {n} просте число", ConsoleColor.Green);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            EH eh = new EH();

            eh.showText("Виберіть завдання:", ConsoleColor.White);
            eh.showText("[1] Завдання №1", ConsoleColor.Cyan);
            eh.showText("[2] Завдання №2", ConsoleColor.Green);
            eh.showText("[3] Завдання №3", ConsoleColor.Yellow);
            eh.showText("[4] Завдання №4", ConsoleColor.Blue);
            int menuM = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            switch (menuM)
            {
                case 1:
                    eh.NumberOne();
                    break;
                case 2:
                    eh.NumberTwo();
                    break;
                case 3:
                    eh.NumberThree();
                    break;
                case 4:
                    eh.NumberFour();
                    break;
                default:
                    eh.showText("Виберіть завдання:", ConsoleColor.White);
                    eh.showText("[1] Завдання №1", ConsoleColor.Cyan);
                    eh.showText("[2] Завдання №2", ConsoleColor.Green);
                    eh.showText("[3] Завдання №3", ConsoleColor.Yellow);
                    menuM = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    break;
            }
            Console.ReadLine();       
        }
    }
}
