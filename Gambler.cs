// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gambler.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;

    /// <summary>
    /// class gambler
    /// </summary>
    public class Gambler
    {
        /// <summary>
        /// a method for calculating a gambling amount
        /// </summary>
        public void Gambling()
        {
            try
            {
                ////original amount with the gambler
                Console.WriteLine("enter stake");
                int stake = Utility.Getinteger();
                if (stake > 0)
                {
                    ////the money want to earn
                    Console.WriteLine("enter goal");
                    int goal = Utility.Getinteger();
                    if (goal < 0)
                    {
                        Console.WriteLine("Enter the correct goal");
                        Console.ReadLine();
                    }
                    else
                    {
                        ////give value in number of times
                        Console.WriteLine("enter number of times");
                        int times = Utility.Getinteger();
                        int wins = 0;
                        int loss = 0;
                        //// creating an object of random function
                        Random random = new Random();
                        for (int i = 0; i < times; i++)
                        {
                            int cash = stake;
                            ////while loop is used to check whether the cash is greater than zero and less than goal
                            while (cash > 0 && cash < goal)
                            {
                                if (random.Next(0, 2) < 0.5)
                                {
                                    cash++;
                                }
                                else
                                {
                                    cash--;
                                }
                            }

                            if (cash == goal)
                            {
                                wins++;
                            }
                            else
                            {
                                loss++;
                            }
                        }

                        Console.WriteLine(wins + " wins of " + times);
                        Console.WriteLine(" percentage of wins is " + ((100.0 * wins) / times));
                        Console.WriteLine(" percentage of loss is " + ((100.0 * loss) / times));
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Enter the proper value");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}