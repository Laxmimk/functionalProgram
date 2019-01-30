namespace Funpgm1
{
    using System;
    class Harmonic
    {
        public void Harmonicnumbers()
        {
            try
            {
                Console.WriteLine("enter to find n th harmonic number");
                int n = Utility.Getinteger();
                float result = 0;
                ////this loop is used for finding the n th harmonic number
                for (int i = 1; i <= n; i++)
                {
                    result = result + (float)(1.0 / i);
                }

                Console.WriteLine("n th harmonic number is " + result);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

