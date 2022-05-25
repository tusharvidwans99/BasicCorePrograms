using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Flipcoin
    {

        public static void FliptheCoin()
        {
            
            int HEAD = 1;
            int Headcount = 0;
            int TailCount = 0;

            double HeadPercentage;
            double TailPercentage;
            
            Console.Write("Enter the value for number of flips: ");
            int flipcoin = Convert.ToInt32(Console.ReadLine());

            if(flipcoin > 0)
            {
                for(int i = 0; i <= flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    
                    
                    if(number == HEAD)
                    {
                        Headcount++;
                    }
                    else
                    {
                        TailCount++;
                    }
                    
                }
            }
            Console.WriteLine("Headcount:" + Headcount + " Tailcount: " + TailCount);
            HeadPercentage = (double)Headcount / flipcoin * 100;
            TailPercentage = (double)TailCount / flipcoin * 100;

            Console.WriteLine("Head Win Percentage: "+Math.Round(HeadPercentage,2));
            Console.WriteLine("Tail Win Percentage: "+Math.Round(TailPercentage,2));

        }

    }
}
