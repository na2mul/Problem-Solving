using ReverseStackUsingRecursion;

var reverseStack = new ReverseStack();

var stack = new Stack<int>();

for (int i = 1; i <= 9; i++)
{
    stack.Push(i);
}

reverseStack.Reverse(stack);

foreach(var item in stack)
{
    Console.WriteLine(item);
}