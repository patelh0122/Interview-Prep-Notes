int BinarySearch(int[] nums, int target, bool findFirst)
{
    int left = 0, right = nums.Length - 1;
    int result = -1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (nums[mid] == target)
        {
            result = mid;

            if (findFirst)
                right = mid - 1; // go LEFT
            else
                left = mid + 1;  // go RIGHT
        }
        else if (nums[mid] < target)
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }

    return result;
}