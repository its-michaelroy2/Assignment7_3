using System;

namespace Assignment7_3_
{
    // Class representing a node in the bst
    public class TreeNode
    {
        public int val;           // Value within node
        public TreeNode left;     // Ref. to the left child
        public TreeNode right;    // Ref. to the right child

        // TreeNode construct
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    // Class containing solution method
    public class Solution
    {
        // Search method for value in BST
        public TreeNode SearchBST(TreeNode root, int val)
        {
            // Standard base seems to be if root is null or value is found, return the current node
            if (root == null || root.val == val)
                return root;

            // If the value we're searching for is < current node's value,
            // search in the left subtree
            if (val < root.val)
                return SearchBST(root.left, val);
            
            // Otherwise, search in the right subtree
            else
                return SearchBST(root.right, val);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 7.3");
            Console.WriteLine("==============");

            // Create a sample BST
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(7);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);

            // Create an instance of the Solution class
            Solution solution = new Solution();

            // Example: searching for values 1 and 5
            int[] testValues = { 1, 5 };

            // Iterate through test cases
            foreach (int val in testValues)
            {
                // Search for value in BST
                TreeNode result = solution.SearchBST(root, val);

                // Result
                if (result != null)
                    Console.WriteLine($"Found node with value {val}");
                else
                    Console.WriteLine($"Node with value {val} not found");
            }
        }
    }
}