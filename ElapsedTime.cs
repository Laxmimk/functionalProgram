namespace Funpgm1
{
    using System;
    using System.Diagnostics;

   public class ElapsedTime
    {
        public void Stopwatch()
        {
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                Console.WriteLine("enter 1 to start ");
                ////is used to call start time method
                int i = Utility.Getinteger();
                if (i == 1)
                {
                    stopwatch.Start();
                }

                Console.WriteLine("enter 0 to stop ");
                ////is used to call stop time method
                int j = Utility.Getinteger();
                if (j == 0)
                {
                    stopwatch.Stop();
                }

                ////printing the elapse time
                Console.WriteLine("elapsed time is " + stopwatch.Elapsed);
                Console.ReadLine();

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
