using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP5
{
    class Logger
    {
        private static string path = @"C:\Users\thesi\Desktop\БГТУ\2 курс\3 семестр\c#\лабораторные\7\OOP5\OOP5\log.txt";

        public static void LogErrorInFile(Exception ex)
        {
            using(StreamWriter sw = new StreamWriter(path,true))
            {
               sw.WriteLine($" Ошибка: {ex.Message}\n" +
                    $"Метод:{ex.TargetSite}\n" +
                  $"Время:{DateTime.Now}\n" +
                  $"Источник{ex.Source}\n" +
                  $"Стек{ex.StackTrace}\n");
                sw.WriteLine("--------------------------------------");
            }
        }
        public static void LogErrorInConsole(Exception ex)
        {
            Console.WriteLine($" Ошибка: {ex.Message}\n" +
                    $"Метод:{ex.TargetSite}\n" +
                       $"Время:{DateTime.Now}\n" +
                    $"Источник{ex.Source}\n" +
                    $"Стек{ex.StackTrace}\n");
            Console.WriteLine("--------------------------------------");
        }
    }
}
