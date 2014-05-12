
namespace ICalculator.SortiOperation
{
   public class Ascending : ISortiOperation
    {
        public int[] Sort(int[] array)
        {
            int beg, end;
            int count = 0;

            for (int i = 0; i < array.Length / 2; i++) 
            {                                      
                beg = 0;
                end = array.Length - 1;

                do
                {
                    count += 2;
                 
                    if (array[beg] > array[beg + 1])
                        Swap(array, beg, beg + 1);
                    beg++;

                    if (array[end - 1] > array[end])
                        Swap(array, end - 1, end);
                    end--;

                }
                while (beg <= end);
            }
            return array;
        }

        private void Swap(int[] myint, int i, int j)
        {
            int glass;
            glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }
    }
}
