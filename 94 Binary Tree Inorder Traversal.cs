
/**
*  this is inorder traversal, if the root is null, skip,
* then push left first, root, then right;
*/
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();
        inorder(root, res);
        return res;
    }
    
    private void inorder(TreeNode root, List<int> res){
        if(root == null){
            return;
        }
        
        inorder(root.left, res);
        res.Add(root.val);
        inorder(root.right, res);
    }
}