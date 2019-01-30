namespace Funpgm1
{
    using System;
    
   public class ReplaceString
    {
        /// <summary>
        /// to replace the name 
        /// </summary>
       public void ReplaceName()
        {
            Console.WriteLine("Enter the name");
            String name = Console.ReadLine();
            if (Utility.IsString(name))
            {
                String str2 = "Hello <<username>> How are you";
                //// replacing the name with the user input 
                str2 = str2.Replace("<<username>>", name);
                Console.WriteLine(str2);
                Console.ReadLine();
            }
        }
    }
}
