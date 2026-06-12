namespace FindKthSymbolInGrammarUsingRecursion
{
    public class FindKthSymbolInGrammar
    {
        public bool FindKthGrammar(int n, int k)
        {
            if(n == 1 &&  k == 1) return false;

            int mid = (int)Math.Pow(2 ,n - 1)/2;

            if(k <= mid)
                return FindKthGrammar(n-1, k);
            else
                return !FindKthGrammar(n, k-mid);
        }
    }
}
