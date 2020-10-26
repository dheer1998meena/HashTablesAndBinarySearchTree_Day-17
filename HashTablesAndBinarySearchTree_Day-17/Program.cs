// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Dheer Singh Meena"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace HashTablesAndBinarySearchTree_Day_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC2- Inset all the element in the specified node depending upon the value passed by user as item
            // Creating a instance object of MyBinaryTree.
            MyBinaryTree<int> binaryTree = new MyBinaryTree<int>(56);
            Console.WriteLine("Inserting item");
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(3);
            binaryTree.Insert(16);
            binaryTree.Insert(11);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(65);
            binaryTree.Insert(63);
            binaryTree.Insert(67);
            Console.WriteLine("Displaying Binary Tree");
            binaryTree.Display();
            Console.WriteLine("===============================");
            //UC3 - Ability to search an element  whether the element is present in the binary tree or not
            Console.WriteLine("Searching element");
            binaryTree.Search(63, binaryTree);
            binaryTree.Search(55, binaryTree);
            Console.ReadLine();
        }
    }
}
