using System;

namespace MyLib
{
    /// Calculation of mathematical functions

    public class LibraryMethods
    {
        /// <summary>
        /// Week_count(number_days)
        /// </summary>
        /// <param name="number_days">An integer entered from the keyboard by the user — argument of the Week_count function.</param>
        /// <returns>Returns the value of the Week_count (number of full weeks)  for a given integer.</returns>
        public static int Week_count(int number_days)
        {
            double week_count = number_days / 7;

            int rounded_week_count = (int)Math.Floor(week_count);

            return rounded_week_count;
        }

        /// <summary>
        /// Sum_series(n)
        /// </summary>
        /// <param name="n">An integer entered from the keyboard by the user — argument of the Sum_series function.</param>
        /// <returns>Returns the value of the Sum_series (the sum of a given series)  for a given integer.</returns>
        public static double Sum_series(int n)
        {
            double sum = 0;

            for (int i=0; i<n+1; i++)
            {
                double a = Math.Pow(-1, n) * (1 / Math.Pow(2, n));

                sum = sum + a;
            }

            return sum;
        }

        /// <summary>
        /// Series_sum(eps, n)
        /// </summary>
        /// <param name="eps">An double entered from the keyboard by the user — first argument of the Series_sum function.</param>
        /// <param name="z">An integer entered from the keyboard by the user — second argument of the Series_sum function.</param>
        /// <returns>Returns the value of the Series_sum (the sum of a given series)  for a given double and integer.</returns>
        public static double Series_sum(double eps, int z)
        {
            double sum = 1;
            double a = 1;
            int F = 1;
            int n = 1;

            while (a > eps)
            {
                F = F * n;
                a = Math.Pow(-1, n) * (1 / (F * z));
                sum = sum + a;
                n = n + 1;
            }

            return sum;
        }

        /// <summary>
        /// Function_z(z)
        /// </summary>
        /// <param name="z">An integer entered from the keyboard by the user — argument of the Function_z function.</param>
        /// <returns>Returns the value of the Function_z for a given integer.</returns>
        public static double Function_z(int z)
        {
            double function_z = 1 - z * Math.Log(2);

            return function_z;
        }

        /// <summary>
        /// Calculation_error(sum, function_z)
        /// </summary>
        /// <param name="sum">An double from the Series_sum function — first argument of the Calculation_error function.</param>
        /// <param name="function_z">An double from the Function_z function — second argument of the Calculation_error function.</param>
        /// <returns>Returns the value of the Calculation_error for a given double and double.</returns>
        public static double Calculation_error(double sum, double function_z)
        {
            double calculation_error = (Math.Abs(sum - function_z) / function_z) * 1;

            return calculation_error;
        }
    }
}