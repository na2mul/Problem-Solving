namespace SortListUsingRecursion
{
    public class SortList
    {
        public void Sort(List<int> list)
        {
            if (list.Count == 1)
                return;
            int temp = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Sort(list);
            Insert(list, temp);
        }
        public void Insert(List<int> list, int temp)
        {
            if (list.Count == 0 || list[list.Count - 1] <= temp)
            {
                list.Add(temp);
                return;
            }
            int value = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            Insert(list, temp);
            list.Add(value);
        }
    }
}
