using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeDepathAdvancedAlgoritem
{
    class BinaryTree
    {
        public class Node
        {
            public int data;
            public Node left, right;

            public Node(int item)
            {
                data = item;
                left = right = null;
            }
        }

        public static class Tree
        {
            public static Node root;

            public static int Llogaritethelsine(Node node)
            {
                if (node == null)
                    return 0;
                else
                {
                    int leftDepth = Llogaritethelsine(node.left);
                    int rightDepth = Llogaritethelsine(node.right);

                    if (leftDepth > rightDepth)
                        return (leftDepth + 1);
                    else
                        return (rightDepth + 1);
                }
            }

            public static Node Mbush(Node rrenja, int vlera)
            {
                if (rrenja == null)
                    rrenja = new Node(vlera);
                else if (vlera <= rrenja.data)
                    rrenja.left = Mbush(rrenja.left, vlera);
                else if (vlera > rrenja.data)
                    rrenja.right = Mbush(rrenja.right, vlera);

                return rrenja;
            }
        }
    }
}
