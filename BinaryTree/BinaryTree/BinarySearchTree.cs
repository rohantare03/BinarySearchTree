using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinarySearchTree<K> where K : IComparable
    {
        public K NodeData;
        public BinarySearchTree<K> Left;
        public BinarySearchTree<K> Right;
        public BinarySearchTree(K Nodedata)
        {
            this.NodeData = Nodedata;
            this.Left = null;
            this.Right = null;
        }
        int LeftCount = 0;
        int RightCount = 0;
        public void AddNode(K item)
        {
            K CurrentNode = NodeData;   //56
            if (item.CompareTo(CurrentNode) < 0)
            {
                if (this.Left == null)
                {
                    Left = new BinarySearchTree<K>(item);
                }
                else
                {
                    Left.AddNode(item);
                }
                LeftCount++;
            }
            else
            {
                if (this.Right == null)
                {
                    Right = new BinarySearchTree<K>(item);
                }
                else
                {
                    Right.AddNode(item);
                }
                RightCount++;
            }
        }
        public void Getsize()
        {
            Console.WriteLine("Size of the Binary Tree :" + (LeftCount + RightCount + 1));
        }
        public void Display()
        {
            if (this.Left != null)
            {
                Left.Display();
            }
            Console.Write("  ");
            Console.Write(this.NodeData);
            Console.Write("  ");
            if (this.Right != null)
            {
                Right.Display();
            }
        }
        public bool Search(K element, BinarySearchTree<K> node)
        {
            bool result = false;
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Node Found : " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current Node : " + node.NodeData);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {
                Search(element, node.Left);
            }
            if (element.CompareTo(node.NodeData) > 0)
            {
                Search(element, node.Right);
            }
            return result;
        }
    }
}
