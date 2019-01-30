namespace Funpgm1
{
    using System;
    public class Leapyear
    {   
        /// <summary>
    /// to find the given year is leap year or not
    /// </summary>
    /// <returns></returns>
        public int Findleapyear()
        {//// initialising the local variable to zero
            int year = 0;
            try
            {
                Console.WriteLine("Enter the year");
                Console.ReadLine();
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
                    //// if year is not completely divisible by 100 then it is leap year 
                    else
                        Console.WriteLine("the year is a leap year")
    ;
                }
                else
                    Console.WriteLine("The year is not a leap year");
            }
    catch(Exception e)
        {
                //// to print the exception message
                Console.WriteLine(e.Message);
        }
            return 0;
        }
    }
}
