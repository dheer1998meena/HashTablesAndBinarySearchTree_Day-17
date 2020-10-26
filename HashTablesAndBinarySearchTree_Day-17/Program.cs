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
            // Creating an object of MyMapNode Class
            // size of the hash table is 5
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            Console.WriteLine("Adding KeyValue pair");
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            Console.WriteLine("Getting the value of index 3: " + hash.Get("3"));
            Console.WriteLine("Getting the value of index 1: " + hash.Get("1"));
            // UC 1 : Ability to find  the frequency of the specified value in the hashtable.
            hash.GetFrequencyOf("To");
            Console.ReadLine();
        }
    }
}
