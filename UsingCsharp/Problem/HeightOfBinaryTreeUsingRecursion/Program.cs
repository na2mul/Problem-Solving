// Creating the tree structure
//        1
//       / \
//      /   \
//     2     3
//    / \     \ 
//   /   \     \
//  4     8     5
using HightOfBinaryTreeUsingRecursion;

//Node root = new Node(1);
//root.Left = new Node(2);
//root.Right = new Node(3);
//root.Left.Left = new Node(4);
//root.Left.Right = new Node(8);
//root.Right.Right = new Node(5);


var tree = new HeightOfBinaryTree();
Node root = tree.GenerateBinaryTree(new Node(1), 5);


int height = tree.GetHight(root);


Console.WriteLine("Height of the tree is: " + height);
