
// Source : https://leetcode.com/problems/binary-tree-inorder-traversal/
// Author : Vitor França
// Date   : Apr 15, 2024

/********************************************************************************** 
* 
* Given a binary tree, return the inorder traversal of its nodes' values.
* 
* For example:
* Given binary tree {1,#,2,3},
* 
*    1
*     \
*      2
*     /
*    3
* 
* return [1,3,2].
*                
**********************************************************************************/

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

public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> inOrderNodes = new List<int>();
        if (root == null) return inOrderNodes;
        TreeNode node = root;

        Travesal(node, inOrderNodes);

        return inOrderNodes;
    }

    public static IList<int> Travesal(TreeNode node, IList<int> inOrderNodes) 
    {
        if (node.left != null) Travesal(node.left, inOrderNodes);
        if (node.val != null) inOrderNodes.Add(node.val);
        if (node.right != null) Travesal(node.right, inOrderNodes);

        return inOrderNodes;
    }
}