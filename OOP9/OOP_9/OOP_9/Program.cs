using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_9
{
    class Program
    {
        static void Main(string[] args)
        {
            User.Software Software;
            User user = new User();
            List<string> SW = new List<string> { "Windows", "MacOS", "Linux", "bada", "UNIX" };
            foreach (string item in SW)
            {
                Console.Write(item + "\t");
            }
            user.Upgrade += (list, message) =>
            {
                Console.WriteLine(message);
                foreach (string item in list)
                {
                    Console.Write(item + "\t");
                }
            };
            user.Work += (list, message) =>
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ResetColor();
            };
           
            Software = user.Loading;
            Software(SW, ""); 
            Software = user.Edit;
            Software(SW, "");
            Console.WriteLine("\n\n\n--------------Работа со строками--------------\n");

            Func<string, string> A;
            string str = "Мяу , Мур, кис";

            Console.WriteLine($"Исходная строка:        {str}");
            A = StringHandler.RemoveS;
            Console.WriteLine($"Без знаков препинания:  {str = A(str)}");
            A = StringHandler.RemoveSpase;
            Console.WriteLine($"Без пробелов:           {str = A(str)}");
            A = StringHandler.Upper;
            Console.WriteLine($"Заглавными буквами:     {str = A(str)}");
            A = StringHandler.Lower;
            Console.WriteLine($"Строчными буквами:      {str = A(str)}");
            A = StringHandler.AddToString;

            Console.WriteLine($"С добавлением символа:  {str = A(str)}");

            Console.ReadKey();
        }
    }
}
