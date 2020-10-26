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
            // UC3 Ability to Remove particular words from large paragraph phrase
            // Creating an object of MyMapNode Class
            // size of the hash table is 20
            // Storing the sentence in the variable para
            MyMapNode<string, string> hash = new MyMapNode<string, string>(20); 
            string para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            string[] paraWords = para.Split(' ');  // spliting the words of the phrase and storing each word in the Array String
           int pLength = paraWords.Length;  // Getting the length of the Array String
            // Itreating along each word and adding it to hash set
            for (int i = 0; i < pLength; i++)
            {
                hash.Add(Convert.ToString(i), paraWords[i]);
            }
            Console.WriteLine("Removing the word 'avoidable' from the hash table ");
            Console.WriteLine("Frequency before removal of 'avoidable' :" + hash.GetFrequency("avoidable"));
            hash.RemoveValue("avoidable");
            Console.WriteLine("Frequency after removal of 'avoidable' :" + hash.GetFrequency("avoidable"));
            Console.ReadLine();
        }
    }
}
