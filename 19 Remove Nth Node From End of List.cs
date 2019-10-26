/**
	in node list, its simple to remove, the hard part is how to 
	find the correct node, after we find it, just remove it ,and 
	change the previous node to point to the next node.

	1 find the end of the node list, then got the length of node list.
	  base on this ,we can locate the node, then remove it.
	  there is a case need to consider, is if we remove the first node of the list
	  then, return the next directly.

	2 what i learn, all the node ans and node res i created, they are just
	 pointer towards the node head. and head is also pointer we keep moving towards the end.
	 so thay's way we dont need to new a real node, we just need to create pointer to point to 
	 those nodes.
*/

public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode ans = head;
        int l = 0;
        while(head != null){
            l++;
            head = head.next;
        }
        if(l == n) return ans.next;
        int s = l - n;
        ListNode res = ans;
        
        while(s > 1){
            ans = ans.next;
            s--;
        }
        if(ans.next.next != null){
            ans.next = ans.next.next;
        }
        else ans.next = null;
        return res;
    }
}