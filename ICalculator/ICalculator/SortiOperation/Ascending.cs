
namespace ICalculator.SortiOperation
{
   public class Ascending : ISortiOperation
    {
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++) 
            {                                      
                int begin = 0;
                int end = array.Length - 1;

                do
                {
                    if (array[begin] > array[begin + 1])
                        Swap(array, begin, begin + 1);
                    begin++;

                    if (array[end - 1] > array[end])
                        Swap(array, end - 1, end);
                    end--;

                }
                while (begin <= end);
            }
            return array;
        }

        private void Swap(int[] myint, int i, int j)
        {
            int temp = myint[i];
            myint[i] = myint[j];
            myint[j] = temp;
        }
    }
}
