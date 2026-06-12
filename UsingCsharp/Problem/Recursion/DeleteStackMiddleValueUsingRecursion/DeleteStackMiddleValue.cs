namespace DeleteStackMiddleValueUsingRecursion
{
    public class DeleteStackMiddleValue
    {
       public void DeleteMiddleValue(Stack<int> s, int k)
        {
            if(k == 1)
            {
                s.Pop();
                return;
            }
            int temp = s.First();
            s.Pop();
            DeleteMiddleValue(s, k - 1);
            s.Push(temp);
        }
    }
}
