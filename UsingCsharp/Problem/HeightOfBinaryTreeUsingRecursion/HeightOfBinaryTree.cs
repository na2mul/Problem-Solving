namespace HightOfBinaryTreeUsingRecursion
{
    public class HeightOfBinaryTree
    {
        private static Random random = new Random();
        public int GetHight(Node root)
        {
            if (root == null)
                return 0;
            int left = GetHight(root.Left);
            int right = GetHight(root.Right);

            return 1 + int.Max(left, right);
        }
        public Node GenerateBinaryTree(int hight)
        {
            if (hight < 1)
            {
                return null;
            }
            Node node = new Node(random.Next(100));

            node.Left = GenerateBinaryTree(hight - 1);
            node.Right = GenerateBinaryTree(hight - 1);

            return node;
        }

        public Node GenerateBinaryTree(Node root, int hight)
        {
            if (hight < 1)
                return null;
            
            root.Left = new Node(random.Next(100));
            root.Right = new Node(random.Next(100));

            GenerateBinaryTree(root.Left, hight - 1);
            GenerateBinaryTree(root.Right, hight - 1);

            return root;
        }
    }    
}
