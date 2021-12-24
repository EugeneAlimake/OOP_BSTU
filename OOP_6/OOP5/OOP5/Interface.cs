using System;
using System.Collections.Generic;
using System.Text;

namespace OOP5
{
    public interface Inventary
    {
        void Take_Invent();
        void Back_Invent();
    }

    public interface InBall : Inventary
    {
        void Play();

    }
    public interface InTennisBall : InBall
    {
        void Do();
    }
    public interface InBacketBall : InBall
    {
        void Do();
    }


}
