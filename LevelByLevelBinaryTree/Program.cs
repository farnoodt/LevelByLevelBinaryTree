using System;

namespace LevelByLevelBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node tree = new Node(1);
            tree.left = new Node(2);
            tree.left.left = new Node(4);
            tree.left.right = new Node(5);
            tree.left.right.left = new Node(8);
            tree.left.right.right = new Node(9);
            tree.right = new Node(3);
            tree.right.left = new Node(6);
            tree.right.right = new Node(7);
            tree.right.right.left = new Node(10);

            TraversalLevelByLevel LBL = new TraversalLevelByLevel();
            LBL.printLevelbyLevel(tree);
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
