/** 
	compare the head of two node list, choose the smaller one to be the head,
	then move to next node.
	if one list is finished and another is not, then point the node to another list directly
*/
public class Solution {
    public ListNode MergeTwoLists(ListNode l1, ListNode l2) {
        ListNode head = new ListNode(0);
		ListNode res = head;

		while(l1 != null && l2 != null){
            int v = 0;
            if(l1.val <= l2.val){
                v = l1.val;
                l1 = l1.next;
            }else{
                v = l2.val;
                l2 = l2.next;
            }
            ListNode temp = new ListNode(v);
            head.next = temp;
            head = head.next;
		}
        if(l1 == null) head.next = l2;
        if(l2 == null) head.next = l1;
        return res.next;
    }
}