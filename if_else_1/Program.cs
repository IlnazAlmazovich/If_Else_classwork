using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите консольную программу, в которую пользователь вводит с клавиатуры два числа.
            //А программа сранивает два введенных числа и выводит на консоль результат сравнения
            //(два числа равны, первое число больше второго или первое число меньше второго).

            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("Первое число меньше второго");
            }
            else
            {
                Console.WriteLine("Оба числа равны");
            }
            Console.ReadKey();

        }
    }
}
