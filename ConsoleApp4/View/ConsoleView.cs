using ConsoleApp4.Infrastryctyre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.View
{
     
    class ConsoleView
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }

        public Complex GetData()
        {
            Console.Write("Введите действительную часть числа: ");
            double.TryParse(Console.ReadLine(), out double re);
            Console.Write("Введите мнимую часть числа: ");
            double.TryParse(Console.ReadLine(), out double im);
            return new Complex(re, im);
        }


    }
}
