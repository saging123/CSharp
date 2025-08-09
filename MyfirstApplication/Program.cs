using System;
namespace MyfirstApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Age: ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("You are " + name);
            Console.WriteLine("Your age is  " + age);
        }

    }
}