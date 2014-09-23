using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S1.L02A
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 25; row++)
            {    
                for (int column = 1; column <= 39; column++)
                {
                    switch (row % 3)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                    }
                    Console.Write("* ");

                }
                Console.WriteLine();

                if (row % 2 != 0)
                {
                    Console.Write(" ");
                }

            
            } 
            
            
        }
    }
}
