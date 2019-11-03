/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }


 User preorder to serialize the tree, and when deserilize, if it's special case, means this branch is already end.
 */
public class Codec {

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root == null) return string.Empty;
        StringBuilder sb = new StringBuilder();
        preorder(root, sb);
        return sb.ToString();
    }
    
    private void preorder(TreeNode root, StringBuilder sb){
        if(root == null){
            sb.Append("$").Append(",");
            return;
        }
        sb.Append(root.val).Append(",");
        preorder(root.left, sb);
        preorder(root.right, sb);
    }
    

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        if(string.IsNullOrEmpty(data)) return null;
        Queue<string> que = new Queue<string>();
        var list = data.Split(",");
        foreach(var item in list){
            que.Enqueue(item);
        }
        return deser(que);
    }
    
    private TreeNode deser(Queue<string> que){
        string str = que.Dequeue();
        if(str.Equals("$"))
            return null;
        
        TreeNode root = new TreeNode(Int32.Parse(str));
        root.left = deser(que);
        root.right = deser(que);
        return root;
    }
}
