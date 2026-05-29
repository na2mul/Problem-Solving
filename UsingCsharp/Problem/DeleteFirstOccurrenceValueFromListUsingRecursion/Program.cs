using DeleteFirstOccurrenceValueFromListUsingRecursion;

var deleteFirstOccurrenceValueFromList = new DeleteFirstOccurrenceValueFromList();
var list = new List<int>() { 1, 4, 3, 4, 5, 6 };

Console.Write("Before     ");
foreach (var item in list)
    Console.Write(item + " ");
Console.WriteLine();

int value = deleteFirstOccurrenceValueFromList.DeleteFirstOccurrenceValue(list, 4);

Console.WriteLine(value > -1 ? "Value Found" : "Value not Found");
Console.Write("After      ");
foreach (var item in list)
    Console.Write(item + " ");
