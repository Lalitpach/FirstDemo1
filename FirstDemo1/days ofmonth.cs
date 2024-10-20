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
            Console.WriteLine("enter months");
            String month = Conole.Readline();
            if (month == "febuary" || month = "febuary")
            {
                Console.WriteLine($"{month} has 28days");
            }
            else if (month == "january" || month == "feb" || month == "March" || month == "april" || month == "May" || month == "june" || month == "july" || month == "august" || month == "sep" || month =="oct" || month = "nov" || month = "dec") ;
            {
                Console.WriteLine($"{month} has 31days");
            }
            


        }



    }
}

