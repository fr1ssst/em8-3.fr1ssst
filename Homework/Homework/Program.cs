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
        static public void showText(string text, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(text);

            Console.WriteLine();
        }
    }
    class Task
    {
        static int[] GenerateRandomArray()
        {
            Random random = new Random();
            int length = random.Next(5, 15);
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(1, 100);
            }

            return array;
        }
        static int GetSubarrayLength(int arrayLength)
        {
            Random random = new Random();
            int subarrayLength = random.Next(2, arrayLength / 2 + 1);
            return subarrayLength;
        }

        static List<int[]> CreateSubarrays(int[] array, int subarrayLength)
        {
            List<int[]> subarrays = new List<int[]>();

            for (int i = 0; i < array.Length; i += subarrayLength)
            {
                int[] subarray = new int[subarrayLength];
                Array.Copy(array, i, subarray, 0, subarrayLength);
                subarrays.Add(subarray);
            }

            return subarrays;
        }
        public void NumberOne()
        {
            Random rand = new Random();
            int smallest = Int32.MaxValue;
            int second_smallest = Int32.MaxValue;

            int number = MessageHelper.getInt("Якою довжиною буде масив?(Не менше 4)", ConsoleColor.Blue);
            if(number < 4) 
            {
                MessageHelper.showText("Помилка, масив менше 4 чисел", ConsoleColor.DarkRed);
            }
            else 
            {
                int[] arr = new int[number];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(10, 101);
                    Console.Write(arr[i] + " ");

                    if (arr[i] < smallest)
                    {
                        smallest = arr[i];
                    }
                    if (arr[i] < second_smallest && arr[i] > smallest)
                    {
                        second_smallest = arr[i];
                    }
                }
                Console.WriteLine();
                MessageHelper.showText($"Найменший елемент масиву: {smallest}", ConsoleColor.Cyan);
                MessageHelper.showText($"Другий найменший елемент масиву: {second_smallest}", ConsoleColor.Green);
            }           
        }
        public void NumberTwo()
        {   
            //генеруємо масив випадкових чисел
            int[] numbers = GenerateRandomArray();

            //визначаємо чи можна розбити масив на підмасиви однакової довжини
            int subarrayLength = GetSubarrayLength(numbers.Length);
            bool canBeDivided = numbers.Length % subarrayLength == 0;

            if (canBeDivided)//створюємо та заповнюємо підмасиви
            {
                List<int[]> subarrays = CreateSubarrays(numbers, subarrayLength);

                MessageHelper.showText($"Масив можна розділити на {subarrays.Count} підмасиви довжиною {subarrayLength}.", ConsoleColor.Green);
                MessageHelper.showText("Підмасиви:", ConsoleColor.Cyan);

                for (int i = 0; i < subarrays.Count; i++)
                {
                    MessageHelper.showText($"•Підмасив {i + 1}: {string.Join(", ", subarrays[i])}", ConsoleColor.Yellow);
                }
            }
            else
            {
                MessageHelper.showText("Масив не можна розділити на підмасиви однакової довжини.", ConsoleColor.DarkRed);
                return;
            }
            Console.ReadKey();
        }
        public void NumberThree()
        {
            Random random = new Random();

            int[] array = new int[100];
            int count = 1;
            int frequentNumber = array[0];

            for (int i = 0; i < (array.Length - 1); i++)
            {
                array[i] = random.Next(10, 101);
                Console.Write(array[i] + " ");

                int tempNumber = array[i];
                int tempCount = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (tempNumber == array[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Найчастіше число в цьому масиві {0} повторюється {1} разів", frequentNumber, count);
        }
        public void NumberFour()
        {
            
        }
    }
    internal class Program
    {      
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Random rand = new Random(); 

            Task task = new Task();

            MessageHelper.showText("Виберіть завдання:", ConsoleColor.White);
            MessageHelper.showText("[1] Завдання №1", ConsoleColor.Cyan);
            MessageHelper.showText("[2] Завдання №2", ConsoleColor.Green);
            MessageHelper.showText("[3] Завдання №3", ConsoleColor.Yellow);
            //MessageHelper.showText("[4] Завдання №4", ConsoleColor.Blue);
            MessageHelper.showText("[0] Вихід з програми", ConsoleColor.Red);
            int menuM = MessageHelper.getInt(null);

            Console.Clear();

            switch (menuM)
            {
                case 0:
                    MessageHelper.showText("Вихід із програми...", ConsoleColor.DarkRed);
                    Thread.Sleep(1000);
                    return;
                case 1:
                    MessageHelper.showText("Умова:" +
                        "\n1)Напишіть програму, яка генерує масив " +
                        "двозначних випадкових чисел і виводить друге " +
                        "найменше число зі списку.", ConsoleColor.Gray);
                    task.NumberOne();
                    break;
                case 2:
                    MessageHelper.showText("Умова:" +
                        "\n2) Напишіть програму, яка генерує масив випадкових  " +
                        "чисел, випадкової довжини після цього визначає, " +
                        "чи можна розділити масив на підмасиви, такі що " +
                        "кількість елементів у кожному підмасиві була " +
                        "однакова. Після цього створює такі масиви, " +
                        "заповнює їх числами з першого масиву та виводить " +
                        "інформацію про те скільки масивів було створено.", ConsoleColor.Gray);
                    task.NumberTwo();
                    break;
                case 3:
                    MessageHelper.showText("Умова:" +
                        "\n3)Напишіть програму, яка генерує масив випадкових " +
                        "чисел довжиною в 100 елементів і знаходить число " +
                        "яке найчастіше зустрічається.", ConsoleColor.Gray);
                    task.NumberThree();
                    break;
                /*case 4:
                    MessageHelper.showText("Умова:" +
                        "\n4)", ConsoleColor.Gray);
                    task.NumberFour();
                    break;*/
                default:
                    MessageHelper.showText("Виберіть завдання:", ConsoleColor.White);
                    MessageHelper.showText("[1] Завдання №1", ConsoleColor.Cyan);
                    MessageHelper.showText("[2] Завдання №2", ConsoleColor.Green);
                    MessageHelper.showText("[3] Завдання №3", ConsoleColor.Yellow);
                    //MessageHelper.showText("[4] Завдання №4", ConsoleColor.Blue);
                    MessageHelper.showText("[0] Вихід з програми", ConsoleColor.Red);
                    menuM = MessageHelper.getInt("");


                    Console.Clear();
                    break;
            }
            Console.ReadKey();
        }
    }
}
