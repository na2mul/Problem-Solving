namespace PermutationWithSpaceUsingRecursion
{
    public class PermutationWithSpace
    {
        public void Permuation(string output, string input)
        {
            if(input.Length == 0)
            {
                Console.Write(output + ", ");
                return;
            }

            string output1 = output;
            string output2 = output;
            output1 = output1.Insert(output1.Length, " ");
            output1 = output1.Insert(output1.Length, input[0].ToString());

            output2 = output2.Insert(output2.Length, input[0].ToString());
            input = input.Remove(0, 1);

            Permuation(output1, input);
            Permuation(output2, input);
        }
    }
}
