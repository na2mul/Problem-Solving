using SortListUsingRecursion;

var sort = new SortList();
var list = new List<int>() { 2, 1, 5, 3, 4 };
sort.Sort(list);

foreach(var item in list)
{
    Console.Write(item + " ");
}