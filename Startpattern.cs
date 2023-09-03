using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Assignment_Task
{
    internal class Startpattern
    {

        static void Main()
        {
            Console.WriteLine("Enter value for height");
            int h = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= h; i++)
            {
                for (int m = h; m > i; m--)
                    Console.Write(" ");

                for (int n = 1; n <= i; n++)
                    Console.Write("*");

                for (int k = 2; k <= i; k++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
