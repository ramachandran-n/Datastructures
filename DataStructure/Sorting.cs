using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Sort
{
    public static class Sorting
    {
        public static List<T> BubbleSort<T>(List<T> inputArray)
        {
            //Get the count of the inputArray
            int arrayLengh = inputArray.Count();
            //Set the sorted flag
            bool sorted;
            //Set the temp variable
            T temp;
            //Outer loop
            for (int i = 0; i < arrayLengh; i++)
            {
                //Set the value of the sorted flag
                sorted = false;
                //Inner loop
                for (int j = 0; j < arrayLengh-1; j++)
                {
                    if(Comparer<T>.Default.Compare(inputArray[j], inputArray[j + 1]) == 1)
                    {
                        temp = inputArray[j];
                        inputArray[j] = inputArray[j + 1];
                        inputArray[j + 1] = temp;
                        sorted = true;
                    }
                }

                //Check for the sorted flag - if false all elements are sorted
                if(sorted==false)
                    //If sorted is false break the loop
                    break;
            }
            return inputArray;
        }

        public static List<T> SelectionSort<T>(List<T> inputArray)
        {
            //Get the count of the inputArray
            int arrayLength = inputArray.Count();
            //Set the temp variable
            T temp;
            //Set the minimum value in the array
            int minimumValue = 0;
            //Set the loop counters
            int i = 0;
            int j = 0;
            //Outer loop

            for(i = 0; i < arrayLength-1 ; i++)
            {
                //Assign the element at index i to minimumValue
                minimumValue = i;
                //Inner loop to check the minimum value
                for(j = i + 1; j < arrayLength; j++)
                {
                    if(Comparer<T>.Default.Compare(inputArray[j], inputArray[minimumValue]) == -1)
                    {
                        minimumValue = j;
                    }
                }

                if(Comparer<T>.Default.Compare(inputArray[i], inputArray[minimumValue])!= 0)
                {
                    //swap the values
                    temp = inputArray[i];
                    inputArray[i] = inputArray[minimumValue];
                    inputArray[minimumValue] = temp;
                }
            }
            return inputArray;
        }
    }
}
