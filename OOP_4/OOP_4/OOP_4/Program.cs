using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Massiv arr1 = new Massiv(2);
            //Console.WriteLine(Date);
            Console.WriteLine("Введите числа для двух массивов:");
            Console.ResetColor();
            for (int i = 0; i < arr1.Index; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Massiv arr2 = new Massiv(2);
            for (int i = 0; i < arr2.Index; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
           
            arr1.Show();
            Console.WriteLine();
            arr2.Show();
            Console.WriteLine();

            Massiv arr3 = new Massiv(5);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~ Перегрузка оператора - ~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            arr3 = arr1 - arr2;         //перегрузка -
            arr3.Show();
            Console.WriteLine();

            Massiv arr4 = new Massiv(20);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~ Перегрузка оператора + ~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            arr4 = arr1 + arr2;         //перегрузка +
            arr4.Show();
            Console.WriteLine();

            int num, vhod;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~ Перегрузка оператора > и != ~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Введите число");
            Console.ResetColor();
            num = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            vhod = arr1 > num;                  //перегрузка >
            if (vhod == 1)
                Console.WriteLine("число входит в arr1");
            else
                Console.WriteLine("число не входит в arr1");
            if (arr1 != arr2)                       //перегрузка !=
                Console.WriteLine(" Arr1 != Arr2");
            else
                Console.WriteLine("Arr1 == Arr2");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~ Удаление гласных ~~~~~~~~~~~~~~~~~~");
            string str = "Кусьмяу";
            Console.WriteLine(str.DeleteVowel());
            Console.WriteLine();
            int r = arr4.Dif();
            Console.WriteLine("Разница между максимальным и минимальным элементами - " + r);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~ Количество элементов в массиве arr4 ~~~~~~~~~~~~~~~~~~");
            int c = arr4.Length();
            Console.WriteLine(c);
        }
    }
}