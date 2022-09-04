using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    internal class DateModifier
    {
        public static int CalculateDateDiffInDays(string firstDate, string secondDate)
        {
            DateTime dateone = DateTime.Parse(firstDate);
            DateTime datetwo = DateTime.Parse(secondDate);
            int days = Math.Abs((dateone - datetwo).Days);
            return days;
        }
    }
}
