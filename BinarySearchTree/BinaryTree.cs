using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        Node originalRoot;
        Node root;
        int rootValue;
        
        //Constructor
        public BinaryTree()
        {
            root = null;
        }

        //Methods


        public void Add(int data)
        {
            
            Node node = new Node(data);
            if (originalRoot == null)
            {
                originalRoot = node;
                rootValue = originalRoot.data;
            }                
            else
            {
                root = originalRoot;
                while (true)
                {
                    if (node.data > root.data)
                    {

                        if (root.rightChild == null)
                        {
                            root.rightChild = node;
                            return;
                        }
                        else
                        {
                            root = root.rightChild;
                        }
                    }
                    else
                    {
                        if (root.leftChild == null)
                        {
                            root.leftChild = node;
                            return;
                        }
                        else
                        {
                            root = root.leftChild;
                        }
                    }
                }
            }
        }
        public void Search(int value)
        {

            if (rootValue == value)
            {
                Console.WriteLine("Found at Root Value");
            }
            else if (value < rootValue)
            {
                Console.WriteLine("Left");
                root = originalRoot.leftChild;
            }
            else
            {
                Console.WriteLine("Right");
                root = originalRoot.rightChild;
            }
             
            while (value != root.data)
            {
                if (value < root.data)
                {
                    Console.WriteLine("Left");
                    root = root.leftChild;
                }
                else if (value > root.data)
                {
                    Console.WriteLine("Right");
                    root = root.rightChild;                    
                }
                else
                {
                    Console.WriteLine("Value not found on tree.");
                }                
            }
            if (value == root.data)
            {
                Console.WriteLine("Found: " + value);
            }
            //Console.ReadLine();
        }

    }
}
