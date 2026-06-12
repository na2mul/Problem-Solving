
namespace ReverseStackUsingRecursion
{
    public class ReverseStack
    {
        public void Reverse(Stack<int> stack)
        {
            if (stack.Count == 1)
                return;
            int temp = stack.First();
            stack.Pop();
            Reverse(stack);
            Insert(stack, temp);
        }

        private void Insert(Stack<int> stack, int temp)
        {
            if (stack.Count == 0)
            {
                stack.Push(temp);
                return;
            }
            int value = stack.First();
            stack.Pop();
            Insert(stack, temp);
            stack.Push(value);
        }
    }
}
