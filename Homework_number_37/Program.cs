using System;
using System.Collections.Generic;

namespace Homework_number_37
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dataStorage = new List<string>();
            string[] array1 = new string[] { "1", "2", "4" };
            string[] array2 = new string[] { "3", "5", "4" };

            AddArrayInCollection(dataStorage, array1);
            AddArrayInCollection(dataStorage, array2);

            PrintCollection(dataStorage);
        }

        private static void AddArrayInCollection(List<string> collection, string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (collection.Contains(array[i]) == false)
                {
                    collection.Add(array[i]);
                }
            }
        }

        private static void PrintCollection(List<string> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                Console.Write($"{collection[i]} ");
            }
        }
    }
}
