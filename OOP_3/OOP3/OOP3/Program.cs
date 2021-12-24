using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public partial class Bus
    { 
     //Фамилия и инициалы водителя, 
     //Номер автобуса, Номер маршрута, Марка, Год начала эксплуатации, Пробег
     
        public string lastname;
        public string name, firstlettername;
        public string middlename, firstlettermiddlename; 
        public string brand;
        private readonly int id; 
        public int routenumber;
        public int mileage;
        public const int year = 2002;
        public int ages;
        private static int numberofbuses = 0;
        private int Busnumber;
        public int busnumber
        {
            get
            {
                return busnumber;
            }
            set
            {
                if (value < 0)
                    Console.WriteLine("Неверное значение номера");
                else
                    Busnumber = value;
            }
        }
       
        static Bus()
        {
            Console.WriteLine("Создан первый объект класса");
            Console.WriteLine();
        }
        
        public string Names()
        {
            firstlettermiddlename = middlename.Substring(0, 1);
            firstlettername = name.Substring(0, 1);
            return firstlettermiddlename;
           
        }
        public int age()
        {
            ages = 2021 - year;
            return ages;
        }
        
        public Bus()
        {
            
            lastname = "Лектер";
            firstlettername = "Г";
            firstlettermiddlename = "М";
            brand = "Hyundai";
            busnumber = 1;
            id = GetHashCode();
            routenumber = 2;
            mileage = 1890;
        }
        public Bus(string a, string b, string c, string d, int e, int f, int i)
        {
            Console.WriteLine();
            lastname = a;
            name = b;
            middlename = c;
            brand = d;
            busnumber = e;
            routenumber = f;
            mileage = i;
            id = GetHashCode();

        }
        public void Info()
        {
            Console.WriteLine($"Объект номер {++numberofbuses} создан");
            Console.WriteLine($"Водитель        {lastname} {firstlettername}.{firstlettermiddlename}.");
            Console.WriteLine($"Бренд   {brand} ");
            Console.WriteLine($"Номер автобуса   {Busnumber} ");
            Console.WriteLine($"Номер маршрута   {routenumber} ");
            Console.WriteLine($"Год начала эксплуатации   {year} ");
            Console.WriteLine($"Пробег   {mileage}");
            Console.WriteLine($"ID              {id} ");
            Console.WriteLine($" Возраст             {ages} ");
            Console.WriteLine("____________________________________");

        }
        public Bus(string a, string b, string c, int e, int f, int i)
        {
            Console.WriteLine();
            lastname = a;
            name = b;
            middlename = c;
            busnumber = e;
            routenumber = f;
            mileage = i;


        }
        public void Info1()
        {
            Console.WriteLine($"Объект номер {++numberofbuses} создан");
            Console.WriteLine($"Водитель        {lastname} {firstlettername}.{firstlettermiddlename}.");
            Console.WriteLine($"Номер автобуса   {Busnumber} ");
            Console.WriteLine($"ID              {id} ");
            Console.WriteLine($"Номер маршрута   {routenumber} ");
            Console.WriteLine("____________________________________");

        }
        public void ChangeVariable(ref int a, out int b)
        {
            b = a;//// обязательно нужно присвоить значение 
            //(если не присвоить будет ошибка компиляции)
            //Ключевое слово ref позволяет передавать аргумент 
            //(параметр) по ссылке, а не по значению. Если мы передаем 
            //параметр по ссылке, то этот параметр (переменную) можно 
            //изменить внутри метода, 
            //ref сообщает компилятору, что объект инициализируется до 
            //входа в функцию, в то время как out сообщает компилятору, 
            //что объект будет инициализирован внутри функции.
            a = -999;
        }

    }
    public class zadanie
        {
            private zadanie() { }
            public static string b = "private constructor";
        }
    class Program
    {
        static void Main(string[] args)
        {
            Bus First = new Bus();
            Console.WriteLine();
            First.age();
            First.Info();

            Bus[] arr = new Bus[2];
            arr[0] = new Bus("Грэм", "Уилл", "Д", "Ford", 2, 3, 15);
            arr[1] = new Bus("Кроуфорд", "Джек", "Л", "Kia", 3, 4, 163);
            arr[0].Names();
            arr[0].age();
            arr[0].Info();
            arr[1].age();
            arr[1].Names();
            arr[1].Info();

            Bus Four = new Bus();
            Four.lastname = "Зеллер";
            Four.name = "Брайан";
            Four.middlename = "А";
            Four.brand = "BMW";
            Four.busnumber = 2;
            Four.routenumber = 3;
            Four.mileage = 170;
            Four.age();
            Four.Names();
            Four.Info();
            Bus Five = new Bus();
            Five.lastname = "Прайс";
            Five.name = "Д";
            Five.middlename = "А";
            Five.brand = "BMW";
            Five.busnumber = 2;
            Five.routenumber = 2;
            Four.mileage = 170;
            Five.Names();
            Five.Info1();

            Console.WriteLine("Ганнибал==Брайан?  " + First.Equals(Four));
            Console.WriteLine("Type of Gannibal " + Four.GetType());
            Console.WriteLine(Four.GetHashCode());
            Console.WriteLine(Four.ToString() + "\n");

            Console.WriteLine(zadanie.b);
            Console.WriteLine();

            int a = 1, b;
            First.ChangeVariable(ref a, out b);
            Console.WriteLine($"a := {a}, b := {b}");

            Bus[] arr1 = new Bus[3];
            arr1[0] = new Bus("Колядко", "Яна", "Д", "Audi", 2, 3, 15);
            arr1[1] = new Bus("Машук", "Юля", "Л", "Жигуль", 3, 4, 163);
            arr1[2] = new Bus("Онежко", "Юлий", "Л", "Ford", 5, 1, 1603);
            Console.WriteLine("________________");
            Console.WriteLine("Автобус с номером маршрута 1:   |");
            Console.WriteLine("________________");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i].routenumber == 1)
                {
                    arr1[i].Names();
                    arr1[i].age();
                    arr1[i].Info();
                }
               


            }
            Console.WriteLine("________________");
            Console.WriteLine("Автобус с номером маршрута 2:   |");
            Console.WriteLine("________________");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i].routenumber == 2)
                {
                    arr1[i].Names();
                    arr1[i].age();
                    arr1[i].Info();
                }
               


            }
            Console.WriteLine("________________");
            Console.WriteLine("Автобус с номером маршрута 3:   |");
            Console.WriteLine("________________");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i].routenumber == 3)
                {
                    arr1[i].Names();
                    arr1[i].age();
                    arr1[i].Info();
                }

            }
            Console.WriteLine("________________");
            Console.WriteLine("Автобус с большим пробегом:   |");
            Console.WriteLine("________________");
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i].mileage>150)
                {
                    arr1[i].Names();
                    arr1[i].age();
                    arr1[i].Info();
                }

            }

            var bus4 = new { Name = "Чик-чирик", fl= "Д", flmn= "A",bn=2,rn=3, m=15 };
            Console.WriteLine(bus4.GetType().Name);
            Console.WriteLine($"Имя водителя {bus4.Name} {bus4.fl}.{bus4.flmn}.");
            Console.WriteLine($"Номер автобуса {bus4.bn}");
            Console.WriteLine($"Номер маршрута {bus4.rn}");
            Console.WriteLine($"пробег { bus4.m}");
        }
    }
}
