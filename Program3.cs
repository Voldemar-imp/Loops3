using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditionalOperatorsAndLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 5;
            int maxNumber = 96;
            int step = 7;
            int number;

            for (number = minNumber; number <= maxNumber; number += step)
            {
                Console.WriteLine(number);                
            }            
        }
    }
}
