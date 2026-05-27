namespace SumOfNValueUsingRecursion
{
    public class Sum
    {
        public int AddValueOneToN(List<int> list, int i = 0)
        {
            if(i == list.Count)
                return 0;
            return list[i] + AddValueOneToN(list, i+1);
        }
    }
}
