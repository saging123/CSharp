using System;
namespace MyfirstApplication
{
    class Cli
    {
        public static void Entry(string[] args)
        {
            double Len = Double.Parse(args[0]);
            double Wid = Double.Parse(args[1]);
            PrintArgs(args[0], args[1]);
            Console.WriteLine("The area is " + ComputeAreaOfRectangle(Len, Wid));
         
        }
        public static double ComputeAreaOfRectangle(double Length, double Width)
        {
            return Length * Width;
        }
        public static void PrintArgs(string args1, string args2)
        {
            Console.WriteLine("The arg One is " + args1);
            Console.WriteLine("The arg Two is " + args2);
 
        }




    }
}