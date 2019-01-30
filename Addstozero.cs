// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Addstozero.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;

    /// <summary>
    /// class for Adds to zero
    /// </summary>
    public class Addstozero
    {
        /// <summary>
        /// a method to sum the 3 integers
        /// </summary>
        public void Sumof3integers()
        {
            try
            {
                int count = 0;
                ////taking user input to fix the size of array
                Console.WriteLine("Enter size of array");
                int n = Convert.ToInt32(Console.ReadLine());
                ////declaring and initializing the array
                int[] arr = new int[n];
                ////taking user input to enter n numbers in array
                Console.WriteLine("Enter " + n + " numbers");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                ////printing all the elements of an array
                Console.WriteLine("Entered numbers are:");
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    Console.Write(arr[i] + " ");
                }
                ////for generating new line
                Console.WriteLine();
                ////iteration to check which num when add will result zero
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = i + 1; j < arr.GetLength(0); j++)
                    {
                        for (int k = j + 1; k < arr.GetLength(0); k++)
                        {
                            ////execute if add of num is zero
                            if (arr[i] + arr[j] + arr[k] == 0)
                            {
                                count++;
                                Console.WriteLine("Number which give zero after add are: " + arr[i] + " " + arr[j] + " " + arr[k]);
                                Console.ReadLine();
                            }
                        }
                    }
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