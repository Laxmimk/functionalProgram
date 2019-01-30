namespace Funpgm1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    /// <summary>
    /// to print a 2D array
    /// </summary>
    public class Array2D
    {
        public void TwoDArray()
        {
            try
            {
                //// the number of rows in an 2D array
                Console.WriteLine("Enter row value");
                int row = Utility.Getinteger();
               //// the number of columns in an 2D array
                Console.WriteLine("enter column value");
                int column = Utility.Getinteger();
                string[,] a = null;
                if (row >= 0 && column >= 0)
                {
                    a = new string[row, column];
                    Console.WriteLine("enter array elementa");
                    ////this is used for storing array elements 
                    for (int i = 0; i <= row - 1; i++)
                    {
                        for (int j = 0; j <= column - 1; j++)
                        {
                            a[i, j] = Console.ReadLine();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("enter the proper row and column values");
                }
                ////this loop is used for displaying array elements
                for (int i = 0; i <= row - 1; i++)
                {
                    for (int j = 0; j <= column - 1; j++)
                    {
                        Console.Write(a[i, j] + "     ");
                    }

                    Console.WriteLine();
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
