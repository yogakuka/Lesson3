using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class App
    {
        private int sum = 0;
        private int askNumber()
        {
            int number;
            Console.WriteLine("Напишите число");
            if(int.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Вы должны ввести число!");
                return this.askNumber();
            }
        }
        private void printResult()
        {
            Console.WriteLine($"сумма всех нечетных положительных чисел равна {this.sum}");
            Console.ReadLine();
        }
        private int checkNumber(int number)
        {
            if ((number % 2 == 1) & (number > 0))
            {
                return number;
            }
            else
            {
                return 0;
            }
        }
        public void Start()
        {
            int number = 0;
            Console.WriteLine("Вводите числа, чтобы подсчитать сумму введенных" +
                " нечетных положительных чисел введите 0");
            while (true)
            {
                number = this.askNumber();
                this.sum += this.checkNumber(number);
                if (number == 0)
                {
                    this.printResult();
                    return;
                }
            }
        }
    }
}
