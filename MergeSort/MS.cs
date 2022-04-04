using System;

namespace MergeSort
{
    class MS
    {
        void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
            {
                L[i] = arr[l + i];
            }
            for (j = 0; j < n2; ++j)
            {
                R[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }

            for (int x = 0; x < arr.Length; ++x)
            {
                Console.Write(arr[x] + " ");
            }
            Console.WriteLine("\n");
        }

        void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;

                sort(arr, l, m);
                sort(arr, m + 1, r);

                merge(arr, l, m, r);
            }
        }

        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 16, 21, 11, 8, 12, 22 };
            MS meSo = new MS();
            meSo.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("Siralanmis Dizimiz");
            printArray(arr);
        }
    }
}
/*
[16,21,11,8,12,22] -> Merge Sort

    1. Yukarıdaki dizinin sort türüne göre aşamalarını yazınız.
    2. Big-O gösterimini yazınız.

1. Adım: 16 21 11 8 12 22

2. Adım: 11 16 21 8 12 22

3. Adım: 8 11 12 16 21 22

    2. Big-O notasyonu, Average case, Worst case, Best case her üç durumda da O(nlogn) dir.
*/