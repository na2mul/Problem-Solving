namespace ValidBinaryPrefixUsingRecursion
{
    public class ValidBinaryPrefix
    {
        //here is the problem link
        // https://www.geeksforgeeks.org/problems/print-n-bit-binary-numbers-having-more-1s-than-0s0252/1
        public void GenerateValidBinaryNumber(int input, string output, int zeros, int ones)
        {
           if(input == 0)
            {
                Console.Write(output + ", ");
                return;
            }

            string output1 = output;
            output1 = output1.Insert(output1.Length, "1");
            GenerateValidBinaryNumber(input - 1, output1, zeros, ones + 1);

            if(ones > zeros)
            {
                output1 = output;
                output1 = output1.Insert(output1.Length, "0");
                GenerateValidBinaryNumber(input - 1, output1, zeros + 1, ones);
            }
        }   
    }
}
