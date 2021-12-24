using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace OOP5
{


    class Program
    {
        static void Main(string[] args)
        {   
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n~~~~~~~~~ С К А М Е Й К А ~~~~~~~~~");
            Console.ResetColor();
            Gum skam = new Bench();
            skam.Do();
            skam.Relax(30);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n~~~~~~~~~ Б Р У С Ь Я ~~~~~~~~~");
            Console.ResetColor();
            Gum brus = new Beams();
            brus.Do();
            brus.Relax(25);
            if (brus is Beams)
            {
                Console.WriteLine($"{skam} is Beams ");         ///true
            }
            //Ключевое слово IS позволяет сравнить объект и тип данных, 
            //что бы определить принадлежит ли наш объект этому типу.
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n~~~~~~~~~ М А Т Ы ~~~~~~~~~");
            Console.ResetColor();
            Gum Mate = new Mat();
            Mate.Do();
            Mate.Relax(5);

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n~~~~~~~~~ Б А С К Е Т Б О Л ~~~~~~~~~");
            Console.ResetColor();
            Basketball Bask = new Basketball();
            InBacketBall bask_ball = Bask;

            Bask.Take_Invent();
            Bask.Play();
            Bask.Do();
            Bask.Do();
            Bask.Back_Invent();
            Bask.Relax(10);
            //позволяет преобразовывать тип в определенный ссылочный тип 
            if (bask_ball as Gum != null)
            {
                Console.WriteLine($"{bask_ball} as Gum ");   ///true
            }

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n\n~~~~~~~~~ Т Е Н И С ~~~~~~~~~");
            Console.ResetColor();
            Tennic Ten = new Tennic();
            InTennisBall tenic_ball = Ten;

            Ten.Take_Invent();
            Ten.Play();
            Ten.Do();
            Ten.Do();
            Ten.Back_Invent();
            Ten.Relax(5);
        }
    }
 }
