using System;
using System.Collections.Generic;
using System.Text;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace OOP_8
{

    public class CollectionTypeMassiv<T> : InterfaceGeneric<T>    //1 задание(создание самого класса)
    {
        private T[] A;
        private int index;
        public static int numberes;
        public int Index    //свойство класса
        {
            get { return index; }
        }

        public CollectionTypeMassiv(int Index)
        {
            A = new T[Index];
            index = Index;
            numberes = 0;
        }

        public void Delete(T dr)
        {
            for (int i = 0; i < numberes; i++)
            {
                if (dr.Equals(A[i]))
                {
                    A[i] = default;
                    int b = i;
                    if (i < numberes)
                    {
                        for (int q = i; q < numberes - 1; q++)
                        {
                            A[q] = A[q + 1];
                            A[q + 1] = default;
                        }
                        numberes--;
                    }
                }

            }

        }
        public void Add(T dr)
        {
            if (numberes < Index)
            {
                A[numberes] = dr;
            }
            numberes++;
        }
        public void LSearch(T[] _A)
        {

            A = (T[])_A.Clone();
        }

        public void Show()
        {
            for (int i = 0; i < numberes; i++)
            {
                Console.Write($"{A[i]}  ");
            }
            Console.WriteLine();
        }
        public void Find(T dr)
        {
            for (int i = 0; i < numberes; i++)
            {
                if (dr.Equals(A[i]))
                {
                    Console.WriteLine($"{dr} найден под индексом {i}");
                }
                else
                {
                    Console.WriteLine("Ничего не найдено!");
                }
            }
        }

        public void SaveInFile()
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\thesi\Desktop\БГТУ\2 курс\3 семестр\c#\лабораторные\8\OOP_8\OOP_8\puk.txt", false))
            {
                for (int i = 0; i < numberes; i++)
                { sw.WriteLine(A[i]); }

            }
        }
       
    }
}
     
            

            
            

    
 

