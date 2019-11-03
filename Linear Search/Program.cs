using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter array (eg: 1,2) : ");
            string str = Console.ReadLine();

            Console.WriteLine("Please Enter Value to Search : ");
            string value = Console.ReadLine();

            string[] array = str.Split(',');

            Console.WriteLine(SearchByLinear(array, value));
            Console.ReadLine();

        }

        public object[] StringToArray(string input, string separator, Type type)
        {
            string[] stringList = input.Split(separator.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            Object[] list = new object[stringList.Length];

            for (int i = 0; i < stringList.Length; i++)
            {
                list[i] = Convert.ChangeType(stringList[i], type);
            }
            return list;
        }

        public static string SearchByLinear(string[] array, string value)
        {
            string result = "value not found";

            for (int j = 0; j < array.Length; j++)
            {
                if(value == array[j])
                {
                    result += "Value found in array index : " + j;
                }
            }

            return result;
        }

        
    }
}
