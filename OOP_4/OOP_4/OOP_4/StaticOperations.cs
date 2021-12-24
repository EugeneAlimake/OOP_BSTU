using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lab_4
{
    static class StatisticOperations
    {
        public static int Max(this Massiv arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Index; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        public static int Min(this Massiv arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Index; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            return min;
        }

        public static int Length(this Massiv arr) //количество
        {
            int count = 0;
            for (int i = 0; i < arr.Index; i++)
                count++;
            return count;
        }

        public static int Dif(this Massiv arr)    //разница
        {
            return Max(arr) - Min(arr);
        }

        public static int Sum(this Massiv arr) //сумма
        {
            int res = 0;
            for (int i = 0; i < arr.Index; i++)
            {
                res += arr[i];
            }
            return res;
        }

        public static String DeleteVowel(this String str)   //удаление гласных
        {
            string res = "";
            res = Regex.Replace(str, "[аоэюяуеыиaeiouyЙУЕЫАОЭЯИЮAEIOUY]?", "");
            return res;
        }

        public static Massiv FiveElem(this Massiv arr)  //удаление 5 элементов
        {
            Massiv arr1 = new Massiv(arr.Index - 5);
            for (int i = 0; i < arr1.Index; i++)
            {
                arr1[i] = arr[i + 5];
            }
            return arr1;
        }
    }
}