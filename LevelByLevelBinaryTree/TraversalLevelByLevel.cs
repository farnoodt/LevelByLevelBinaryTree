using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelByLevelBinaryTree
{
    class TraversalLevelByLevel
    {
       public void  printLevelbyLevel(Node root)
        {
            if (root == null)
                return;

            Queue<Node> Q1 = new Queue<Node>();
            Queue<Node> Q2 = new Queue<Node>();

            Q1.Enqueue(root);

            while (Q1.Count != 0 || Q2.Count != 0)
            {
                Console.WriteLine();
                if(Q1.Count != 0)
                {
                    while(Q1.Count != 0)
                    {
                        root = Q1.Dequeue();
                        Console.Write(root.data + ", ");
                        if (root.left != null)
                            Q2.Enqueue(root.left);

                        if (root.right != null)
                            Q2.Enqueue(root.right);
                    }
                }

                Console.WriteLine();
                if(Q2.Count != 0)
                {
                    while(Q2.Count != 0)
                    {
                        root = Q2.Dequeue();
                        Console.Write(root.data + ", ");
                        if (root.left != null)
                            Q1.Enqueue(root.left);

                        if (root.right != null)
                            Q1.Enqueue(root.right);
                    }
                }
            }
        }
    }
}
