using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace If_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var login = 123;
            var password = 1234;

            Console.WriteLine( "Введите логин");
            var uslog = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите пароль");
            var uspass = Convert.ToInt32(Console.ReadLine());

            if (login == uslog && password == uspass)
            {
                Console.WriteLine("Добро пожаловать!!!");
            }
            else
            {
                Console.WriteLine("Данные введены не правильно");
            }
        }
    }
}
