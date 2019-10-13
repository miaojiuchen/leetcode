using System;
namespace Leetcode
{
    public class AddTwoNumbersLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = null;
            var pr = result;

            var overflow = 0;

            while (l1 != null || l2 != null || overflow > 0)
            {
                int val1 = 0;
                int val2 = 0;
                if (l1 != null)
                {
                    val1 = l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    val2 = l2.val;
                    l2 = l2.next;
                }

                var sum = val1 + val2 + overflow;
                overflow = sum >= 10 ? 1 : 0;

                if (result == null)
                {
                    result = new ListNode(sum % 10);
                    pr = result;
                }
                else
                {
                    pr.next = new ListNode(sum % 10);
                    pr = pr.next;
                }
            }

            return result;
        }
    }
}
