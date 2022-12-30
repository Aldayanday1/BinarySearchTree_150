﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

   class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }

    }

    /* A node class consists os three things, the information, reference to the
     right child, and reference to the left child*/
    
    class BinaryTree
    {
        public Node ROOT;
        public BinaryTree()
        {
            ROOT = null; /*Inittializing ROOT to null*/
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
