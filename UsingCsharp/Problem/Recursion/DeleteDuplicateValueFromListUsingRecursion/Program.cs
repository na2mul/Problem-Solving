using DeleteDuplicateValueFromListUsingRecursion;

var deleteDuplicateValueFromList = new DeleteDuplicateValueFromList();
var list = new List<int>() { 1, 4, 3, 4, 5, 6 };
int value = deleteDuplicateValueFromList.DeleteDuplicateValue(list, 4);

Console.WriteLine(value > -1 ? "Value Found" : "Value not Found");
foreach (var item in list)
    Console.Write(item + " ");

