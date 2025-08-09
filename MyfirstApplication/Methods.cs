using System;
namespace MyfirstApplication
{
    class Methods
    {
        public static void Entry(string[] args)
        {
            double side = 11.14;
            double computedArea = ComputeAreaOfSquare(side);
            Console.WriteLine("The area of square is " + computedArea);
            double Length = 10;
            double Width = 9;
            double AreaOfRect = ComputeAreaOfRectangle(Length, Width);

            Console.WriteLine("The area of Rectangle is " + AreaOfRect );
        }
        // this method compute the area of square given the side
        public static double ComputeAreaOfSquare(double side)
        {
            return side * side;
        }

        // compute for area of rectangle Length x width
        public static double ComputeAreaOfRectangle(double Length, double Width)
        {
            return Length * Width;
        }
        
    }
}