﻿namespace BasicProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Basic Core Problems");
            Console.WriteLine("------------------------");
            //UC_1
            FlipCoin.CheckCoinFlip();
            Console.WriteLine("------------------------");
            //UC_2
            LeapYear.Year();
            Console.WriteLine("------------------------");
            //UC_3
            PowerOfTwo.Power();
            Console.WriteLine("------------------------");
            //UC_4
            HarmonicNumber.checkHarmonicSeries();
        }
    }
}