using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Interfaces
{
    class MyString : IComparable<MyString>
    {
        private string text;
        private int razm;


        public MyString()
        {

        }

        public MyString(string text, int razm)
        {
            Text = text;
            Razm = razm;
        }
        public string Text { get => text; set => text = value; }
        public int Razm { get => razm; set => razm = value; }

        public int CompareTo(MyString other)
        {
            int a = 0, a1 = 0;
            for (int i =0; i < Text.Length; i ++)
            {
                if (Text[i] == 'a')
                {
                    a++;
                }
            }

            for (int i = 0; i < other.Text.Length; i++)
            {
                if (other.Text[i] == 'a')
                {
                    a1++;
                }
            }
            return (a - a1);
        }
        public int GetA()
        {
            int a = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] == 'a')
                {
                    a++;
                }
            }
            return a;
        }
        public override string ToString()
        {
            return (GetA() + " -------количество букв а в слове " + Text);
        }
    }
}
