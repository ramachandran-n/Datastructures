using NUnit.Framework;
using System.Collections.Generic;
using System;
using DataStructure.Search;
using DataStructure.Sort;

namespace Consumer
{
    [TestFixture]
    public class TestCases
    {
        [Test]
        public void LinearSearchTestString()
        {
            List<string> stringInputList = new List<string>();
            stringInputList.Add("Ramachandran");
            stringInputList.Add("Narayanan");
            stringInputList.Add("Chandran");
            stringInputList.Add("Ram");
            stringInputList.Add("RyuSan");
            Assert.AreEqual(3, Searching.LinearSearch(stringInputList, "Ram"));
        }
        [Test]
        public void LinearSearchTestDouble()
        {
            List<double> doubleInputList = new List<double>();
            doubleInputList.Add(10.0);
            doubleInputList.Add(14.0);
            doubleInputList.Add(19.0);
            doubleInputList.Add(26.0);
            doubleInputList.Add(27.0);
            doubleInputList.Add(31.0);
            doubleInputList.Add(33.0);
            doubleInputList.Add(35.0);
            doubleInputList.Add(42.0);
            doubleInputList.Add(44.0);
            Assert.AreEqual(3, Searching.LinearSearch(doubleInputList, 26.0));
        }

        [Test]
        public void LinearSearchTestInt()
        {
            List<int> inputList = new List<int>();
            inputList.Add(10);
            inputList.Add(14);
            inputList.Add(19);
            inputList.Add(26);
            inputList.Add(27);
            inputList.Add(31);
            inputList.Add(33);
            inputList.Add(35);
            inputList.Add(42);
            inputList.Add(44);
            Assert.AreEqual(4, Searching.LinearSearch(inputList, 27));
        }

        [Test]
        public void BinarySearchInt()
        {
            List<double> doubleInputList = new List<double>();
            doubleInputList.Add(10.0);
            doubleInputList.Add(14.0);
            doubleInputList.Add(19.0);
            doubleInputList.Add(26.0);
            doubleInputList.Add(27.0);
            doubleInputList.Add(31.0);
            doubleInputList.Add(33.0);
            doubleInputList.Add(35.0);
            doubleInputList.Add(42.0);
            doubleInputList.Add(44.0);
            Assert.AreEqual(4, Searching.BinarySearch(doubleInputList, 27.0));
        }

        [Test]
        public void BinarySearchDouble()
        {
            List<int> inputList = new List<int>();
            inputList.Add(10);
            inputList.Add(14);
            inputList.Add(19);
            inputList.Add(26);
            inputList.Add(27);
            inputList.Add(31);
            inputList.Add(33);
            inputList.Add(35);
            inputList.Add(42);
            inputList.Add(44);
            Assert.AreEqual(4, Searching.BinarySearch(inputList, 27));
        }

        [Test]
        public void BinarySearchString()
        {
            List<string> stringInputList = new List<string>();
            stringInputList.Add("Ramachandran");
            stringInputList.Add("Narayanan");
            stringInputList.Add("Chandran");
            stringInputList.Add("Ram");
            stringInputList.Add("RyuSan");
            Assert.AreEqual(2, Searching.BinarySearch(stringInputList, "Ram"));
        }

        [Test]
        public void BubbleSortInt()
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

            List<int> sortedArray = new List<int>() {-1,10,14,19,26,27,31,33,35,42,44,100};
            var outputArray = Sorting.BubbleSort(inputList);
            Assert.AreEqual(sortedArray, outputArray);
        }

        [Test]
        public void BubbleSortDouble()
        {
            List<double> doubleInputList = new List<double>();
            doubleInputList.Add(-10.0);
            doubleInputList.Add(-19.0);
            doubleInputList.Add(26.0);
            doubleInputList.Add(27.0);
            doubleInputList.Add(31.0);
            doubleInputList.Add(33.0);
            doubleInputList.Add(35.0);
            doubleInputList.Add(44.0);
            doubleInputList.Add(10.0);
            doubleInputList.Add(14.0);
            doubleInputList.Add(19.0);
            doubleInputList.Add(26.0);
            doubleInputList.Add(-14.0);
            doubleInputList.Add(42.0);

            List<double> sortedArray = new List<double>() { -19.0, -14.0, -10.0, 10.0, 14.0, 19.0, 26.0, 26.0, 27.0, 31.0, 33.0, 35.0, 42.0, 44.0 };
            var outputArray = Sorting.BubbleSort(doubleInputList);
            Assert.AreEqual(sortedArray, outputArray);
        }

        [Test]
        public void BubbleSortString()
        {
            List<string> stringInputList = new List<string>();
            stringInputList.Add("Z");
            stringInputList.Add("A");
            stringInputList.Add("D");
            stringInputList.Add("M");
            stringInputList.Add("B");

            List<string> sortedArray = new List<string>() { "A","B","D","M","Z"};
            var outputArray = Sorting.BubbleSort(stringInputList);
            Assert.AreEqual(outputArray, sortedArray);
        }

        [Test]
        public void SelectionSortInt()
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

            List<int> sortedArray = new List<int>() { -1, 10, 14, 19, 26, 27, 31, 33, 35, 42, 44, 100 };
            var outputArray = Sorting.SelectionSort(inputList);
            Assert.AreEqual(sortedArray, outputArray);
        }

        [Test]
        public void SelectionSortDouble()
        {
            List<double> doubleInputList = new List<double>();
            doubleInputList.Add(-10.0);
            doubleInputList.Add(-19.0);
            doubleInputList.Add(26.0);
            doubleInputList.Add(27.0);
            doubleInputList.Add(31.0);
            doubleInputList.Add(33.0);
            doubleInputList.Add(35.0);
            doubleInputList.Add(44.0);
            doubleInputList.Add(10.0);
            doubleInputList.Add(14.0);
            doubleInputList.Add(19.0);
            doubleInputList.Add(26.0);
            doubleInputList.Add(-14.0);
            doubleInputList.Add(42.0);

            List<double> sortedArray = new List<double>() { -19.0, -14.0, -10.0, 10.0, 14.0, 19.0, 26.0, 26.0, 27.0, 31.0, 33.0, 35.0, 42.0, 44.0 };
            var outputArray = Sorting.SelectionSort(doubleInputList);
            Assert.AreEqual(sortedArray, outputArray);
        }

        [Test]
        public void SelectionSortString()
        {
            List<string> stringInputList = new List<string>();
            stringInputList.Add("Z");
            stringInputList.Add("A");
            stringInputList.Add("D");
            stringInputList.Add("M");
            stringInputList.Add("B");

            List<string> sortedArray = new List<string>() { "A", "B", "D", "M", "Z" };
            var outputArray = Sorting.SelectionSort(stringInputList);
            Assert.AreEqual(outputArray, sortedArray);
        }
    }
}
