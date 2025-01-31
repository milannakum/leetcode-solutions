// Link: https://leetcode.com/problems/invert-binary-tree/
// Name: 226. Invert Binary Tree

TreeNode InvertTree(TreeNode root)
{
    if (root == null) return null;

    TreeNode left = InvertTree(root.left);
    root.left = InvertTree(root.right);
    root.right = left;
    return root;
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
