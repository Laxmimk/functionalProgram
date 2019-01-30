// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Primefactors.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;

    /// <summary>
    /// class prime factors 
    /// </summary>
    public class Primefactors
    {
        /// <summary>
        /// a method to find all the prime factors of a given number
        /// </summary>
        public void Findprimefactors()
        {
            try
            {
                Console.WriteLine("enter number to find prime factors");
                int number = Utility.Getinteger();
                if (number > 0)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        int count = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                count++;
                            }
                        }

                        if (count == 2)
                        {
                            int validation = 1;
                            while (number % i == 0)
                            {
                                if (validation == 1)
                                {
                                    Console.WriteLine(i);
                                    validation++;
                                }

                                number = number / i;
                            }
                        }
                    }

                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter the valid input");
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