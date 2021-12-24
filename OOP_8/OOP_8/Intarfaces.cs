using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
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
