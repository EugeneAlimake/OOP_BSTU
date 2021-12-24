using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{

    public class Massiv//1 задание(создание самого класса)
    {
        public int[] massiv;
        private int index;
        public int Index    //свойство класса
        {
            get { return index; }
        }
        public Massiv(int Index)        //конструктор класса
        {
            index = Index;
            massiv = new int[Index];
        }
        public int this[int NumOfElement]   //индексатор класса
        {
            get { return massiv[NumOfElement]; }
            set { massiv[NumOfElement] = value; }
        }

        //перегрузка операторов 
        public static Massiv operator -(Massiv x, Massiv y)     //разность
        {
            Massiv temp = new Massiv(x.Index);
            for (int i = 0; i < temp.Index; i++)
                temp[i] = x[i] - y[i];
            return temp;
        }

        public static int operator >(Massiv x, int a)  //проверка на вхождение элемента
        {
            for (int i = 0; i < x.Index; i++)
            {
                if (x[i] == a)
                    return 1;
                
                    
            }
            return 0;
        }
        public static int operator <(Massiv x, int a)  //проверка на не вхождение эл
        {
            for (int i = 0; i < x.Index; i++)
            {
                if (x[i] != a)
                    continue;
                else
                    return 0;
            }
            return 1;
        }
        public static bool operator !=(Massiv x, Massiv y)  //неравенство массивов
        {
            for (int i = 0; i < x.Index; i++)
            {
                if (x[i] != y[i])
                    return true;
                else
                    continue;
            }
            return false;
        }
        public static bool operator ==(Massiv x, Massiv y)  //равенство
        {
            for (int i = 0; i < x.Index; i++)
            {
                if (x[i] == y[i])
                    return true;
                else
                    continue;
            }
            return false;
        }
        public static Massiv operator +(Massiv x, Massiv y) //объединение массивов
        {
            Massiv temp = new Massiv(x.Index + y.Index);
            for (int i = 0; i < x.Index; i++)
            {
                temp[i] = x[i];
            }
            for (int i = 0; i < y.Index; i++)
            {
                temp[i + x.Index] = y[i];
            }
            return temp;
        }

        public void Show(int NumOfElement)
        {
            Console.Write(massiv[NumOfElement]);
        }
        public void Show()
        {
            for (int i = 0; i < index; i++)
            {
                Console.Write(massiv[i] + " ");
            }
        }
        //Owner
        private Owner owner = new Owner(32156401, "EugeneAliMake", "BelSTU");
        //вложенный класс Date
        public class Date
        {
            public readonly DateTime time;
            public Date()
            {
                time = DateTime.Now;
            }
        }
        public Date date = new Date();

        public override bool Equals(object obj)
        {
            if (!(obj is Massiv))
                return false;
            return this == (Massiv)obj;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
