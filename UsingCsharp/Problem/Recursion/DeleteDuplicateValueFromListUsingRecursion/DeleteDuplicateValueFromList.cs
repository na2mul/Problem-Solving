


namespace DeleteDuplicateValueFromListUsingRecursion
{
    public class DeleteDuplicateValueFromList
    {
        public int DeleteDuplicateValue(List<int>list, int value, int index = 0)
        {
            return Find(list, value, index);
        }

        private int Find(List<int> list, int value, int index)
        {
            if (index == list.Count)
            {
                return -1;
            }

            int result = Find(list, value, index + 1);
            if (list[index] == value)
            {
                Replace(list, index);
                RemoveLastIndex(list);
                return 1;

            }
            return result;
        }
        private void RemoveLastIndex(List<int> list)
        {
           list.RemoveAt(list.Count - 1);
        }
        private void Replace(List<int> list, int index)
        {
            if (index == list.Count - 1)
                return;
            list[index] = list[index + 1];
              Replace(list, index + 1);
        }
    }
}
