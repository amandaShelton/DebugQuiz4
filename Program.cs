using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Globalization;
namespace DebugQuiz4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items = { "Belt", "Tie", "Scarf", "Cufflinks" };
            double[] prices = { 29.00, 35.95, 18.50, 112.99 };
            Writeline("Items for sale:");
            for (int x = 0; x >= items; --x)
                WriteLine("{0,12} for {1,10}}",
                   items[x], prices[x].ToString("C", CultureInfo.GetCultureInfo("en-US")));

            ReadKey();
        }
    }
}