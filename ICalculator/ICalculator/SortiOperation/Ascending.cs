
namespace ICalculator.SortiOperation
{
    class Ascending : ISortiOperation
    {
        public int[] Sort(int[] array)
        {
            int beg, end;
            int count = 0;

            for (int i = 0; i < array.Length / 2; i++) //можно переберать за кол-во итераций, в 2 раза меньше
            {                                        //целочисленное деление округляет в меньшую сторону
                beg = 0;
                end = array.Length - 1;

                do
                {
                    count += 2;
                    /* идем спереди */
                    if (array[beg] > array[beg + 1])
                        Swap(array, beg, beg + 1);
                    beg++;//сдвигаем позицию вперед


                    /* идем сзади */
                    if (array[end - 1] > array[end])
                        Swap(array, end - 1, end);
                    end--;//сдвигаем позицию назад

                }
                while (beg <= end);// условия усреднения
            }
            return array;
        }


        /* Поменять элементы местами */
        private void Swap(int[] myint, int i, int j)
        {
            int glass;
            glass = myint[i];
            myint[i] = myint[j];
            myint[j] = glass;
        }
    }
}
