// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quadratic.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;

    /// <summary>
    /// class quadratic 
    /// </summary>
    public class Quadratic
    {
        /// <summary>
        /// a method to find the roots of the quadratic equation 
        /// </summary>
        public void Rootsofeqn()
        {
            try
            {
                int a, b, c;
                double delta, x;
                double y;
                Console.WriteLine("Enter the value of a");
                a = Utility.Getinteger();
                Console.WriteLine("Enter the value of b");
                b = Utility.Getinteger();
                Console.WriteLine("Enter the value of c");
                c = Utility.Getinteger();
                delta = (b * b) - (4 * a * c);
                if (delta == 0)
                {
                    Console.WriteLine("Both the roots are equal");
                    x = -b / (2.0 * a);
                    y = -b / (2.0 * a);
                    Console.WriteLine("The first root is = {0} ", x);
                    Console.WriteLine("The second root is = {0} ", y);
                    Console.ReadLine();
                }
                else if (delta > 0)
                {
                    Console.WriteLine("The roots are real and different");
                    x = (-b + Math.Sqrt(delta)) / (2 * a);
                    y = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("The first root is = {0} ", x);
                    Console.WriteLine("The second root is = {0} ", y);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("the roots are imaginary");
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
