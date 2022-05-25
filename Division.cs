using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Division
    {
        public static void CalculateQuotientAndReamainder()
        {
            Console.Write("Enter the Dividend: ");
            int dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Divisor: ");
            int divisor =Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine($"Dividend: {dividend} Divisor: {divisor}");
            Console.WriteLine($"Quotient: {quotient}\n Remainder: {remainder}");
        }

    }
}
