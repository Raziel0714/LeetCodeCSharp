/**

    要注意什么时候穿值，什么时候传引用
 */
public class Solution {
    public static int res = Int32.MinValue;
    public int MaxPathSum(TreeNode root) {
        res = Int32.MinValue;
        helper(root);
        return res; 
    }
    
    private int helper(TreeNode root){
        if(root == null) return 0;
        
        int left = Math.Max(helper(root.left), 0);
        int right = Math.Max(helper(root.right), 0);
        
        res = Math.Max(left + right + root.val, res);
        return Math.Max(left, right) + root.val;
    }
}