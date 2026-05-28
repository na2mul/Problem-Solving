namespace DeleteStackMiddleValueUsingRecursion
{
    public class DeleteStackMiddleValue
    {
       public void DeleteMiddleValue(Stack<int> v, int k)
        {
            if(k == 1)
            {
                v.Pop();
                return;
            }
            int temp = v.First();
            v.Pop();
            DeleteMiddleValue(v, k - 1);
            v.Push(temp);
        }
    }
}
