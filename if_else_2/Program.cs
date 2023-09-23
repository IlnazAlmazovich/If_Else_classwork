using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишите консольную программу, в которую пользователь вводит с клавиатуры число. Если число одновременно больше 5 и меньше 10,
            //то программа выводит "Число больше 5 и меньше 10". Иначе программа выводит сообщение "Неизвестное число".
            Console.WriteLine("Введите число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 5 && num1 < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
    }
}
