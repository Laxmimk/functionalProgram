// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReplaceString.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Laxmi K"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Funpgm1
{
    using System;

    /// <summary>
    /// class replace string to replace one string with another
    /// </summary>
    public class ReplaceString
    {
        /// <summary>
        /// to replace the name 
        /// </summary>
       public void ReplaceName()
        {
            try
            {
                Console.WriteLine("Enter the name");
                string name = Console.ReadLine();
                if (Utility.IsString(name))
                {
                    string str2 = "Hello <<username>> How are you";
                    //// replacing the name with the user input 
                    str2 = str2.Replace("<<username>>", name);
                    Console.WriteLine(str2);
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