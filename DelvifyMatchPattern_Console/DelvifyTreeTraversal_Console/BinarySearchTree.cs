using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelvifyTreeTraversal_Console
{
    public class BinarySearchTree
    {
        #region Properties
        public NodeModel rootNode; 
        #endregion

        public BinarySearchTree()
        {
            rootNode = null;
        }
        public NodeModel GetRootNode()
        {
            return rootNode;
        }
        public void InsertNode(int nodeID)
        {
            //Create a new node and assign the id for the node
            NodeModel newNode = new NodeModel();
            newNode.item = nodeID;
            
            //if the root node is null.. the generate node is the root node
            if (rootNode == null)
                rootNode = newNode;
            else
            {
                //assign the current node as rootNode
                NodeModel current = rootNode;
                NodeModel parent;
                while (true)
                {
                    //assign the current node as parent
                    parent = current;
                    //if the assigned value is less than the current item value assign it to left and return
                    if (nodeID < current.item)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    //if the assigned value is greater than the current item value assign it to left and return
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        #region Traversal Methods
        /// <summary>
        ///  An inorder traversal visits all the nodes in a binary serach tree in ascending order of the node key values
        /// </summary>
        /// <param name="rootNode"></param>
        public void Inorder(NodeModel rootNode)
        {
            if (rootNode != null)
            {
                Inorder(rootNode.left);
                Console.Write(rootNode.item + " ");
                Inorder(rootNode.right);
            }
        }
        #endregion
    }
}
