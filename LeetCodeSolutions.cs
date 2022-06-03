using System;

public class LeetCodeSolutions
{
	public LeetCodeSolutions()
	{
		public static bool PalindromeNumber(int x)
        {
			/*
			 * Solution:
			 * 1- Loop through first half of int
			 * 2- Compare each one with the other side (ex: x = 123456, is 1 = 6; 2 = 5; etc..
			 * 3- Return true while no differences found.
			 */

			//Step 1: Loop through first half of int
			//Get int length
			int numLength = x.ToString().Length;
			//Loop through half of it
			bool result = true;
			for (int i = 0; i < numLength/2; i++)
            {
				//Compare left side with right side
				if (x.ToString()[i] != x.ToString()[numLength - i - 1])
                {
					result = false;
					break;
                }
            }
			return result;
        }
	}

	/**
	 * Definition for singly-linked list.
	 * public class ListNode {
	 *     public int val;
	 *     public ListNode next;
	 *     public ListNode(int val=0, ListNode next=null) {
	 *         this.val = val;
	 *         this.next = next;
	 *     }
	 * }
	*/

	public class Solution
	{
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
		{
			int leftover = 0;
			int counter = 0;
			while (l1.next != null || l2.next != null)
            {

            }
		}
	}
}
