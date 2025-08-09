using System;
using System.Numerics;
namespace MyfirstApplication
{
    class DataTypes
    {
        public static void Entry(string[] args)
        {
            int age = 10; // no decimal
            string name = "Juan"; // enclosed within double quote
            char fistLetter = 'I'; // enclosed within single quote
            double PI = 2.1141645654654654654654654645645;
            float balance = 324234.23f; // suffix f 
            bool isMale = true; // true or false
            Console.WriteLine("The age is " + age); // concatenation 
            Console.WriteLine("You are " + name);
            Console.WriteLine("Intial  " + fistLetter);
            Console.WriteLine("Is Male?   " + isMale);
            Console.WriteLine("PI   " + PI);
            Console.WriteLine("Balance   " + balance);
            Console.WriteLine("Int value from " + int.MinValue + " to " + int.MaxValue);
            Console.WriteLine("Float value from " + float.MinValue + " to " + float.MaxValue);
            Console.WriteLine("Double value from " + double.MinValue + " to " + double.MaxValue);

        }
      
        
    }
}