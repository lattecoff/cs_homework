using System;

namespace currency_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyBy = 0;
            const double course = 2.56;

            Console.WriteLine("Введите сумму денег");
            if (double.TryParse(Console.ReadLine(), out moneyBy))
            {
                Console.WriteLine(moneyBy + "BY" + " = " + (moneyBy / course) + "USD");
            }
            else
            {
                Console.WriteLine("Не корректная сумма!");
            }


            Console.ReadKey();
        }
    }
}
