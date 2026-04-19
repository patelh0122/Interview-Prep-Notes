public class Solution
{
    public int[] SortArray(int[] nums)
    {
        QuickSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void QuickSort(int[] nums, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(nums, left, right);

            QuickSort(nums, left, pivotIndex - 1);
            QuickSort(nums, pivotIndex + 1, right);
        }
    }

    private int Partition(int[] nums, int left, int right)
    {
        int pivot = nums[right];   // pick last element
        int i = left;              // pointer for smaller elements

        for (int j = left; j < right; j++)
        {
            if (nums[j] < pivot)
            {
                Swap(nums, i, j);
                i++;
            }
        }

        Swap(nums, i, right); // place pivot at correct position
        return i;
    }

    private void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}