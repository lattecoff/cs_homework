using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parity_check
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum = 0;


            Console.WriteLine("Введите целое число ");
            
            if (int.TryParse(Console.ReadLine(), out userNum))
            {
                if ((userNum % 2) == 0)
                {
                    Console.WriteLine("Число четное");
                }
                else
                {
                    Console.WriteLine("Число не четное");
                }
            }
            else
            {
                Console.WriteLine("Не корректное число!");
            }

            Console.ReadKey();
        }
    }
}
