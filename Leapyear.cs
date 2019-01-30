// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Leapyear.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;

    /// <summary>
    /// class leap year to find whether the given year is leap year or not
    /// </summary>
    public class Leapyear
    {   
        /// <summary>
    /// to find the given year is leap year or not
    /// </summary>
    /// <returns>it gives whether the year is leap year or not</returns>
        public int Findleapyear()
        {
            try
            {
                //// initialising the local variable to zero
                int year = 0;
                Console.WriteLine("Enter the year");
                Console.ReadLine();
                if (year > 999)
                {
                    if ((year % 4) == 0)
                    {
                        if ((year % 100) == 0)
                        {
                            if ((year % 400) == 0)
                            {
                                //// if year is divisible by 400 then it is a leap year
                                Console.WriteLine("the year is a leap year");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("The year entered is not a leap year " + year);
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("the year is a leap year");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The year is not a leap year");
                    }
                }
                else
                {
                    Console.WriteLine("Enter the year with 4 digit");
                }
            }
            catch (Exception e)
            {
                //// to print the exception message
                Console.WriteLine(e.Message);
            }

            return 0;
        }
    }
}