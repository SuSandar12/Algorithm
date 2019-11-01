using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter string to be processed: ");
            var inputString = Console.ReadLine();
            URLifyString(inputString);
            Console.ReadLine();
        }

        private static void URLifyString(string inputString)
        {
            if (inputString != null)
            {
                //Find out the length of the given string    
                int inputStringLength = inputString.Length;
                //Convert the given string into an array of type character    
                char[] inputCharacterSet = inputString.ToCharArray();

                //Find out the count of spaces within the input string     
                int spaceInStringCount = 0;
                for (int indexCount = 0; indexCount < inputStringLength; indexCount++)
                {
                    if (inputCharacterSet[indexCount] == ' ')
                    {
                        spaceInStringCount++;
                    }
                }

                // multiply the number of spaces with 2 to find out the extra space required to replace ' ' with '%20'    
                // for example if there is one ' ' space then we need two extra places     
                // the given string to add '%20'    
                int extraSpacesRequired = (spaceInStringCount * 2);
                //add extra spaces required to shift characters and replace ' ' with '%20'    
                inputCharacterSet = inputCharacterSet.Concat(new char[extraSpacesRequired]).ToArray();
                int inputCharacterSetCurrentIndex = inputStringLength - 1 + extraSpacesRequired;

                //iterate through the given string but note that start from the end and working backwards because    
                //we have added an extra buffer at the end, which allows us to change characters without worrying about what we're overwriting.    
                for (int inputIndex = inputStringLength - 1; inputIndex >= 0; inputIndex--)
                {
                    //if ' ' space found then replace ' ' with '%20'    
                    if (inputCharacterSet[inputIndex] == ' ')
                    {
                        inputCharacterSet[inputCharacterSetCurrentIndex--] = '0';
                        inputCharacterSet[inputCharacterSetCurrentIndex--] = '2';
                        inputCharacterSet[inputCharacterSetCurrentIndex--] = '%';
                    }
                    else
                    {
                        //if not found then shift current character by 2 places    
                        inputCharacterSet[inputCharacterSetCurrentIndex--] = inputCharacterSet[inputIndex];
                    }
                }
                Console.Write("Modified string is :");
                Console.WriteLine(inputCharacterSet);
            }
        }
    }
}