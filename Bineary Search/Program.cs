using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bineary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter array (eg: 1,2) : ");
            string str = Console.ReadLine();

            Console.WriteLine("Please Enter Value to Search : ");
            int value = Console.Read();

            string[] strArray = str.Split(',');
            int[] array = new int[strArray.Length]; 

            for(int i=0; i< strArray.Length; i++)
            {
                array[i] = Convert.ToInt32(strArray[i]);
            }


            Console.WriteLine(SearchByBinary(array, value));
            Console.ReadLine();
        }

        private static string SearchByBinary(int[] array, int value)
        {
            string result = "value not found";
            int lower = 1;
            int upper = array.Length;

            //O(LogN)
            while (lower <= upper)
            {
                int midpoint = (lower + upper) / 2;
                if (array[midpoint] > value)
                {
                    upper = midpoint - 1;
                }
                else if (array[midpoint] < value)
                {
                    lower = midpoint + 1;
                }
                else
                {
                    result = "Value found in " + midpoint;
                }
            }

            return result;
        }
    }
}
