using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Homework
{
    class MessageHelper
    {
        static public string getString(string message)
        {
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
    //////////////////////////////////////////////////////////////////////////
    class Figur 
    {
        protected double height = 0;
        protected double width = 0;
        protected double length = 0;
        protected int radius = 0;
        protected int diameter = 0;
        public Figur(double height, double width, double length, int radius, int diameter)
        {
            this.length = length;
            this.width = width;
            this.height = height;
            this.radius = radius;
        }
    }
    class Rectangle : Figur
    {
        public Rectangle(double length, double width) : base(0, width, length, 0, 0)
        {
            this.length = length;
            this.width = width;
        }
        public void AreaRectangle()
        {
            MessageHelper.showText("Добре будемо обчислювати площу");
            MessageHelper.showText("Формула для обчислення площі прямокутника:" +
                "\nS = a * b");
            length = MessageHelper.getDouble("Введіть довжину прямокутника в см:");
            width = MessageHelper.getDouble("Введіть ширину прямокутника в см:");
            MessageHelper.showText($"Площа прямокутника:" +
                $"\nS = {length} * {width}" +
                $"\nS = {length * width}");
        }
        public void PerimeterRectangle()
        {
            MessageHelper.showText("Добре будемо обчислювати периметр");
            MessageHelper.showText("Формула для обчислення периметр прямокутника:" +
                "\nP = 2 * (a + b)");
            length = MessageHelper.getDouble("Введіть довжину прямокутника в см:");
            width = MessageHelper.getDouble("Введіть ширину прямокутника в см:");
            MessageHelper.showText($"Периметр прямокутника:" +
                $"\nP = 2 * ({length} + {width})" +
                $"\nP = {2 * (length + width)}");
        }
    }
    class Circle : Figur
    {
        public Circle(int radius, int diameter, int length) : base(0, 0, length, radius,diameter)
        {
            this.radius = radius;
            this.diameter = diameter;
            this.length = length;
        }
        public void AreaCircle()
        {
            MessageHelper.showText("Добре будемо обчислювати площу");
            MessageHelper.showText("Формула для обчислення площі кола:" +
                "\nS = π * r ^ 2");
            radius = MessageHelper.getInt("Введіть радіус кола в см:");
            MessageHelper.showText($"Площа кола:" +
                $"\nS = π * {radius} ^ 2" +
                $"\nS = {radius ^ 2}π");
        }
        public void DiameterCircle()
        {
            MessageHelper.showText("Добре будемо обчислювати діаметр");
            MessageHelper.showText("Формула для обчислення діаметра кола:" +
                "\nD = 2 * r");
            radius = MessageHelper.getInt("Введіть радіус кола в см:");
            MessageHelper.showText($"Діаметр кола:" +
                $"\nD = 2 * {radius}" +
                $"\nD = {2 * radius}");
        }
        public void RadiusCircle()
        {
            MessageHelper.showText("Добре будемо обчислювати радіус");
            MessageHelper.showText("Формула для обчислення радіуса кола:" +
                "\nr = D / 2");
            diameter = MessageHelper.getInt("Введіть діметр кола в см:");
            MessageHelper.showText($"Радіус кола:" +
                $"\nr = {diameter} / 2" +
                $"\nr = {diameter / 2}");
        }
        public void LengthCircle()
        {
            MessageHelper.showText("Добре будемо обчислювати довжину");
            MessageHelper.showText("Формула для обчислення довжини кола:" +
                "\nС = 2 * π * r");
            radius = MessageHelper.getInt("Введіть радіус кола в см:");
            MessageHelper.showText($"Радіус кола:" +
                $"\nC = 2 * π * {radius}" +
                $"\nС = {2 * radius}π");
        }
    }
    class Trapeze : Figur
    {
        public Trapeze() : base(0, 0, 0, 0, 0)
        {

        }
    }
    class Square : Figur
    {
        public Square(double length, double width) : base(0, length, width, 0, 0)
        {
            this.length = length;
            this.width = width;
        }
    }
    //////////////////////////////////////////////////////////////////////////
    class Car
    {
        private Engine motor = null;

        protected string brand = "";
        protected string model = "";
        protected int graduationYear = 0;
        protected string engineInfo = "";
        protected int length = 0;
        protected int width = 0;
        protected int height = 0;
        protected int mas = 0;
        public Car(string brand, string model, int graduationYear, string engineInfo,
            int length, int width, int height, int mas, Engine motor) 
        {
            this.brand = brand;
            this.model = model;
            this.graduationYear = graduationYear;
            this.engineInfo = engineInfo;
            this.length = length;
            this.width = width;
            this.height = height;
            this.mas = mas;

            this.motor = motor;
        }
        //set, get functions
        public void setBrand(string brand) => this.brand = brand;
        public string getBrand() => this.brand;
        public void setModel(string model) => this.model = model;
        public string getModel() => this.model;
        public void setGYl(int graduationYear) => this.graduationYear = graduationYear;
        public int getGY() => this.graduationYear;
        public void setEI(string engineInfo) => this.engineInfo = engineInfo;
        public string getEI() => this.engineInfo;
        public void setLength(int length) => this.length = length;
        public int getLength() => this.length;
        public void setWidth(int width) => this.width = width;
        public int getWidth() => this.width;
        public void setHeight(int height) => this.height = height;
        public int getHeight() => this.height;
        public void setMas(int mas) => this.mas = mas;
        public int getMas() => this.mas; 
        public void showInfoCars()
        { 
            MessageHelper.showText("=======ПРО МАШИНУ=======");
            MessageHelper.showText($"Модель: {model}", ConsoleColor.Yellow);
            MessageHelper.showText($"Бренд: {brand}", ConsoleColor.DarkYellow);
            MessageHelper.showText($"Рік випуску: {graduationYear}", ConsoleColor.Blue);
            MessageHelper.showText($"Двигун: {engineInfo}", ConsoleColor.Cyan);
            MessageHelper.showText($"Довжина: {length} мм", ConsoleColor.DarkGreen);
            MessageHelper.showText($"Ширина: {width} мм", ConsoleColor.DarkBlue);
            MessageHelper.showText($"Висота: {height} мм", ConsoleColor.Green);
            MessageHelper.showText($"Маса: {mas} кілограмів", ConsoleColor.DarkCyan);

            MessageHelper.showText($"=======ПРО ДВИГУН=======");
            MessageHelper.showText($"Сила: {motor.getPower()} к.с.", ConsoleColor.Magenta);
            MessageHelper.showText($"Об'єм: {motor.getVolume()} літри", ConsoleColor.DarkMagenta);
        }  
    }
    class Engine
    {
        Random random = new Random();
        protected int power = 0;
        protected double volume = 0;
        public Engine(int power, int volume)
        {
            this.power = power;
            this.volume = volume;
        }
        //set, get functions
        public void setPower(int power) => this.power = power;
        public int getPower() => this.power;
        public void setVolume(double volume) => this.volume = volume;
        public double getVolume() => this.volume;
    }
    class Sedan : Car
    {
        public Sedan(string brand, string model, int graduationYear, string engineInfo,
            int length, int width, int height, int mas, Engine motor) : base(brand, 
            model, graduationYear, engineInfo,
            length, width, height, mas, motor)
        {
            this.brand = brand;
            this.model = model;
            this.graduationYear = graduationYear;
            this.engineInfo = engineInfo;
            this.length = length;
            this.width = width;
            this.height = height;
            this.mas = mas;
        }
    }
    class Truck : Car
    {
        public Truck(string brand, string model, int graduationYear, string engineInfo,
            int length, int width, int height, int mas, Engine motor) : base(brand,
            model, graduationYear, engineInfo,
            length, width, height, mas, motor)
        {
            this.brand = brand;
            this.model = model;
            this.graduationYear = graduationYear;
            this.engineInfo = engineInfo;
            this.length = length;
            this.width = width;
            this.height = height;
            this.mas = mas;
        }
    }
    class Pickup : Car
    {
        public Pickup(string brand, string model, int graduationYear, string engineInfo,
            int length, int width, int height, int mas, Engine motor) : base(brand,
            model, graduationYear, engineInfo,
            length, width, height, mas, motor)
        {
            this.brand = brand;
            this.model = model;
            this.graduationYear = graduationYear;
            this.engineInfo = engineInfo;
            this.length = length;
            this.width = width;
            this.height = height;
            this.mas = mas;
        }
    }
    //////////////////////////////////////////////////////////////////////////
    class Task
    {      
        public void NumberOne()
        {
            Engine L1KD_FTV = new Engine(173, 3);
            Engine _2JZ_GTE = new Engine(330, 3);
            Engine v8 = new Engine(560, 4);
            Engine v8_R730 = new Engine(537, 16);
            Engine p6_Turbo = new Engine(387, 3);
            Engine electro = new Engine(0, 0);

            MessageHelper.showText("[1]Седан", ConsoleColor.Blue);
            MessageHelper.showText("[2]Грузовик", ConsoleColor.DarkGreen);
            MessageHelper.showText("[3]Пікап", ConsoleColor.Cyan);
            MessageHelper.showText("Виберіть клас машини:", ConsoleColor.Magenta);
            int menuNO = MessageHelper.getInt(null);
            Console.Clear();
            if (menuNO == 1)
            {
                Sedan audi_rs7 = new Sedan("Audi", "Audi RS7", 2023, "Бензиновий двигун",
                    5012, 2139, 1419, 2020, v8);
                Sedan supra_mk5 = new Sedan("Toyota", "GR Supra", 2023, "Бензиновий двигун",
                    4378, 1853, 1292, 1541, _2JZ_GTE);

                MessageHelper.showText("===Ви вибрали клас машини седан===", ConsoleColor.Blue);
                audi_rs7.showInfoCars();
                MessageHelper.showText("===================================", ConsoleColor.White);
                supra_mk5.showInfoCars();
            }
            else if (menuNO == 2)
            {
                Truck scania_r450 = new Truck("Scania", "Scania R450", 2017, "Дизельний двигун",
                10000, 2450, 2890, 5230, v8_R730);

                MessageHelper.showText("===Ви вибрали клас машини грузовик===", ConsoleColor.Cyan);
                scania_r450.showInfoCars();
            }
            else if (menuNO == 3)
            {
                Pickup hi_Lux7 = new Pickup("Toyota", "Hi-Lux 7", 2004, "Бензиновий двигун",
                4975, 1760, 1795, 2730, L1KD_FTV);

                Pickup Ford_F150_Lightning = new Pickup("Ford Motor Company", "Ford F-150 Lightning",
                    2022, "Електродвигун", 5910, 2030, 2004, 2948, electro);

                MessageHelper.showText("===Ви вибрали клас машини пікап===", ConsoleColor.Cyan);
                hi_Lux7.showInfoCars();
                MessageHelper.showText("===================================", ConsoleColor.White);
                Ford_F150_Lightning.showInfoCars();
            }
            else
            {
                MessageHelper.showText("Помилка! Такої функції не має!", ConsoleColor.DarkRed);
                return;
            }
        }
        public void NumberTwo()
        {
            MessageHelper.showText("Виберіть фігуру з якою хочете працювати:");
            MessageHelper.showText("[1]Прямокутник");
            MessageHelper.showText("[2]Квадрат");
            MessageHelper.showText("[3]Трапеція");
            MessageHelper.showText("[4]Коло");
            int change_f = MessageHelper.getInt(null);
            
            Console.Clear();
            switch(change_f) 
            { 
                case 1:
                    Rectangle rectangle = new Rectangle();

                    MessageHelper.showText("Що будемо обчислювати?");
                    MessageHelper.showText("[1]Площу");
                    MessageHelper.showText("[2]Периметр");
                    int r = MessageHelper.getInt(null);
                    Console.Clear();

                    if(r == 1) 
                    {
                        rectangle.AreaRectangle();
                    }
                    else if(r == 2) 
                    {
                       rectangle.PerimeterRectangle();
                    }
                    else 
                    {
                        MessageHelper.showText("Помилка! Такої функції не має!", ConsoleColor.DarkRed);
                        return;
                    }    
                    break;
                case 2:
                    Square square = new Square();
                    break;
                case 3:
                    break;
                case 4:
                    Circle circle = new Circle();

                    MessageHelper.showText("Що будемо обчислювати?");
                    MessageHelper.showText("[1]Площу");
                    MessageHelper.showText("[2]Радіус");
                    MessageHelper.showText("[3]Діаметр");
                    MessageHelper.showText("[4]Довжину");
                    int s = MessageHelper.getInt(null);
                    Console.Clear();

                    if (s == 1)
                    {
                        circle.AreaCircle();
                    }
                    else if (s == 2)
                    {
                        circle.RadiusCircle();
                    }
                    else if (s == 3)
                    {
                        circle.DiameterCircle();
                    }
                    else if (s == 4)
                    {
                        circle.LengthCircle();
                    }
                    else
                    {
                        MessageHelper.showText("Помилка! Такої функції не має!", ConsoleColor.DarkRed);
                        return;
                    }
                    break;
                default:
                    MessageHelper.showText("Помилка! Такої функції не має!", ConsoleColor.DarkRed);
                    return;
            }
        }
        public void NumberThree()
        {
            
        }
        public void NumberFour()
        {
            
        }
    }
    //////////////////////////////////////////////////////////////////////////
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
            //MessageHelper.showText("[3] Завдання №3", ConsoleColor.Yellow);
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
                        "\n1) Створіть клас Автомобіль, " +
                        "в якому є характеристики марка, модель і " +
                        "рік випуску та в ньому має зберігатись клас " +
                        "Двигун. " +
                        "Створіть підкласи Седан, Вантажівка та Пікап, які " +
                        "наслідуються від класу Автомобіль. " +
                        "Клас  Двигун має у себе характеристики потужність " +
                        "та об’єм. Створити до характеристик гетери " +
                        "та сетери. У кожного класу-дитини створити " +
                        "свої додаткові властивості та методи на ваш " +
                        "розсуд. Напишіть програму, яка створює об'єкти " +
                        "цих класів та викликає їх методи.", ConsoleColor.Gray);
                    task.NumberOne();
                    break;
                case 2:
                    MessageHelper.showText("Створіть клас Фігура, від якого " +
                        "успадковуються підкласи Прямокутник, Квадрат, Трапеція та Коло." +
                        " Кожен з цих підкласів має свої " +
                        "властивості(параметри висоти/ширини/довжини/радіуса) та " +
                        "методи для обчислення площі та периметра фігури. " +
                        "Реалізуйте ці класи та напишіть програму, в якій користувач " +
                        "може вибрати фігуру з якою хоче працювати та може ввести " +
                        "необхідні параметри фігур та вибрати яку із формул він " +
                        "хоче використати.\r\n", ConsoleColor.Gray);
                    task.NumberTwo();
                    break;
                /*case 3:
                    MessageHelper.showText("Умова:" +
                        "\n3)Напишіть програму, яка генерує масив випадкових " +
                        "чисел довжиною в 100 елементів і знаходить число " +
                        "яке найчастіше зустрічається.", ConsoleColor.Gray);
                    task.NumberThree();
                    break;
                case 4:
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