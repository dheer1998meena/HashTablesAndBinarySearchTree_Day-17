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
            // UC_2- Ability to find frequency of words in large paragraph phrase
            // Creating object of MyMapNode Class
            // size of hash table is 20
            MyMapNode<string, string> hash = new MyMapNode<string, string>(20);
            // Storing the sentence in the variable paragraph
            string paragraph = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            // spliting the words of the phrase and storing each word in the Array String
            string[] paragraphWords = paragraph.Split(' ');
            // Getting the length of the Array String
            int paragraphLength = paragraphWords.Length;
            // Itreating along each word and adding it to hash set
            for (int i = 0; i < paragraphLength; i++)
            {
                hash.Add(Convert.ToString(i), paragraphWords[i]);
            }
            // iterating using for each loop to get the frequency of each word in the sentence
            foreach (string word in paragraphWords)
            {
                hash.GetFrequency(word);
            }
            Console.ReadLine();
        }
    }
}
