public class Solution {
    public int[] SortArray(int[] nums) {
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void MergeSort(int[] arr, int start, int end)
    {
        if (start < end)
        {
            int mid = start + (end - start) / 2;

            MergeSort(arr, start, mid);
            MergeSort(arr, mid + 1, end);
            Merge(arr, start, mid, end);
        }
    }

    private void Merge(int[] nums, int start, int mid, int end)
    {
        int[] temp = new int[end - start + 1];
        int leftPtr = start;
        int rightPtr = mid + 1;
        int index = 0;

        while (leftPtr <= mid && rightPtr <= end)
        {
            if (nums[leftPtr] <= nums[rightPtr])
            {
                temp[index] = nums[leftPtr];
                leftPtr++;
            }
            else
            {
                temp[index] = nums[rightPtr];
                rightPtr++;
            }
            index++;
        }

        while (leftPtr <= mid)
        {
            temp[index] = nums[leftPtr];
            leftPtr++;
            index++;
        }

        while (rightPtr <= end)
        {
            temp[index] = nums[rightPtr];
            rightPtr++;
            index++;
        }

        for (int i = 0; i < temp.Length; i++)
        {
            nums[start + i] = temp[i];
        }
    }
}