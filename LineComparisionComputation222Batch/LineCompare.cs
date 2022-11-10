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
            //line1 co-ordinates
            Console.WriteLine("Enter the First lines co-ordinates x1 and y1 ");
            int x1=Convert.ToInt32(Console.ReadLine());
            int y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the First lines co-ordinates x2 and y2 ");
            int x2=Convert.ToInt32(Console.ReadLine());
            int y2=Convert.ToInt32(Console.ReadLine());

            //line2 co-ordinates
            Console.WriteLine("Enter the Second lines co-ordinates m1 and n1 ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second lines co-ordinates m2 and n2 ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            double LengthOfLine1=Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double LengthOfLine2 = Math.Sqrt(Math.Pow(m2 - m1, 2) + Math.Pow(n2 - n1, 2));
            Console.WriteLine("The length of line1 is : " + LengthOfLine1);
            Console.WriteLine("The length of line2 is : " + LengthOfLine2);
            //UC2
            if(LengthOfLine1.Equals(LengthOfLine2))
                Console.WriteLine("Both lines are Equal");
            else
                Console.WriteLine("Lines are not equal");
        }
    }
}
