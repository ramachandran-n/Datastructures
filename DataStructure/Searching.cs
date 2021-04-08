using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Search
{
    public static class Searching
    {
        /// <summary>
        /// Created by Ramachandran Narayanan
        /// Implements a simple linear search
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="searchItem"></param>
        public static int LinearSearch<T>(List<T> inputArray, T searchItem)
        {
            for(int i = 0; i < inputArray.Count; i++)
            {
                if(EqualityComparer<T>.Default.Equals(inputArray[i], searchItem))
                {
                    
                    return i;
                }
            }
            return -1;
        }

        public static int BinarySearch<T>(List<T> inputArray, T searchItem)
        {
            //Sort the array
            inputArray.Sort();
            //Set the lower bound
            int lowerBound = 0;
            //Set the upperBound
            int upperBound = inputArray.Count();
            //Set the search flag as false
            bool foundFlag = false;
            //Set the midPoint
            int midPoint = 0;

            while (foundFlag == false)
            {
                if (upperBound < lowerBound)
                    break;
                
                //Calculate the midPoint value
                midPoint = lowerBound + (upperBound - lowerBound) / 2;
                Debug.WriteLine(Comparer<T>.Default.Compare(inputArray[midPoint], searchItem));
                if (Comparer<T>.Default.Compare(inputArray[midPoint],searchItem) == -1)
                    lowerBound = midPoint + 1;

                if (Comparer<T>.Default.Compare(inputArray[midPoint], searchItem) == 1)
                    upperBound = midPoint - 1;

                if (Comparer<T>.Default.Compare(inputArray[midPoint], searchItem) == 0)
                {
                    foundFlag = true;
                    return midPoint;
                }
            }
            return -1;
        }
    }
}
