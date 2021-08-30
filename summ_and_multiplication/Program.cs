using System;

namespace summ_and_multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNum1 = 0;
            int userNum2 = 0;
            int userNum3 = 0;

            Console.WriteLine("Введите первое целое число ");
            if (int.TryParse(Console.ReadLine(), out userNum1))
            {
                Console.WriteLine("Введите второе целое число ");
                if (int.TryParse(Console.ReadLine(), out userNum2))
                {
                    Console.WriteLine("Введите третье целое число ");
                    if (int.TryParse(Console.ReadLine(), out userNum3))
                    {

                        Console.WriteLine("Сумма чисел " + userNum1 + " + " + userNum2 + " + " + userNum3 + " = " + (userNum1 + userNum2 + userNum3));
                        Console.WriteLine("Произведение чисел " + userNum1 + " * " + userNum2 + " * " + userNum3 + " = " + (userNum1 * userNum2 * userNum3));
                    }
                    else
                    {
                        Console.WriteLine("Не корректное число!");
                    }
                }
                else
                {
                    Console.WriteLine("Не корректное число!");
                }
            }
            else
            {
                Console.WriteLine("Не корректное число!");
            }
        }
    }
}
