
using System;
using System.Globalization;

namespace PlusMinus
    //Program to get an array of integers.Find the number of zeroes,positive and negative integers and find its respective ratios with respect to the size of the array.
{
    public class PlusMinus
    {
        public static void Main(string[] args)
        {
           
            int zero = 0;
            int positive = 0;
            int negative = 0;
            
            Console.WriteLine("Enter the size of the array");
            int x=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            int i;
           
            Console.Write("Input elements");

            for (i = 0; i < x; i++)
            {
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

        
            Console.Write("\n");

            for(i = 0; i < x;i++)
            {
                if (arr[i] ==0)
                {
                    zero++;
                }
                else if (arr[i] >0)
                {
                    positive++;
                }
                else
                {
                    negative++;
                }
            }
          
            float zeroratio = (float)zero / x;
            float positiveratio = (float)positive / x;
            float negativeratio = (float)negative / x;
            Console.WriteLine("Zero Ratio" + zeroratio.ToString("f6"));
            Console.WriteLine("Positive Ratio" + positiveratio.ToString("f6"));
            Console.WriteLine("Negative Ratio" + negativeratio.ToString("f6"));
        }
    }
}