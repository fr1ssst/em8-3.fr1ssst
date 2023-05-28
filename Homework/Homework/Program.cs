using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework
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
        }
        public void NumberTwo()
        {
            mh = new MessageHelper();
        }
        public void NumberThree()
        {
            mh = new MessageHelper();
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
            mh.showText("[4] Завдання №4", ConsoleColor.Blue);
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
                        "\n1)", ConsoleColor.Gray);
                    task.NumberOne();
                    break;
                case 2:
                    mh.showText("Умова:" +
                        "\n2)", ConsoleColor.Gray);
                    task.NumberTwo();
                    break;
                case 3:
                    mh.showText("Умова:" +
                        "\n3)", ConsoleColor.Gray);
                    task.NumberThree();
                    break;
                case 4:
                   mh.showText("Умова:" +
                        "\n4)", ConsoleColor.Gray);
                    task.NumberFour();
                    break;
                default:
                    mh.showText("Виберіть завдання:", ConsoleColor.White);
                    mh.showText("[1] Завдання №1", ConsoleColor.Cyan);
                    mh.showText("[2] Завдання №2", ConsoleColor.Green);
                    mh.showText("[3] Завдання №3", ConsoleColor.Yellow);
                    mh.showText("[4] Завдання №4", ConsoleColor.Blue);
                    mh.showText("[0] Вихід з програми", ConsoleColor.Red);
                    menuM = MessageHelper.getInt("");


                    Console.Clear();
                    break;
            }
            Console.ReadLine();
        }
    }
}
