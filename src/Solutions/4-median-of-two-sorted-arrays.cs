namespace Solutions
{
    public partial class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var totalElementsCount = nums1.Length + nums2.Length;
            var medianArrCount = (totalElementsCount / 2) + 1;

            var current = 0;
            var previous = 0;

            for (int i1 = 0, i2 = 0; (i1 + i2) < medianArrCount;)
            {
                var takeFirst =
                    (i2 >= nums2.Length) ||
                    (i1 < nums1.Length && nums1[i1] < nums2[i2]);

                previous = current;
                current = takeFirst ? nums1[i1++] : nums2[i2++];
            }

            var isEven = totalElementsCount % 2 == 0;
            return isEven ? (previous + current) / 2.0 : current;
        }
    }
}
