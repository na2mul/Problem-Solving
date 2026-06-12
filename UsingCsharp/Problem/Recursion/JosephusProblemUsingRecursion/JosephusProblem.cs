namespace JosephusProblemUsingRecursion
{
    public class JosephusProblem
    {
        public int FindSurvivorNumber(List<int> input, int k, int index = 0)
        {
            if (input.Count == 1)
                return input[0];

            index = (index + k - 1) % input.Count;
            input.RemoveAt(index);
            return FindSurvivorNumber(input, k, index);
        }
    }
}
