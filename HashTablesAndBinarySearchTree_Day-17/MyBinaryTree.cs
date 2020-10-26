// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace HashTablesAndBinarySearchTree_Day_17
{
    //Creating MyMapTree class as a generic class 
   public class MyBinaryTree<T> where T : IComparable
    {
        // nodeData value in the Binary tree
        public T nodeData { get; set; }
        // leftTree storing the element less than the node data
        public MyBinaryTree<T> leftTree { get; set; }
        // rightTree storing the element greater than the node data.
        public MyBinaryTree<T> rightTree { get; set; }
        // Defining two local variable.
        int leftCount;
        int rightCount;
        // Creating a parameterized constructor.
        public MyBinaryTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;
        }

        /// <summary>
        ///UC1- Inset the element in the specified node depending upon the value passed by user as item
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            // Creating a currentNodeValue variable copying the value of nodeData into currentNodeValue.
            T currentNodeValue = this.nodeData;
            //comparing if the value entered is greater than current node or less than. 
            if (currentNodeValue.CompareTo(item)>0)
            {
                //if the item value less than currentNodeValue then adding into left tree
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinaryTree<T>(item);
                    Console.WriteLine("Inserting item on left is : " + item);
                }
                // Recursion remember first it will reach the end node and also traverse back to upper nodes
                else
                {
                    this.leftTree.Insert(item);
                }
            }
            else
            {
                //if the item value greater than currentNodeValue then adding into left tree
                if (this.rightTree == null)
                {
                    this.rightTree = new MyBinaryTree<T>(item);
                    Console.WriteLine("Inserting item on right is : " + item);
                }
                // Recursion remember first it will reach the end node and also traverse back to upper nodes
                else
                {
                    this.rightTree.Insert(item);
                }
            }
        }
        /// <summary>
        /// Creating Display method for Binary Tree.
        /// </summary>
        public void Display()
        {
            //If the leftTree is not null then printing the values in that left tree 
            if (this.leftTree!= null)
            {
                this.leftCount++;
                //Using recursion reach to the last node of left tree and print it 
                this.leftTree.Display();
            }
            // Printing the root element.
            Console.WriteLine(this.nodeData.ToString());
            //If the rightTree is not null then printing the values in that left tree.
            if (this.rightTree != null)
            {
                this.rightCount++;
                //Using recursion reach to the last node of left tree and print it 
                this.rightTree.Display();
            }
        }
        /// <summary>
        /// Getiing the size of Binary Treee
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("size" + "  " + (1 + this.leftCount + this.rightCount));
            Console.WriteLine("Left count size  is :" + this.leftCount);
            Console.WriteLine("Right count size is  :" + this.rightCount);
        }
    }
}
