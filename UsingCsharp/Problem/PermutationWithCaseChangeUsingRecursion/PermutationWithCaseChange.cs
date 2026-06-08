namespace PermutationWithCaseChangeUsingRecursion
{
    public class PermutationWithCaseChange
    {
        public void Permutation(string output, string input)
        {
            if(input.Length == 0)
            {
                Console.Write(output + ", ");
                return;
            }

            string output1 = output;
            string output2 = output;

            output1 = output1.Insert(output1.Length, input[0].ToString());
            output2 = output2.Insert(output2.Length, input[0].ToString().ToUpper());

            input = input.Remove(0, 1);

            Permutation(output1, input);
            Permutation(output2, input);
        }
    }
}
