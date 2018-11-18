using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelvifyTreeTraversal_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the number of nodes you want to create in a binary search tree eg.10?");
                string nodeInput = Console.ReadLine();
                if (int.Parse(nodeInput) > 0)
                {
                    int noOfNodes;
                    noOfNodes = Int32.Parse(nodeInput);
                    int[] arrayofItem = new int[noOfNodes];

                    Console.WriteLine("Enter the items to be inserted in the tree as , seprated integer no. like e.g. 16,43,45,98 ?");
                    string userInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(userInput) && userInput.Length > 0)
                    {
                        string[] inputArray = userInput.Split(',');
                        if (inputArray.Length == noOfNodes)
                        {
                            for (int i = 0; i < noOfNodes; i++)
                                arrayofItem[i] = Int32.Parse(inputArray[i]);

                            //Call for the Binary Seaarch Tree Programme (Inorder Traversal)
                            Console.WriteLine("Inorder Traversal for the input binary serach tree is : ");
                            BinarySearchTree binaryTree = new BinarySearchTree();

                            //Create a binary tree before the inorder traversal.
                            CreateBinarySearchTree(ref binaryTree, arrayofItem);

                            //call to do the Inorder Traversal.
                            binaryTree.Inorder(binaryTree.GetRootNode());

                            Console.WriteLine(" ");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.Write(string.Format("The no of items input {0} should be equal to no of node {1} defined earlier.",noOfNodes, inputArray.Length));
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.Write("Invalid Input from user.The Input should be like e.g. 16,43,65,87");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.Write("Invalid No of Nodes.The Input should be like e.g.10 or any number greater than 0.");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.Write(string.Format("Error in Inorder of Binary Search Tree.Error Details {0}", ex.ToErrorMessage()));
                Console.ReadLine();
            }
        }
        public static void CreateBinarySearchTree(ref BinarySearchTree binaryTree, int[] arrayofItem)
        {
            foreach (int nodeItem in arrayofItem)
            {
                binaryTree.InsertNode(nodeItem);
            }
        }
    }
}
