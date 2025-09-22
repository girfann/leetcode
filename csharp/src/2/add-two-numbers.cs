namespace LeetCode.src._2;

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;

    public ListNode? next = next;
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var current = new ListNode();
        var tempHead = current;

        var carry = 0;

        while (l1 != null || l2 != null)
        {
            var sum = carry + (l1?.val ?? 0) + (l2?.val ?? 0);
            carry = sum / 10;

            current.next = new ListNode(sum % 10);
            current = current.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        if (carry == 1)
            current.next = new ListNode(carry);

        return tempHead.next!;
    }
}
