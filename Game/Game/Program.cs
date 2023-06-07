using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode; 
            Random random = new Random();
            int balance = 80;
            
            Console.WriteLine("Введіть ім'я:");
            string name = Convert.ToString(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"{name}, виберіть категорію:" +
                $"\n[1]Основні" +
                $"\n[2]Ігри" +
                $"\n[3]Бізнес" +
                $"\n[4]Клани");
            int category = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (category) 
            { 
                case 1:
                    Console.WriteLine($"{name}, основні команди:" +
                        $"\n[1]Профіль" +
                        $"\n[2]Рейтинг" +
                        $"\n[3]Продати рейтинг" +
                        $"\n[4]Баланс" +
                        $"\n[5]Інвертар" +
                        $"\n[6]Курс руди" +
                        $"\n[7]Банк" +
                        $"\n[8]Дать" +
                        $"\n[9]Біткоїни" +
                        $"\n[10]Щодений подарунок" +
                        $"\n[11]Змінити ім'я" +
                        $"\n[12]Статуси" +
                        $"\n[13]Енергія" +
                        $"\n[14]Шахта" +
                        $"\n[15]Машини" +
                        $"\n[16]Літаки" +
                        $"\n[17]Яхти" +
                        $"\n[18]Вертольоти" +
                        $"\n[19]Будинки" +
                        $"\n[20]Телефони");
                    break;
                case 2:
                    Console.WriteLine($"{name}, ігрові команди:" +
                        $"\n[1]Спін [ставка]" +
                        $"\n[2]Кубик [ставка]");
                    int gCommands = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    switch (gCommands) 
                    {
                        case 1:
                            Console.WriteLine("Введіть ставку для спіна:");
                            int spin = Convert.ToInt32(Console.ReadLine());

                            if (random.Next(0, 2) == 1)
                            {
                                Console.WriteLine($"Ви виграли {spin * 2}!");
                            }
                            else 
                            { 
                                Console.WriteLine("Ви програли!"); 
                            }
                            break; 
                        case 2:
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine($"{name}, команди бізнесу:" +
                        $"\n[1]Бізнес" +
                        $"\n[2]Майнинг ферма" +
                        $"\n[3]Сад");
                    break;
                case 4:
                    Console.WriteLine($"{name}, кланові команди:" +
                        $"");
                    break;
            }

            Console.ReadKey();
        }
    }
}
