using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using OOP_8;

namespace OOP_8
{
    class Info
    {
    }
    abstract class Gum
    {
        protected int Exp = 0;
        public override string ToString() => "Gum";
        public abstract void Do();
        public virtual void Relax(int minut)
        {
            Console.WriteLine($"Вы отдыхаете {minut} минут");
        }
    }

    sealed class Bench : Gum
    {
        public override string ToString() => "Bench";
        public override void Do() => Console.WriteLine("Вы решили посидеть на скамейке, на ней тренироваться нельзя");

    }
    class Mat : Gum
    {
        public override string ToString() => "Mat";

        public override void Do() => Console.WriteLine("Вы решили позаниматься на матах");

    }

    class Beams : Gum
    {
        public override string ToString() => "Beams";
        public override void Do() => Console.WriteLine("Вы решили потренироваться на брусьях");

    }

    sealed class Basketball : Gum, InBacketBall
    {
        public override string ToString() => "Basketball";
        public void Take_Invent() => Console.WriteLine("Вы взяли баскетбольный мяч ");
        public void Back_Invent() => Console.WriteLine("Вы вернули баскетбольный мяч ");
        public void Play() => Console.WriteLine("Вы решили поиграть с баскетбольным мячом");
        //одноименные методы 
        public override void Do() => Console.WriteLine("Вы решили позаниматься баскетболом");
        void InBacketBall.Do() => Console.WriteLine("Вы решили покидать в кольцо баскетбольный мяч");

    }
    sealed class Tennis : Gum, InTennisBall
    {
        public override string ToString() => "Tennis";
        public void Take_Invent() => Console.WriteLine("Вы взяли тенисный мяч и ракетки");
        public void Back_Invent() => Console.WriteLine("Вы вернули Тенисный мяч ");
        public void Play() => Console.WriteLine("Вы решили поиграть с тенисным мячом");
        public override void Do() => Console.WriteLine("Вы решили позаниматься тенисом");
        void InTennisBall.Do() => Console.WriteLine("Вы решили понабивать мячик");


    }
}
