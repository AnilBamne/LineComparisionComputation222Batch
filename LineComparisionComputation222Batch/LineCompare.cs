using System;

namespace LineComparisionComputation222Batch
{
    //Creating a interface
    public interface IEmpWageBuilder
    {
        void UsingEqualsMethod(double line1Length, double line2Length);
        void UsingCompareToMethod(double line1Length, double line2Length);

    }
    //Inheriting the interface and defining the methods
    public class NewClass:IEmpWageBuilder
    {
        public void ComputeLength()
        {
            NewClass obj=new NewClass();
            //line1 co-ordinates
            Console.WriteLine("Enter the First lines co-ordinates x1 and y1 ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the First lines co-ordinates x2 and y2 ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());

            //line2 co-ordinates
            Console.WriteLine("Enter the Second lines co-ordinates m1 and n1 ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second lines co-ordinates m2 and n2 ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            //computation of lengths
            double LengthOfLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double LengthOfLine2 = Math.Sqrt(Math.Pow(m2 - m1, 2) + Math.Pow(n2 - n1, 2));
            Console.WriteLine("The length of line1 is : " + LengthOfLine1);
            Console.WriteLine("The length of line2 is : " + LengthOfLine2);

            //calling the methods here and providing length parameters
            obj.UsingEqualsMethod(LengthOfLine1, LengthOfLine2);
            obj.UsingCompareToMethod(LengthOfLine1, LengthOfLine2);

        }
        //Providing method bodies to the interface methodas
        public void UsingEqualsMethod(double line1Length, double line2Length)
        {
            //Using Equals method
            Console.WriteLine("\nUsing Equals Method");
            if (line1Length.Equals(line2Length)) Console.WriteLine("Both lines are Equal");
            else if (line1Length > line2Length) Console.WriteLine("Line1 Is Greater Than Line2");
            else Console.WriteLine("Line2 Is Greater Than Line1");
        }
        public void UsingCompareToMethod(double line1Length, double line2Length)
        {
            //Using CompareTo method
            Console.WriteLine("\nUsing CompareTo Method");
            if (line1Length.CompareTo(line2Length) > 0) Console.WriteLine("Line1 Is Greater Than Line2");
            else if (line2Length.CompareTo(line1Length) > 0) Console.WriteLine("Line2 Is Greater Than Line1");
            else Console.WriteLine("Both Lines Are Equal");
        }
    }
    public class LineCompare
    {
        public static void Main(string[] args)
        {
            //main
            Console.WriteLine("Welcome To LineComparisionComputation program");
            //UC8: Using OOPs concept Interface and Inheritance
            NewClass obj = new NewClass();
            obj.ComputeLength();    
        }
        
    }
}
