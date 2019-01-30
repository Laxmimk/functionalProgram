
namespace Funpgm1
{
    using System;

    public class MainClass
    {
        /// <summary>
        /// the main method of the classes written using switch case 
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            String n;
            Console.WriteLine("Enter the number to get the input");
            n = Console.ReadLine();
            //// to write the repetative pgm 
            if (Utility.Integerof(n) == true)
            {
                Console.WriteLine("Please enter the proper input");
                Console.ReadLine();
            }
            else
            {
                int num = Convert.ToInt32(n);
                
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
                    case 5:
                        Harmonic h = new Harmonic();
                        h.Harmonicnumbers();
                        break;
                    case 6:
                        Primefactors pf = new Primefactors();
                        pf.Findprimefactors();
                        break;
                    case 7:
                        Gambler g = new Gambler();
                        g.Gambling();
                        break;
                    case 8:
                        Coupon c = new Coupon();
                        c.CouponNumbers();
                        break;
                    case 9:
                        Array2D d = new Array2D();
                        d.TwoDArray();
                        break;
                    case 10:
                        Addstozero az = new Addstozero();
                        az.Sumof3integers();
                        break;

                    case 12:
                        Stringpermutation sp = new Stringpermutation();
                        sp.Strpermutation();
                        break;
                    case 13:
                        ElapsedTime et = new ElapsedTime();
                        et.Stopwatch();
                        break;
                    case 15:
                        Quadratic q = new Quadratic();
                        q.Rootsofeqn();
                        break;
                }
            }
        }
    }
}
