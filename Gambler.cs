namespace Funpgm1
{
    using System;
    public class Gambler
    {
        public void Gambling()
        {
            try
            {
                ////original amount with the gambler
                Console.WriteLine("enter stake");
                int stake = Utility.Getinteger();
                ////the money want to earn
                Console.WriteLine("enter goal");
                int goal = Utility.Getinteger();
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

