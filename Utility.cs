// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;

    /// <summary>
    /// class utility
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// converts given integer to integer of 32 bits
        /// </summary>
        /// <returns> returns an integer</returns>
        public static int Getinteger()
        {
                int x = Convert.ToInt32(Console.ReadLine());
                return x;           
        }

        /// <summary>
        /// a method for parsing
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns> returns true or false</returns>
        public static bool Integerof(string str)
        {
            int p;
            //// to convert the string to 32 bit integer form
            if (int.TryParse("str", out p))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// a method to find the wind chill 
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="v">The v.</param>
        public void Windchill(double t, double v)
        {
            double w = 35.74 + (0.6215 * t) + (((0.4275 * t) - 35.75) * Math.Pow(v, 0.16));
            Console.WriteLine("wind chill is : " + w);
            Console.ReadLine();
        }

        /// <summary>
        /// a method to find the euclidian distance
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void EuclidianDistance(int x, int y)
        {
            double dist = Math.Sqrt((x * x) + (y * y));
            Console.WriteLine("distance from (" + x + ", " + y + ") to (0, 0) = " + dist);
            Console.ReadLine();
        }

        /// <summary>
        /// a method to find the power of 2
        /// </summary>
        /// <param name="value">The value.</param>
        public void Findpowerof2(int value)
        {
            try
            {
                Console.WriteLine("Total num " + value);
                if (value >= 0 && value < 31)
                {
                    for (int i = 0; i < value; i++)
                    {
                        Console.WriteLine(Math.Pow(2, i));
                    }
                }
                else
                {
                    Console.WriteLine("Enter the appropriate value");
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Determines whether the specified string is string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns>
        ///   <c>true</c> if the specified string is string; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsString(string str)
        {
            int i = 0;
            //// returns the value of substring present in the string
                if (str.Contains(" "))
                {
                Console.WriteLine("Invalid input");
                return false;
                }

                    for (i = 0; i < 10; i++)
                    {
                //// converts the integer value to equivalent string format
                if (str.Contains(i.ToString()))
                {
                    Console.WriteLine("you have entered the wrong input");
                    return false;
                }
                    }

            return true;
                }
            }            
        }        