using System;
using System.Collections.Generic;
using System.Text;
namespace AlgorithmProgramms
{
    //public class Tree
    //{
    //    Node root;
    //    public bool insert(int val)
    //    {
    //        if (root == null)
    //        {
    //            root = new Node(val);
    //            return true;
    //        }
    //        else
    //        {
    //            //return root.insert(val);
    //            bool res= insert(val);
    //            return res;
    //        }
    //    }

    //    public bool find(int val)
    //    {
    //        if (root == null)
    //            return false;
    //        else
    //            //return root.find(val);
    //            bo ress= find(val);
    //            return ress;
    //    }

    //    public void preorder()
    //    {
    //        if (this != null)
    //        {
    //            Console.WriteLine("preorder");
    //            //root.preorder();
    //            preorder();
    //        }
    //    }

    //    public void postorder()
    //    {
    //        if (this != null)
    //        {
    //            Console.WriteLine("postorder");
    //            //root.postorder();
    //            postorder();
    //        }
    //    }

    //    public void inorder()
    //    {
    //        if (root != null)
    //        {
    //            Console.WriteLine("inorder");
    //            inorder();
    //        }
    //    }

    //    public class Node
    //    {
    //        private Node leftChild;
    //        private Node rightChild;
    //        private int data;

    //        public Node(int val)
    //        {
    //            data = val;
    //        }

    //        private bool insert(int val)
    //        {
    //            bool added = false;
    //            if (this == null)
    //            {
    //                this.data = val;
    //                return true;
    //            }
    //            else if (val < this.data)
    //            {
    //                if (this.leftChild == null)
    //                {
    //                    this.leftChild = new Node(val);   //no left chid created new Node
    //                    return true;
    //                }
    //                else
    //                    added = this.leftChild.insert(val);
    //            }
    //            else if (val > this.data)
    //            {
    //                if (this.rightChild == null)
    //                {
    //                    this.rightChild = new Node(val);
    //                    return true;
    //                }
    //                else
    //                    added = this.rightChild.insert(val);
    //            }
    //            return added;
    //        }

    //        private bool find(int val)
    //        {
    //            bool found = false;
    //            if (this == null)
    //                return false;
    //            else if (val == null)
    //                return true;
    //            else if (val < this.data && this.leftChild != null)
    //                found = this.leftChild.find(val);
    //            else if (val > this.data && this.rightChild != null)
    //                found = this.rightChild.find(val);
    //            return found;
    //        }

    //        private void preorder()
    //        {
    //            if (this != null)
    //            {
    //                Console.WriteLine(this.data);
    //                if (this.leftChild != null)
    //                    this.leftChild.preorder();
    //                else if (this.rightChild != null)
    //                    this.rightChild.preorder();

    //            }
    //        }
    //        private void postorder()
    //        {
    //            if (this != null)
    //            {
    //                Console.WriteLine(this.data);
    //                if (this.leftChild != null)
    //                    this.leftChild.postorder();
    //                else if (this.rightChild != null)
    //                    this.rightChild.postorder();
    //                Console.WriteLine(this.data);
    //            }
    //        }
    //        private void inorder()
    //        {
    //            if (this != null)
    //            {
    //                Console.WriteLine(this.data);
    //                if (this.leftChild != null)
    //                {
    //                    this.leftChild.inorder();
    //                    Console.WriteLine(this.data);
    //                }
    //                else if (this.rightChild != null)
    //                    this.rightChild.inorder();
    //            }
    //        }
    //    }
       
    //}
        
        
    }
















