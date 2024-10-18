using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstdemo1
{
    internal class days_ofmonth
    {
        static void main(string[] args)
        {
            Console.WriteLine("enter month number (1-12):");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the year:");
            int year = Convert.ToInt32(Console.ReadLine());
            int dayInMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine("the total number of days in month" + month + "of year" + year + "is" + dayInMonth);


        }



    }
}

