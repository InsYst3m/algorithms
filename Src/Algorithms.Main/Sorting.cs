namespace Algorithms.Main
{
    public class Sorting
    {
        public int[] InsertionSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                int j = i;

                while (j > 0 && inputArray[j] < inputArray[j - 1])
                {
                    (inputArray[j - 1], inputArray[j]) = (inputArray[j], inputArray[j - 1]);

                    j--;
                }
            }

            return inputArray;
        }
    }
}