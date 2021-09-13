using System;

namespace Console_Variant15
{
    class Program
    {
        static void Main(string[] args)
        {
            string UNDERLINE = "\x1B[4m";
            string RESET = "\x1B[0m";

            Console.WriteLine();
            Console.WriteLine(" ┌──────────────────────────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine(" │Variant 15                                                                                │");
            Console.WriteLine(" └──────────────────────────────────────────────────────────────────────────────────────────┘");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" ┌───────────────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine(" │"+UNDERLINE+"Task 1"+RESET);
            Console.WriteLine(" │");
            Console.WriteLine(" │");
            Console.WriteLine(" │"+UNDERLINE+"Incoming data"+RESET);
            Console.Write(" │Enter the number of days:");
            int number_days;
            if (!Int32.TryParse(Console.ReadLine(), out number_days))
            {
                Console.WriteLine(" │");
                Console.WriteLine(" │"+UNDERLINE+"Result"+RESET);
                Console.WriteLine(" │Incorrect input. An integer must be entered.");
                Console.WriteLine(" │Press \"Enter\" and the program will shut down.");

                Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (number_days < 0)
            {
                Console.WriteLine(" │");
                Console.WriteLine(" │");
                Console.WriteLine(" │A number equal to or greater than zero must be entered.");
                Console.WriteLine(" │Press \"Enter\" and the program will shut down.");

                Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }
            double week_count = MyLib.LibraryMethods.Week_count(number_days);
            Console.WriteLine(" │Number of full weeks: " + week_count);
            Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");
        }
    }
}
