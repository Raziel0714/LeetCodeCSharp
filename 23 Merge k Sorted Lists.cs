/**
    Merge two list every time, looping the list to merge all the list.
    time complexity O(n*n)
*/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode helper = null;
        foreach(var item in lists){
            helper = MergeTwo(helper, item);
        }
        return helper;
    }
    
    public ListNode MergeTwo(ListNode l1, ListNode l2){
        ListNode head = new ListNode(0);
        ListNode ans = head;
        
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
        
        if(l1 == null){
            head.next = l2;
        }
        if(l2 == null){
            head.next = l1;
        }
        return ans.next;
    }
}

/**
突然感觉领悟了分治算法， 决定一写 hmm much better
*/
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        return divider(lists, 0, lists.Length-1);
    }
    
    public ListNode divider(ListNode[] lists, int start, int end){
        if(start > end) return null;
        if(start == end) return lists[start];
        int mid = start + (end - start) / 2;
        ListNode left = divider(lists, start, mid);
        ListNode right = divider(lists, mid+1, end);
        return MergeTwo(left, right);
    }
    
    
    public ListNode MergeTwo(ListNode l1, ListNode l2){
        ListNode head = new ListNode(0);
        ListNode ans = head;
        
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
        
        if(l1 == null){
            head.next = l2;
        }
        if(l2 == null){
            head.next = l1;
        }
        return ans.next;
    }
}

/**
    we can also use heap for this problem.
    need to learn.
*/