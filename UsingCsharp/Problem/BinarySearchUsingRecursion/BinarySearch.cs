namespace BinarySearchUsingRecursion
{
    public class BinarySearch
    {
        public int Sort(List<int> list, int target, int l, int r)
        {
            int mid = l + ((r - l) / 2);

            if (l > r)
                return -1;

            if (list[mid] == target)
                return mid;

            if (list[mid] < target)
                l = mid + 1;
            else
                r = mid - 1;
            return Sort(list, target, l, r);
        }
    }
}
