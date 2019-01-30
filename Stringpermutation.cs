// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stringpermutation.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;

    /// <summary>
    /// class String permutation to find the no of permutations possible on a given string
    /// </summary>
    public class Stringpermutation
    {
        /// <summary>
        /// a method str permutation
        /// </summary>
        public void Strpermutation()
        {
            try
            {
                Console.WriteLine("Enter the string");
                string str = Console.ReadLine();
                this.Permutation(str.ToCharArray(), 0);
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// a method to swap the letters 
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        public void Swap(char[] array, int i, int j)
        {
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        /// <summary>
        /// a method for permutations
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="index">The index.</param>
        public void Permutation(char[] array, int index)
        {
            try
            {
                if (index == array.Length - 1)
                {
                    Console.WriteLine(array);
                }
                else
                {
                    for (int i = index; i < array.Length; i++)
                    {
                        this.Swap(array, index, i);
                        this.Permutation(array, index + 1);
                        this.Swap(array, index, i);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
