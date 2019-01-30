// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ElapsedTime.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;
    using System.Diagnostics;

    /// <summary>
    /// class for finding an elapsed time
    /// </summary>
    public class ElapsedTime
    {
        /// <summary>
        /// a method stopwatch to calculate the elapsed time
        /// </summary>
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
