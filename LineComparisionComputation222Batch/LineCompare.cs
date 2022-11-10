using System;

namespace LineComparisionComputation222Batch
{
    internal class LineCompare
    {
        static void Main(string[] args)
        {
            //main
            Console.WriteLine("Welcome To LineComparisionComputation program");
            /*UC1
             * As a fan of geometry, I want to model a line based on a point
             *consisting of (x, y) co-ordinates using the Cartesian system,So that 
             *I can calculate its length.*/

            Console.WriteLine("Enter the First co-ordinates x1 and y1 ");
            int x1=Convert.ToInt32(Console.ReadLine());
            int y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second co-ordinates x2 and y2 ");
            int x2=Convert.ToInt32(Console.ReadLine());
            int y2=Convert.ToInt32(Console.ReadLine());

            double LineLength=Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The length of line is : "+ LineLength);
        }
    }
}
