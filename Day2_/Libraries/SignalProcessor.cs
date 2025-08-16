using System;
namespace Day2.Libraries
{
    class SignalProcessor
    {

        public SignalProcessor()
        {
        }
        /**
        * dB = 10 × log10(Watts / Reference Power)
        * This method converts power to decibel
        */
        public double PowerToDecibel(double Power, double ReferencePower)
        {
            double right = Math.Log10(Power / ReferencePower);
            return 10 * right;
        }

        public double DecibelToPower(double Decibel, double ReferencePower)
        {
            // 10 ^ (Decibel / 10 );
            double revRight = Math.Pow(10,  Decibel / 10 );
            return ReferencePower * revRight;
        }
    }
}