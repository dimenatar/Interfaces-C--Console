using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        private static void PrintArrayDouble(DoubleMas [] mas, int razm)
        {
            string outPut = "";
            for (int i =0; i < mas.Length; i++)
            {
                if (i != mas.Length-1)
                {
                    outPut += mas[i].Chislo + ", ";
                }
                else
                {
                    outPut += mas[i].Chislo;
                }
            }
            Console.WriteLine(outPut);
        }
        static void FirstTask()
        {
            int razm;
            Console.WriteLine("Введите размерность");
            razm = int.Parse(Console.ReadLine());
            DoubleMas[] mas = new DoubleMas[razm];
            Random random = new Random();
            char choice;


            Console.WriteLine();
            Console.WriteLine("Хотите забить элементы рандомом? y/n");
            choice = char.Parse(Console.ReadLine());
            CheckRandomWriteArrayOrHand(razm, mas, random, choice);
            Array.Sort(mas, mas[0].Compare);
            PrintArrayDouble(mas, razm);
        }

        private static void CheckRandomWriteArrayOrHand(int razm, DoubleMas[] mas, Random random, char choice)
        {
            if (choice == 'y')
            {
                for (int i = 0; i < razm; i++)
                {
                    mas[i] = new DoubleMas(random.Next(0, 50) + Math.Round(random.NextDouble(), 1));
                }
            }
            else
            {
                for (int i = 0; i < razm; i++)
                {
                    mas[i] = new DoubleMas(double.Parse(Console.ReadLine()));
                }
            }
        }

        static void SecondTask()
        {
            MyString[] strings = new MyString[3];
            strings[0] = new MyString(Console.ReadLine(), 12);
            strings[1] = new MyString(Console.ReadLine(), 12);
            strings[2] = new MyString(Console.ReadLine(), 12);
            Array.Sort(strings);
            Console.WriteLine(strings[0].ToString());
            Console.WriteLine(strings[1].ToString());
            Console.WriteLine(strings[2].ToString());
        }
        static void Main(string[] args)
        {
            int zad = 0;
            Console.WriteLine("Задание 1-2?");
            zad = int.Parse(Console.ReadLine());
            switch (zad)
            {
                case 1:
                    {
                        FirstTask();
                        break;
                    }
                case 2:
                    {
                        SecondTask();
                        break;
                    }
                default: break;
            }

        }
    }
}
