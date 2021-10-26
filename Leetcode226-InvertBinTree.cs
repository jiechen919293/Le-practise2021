using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2021
{
    class Leetcode226_InvertBinTree
    {

        //Definition for binary tree node
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

            //function for tree 
            public TreeNode InvertTree(TreeNode root)
            {
                if (root == null) return null;
                TreeNode tempNode = root.left;
                root.left = root.right;
                root.right = tempNode;
                InvertTree(root.left);
                InvertTree(root.right);
                
                return root;

            }
        }
    }
}
