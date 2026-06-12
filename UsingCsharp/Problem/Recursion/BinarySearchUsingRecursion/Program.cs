using BinarySearchUsingRecursion;

var binarySearch = new BinarySearch();

var list = new List<int>() { 1, 3, 5, 7, 9 };

for(int i = 0; i <= 10 ; i++)
{
    int val = binarySearch.Sort(list, i, 0, list.Count - 1);
    Console.WriteLine( val > -1 ? $"{i} Found at index: {val}" :  $"{i} No Found: {val}");
}