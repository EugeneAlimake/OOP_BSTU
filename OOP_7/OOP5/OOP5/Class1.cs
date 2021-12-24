using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace OOP5
{
    //СТРУКТУРА 
    struct Balls
    {
        public int number;
        public string type;
        public int state;

        public int State
        {
            get => state;
            set => state = (value <= 100) ? value : 100;
        }

        public Balls(int Number, string Type)
        {
            number = Number;
            type = Type;
            state = 100;
        }
    }

    partial class Bools
    {
        private Balls chooses;
        private Balls Basketball = new Balls(1, "баскетбольный");
        private Balls Voleball = new Balls(1, "волебольный");
        private Balls Tennicball = new Balls(1, "тенисный");

        //ПЕРЕЧИСЛЕНИЕ
        public enum Enumeration
        {
            B = 1, V, T
        }

        public void Choese(Enumeration numbr)
        {
            switch (numbr)
            {
                case Enumeration.B:
                    chooses = Basketball;
                    Console.WriteLine("Вы выбрали баскетбольный мяч");
                    break;

                case Enumeration.V:
                    chooses = Voleball;
                    Console.WriteLine("Вы выбрали волейбольный мяч");
                    break;

                case Enumeration.T:
                    chooses = Tennicball;
                    Console.WriteLine("Вы выбрали теннисный мяч");
                    break;

                default:
                    Console.WriteLine("Таких мячей нет");
                    break;
            }
        }
    }
    //КОНТЕЙНЕР
    //хранит разные типы объктов в виде списка
    class Gym
    {
        private readonly List<Gum> ListGym;

        public List<Gum> GetList     ///св-во
        {
            get => ListGym;
        }

        public Gym()                        ///к-р
        {
            ListGym = new List<Gum>();
        }

        public Gym(Gum obj)          ///к-р
        {
            ListGym.Add(obj);
        }

        public void Add(Gum obj)     ///метод
        {
            ListGym.Add(obj);
        }

        public bool Delete(int index)
        {
            if (ListGym.Count < index)
            {
                throw new DeleteException($"Элемент не удален может быть удален, так как его не существует.\n" +
                    $"Текущий размер списка {ListGym.Count} элементов\n" +
                    $"Вы выбрали {index}.");
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"элемент {index} удален.");
            ListGym.RemoveAt(index);
            return true;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("~~~~~~~~С П И С О К~~~~~~~~~");

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var i in ListGym)
            {
                Console.WriteLine(i);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    class Control : IEnumerable
    {
        private List<Snarads> ListSnarads;
        int kash;
        string path = @"C:\Users\thesi\Desktop\3 семестр\мое\c#\6\OOP5\OOP5\mau.txt";
        public Control()
        {

        }
        public Control(int money)
        {
            Console.WriteLine($"В бюджете имеется {money}");
            kash = money;
            ListSnarads = new List<Snarads>();
        }
        public void Readfromfile()
        {
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    int nuberses = Convert.ToInt32(line);
                    ListSnarads.Add(new Snarads(nuberses));
                }
            }
        }
        public void json()
        {
            List<Book> book;
            string file = @"C:\Users\thesi\Desktop\3 семестр\мое\c#\6\OOP5\OOP5\version.json";
            string jsonString;
            using (StreamReader sr = new StreamReader(file))
            {
                jsonString = sr.ReadToEnd();
                book = JsonConvert.DeserializeObject<List<Book>>(jsonString);

            }

            foreach (var item in book)
            {
                item.Show();
            }
        }
        public void Sort()
        {
            ListSnarads.Sort();
        }
        public void Add(Snarads obj)
        {
            if (kash >= obj.sell)
            {
                ListSnarads.Add(obj);
                kash = kash - obj.sell;
            }
            else
            {
                int value = kash - obj.sell;
                throw new KashException($"Недостаточно бюджета\n" +
                   $"Ваш бюджет равен {kash}. " +
                   $"А цена снарядов {obj.sell}\n" +
                   $"Вам не хватает {Math.Abs(value)}");
            }
        }
        public void Show()
        {
            foreach (var i in ListSnarads)
            {

                Console.WriteLine($"{i.numbers}                     {i.sell}");
            }
        }
        public IEnumerator GetEnumerator()
        {
            return ListSnarads.GetEnumerator();
        }
        public void between(int a, int b)           ///метод(снаряды в пределах $)
        {
            var tempList = from shell in ListSnarads
                           where a <= shell.sell && b >= shell.sell
                           select shell;
            ListSnarads = tempList.ToList();
        }
    }
    public class Snarads : IComparable, ICloneable
    {

        public int numbers;
        int Sell;
        const int max = 100;

        public Snarads(int nm)
        {
            numbers = nm;
            Sell = numbers * 10;
        }
        public int CompareTo(object obj)
        {
            Snarads shells = (Snarads)obj;
            if (sell > shells.sell) return 1;
            if (sell < shells.sell) return -1;
            return 0;
        }
        public object Clone() => MemberwiseClone();
        public int sell
        {
            get => Sell;
            set
            {
                if (value < 0)
                    Console.WriteLine("Неверное значение");
                else
                    Sell = value;
            }
        }
        public int Number
        {
            get => numbers;
            set => numbers = value <= max ? value : throw new MaxException($"Ваше значение {value},что больше 100");
        }

    }
    public class Book
    {
        public string book;
        public int numberes;
        public string author;
        public void Show()
        {
            Console.WriteLine($"Название{book} Количество страниц {numberes}");

        }
    }

}
