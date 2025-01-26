public class InsertionSort
{
        public static void Main(string[] args)
        {
            int[] arrayToSort = { 42, 41, 43, 25, 26 };
            SortArray(arrayToSort);
            PrintArray(arrayToSort);
        }

        private static void SortArray(int[] data) 
        {
            for (int i = 1; i < data.Length; ++i)
            {
                int current = data[i];
                int j = i - 1;
  
                while (j >= 0 && data[j] > current)
                {
                    data[j + 1] = data[j];
                    j = j - 1;
                }

                data[j + 1] = current;
            }
        }

        private static void PrintArray(int[] data)
        {
	    Console.Write("Posortowana tablica:\n");

            for (int i = 0; i < data.Length; ++i)
                Console.Write(data[i] + " ");

            Console.Write("\n");
        }
}