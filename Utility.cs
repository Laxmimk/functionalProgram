namespace Funpgm1
{
using System;
    public class Utility
    {
        /// <summary>
        /// to write the repetative part of the program in one place
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
       public static int Getinteger()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static bool Integerof(String str)
        {
            int p;
            //// to convert the string to 32 bit integer form
            if (Int32.TryParse("str", out p))
                return true;
            else
                return false;
        }
        public static bool IsString(String str)
        {
            int i = 0;
            //// returns the value of substring present in the string
                if(str.Contains(" "))
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
    

