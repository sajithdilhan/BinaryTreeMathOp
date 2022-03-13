using System;

namespace BinaryTreeMathOp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node root = new Node { Value="-"};

            root.Left = new Node { Value="*" };
            root.Left.Left = new Node { Value="/" };
            root.Left.Right = new Node { Value="-" };
            root.Left.Left.Left = new Node { Value="15"};
            root.Left.Left.Right = new Node { Value = "-" };
            root.Left.Left.Right.Left = new Node { Value = "7" };
            root.Left.Left.Right.Right = new Node { Value = "+" };
            root.Left.Left.Right.Right.Left = new Node { Value = "1" };
            root.Left.Left.Right.Right.Right = new Node { Value = "1" };
            root.Left.Right.Right = new Node { Value="3" };

            root.Right = new Node { Value = "+" };
            root.Right.Left = new Node { Value="2" };
            root.Right.Right = new Node { Value = "+" };
            root.Right.Right.Right = new Node { Value = "1" };
            root.Right.Right.Left = new Node { Value = "1" };

            var Result = CalculateSubtree(root);
        }

        public static bool CheckIsALeafNode(Node node)
        {
            if (node != null && node.Left == null && node.Right == null)
            return true;
            return false;
        }

        public static double CalculateSubtree(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            if (CheckIsALeafNode(root))
            {
                return Double.Parse(root.Value);
            }
            else
            {
                double left= CalculateSubtree(root.Left);
                double right= CalculateSubtree(root.Right);

                return left + right; //ToDo: Need to Calculate the real values 
            }
        }
    }

    public class Node
    {
        public string Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

    }
}
