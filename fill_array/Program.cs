using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fill_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeArray = 0;

            Console.WriteLine("Введите размер массива");
            if(int.TryParse(Console.ReadLine(), out sizeArray))
            {
                int[] userArray= new int[sizeArray];
                Console.WriteLine("Введите эелемент массива");

                for(int i = 0; i < userArray.Length; i++)
                {
                    if (int.TryParse(Console.ReadLine(), out userArray[i]))
                    {
                        Console.WriteLine("Введите следующий элемент массива");
                    }
                    else
                    {
                        Console.WriteLine("Некорректные данные");
                        i--;
                    }
                }

                for (int i = 0; i < sizeArray; i++)
                {
                    Console.WriteLine("Элемент " + i + ": " + userArray[i]);
                }

            }

            Console.ReadKey();
        }
    }
}
