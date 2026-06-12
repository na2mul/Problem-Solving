namespace GenerateAllBalancedParenthesesUsingRecursion
{
    public class GenerateAllBalancedParentheses
    {
        public void AllBalancedParentheses(int openBracket, int closeBracket, string output)
        {
            if(openBracket == 0 && closeBracket == 0)
            {
                Console.Write(output + ", ");
                return;
            }

            if(openBracket != 0)
            {
                string output1 = output;
                output1 = output1.Insert(output1.Length, "(");
                AllBalancedParentheses(openBracket - 1, closeBracket, output1);
            }

            if(openBracket < closeBracket)
            {
                string output2 = output;
                output2 = output2.Insert(output2.Length, ")");
                AllBalancedParentheses(openBracket, closeBracket - 1, output2);
            }
        }
    }
}
