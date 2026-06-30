using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort.Functions
{
    class QuickS
    {
        public void QuickSort(int[] arr, int start, int end)
        {
            if (start >= end) return;

            int i = start;
            int j = end;
            int pivot = arr[(start + end) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                    i++;

                while (arr[j] > pivot)
                    j--;

                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    i++;
                    j--;
                }
            }

            if (start < j)
                QuickSort(arr, start, j);

            if (i < end)
                QuickSort(arr, i, end); 
        }
    }
}
