using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson0021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ДЗ 2: 
 * Сделать небольшой каталог пользователей (от 3 до 5) 
 * С консоли вводятся данные о пользователе (не менее двух вариантов) 
 * данные записываются в массив (либо двумерный, либо массив массивов, либо несколько разных массивов) 
 * По окончанию запросить у пользователя какого человека он хочет вывести 
 */
            Console.Write("Введите количество пользователей (от 3 до 5): ");
            int a= int.Parse(Console.ReadLine());
            string[,] users = new string[a, 5];
            Console.WriteLine("Введите имя пользователя 0");
            users[0, 0] = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя 0");
            users[0, 1] = Console.ReadLine();
            Console.WriteLine("Введите имя пользователя 1");
            users[1, 0] = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя 1");
            users[1, 1] = Console.ReadLine();
            Console.WriteLine("Введите имя пользователя 2");
            users[2, 0] = Console.ReadLine();
            Console.WriteLine("Введите возраст пользователя 2");
            users[2, 1] = Console.ReadLine();
            if (a >= 4)
            {
                Console.WriteLine("Введите имя пользователя 3");
                users[3, 0] = Console.ReadLine();
                Console.WriteLine("Введите возраст пользователя 3");
                users[3, 1] = Console.ReadLine();
            }
            if (a == 5)
            {
                Console.WriteLine("Введите имя пользователя 4");
                users[4, 0] = Console.ReadLine();
                Console.WriteLine("Введите возраст пользователя 4");
                users[4, 1] = Console.ReadLine();
            }
            Console.WriteLine("Пользователь номер: ");
            int b= int.Parse(Console.ReadLine());
            Console.WriteLine("Имя пользователя" + " : " + users[b, 0] + "\n" + "Возраст пользователя" + " : " );
        }
    }
}
