using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    enum months
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Current month is : {months.July}");
            Console.WriteLine($"It is the {(int)months.July+1}th month of the year 2024");
        }
    }
}
