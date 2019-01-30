namespace Funpgm1
{
    using System;
    public class Coupon
    {
        public void CouponNumbers()
        {
            try
            {
                Console.WriteLine("enter size N");
                ////this variable is used to store the length of coupon number
                int length = Utility.Getinteger();
                ////this string is used to store the resultant distinct coupon numbers
                string CouponNumber = string.Empty;
                int x = 0;
                ////this condition is used to whether the length is correct or not
                if (length > 0)
                {
                    ////creating the object of random class
                    Random random = new Random();
                    for (int i = 1; i <= length; i++)
                    {
                        string v= random.Next(0, length) + string.Empty;
                        x++;
                        ////this condition is used to check whether the numbers are repeating or not
                        if (!CouponNumber.Contains(v))
                        {
                            CouponNumber = CouponNumber + v;
                        }
                        else
                        {
                            i--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("enter proper row and column");
                }

                Console.WriteLine("random number needed to have all distinct numbers is " + x);
                Console.WriteLine("CouponNumbers are ");
                ////this loop to print the distinct coupoun numbers
                foreach (char numbers in CouponNumber)
                {
                    Console.WriteLine(numbers);
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}