using FindKthSymbolInGrammarUsingRecursion;

var findKthGrammar = new FindKthSymbolInGrammar();

for (int n = 1; n<=4; n++)
{
    int m = (int)Math.Pow(2, n - 1);
	for (int k = 1; k <= m; k++)
	{
        Console.Write(findKthGrammar.FindKthGrammar(n, k) + " ");
    }
    Console.WriteLine();
}