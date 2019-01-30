// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Harmonic.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;

    /// <summary>
    /// class Harmonic numbers
    /// </summary>
   public class Harmonic
    {
        /// <summary>
        /// a method to find the harmonic numbers
        /// </summary>
        public void Harmonicnumbers()
        {
            try
            {
                Console.WriteLine("enter to find n th harmonic number");
                int n = Utility.Getinteger();
                float result = 0;
                if (n > 0)
                {
                    ////this loop is used for finding the n th harmonic number
                    for (int i = 1; i <= n; i++)
                    {
                        result = result + (float)(1.0 / i);
                    }

                    Console.WriteLine("n th harmonic number is " + result);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter the number correctly");
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}