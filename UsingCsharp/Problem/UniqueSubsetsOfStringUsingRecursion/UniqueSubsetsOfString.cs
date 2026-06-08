namespace UniqueSubsetsOfStringUsingRecursion
{
    public class UniqueSubsetsOfString
    {
        public HashSet<string> UniqueSubsets(string output, string input, HashSet<string> map)
        {
            if (input.Length == 0)
            {
                map.Add(output);
                return map;
            }
            string output1 = output;
            string output2 = output;

            output2 = output2.Insert(0, input[input.Length - 1].ToString());
            input = input.Remove(input.Length - 1, 1);

            UniqueSubsets(output1, input, map);
            UniqueSubsets(output2, input, map);

            return map;
        }
    }
}
