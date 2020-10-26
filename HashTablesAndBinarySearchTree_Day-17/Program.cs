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
            // UC_2- Ability to find frequency of words in large paragraph phrase
            // Creating an object of MyMapNode Class
            // size of the hash table is 20
            MyMapNode<string, string> hash = new MyMapNode<string, string>(20);
            // Storing the sentence in the variable para
            string para = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            // spliting the words of the phrase and storing each word in the Array String
            string[] paraWords = para.Split(' ');
            // Getting the length of the Array String
            int pLength = paraWords.Length;
            // Itreating along each word and adding it to hash set
            for (int i = 0; i < pLength; i++)
            {
                hash.Add(Convert.ToString(i), paraWords[i]);
            }
            // iterating using for each loop to get the frequency of each word in the sentence
            foreach (string word in paraWords)
            {
                hash.GetFrequency(word);
            }
            Console.ReadLine();
        }
    }
}
