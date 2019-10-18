
/**
	this question is not very hard
	The start node of singly-linked list is actually the number on the first digits (units), the second node is the number on the second digits (tens),so we just need to add the node first, check about carry and then move to next node. need to deal with the some cornor cases since the length of two list might be different.
*/

/**
	This problem is not hard, just a few things need to be careful;
		1> carry need to calculate after head.val.
		2> the value of two node to be assigned to another variable since the val of node and carry will affect each other when calculate
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 public class Solution{
 	public ListNode AddTwoNumbers(ListNode l1, ListNode l2){
 		ListNode pos = new ListNode(0);
 		ListNode res = pos;
 		int carry = 0;
        int t1, t2;
 		while(l1 != null && l2 != null){
 			ListNode head = new ListNode(0);
 			pos.next = head;
            t1 = l1.val;
            t2 = l2.val;
 			head.val = (t1 + t2 + carry) % 10;
 			carry = (t1 + t2 + carry) / 10;
 			pos = pos.next;
 			l1 = l1.next;
 			l2 = l2.next;
 		}
 		if(l1 != null) {
            pos.next = l1;
            while(l1 != null){
                t1 = l1.val;
                l1.val = (t1 + carry) % 10;
                carry = (t1 + carry) / 10;
                l1 = l1.next;
            }
        }
 		if(l2 != null) {
            pos.next = l2;
            while(l2 != null){
                t2 = l2.val;
                l2.val = (t2 + carry) % 10;
                carry = (t2 + carry) / 10;
                l2 = l2.next;
 		    }
        }
        Console.WriteLine(carry);
 		if(carry != 0) 
 		{
 			ListNode tail = new ListNode(carry);
 			while(pos.next != null){
                pos = pos.next;
            }
            pos.next = tail;
 		}
 		return res.next;
 	}
 }