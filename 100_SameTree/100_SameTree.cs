
// Source : https://leetcode.com/problems/same-tree/
// Author : Vitor França
// Date   : Apr 22, 2024

/********************************************************************************** 
* 
* Given two binary trees, write a function to check if they are equal or not.
* 
* Two binary trees are considered equal if they are structurally identical and the nodes have the same value.
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
    public static bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null & q == null) return true;
        if ((p == null && q != null) || (q == null && p != null)) return false;

        bool isSameTree = TreeTraversal(p, q);

        return isSameTree;
    }

    public static bool TreeTraversal(TreeNode p, TreeNode q)
    {
        if (p.left != null && q.left != null)
        {
            bool isSameTree = TreeTraversal(p.left, q.left);
            if (!isSameTree) return false;
        }
        else if ((p.left == null && q.left != null) || (p.left != null && q.left == null))
        {
            return false;
        }

        if (p.val != q.val)
        {
            return false;
        }

        if (p.right != null && q.right != null)
        {
            bool isSameTree = TreeTraversal(p.right, q.right);
            if (!isSameTree) return false;
        }
        else if ((p.right == null && q.right != null) || (p.right != null && q.right == null))
        {
            return false;
        }

        return true;
    }
}