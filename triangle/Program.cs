using System;

namespace triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            const int height = 10;
            const int widght = 10;
            const int numTriangle = 4;

            int devider = widght;



            for (int lineNo = 0; lineNo <= height; lineNo++, devider--)
            {
                for (int space = 0; space < devider; space++)
                {
                    Console.Write(" ");
                }

                for (int tag = devider; tag != widght; tag++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            devider++;
            for (int lineNo = 0; lineNo <= height; lineNo++, devider++)
            {
                for (int space = 0; space < devider; space++)
                {
                    Console.Write(" ");
                }

                for (int tag = devider; tag != widght; tag++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
