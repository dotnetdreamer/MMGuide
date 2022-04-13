using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIk
{
    public class BinaryTee
    {
        public ArrayList MainList { get; set; }

        public BinaryTee()
        {
            MainList = new ArrayList();
        }

        /// <summary>
        /// New node
        /// </summary>
        /// <param name="key"></param>
        /// <returns>BinaryNode</returns>
        public BinaryNode NewNode(int key)
        {
            BinaryNode node = new BinaryNode();
            node.Left = node.Right = null;
            node.Data = key;

            return node;
        }

        /// <summary>
        /// Nodes having single child 
        /// </summary>
        /// <param name="root"></param>
        public void PrintNodesOneChild(BinaryNode root)
        {
            if (root == null)
                return;

            if (root.Right == null && root.Left == null)
            {
                MainList.Add(root.Data);
            }

            PrintNodesOneChild(root.Left);

            PrintNodesOneChild(root.Right);
        }

        public void Output()
        {
            BinaryNode root = NewNode(50);
            root.Left = NewNode(17);
            root.Left.Left = NewNode(9);
            root.Left.Left.Right = NewNode(14);
            root.Left.Left.Right.Left = NewNode(12);
            root.Left.Right = NewNode(23);
            root.Left.Right.Left = NewNode(19);
            root.Right = NewNode(76);
            root.Right.Left = NewNode(54);
            root.Right.Left.Right = NewNode(72);
            root.Right.Left.Right.Left = NewNode(67);

            PrintNodesOneChild(root);

            if (MainList.Count == 0)
                Console.WriteLine(-1);
            else
            {
                foreach (int value in MainList)
                {
                    Console.WriteLine(value);
                }
            }
        }

        public class BinaryNode
        {
            public BinaryNode Left { get; set; }
            public BinaryNode Right { get; set; }
            public int Data { get; set; }
        }
    }
}
