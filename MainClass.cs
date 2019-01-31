// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MainClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;

    /// <summary>
    /// a main class
    /// </summary>
    public class MainClass
    {
        /// <summary>
        /// the main method of the classes written using switch case 
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            try
            {
                string str = null;
                do
                {
                    Console.WriteLine("Enter 1 For Replacing string");
                    Console.WriteLine("Enter 2 For Flip coin");
                    Console.WriteLine("Enter 3 For Leap year");
                    Console.WriteLine("Enter 4 For harmonic numbers");
                    Console.WriteLine("Enter 5 For Prime factors");
                    Console.WriteLine("Enter 6 For Gambler");
                    Console.WriteLine("Enter 7 For Coupon");
                    Console.WriteLine("Enter 8 For 2DArray");
                    Console.WriteLine("Enter 9 For Adds to zero");
                    Console.WriteLine("Enter 10 For String permutations");
                    Console.WriteLine("Enter 11 For Elapsed time");
                    Console.WriteLine("Enter 12 For Quadratic");
                    Console.WriteLine("Enter 13 For Tic tac toe");
                    int num = Convert.ToInt32(Console.ReadLine());
                        switch (num)
                        {
                            case 1:
                                //// object creation
                                ReplaceString f = new ReplaceString();
                                f.ReplaceName();
                                Console.ReadLine();
                                break;
                            case 2:
                                Flipcoin cf = new Flipcoin();
                                cf.Coinflip();
                                break;
                            case 3:
                                Leapyear lp = new Leapyear();
                                lp.Findleapyear();
                                break;
                            case 4:
                                Harmonic h = new Harmonic();
                                h.Harmonicnumbers();
                                break;
                            case 5:
                                Primefactors pf = new Primefactors();
                                pf.Findprimefactors();
                                break;
                            case 6:
                                Gambler g = new Gambler();
                                g.Gambling();
                                break;
                            case 7:
                                Coupon c = new Coupon();
                                c.CouponNumbers();
                                break;
                            case 8:
                                Array2D d = new Array2D();
                                d.TwoDArray();
                                break;
                            case 9:
                                Addstozero az = new Addstozero();
                                az.Sumof3integers();
                                break;

                            case 10:
                                Stringpermutation sp = new Stringpermutation();
                                sp.Strpermutation();
                                break;
                            case 11:
                                ElapsedTime et = new ElapsedTime();
                                et.Stopwatch();
                                break;
                            case 12:
                                Quadratic q = new Quadratic();
                                q.Rootsofeqn();
                                break;
                        case 13:
                            TicTacToe tt = new TicTacToe();
                            tt.Player();
                            tt.Computer();
                            tt.DisplayGame();
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}