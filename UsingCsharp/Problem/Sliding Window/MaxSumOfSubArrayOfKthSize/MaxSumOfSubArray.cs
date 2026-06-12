namespace MaxSumOfSubArrayOfKthSize
{
    public class MaxSumOfSubArray
    {
        public int MaxSum(int[] array, int k)
        {
            int max = int.MinValue;
            int sum = 0;
            int i = 0, j = 0;

            while (j < array.Length)
            {
                if(j < k)
                {
                    sum += array[j++];
                    max = int.Max(max, sum);
                }
                else
                {
                    sum = sum - array[i++] + array[j++];
                    max = int.Max(max, sum);
                }
            }
            return max;
        }
    }
}
