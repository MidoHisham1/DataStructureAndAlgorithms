using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    public class SelectionSort
    {
        public static void Sort(IComparable[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {

                int minIndex = i;
                for (int j = i + 1; j < items.Length - 1; j++)
                {
                    if (IsLessThan(items[j], items[minIndex]))
                        minIndex = j;
                }

                Swap(items, i, minIndex);


            }
        }

        private static bool IsLessThan(IComparable ItemOne, IComparable ItemTwo)
        {
            if (ItemOne.CompareTo(ItemTwo) > -1) return false;
            return true;
        }

        private static void Swap(IComparable[] arrayToSwap, int firstIndex, int secondIndex)
        {
            var temp = arrayToSwap[firstIndex];
            arrayToSwap[firstIndex] = arrayToSwap[secondIndex];
            arrayToSwap[secondIndex] = temp;

        }

    }
}
