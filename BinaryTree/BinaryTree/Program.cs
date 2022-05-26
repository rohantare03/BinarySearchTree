// See https://aka.ms/new-console-template for more information
namespace BinaryTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree");
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(56);
            binarySearchTree.AddNode(30);
            binarySearchTree.AddNode(70);
        
            binarySearchTree.Display();
           
        }
    }
}
