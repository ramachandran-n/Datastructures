using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructure;
using DataStructure.Sort;

namespace DataStructure.Search
{
    class DataStructureConsumer
    {
        static void Main(string[] args)
        {
            List<int> inputList = new List<int>();
            inputList.Add(33);
            inputList.Add(100);
            inputList.Add(10);
            inputList.Add(14);
            inputList.Add(35);
            inputList.Add(42);
            inputList.Add(44);
            inputList.Add(19);
            inputList.Add(26);
            inputList.Add(27);
            inputList.Add(31);
            inputList.Add(-1);

            List<double> doubleInputList = new List<double>();
            doubleInputList.Add(-10.0);
            doubleInputList.Add(-14.0);
            doubleInputList.Add(-19.0);
            doubleInputList.Add(26.0);
            doubleInputList.Add(27.0);
            doubleInputList.Add(31.0);
            doubleInputList.Add(33.0);
            doubleInputList.Add(35.0);
            doubleInputList.Add(42.0);
            doubleInputList.Add(44.0);
            doubleInputList.Add(10.0);
            doubleInputList.Add(14.0);
            doubleInputList.Add(19.0);
            doubleInputList.Add(26.0);


            List<string> stringInputList = new List<string>();
            stringInputList.Add("Ramachandran");
            stringInputList.Add("Narayanan");
            stringInputList.Add("Chandran");
            stringInputList.Add("Ram");
            stringInputList.Add("RyuSan");

            //Console.WriteLine(Searching.LinearSearch(doubleInputList, 14.0));
            //Console.WriteLine(Searching.LinearSearch(stringInputList, "Ram"));
            //Console.WriteLine(Searching.BinarySearch(inputList, 19));
            //Console.WriteLine(Searching.BinarySearch(doubleInputList, 19.0));
            //Console.WriteLine(Searching.BinarySearch(stringInputList, "Ramachandran"));
            var outputArray = Sorting.BubbleSort(doubleInputList);
            foreach (var element in outputArray)
            {
                Console.WriteLine(element);
            }

        }
    }
}
