﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(100);
            binaryTree.Add(94);
            binaryTree.Add(133);
            binaryTree.Add(120);
            binaryTree.Add(88);
            binaryTree.Add(99);
            binaryTree.Add(84);
            binaryTree.Add(55);
            binaryTree.Add(70);
            binaryTree.Search(70);
            Console.ReadLine();
        }
    }
}
