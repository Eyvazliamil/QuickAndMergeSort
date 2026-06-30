using QuickSort.Functions;

QuickS quicksort = new QuickS();

int[] numList = {11, 45, 23, 8, 1, 99, 34, 6 };
quicksort.QuickSort(numList, 0, numList.Length - 1);


foreach (int n in numList)
    Console.WriteLine(n);