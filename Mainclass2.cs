﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mainclass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Parameters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// main class
    /// </summary>
    public class Mainclass
    {
        /// <summary>
        /// a main method 
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            string str = null;
            do
            {
                Console.WriteLine("Enter 1 For Power of 2");
                Console.WriteLine("Enter 2 For Euclidian distance");
                Console.WriteLine("Enter 3 For Wind chill");
                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 4:
                        Powerof2 p = new Powerof2();
                        int b = Convert.ToInt32(args[0]);
                        p.PowerOfTwo(b);
                        break;

                    case 11:
                        Euclidian e = new Euclidian();
                        int x = Convert.ToInt32(args[0]);
                        int y = Convert.ToInt32(args[1]);
                        e.Euclidiandist(x, y);
                        break;

                    case 16:
                        WindChill w = new WindChill();
                        double t = Convert.ToDouble(args[0]);
                        double v = Convert.ToDouble(args[1]);
                        w.Findwindchill(t, v);
                        break;
                    default:
                        Console.WriteLine("Please enter the valid input");
                        Console.ReadLine();
                        break;
                }
            }
            while (str != "n");
            Console.ReadLine();
        }
            }
        
    }

