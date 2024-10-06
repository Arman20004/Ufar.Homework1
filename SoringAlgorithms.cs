namespace Ufar.Homework
{
    public static class SortingAlgorithms
    {
        public static void BubbleSortRecursive(int[] array)
        {
            BubbleSortRecursiveHelper(array, array.Length);
        }

        private static void BubbleSortRecursiveHelper(int[] array, int n)
        {
            if (n == 1)
                return;

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    // Swap array[i] and array[i + 1]
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }

            BubbleSortRecursiveHelper(array, n - 1);
        }


        //////////////////////////////////////////////////////////////////////////////////////////

        public static void SelectionSortRecursive(int[] array)
        {
            SelectionSortRecursiveHelper(array, array.Length, 0);
        }

        private static void SelectionSortRecursiveHelper(int[] a, int n, int index)
        {
            if (index == n)
                return;

            int k = minIndex(a, index, n - 1);

            if (k != index)
            {
                int temp = a[k];
                a[k] = a[index];
                a[index] = temp;
            }

            // Recursively calling selection sort function
            SelectionSortRecursiveHelper(a, n, index + 1);

        }

        private static int minIndex(int[] a, int i, int j)
        {
            if (i == j)
                return i;

            // Find minimum of remaining elements
            int k = minIndex(a, i + 1, j);

            // Return minimum of current and remaining.
            return (a[i] < a[k]) ? i : k;
        }
    }
            
}