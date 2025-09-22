namespace LeetCode.src._1;

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var result = new int[2];
        var indexByNums = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var searchedValue = target - nums[i];

            if (indexByNums.TryGetValue(searchedValue, out var searchedValueIndex))
            {
                result[0] = i;
                result[1] = searchedValueIndex;
                return result;
            }

            _ = indexByNums.TryAdd(nums[i], i);
        }

        return result;
    }
}
