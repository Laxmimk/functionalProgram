namespace Funpgm1
{
    using System;
   public class Stringpermutation
    {
        public void Strpermutation()
        {
            Console.WriteLine("Enter the string");
            String str = Console.ReadLine();
            Permutation(str.ToCharArray(), 0);
            Console.ReadLine();
        }
        public void Swap(char[] arr, int i, int j)
        {
            char temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        public void Permutation(char[] arr, int index)
        {
            try
            {
                if(index== arr.Length - 1)
                {
                    Console.WriteLine(arr);
                }
                else
                {
                    for(int i=index; i<arr.Length; i++)
                    {
                        Swap(arr, index, i);
                        Permutation(arr, index + 1);
                        Swap(arr, index, i);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
