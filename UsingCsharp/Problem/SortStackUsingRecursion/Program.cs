using SortStackUsingRecursion;

var sortStack = new SortStack();

var stack = new Stack<int>();

stack.Push(5);
stack.Push(2);
stack.Push(3);
stack.Push(4);
stack.Push(1);

sortStack.Sort(stack);

foreach (var item in stack)
{
    Console.Write(item + " ");
}