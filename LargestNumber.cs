using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestNumber
    {
        public static void FindLargestNumber()
        {
            Console.Write("Enter the first number: ");
            int first=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int second=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int third=Convert.ToInt32(Console.ReadLine());

            if(first > second && first > third)
            {
                Console.WriteLine($"First number is the largest number i.e {first}");
            }
            else if(second > third && second > first)
            {
                Console.WriteLine($"Second number is the largest number i.e {second}");
            }
            else if(third > first && third > second)
            {
                Console.WriteLine($"Third number is the largest number i.e {third} ");
            }
        }
    }
}
