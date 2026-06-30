using MergeSort.FolderMergeSort;

int[] arr = { 11, 45, 23, 8, 1, 99, 34, 6 };

MergeS merge = new MergeS();
merge.MergeSort(arr, 0, arr.Length - 1);

foreach (int n in arr)
{
    Console.WriteLine(n);
}