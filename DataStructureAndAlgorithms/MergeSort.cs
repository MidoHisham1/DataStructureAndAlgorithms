using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureAndAlgorithms
{
    public class MergeSort<T> where T : IComparable<T>
    {
        public MergeSort()
        {

        }

        public static void Sort(T[] array)
        {
            if (array == null || array.Length <= 1) return;

            T[] aux = new T[array.Length];

            Sort(array, aux, 0, array.Length - 1);

            



        }


        private static void Sort(T[] array, T[] aux, int low, int high)
        {

            if (low >= high) return;

            int middle = (low + high) / 2;

            Sort(array,aux, low, middle);
            Sort(array,aux, middle + 1, high);

            Merge(array, aux , low , middle , high);
        }


        private static void Merge(T[] array, T[] aux, int low, int middle , int high)
        {

            int i = low;
            int j = middle+1;


            for (int k = low; k <= high ; k++) {
                aux[k] = array[k];
            }



            for(int k = low; k <= high;k++)
            {
                if(i > middle)
                {
                    array[k] = aux[j++];
                }
                else if(j > high)
                {
                    array[k] = aux[i++];
                }
                else if (aux[j].CompareTo(aux[i]) <= 0 )
                {
                    array[k] = aux[j++];
                }
                else
                {
                    array[k] = aux[i++];
                }
            }





        }
    }
}
