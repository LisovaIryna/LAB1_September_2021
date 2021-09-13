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
            Console.Write(" │Enter the number of days: ");
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
                Console.WriteLine(" │" + UNDERLINE + "Result" + RESET);
                Console.WriteLine(" │A number equal to or greater than zero must be entered.");
                Console.WriteLine(" │Press \"Enter\" and the program will shut down.");

                Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }
            double week_count = MyLib.LibraryMethods.Week_count(number_days);
            Console.WriteLine(" │");
            Console.WriteLine(" │" + UNDERLINE + "Result" + RESET);
            Console.WriteLine(" │Number of full weeks: " + week_count);
            Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" ┌───────────────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine(" │" + UNDERLINE + "Task 2" + RESET);
            Console.WriteLine(" │");
            Console.WriteLine(" │");
            Console.WriteLine(" │" + UNDERLINE + "Incoming data" + RESET);
            Console.Write(" │Enter the number of members of the series: ");
            int n;
            if (!Int32.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine(" │");
                Console.WriteLine(" │" + UNDERLINE + "Result" + RESET);
                Console.WriteLine(" │Incorrect input. An integer must be entered.");
                Console.WriteLine(" │Press \"Enter\" and the program will shut down.");

                Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (n < 0)
            {
                Console.WriteLine(" │");
                Console.WriteLine(" │" + UNDERLINE + "Result" + RESET);
                Console.WriteLine(" │A number equal to or greater than zero must be entered.");
                Console.WriteLine(" │Press \"Enter\" and the program will shut down.");

                Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }
            double sum = MyLib.LibraryMethods.Sum_series(n);
            Console.WriteLine(" │");
            Console.WriteLine(" │" + UNDERLINE + "Result" + RESET);
            Console.WriteLine(" │The sum of the series: " + sum);
            Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(" ┌───────────────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine(" │" + UNDERLINE + "Task 3" + RESET);
            Console.WriteLine(" │");
            Console.WriteLine(" │");
            Console.WriteLine(" │" + UNDERLINE + "Incoming data" + RESET);
            Console.Write(" │Enter epsilon: ");
            double eps;
            if (!Double.TryParse(Console.ReadLine(), out eps))
            {
                Console.WriteLine(" │");
                Console.WriteLine(" │" + UNDERLINE + "Result" + RESET);
                Console.WriteLine(" │Incorrect input. An double must be entered.");
                Console.WriteLine(" │Press \"Enter\" and the program will shut down.");

                Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (eps <= 0)
            {
                Console.WriteLine(" │");
                Console.WriteLine(" │" + UNDERLINE + "Result" + RESET);
                Console.WriteLine(" │A number greater than zero must be entered.");
                Console.WriteLine(" │Press \"Enter\" and the program will shut down.");

                Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.Write(" │Enter z: ");
            int z;
            if (!Int32.TryParse(Console.ReadLine(), out z))
            {
                Console.WriteLine(" │");
                Console.WriteLine(" │" + UNDERLINE + "Result" + RESET);
                Console.WriteLine(" │Incorrect input. An integer must be entered.");
                Console.WriteLine(" │Press \"Enter\" and the program will shut down.");

                Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }
            if (z <= 0)
            {
                Console.WriteLine(" │");
                Console.WriteLine(" │" + UNDERLINE + "Result" + RESET);
                Console.WriteLine(" │A number greater than zero must be entered.");
                Console.WriteLine(" │Press \"Enter\" and the program will shut down.");

                Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");
                Console.ReadKey();
                Environment.Exit(0);
            }
            double sum_series = MyLib.LibraryMethods.Series_sum(eps, z);
            double function_z = MyLib.LibraryMethods.Function_z(z);
            double calculation_error = MyLib.LibraryMethods.Calculation_error(sum_series, function_z);
            Console.WriteLine(" │");
            Console.WriteLine(" │" + UNDERLINE + "Result" + RESET);
            Console.WriteLine(" │The sum of the series: " + sum_series);
            Console.WriteLine(" │The exact value of the function: " + function_z);
            Console.WriteLine(" │Calculation error: " + calculation_error);
            Console.WriteLine(" └───────────────────────────────────────────────────────────────────────────────────────────");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
