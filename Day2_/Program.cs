using System;
using Day2.Libraries;

namespace Day2
{
    class Program
    {
        public static void Main(string[] args)
        {
            SignalProcessor signalConverter = new SignalProcessor();

            double InputPower = 500;
            double RefPower = 0.001;
            double powerInDecibel = signalConverter.PowerToDecibel(InputPower, RefPower);

            Console.WriteLine(InputPower + " watts to Decibel is " + powerInDecibel);
        }
    }
}