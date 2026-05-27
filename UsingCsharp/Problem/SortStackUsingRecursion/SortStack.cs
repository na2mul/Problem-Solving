namespace SortStackUsingRecursion
{
    public class SortStack
    {
        public void Sort(Stack<int> s)
        {

            if (s.Count == 1)
                return;
            int temp = s.First();
            s.Pop();
            Sort(s);
            Insert(s, temp);
        }
        public void Insert(Stack<int> s, int temp)
        {
            if (s.Count == 0 || s.First() >= temp)
            {
                s.Push(temp);
                return;
            }
            int value = s.First();
            s.Pop();
            Insert(s, temp);
            s.Push(value);
        }
    }
}
