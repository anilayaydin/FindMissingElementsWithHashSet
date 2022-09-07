using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        
        static List<int> findMissingElements(int[] arr1, int[] arr2) {

            List<int> missingElements = new List<int>();
            HashSet<int> secondArrayItems = new HashSet<int>();

            foreach (var item in arr2)
            {
                secondArrayItems.Add(item);
            }

            foreach (var item in arr1)
            {
                if(!secondArrayItems.Contains(item))
                    missingElements.Add(item);
            }

            return missingElements;


        }
        
        static void Main(string[] args) {

            int[] arr1 = {1,3,5,7,8,10};
            int[] arr2 = {3,4,5,7,9,10,11,12};

            List<int> missingElements = findMissingElements(arr1,arr2);

            foreach (var item in missingElements)
            {
                System.Console.WriteLine(item);
            }

        }
    }
}