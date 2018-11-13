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
        Node leftChild;
        Node rightChild;
        int rootValue;
        
        //Constructor


        //Methods

        public void Add(int value)
        {
            if (originalRoot == null)
            {
                originalRoot = new Node(value);
                rootValue = originalRoot.data;
                root = originalRoot;
                return;
            }
            else
            {
                while (root != null)
                {
                    if (value <= root.data)
                    {
                        leftChild = new Node(value);
                        root = leftChild;                        
                    }
                    else
                    {
                        rightChild = new Node(value);
                        root = rightChild;                        
                    }
                    return;
                }
                return;
            }
        }
        public void Search(int value)
        {

            if (rootValue == value)
            {
                Console.WriteLine("Found at Root Value");
                //Console.ReadLine();
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
