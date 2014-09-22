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
                if (row == 2)
                {
                    Console.Write(" ");
                } 
                
                for (int col = 1; col <= 39; col++)
                {
                    Console.Write(" *");                    
                }

               
            } 
            Console.WriteLine();
            
        }
    }
}
