using System;
using System.Collections.Generic;
using System.Text;
using System.CodeDom;
using System.Collections;
using System.Linq;
using System.IO;
using System.Threading.Tasks;


namespace OOP_8
{
    partial class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                CollectionTypeMassiv<int> arr1 = new CollectionTypeMassiv<int>(6);
                //InterfaceGeneric<int> a;
                arr1.Add(1);
                arr1.Add(2);
                arr1.Add(4);
                //arr1.SaveInFile();
                arr1.Show();
                arr1.Delete(2);
                arr1.Show();
                arr1.Find(3);
                CollectionTypeMassiv<string> arr2 = new CollectionTypeMassiv<string>(3);
                arr2.Add("pop");
                arr2.Add("mau");
                arr2.Show();
                arr2.Delete("pop");
                arr2.Show();
                arr2.Find("mau");
                CollectionTypeMassiv<bool> arr3 = new CollectionTypeMassiv<bool>(3);
                arr3.Add(true);
                arr3.Add(false);
                arr3.Show();
                arr3.Show();
                CollectionTypeMassiv<Gum> arr4 = new CollectionTypeMassiv<Gum>(3);
                arr4.Add(new Basketball());
                arr4.Add(new Bench());
                arr4.Add(new Tennis());
                arr4.Show();
                CollectionTypeMassiv<Gum> arr = new CollectionTypeMassiv<Gum>(4);
                LoadFromFile(ref arr);
                Console.WriteLine("\nЭлементы файла file2.txt:");
                arr.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("\nВообщем-то конец");
            }


        }
    }

    partial class Program
    {
        public static void LoadFromFile(ref CollectionTypeMassiv<Gum> objCollectionType)
        {
            string text ;

            using (StreamReader sr = new StreamReader(@"C:\Users\thesi\Desktop\БГТУ\2 курс\3 семестр\c#\лабораторные\8\OOP_8\OOP_8\puk.txt"))
            {
                while ((text = sr.ReadLine()) != null)
                {
                    switch (text)
                    {
                        case "Beams":
                            objCollectionType.Add(new Beams());
                            break;
                        case "Mat":
                            objCollectionType.Add(new Mat());
                            break;
                        case "Tennis":
                            objCollectionType.Add(new Tennis());
                            break;
                        case "Bench":
                            objCollectionType.Add(new Bench());
                            break;
                        case "Basketball":
                            objCollectionType.Add(new Basketball());
                            break;
                    }
                }
            }
        }
    }

}
