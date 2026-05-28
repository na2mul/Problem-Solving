using DeleteStackMiddleValueUsingRecursion;

var deleteStackMiddleValue = new DeleteStackMiddleValue();
var stack = new Stack<int>();
for (int i = 1; i <= 9; i++)
{
    stack.Push(i);
}
deleteStackMiddleValue.DeleteMiddleValue(stack, stack.Count / 2 + 1);

foreach(var item in stack)
{
    Console.Write( item + " ");
}