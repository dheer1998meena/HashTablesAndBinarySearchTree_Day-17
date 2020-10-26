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
            //UC1- Inset the element in the specified node depending upon the value passed by user as item
            // Creating a instance object of MyBinaryTree.
            MyBinaryTree<int> binaryTree = new MyBinaryTree<int>(56);
            Console.WriteLine("Inserting item");
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Display();
            binaryTree.GetSize();
            Console.ReadLine();
        }
    }
}
