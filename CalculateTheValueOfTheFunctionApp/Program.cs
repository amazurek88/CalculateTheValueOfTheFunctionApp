using System;

namespace CalculateTheValueOfTheFunctionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.WriteLine("Program oblicza wartość funkcji y = 19 * x");
            Console.WriteLine("dla x zmieniającego się od 0 do 20.");

            for (x = 0; x <= 20; x++)
            {
                y = 19 * x;
                Console.WriteLine("x = " + x + '\t' + " y = " + y);
            }
        }
    }
}
