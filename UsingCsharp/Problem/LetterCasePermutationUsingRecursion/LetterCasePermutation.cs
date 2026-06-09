namespace LetterCasePermutationUsingRecursion
{
    public class LetterCasePermutation
    {
        public void Permutation(string input, string output)
        {
            if(input.Length == 0)
            {
                Console.Write(output + ", ");
                return;
            }

            if (char.IsLetter(input[0]))
            {
                string output1 = output;
                string output2 = output;

                output1 = output1.Insert(output1.Length, input[0].ToString().ToLower());
                output2 = output2.Insert(output2.Length, input[0].ToString().ToUpper());
                input = input.Remove(0, 1);

                Permutation(input, output1);
                Permutation(input, output2);
            }
            else
            {
                string output1 = output;

                output1 = output1.Insert(output1.Length, input[0].ToString());

                input = input.Remove(0, 1);

                Permutation(input, output1);
            }


        }
    }
}
