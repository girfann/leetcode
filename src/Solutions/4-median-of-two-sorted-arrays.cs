using System;

namespace Solutions
{
    public partial class Solution
    {
        public double FindMedianSortedArrays(int[] a, int[] b)
        {
            if (a.Length > b.Length)
                return FindMedianSortedArrays(b, a);

            var total = a.Length + b.Length;
            var half = (total + 1) / 2;

            var aMin = 0;
            var aMax = a.Length;

            while (true)
            {
                int aElements = (aMin + aMax) / 2;
                int bElements = half - aElements;

                int aLeft = (aElements == 0) ? int.MinValue : a[aElements - 1];
                int bLeft = (bElements == 0) ? int.MinValue : b[bElements - 1];

                int aRight = (aElements == a.Length) ? int.MaxValue : a[aElements];
                int bRight = (bElements == b.Length) ? int.MaxValue : b[bElements];

                if (aLeft <= bRight && bLeft <= aRight)
                    return total % 2 == 0
                        ? (Math.Max(aLeft, bLeft) + Math.Min(aRight, bRight)) / 2.0
                        : Math.Max(aLeft, bLeft);
                else if (aLeft > bRight)
                    aMax = aElements - 1;
                else
                    aMin = aElements + 1;
            }
        }
    }
}
