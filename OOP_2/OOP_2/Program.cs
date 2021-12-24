using System;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace OOP_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // types();
            //strings();
            //massivs();
            //cortez();
            /*Формальные параметры функции – массив целых и строка. Функция должна вернуть кортеж, 
             * содержащий: максимальный и минимальный элементы массива, 
             * сумму элементов массива и первую букву строки .*/

            //(int max, int min, int sum, char firstLetter) tuple;
            //int[] massiv = { 1, 2, 3, 4, 5, 7, 0, 8};
            //string name = "Eugene";
            //tuple = task5(massiv, name);
            //Console.WriteLine("Max число:"+tuple.max+"\n");
            //Console.WriteLine("Min число:"+tuple.min+"\n");
            //Console.WriteLine("Сумма:элементов" + tuple.sum + "\n");
            //Console.WriteLine("Первая буква: "+tuple.firstLetter);
            t6_checked();
            t6_unchecked();


        }
        static void types()
        {
            bool boolVariable = true;
            Console.WriteLine("[true - false] bool variable = " + boolVariable);

            byte byteVariable = 17;
            Console.WriteLine("[0 - 255] byte variable = " + byteVariable);

            sbyte sbyteVariable = 7;
            Console.WriteLine("[-128 - 127] sbyte variable= " + sbyteVariable);

            char charVariable = 'E';
            Console.WriteLine("[16 bit] char variable = " + charVariable);

            decimal decimalVariable = 122222222.22213345123m;
            Console.WriteLine("[16 bytes](29 знаков) decimal variable = " + decimalVariable);

            double doubleVariable = 12.3213123;
            Console.WriteLine("[8 bytes] double variable = " + doubleVariable);

            float floatVariable = (float)3.4;
            Console.WriteLine("[4 bytes] float variable = " + floatVariable);

            int intVariable = 123123123;
            Console.WriteLine("[32 bit][-2,147,483,648-2,147,483,648] int variable= " + intVariable);

            uint unitVariable = 11111111;
            Console.WriteLine("[unsigned 32 bit][0-2,147,483,648] uint variable = " + unitVariable);

            long longVariable = 91918191919;
            Console.WriteLine("[64 bit][-9,223,372,036,854,775,808-9,223,372,036,854,775,808] long variable = " + longVariable);

            ulong ulongVariable = 83172377124;
            Console.WriteLine("[unsigned 64 bit][0-18,446,744,073,709,551,615] ulong variable = " + ulongVariable);

            short shortVariable = 12312;
            Console.WriteLine("[16 bit][-32,767-32,767] short variable = " + shortVariable);

            ushort ushortVariable = 12121;
            Console.WriteLine("[unsigned 16 bit][0-65,535] ushort variable = " + ushortVariable);

            Console.WriteLine("Enter a string type... :");
            string n = Console.ReadLine();
            Console.WriteLine("[string] You'r string is : " + n);
            //---------------------------------------------------------------------------------------------------------//
            // неявное привидение типов
            //byte->short, int ,long
            //short->int, long
            //int->long
            //float->double
            //double->все типы
            byte b = 7;
            short s = b;
            int i = b;
            long l = b;
            double d = 17.17;
            double d2 = d + i;

            //Явное приведение типов
            //Оператор, который делает это называется cast
            //в круглых скобках перед переменной указывается тип данных, 
            //к которому эта переменная должна преобразовывается.
            byte transform = 17;
            Console.WriteLine("[byte] " + transform + " -- to int --> " + (int)transform);
            Console.WriteLine("[int] " + (int)transform + " -- to long --> " + (long)transform);
            Console.WriteLine("[byte] " + transform + " -- to double --> " + (double)transform);
            Console.WriteLine("[double] " + (double)transform + " -- to float --> " + (float)transform);
            Console.WriteLine("[byte] " + transform + " -- to ulong --> " + (ulong)transform);

            //Существует ещё один способ преобразования данных с помощью 
            //класса Convert, в котором есть много статических методов (с префиксом To)
            short s1 = 45;
            byte b1 = Convert.ToByte(s1);
            Console.WriteLine("Byte = " + b1);
            //---------------------------------------------------------------------------------------------------------//
            // Упаковка-преобразование и распаковка-преобразование
            //Упаковка представляет собой процесс преобразования типа значения в тип object или в любой другой тип 
            // интерфейса, реализуемый этим типом значения. Когда тип значения упаковывается общеязыковой средой 
            // выполнения (CLR), он инкапсулирует значение внутри экземпляра System.Object и сохраняет его в управляемой куче. 
            //Операция распаковки извлекает тип значения из объекта.Упаковка является неявной; распаковка является явной
            //Понятия упаковки и распаковки лежат в основе единой  системы типов C#, в которой значение любого типа можно 
            // рассматривать как объект.


            //упаковка
            int number = 5;
            object pack = number;
            // упаковку можно выполнить явно
            //pack=(object)number;

            // распаковка
            pack = 3;
            number = (int)pack;
            //---------------------------------------------------------------------------------------------------------//
            var i2 = 6;
            //i2 компилируется как int

            var s2 = "Hello World";
            //компилируется как string 

            var b3 = true;
            //компилируется как bool

            //опрерация с неявно типизированной переменной
            if (b3) Console.WriteLine(s2);
            //---------------------------------------------------------------------------------------------------------//
            // Nullable
            /* Если после типа переменной поставить ?
             * то это означает что эта переменная может
             * принимат значение null;
             */
            int? null1 = null; // запись int a = null будет ругаться
            int? null2 = null;
            if (null1 == null2)
                Console.WriteLine("равны");
            else
                Console.WriteLine("не равны");
            //---------------------------------------------------------------------------------------------------------//
            /* 
             * var mistake = 123;
             * mistake = 23.32;
             * 
             *  При инициализации в первой строке, она получает тип int и уже остаётся int
             *и неявное привидение к другому типу не будет выполнено
            */
        }
        static void strings()
        {
            //Литералы представляют неизменяемые значения
            //Строковые литералы представляют строки. 
            //Строки заключаются в двойные кавычки:
            string string1 = "Привет";
            string string2 = "Hello";
            if (string1 == string2)
            {
                Console.WriteLine("Строки равны");
            }
            else
            {
                Console.WriteLine("Строки не равны");
            }
            //---------------------------------------------------------------------------------------------------------//
            string str1 = "Привет";
            string str2 = "Как дела?";
            string str3 = "Пока";
            Console.WriteLine(str1 + str2);// сцепление
            Console.WriteLine(String.Concat(str1, str2));//сцепление

            string str4 = str3;// копирование
            Console.WriteLine(str4);
            string str5;
            str5 = String.Copy(str2);//копирование
            Console.WriteLine(str5);

            string word = str2.Substring(0, 3); // выделение подстроки и её копирование
            Console.WriteLine(word);

            string[] words = str2.Split(); // разделение строки на слова
            Console.WriteLine(words[1]);

            //вставка в определенную позицию
            string m = "Приветик, ";
            string n = "пистолетик";
            Console.WriteLine(m.Insert(m.Length, n));

            //удаление
            Console.WriteLine(str2.Remove(3));

            //интерполирование строк.
            //Знак доллара перед строкой указывает, 
            //что будет осуществляться интерполяция строк.
            Console.WriteLine($"Приветики- {n}");
            //---------------------------------------------------------------------------------------------------------//
            //Это удобный метод, позволяющий одновременно проверить, 
            //является ли String null значение значением или String.Empty
            string st6 = null;
            string st7 = "";
            if (string.IsNullOrEmpty(st6) && string.IsNullOrEmpty(st7))
            {
                Console.WriteLine("Обе строки пусты или нулевые");
            }
            //---------------------------------------------------------------------------------------------------------//
            StringBuilder sb = new StringBuilder("Котики");
            sb.Remove(0, 2);
            sb.Insert(4, "Ко");
            Console.WriteLine(sb);

        }
        static void massivs()
        {
            int[,] massiv = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{massiv[i, j]}\t");
                }
                Console.Write("\n");
            }
            //---------------------------------------------------------------------------------------------------------//
            string[] str_massiv = { "Привет", "Как дела?", "Пока" };
            for (int i = 0; i < str_massiv.Length; i++)
                Console.WriteLine($"[{i}]. {str_massiv[i]}");
            Console.WriteLine();
            Console.WriteLine("длина массива строк: " + str_massiv.Length);
            Console.WriteLine("Выберите номер строки, которую хотите заменить: ");
            int a = System.Convert.ToInt32(Console.ReadLine());

            if (a < str_massiv.Length)
            {
                Console.WriteLine("Напишите замену сторчки " + a + ":");
                string zamen = Console.ReadLine();
                str_massiv[a] = zamen;
                for (int i = 0; i < str_massiv.Length; i++)
                    Console.WriteLine($"[{i}]. {str_massiv[i]}");
            }
            else Console.WriteLine("Вы ввели неправильное число");
            //---------------------------------------------------------------------------------------------------------//
            byte size = 4;
            int[][] array = new int[size][];

            for (int i = 0; i < size; i++)
            {
                array[i] = new int[i + 1];
                Console.WriteLine($"заполните массив {i} из {size - 1}");
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}\t");
                }
                Console.Write("\n");
            }
            //---------------------------------------------------------------------------------------------------------//
            var neav = new[] { 1, 10, 100, 1000 }; // int[]
            var neav2 = new[] { "hello", null, "world" }; // string[]
        }
        static void cortez()
        {
            (int, string, char, string, ulong) cort = (1, "Hello", 'B', "World", 1515151515851515);
            Console.Write("Кортеж" + cort);
            Console.Write("\n");
            //---------------------------------------------------------------------------------------------------------//
            Console.Write("Кортеж 1 объект: " + cort.Item1 + "; Кортеж 3 объект: " + cort.Item3 + "; Кортеж 4 объект: " + cort.Item4);
            //---------------------------------------------------------------------------------------------------------//
            string name;
            int age;
            (string name, ushort age) me = ("Eugene AliMake", 19);
            name = me.name;
            age = me.age;
            (name, _) = Return();
            Console.Write("\n");
            Console.WriteLine(me == ("Eugene AliMake", 18));
            Console.WriteLine(me == ("Eugene AliMake", 19));
        }
        static (string, ushort) Return() // return info (string name, ushort age)
        {
            return ("Nikita", 7);
        }
        static (int max, int min, int sum, char firstLetter)task5(int[] a, string str)
        { 
            if ((a is null || a.Length == 0) || (str is null || str.Length == 0))
            {
                throw new ArgumentException("Нет значений");
            }
            int min = int.MaxValue;//присваивание самого максимального значения типа int
            int max = int.MinValue;//присваивание самого минимального значения типа int
            int sum = 0;
            foreach (int i in a)//перебор массива
            { sum += i;
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }
            char letter = str[0];
            return (max, min, sum, letter);
        }
        static void t6_checked()
        {
            checked //Ключевое слово checked используется для явного включения 
            //проверки переполнения при выполнении арифметических операций
            //и преобразований с данными целого типа.
            {
                int l = int.MaxValue;
                Console.WriteLine(l);
            }
        }

        static void t6_unchecked()
        {
            unchecked
            {
                int o = int.MaxValue + 1;
                Console.WriteLine(o);
            }
        }
    }
}
