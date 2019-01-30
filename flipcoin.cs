namespace Funpgm1
{
    using System;
    public class Flipcoin
    {
        /// <summary>
        /// finding the num of flip coins and printing the percentage
        /// </summary>
        public void Coinflip()
        {
            int num;
            int head = 0;
            int tail = 0;
            try
            {
                Console.WriteLine("Enter the number of times to flip the coin");
                //// converts the string input to integer 
                num = Convert.ToInt32(Console.ReadLine());
                //// generating the random values
                Random r = new Random();
                if (num > 0)
                {
                    //// loop to generate the different random numbers
                    for (int i = 1; i <= num; i++)
                    {
                        int var = r.Next(1, 3);
                        if (var < 1.5)
                        {
                            tail++;
                        }
                        else
                        {
                            head++;
                        }
                    }
                    Console.WriteLine(tail);
                    //// finding the percentage of tails and heads 
                    int tailpercentage = (tail * 100) / num;
                    int headpercentage = (head * 100) / num;
                    Console.WriteLine("the percentage of tail is " + tailpercentage);
                    Console.WriteLine("the percentage of head is " + headpercentage);
                }
                else
                {
                    Console.WriteLine("Enter the number which is greater then zero");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


    }
    }

