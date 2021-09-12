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
    }
}