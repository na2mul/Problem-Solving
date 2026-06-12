namespace SubsetsOfStringsUsingRecursion
{
    public class SubsetsOfString
    {
        public void DisplaySubsets(string output, string input)
        {
            if(input.Length == 0)
            {
                Console.Write(output + ", ");
                return;
            }
            string output1 = output;
            string output2 = output;

            output2 = output2.Insert(0, input[input.Length-1].ToString());
            input = input.Remove(input.Length-1,1);

            DisplaySubsets(output1, input);
            DisplaySubsets(output2, input);

            return;
        }
    }
}
