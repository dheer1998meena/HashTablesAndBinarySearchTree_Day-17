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
    public class MyMapNode<K,V>
    {
        //Creating Class For Key Value Pair with data type structure
        public struct KeyValue<k,v>
        {
            // defining members elements with the properties.
            public k Key { get; set; }
            public v Value { get; set; }
            public int Frequency { get; set; }
        }
        // Defining a Variable to store the size of the Linked list
        private readonly int size;
        //A linked list implementing the functionality with storage type as a structure instance.
        private readonly LinkedList<KeyValue<K, V>>[] items;
        // Creating a parameterized constructor of the MyMapNode Class to initialise the size and the key-value struct.
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        // Hash Code Method to Find the Array Position with key as the parameter
        // Gets a unique array items[] position for entered key.
        protected int GetArrayPosition(K Key)
        {
            // Returning a unique position to each different key.
            int position = Key.GetHashCode() % size;
            // Math function to find the absolute position at which the particular key value pair is situated.
            return Math.Abs(position);
        }
        // Creating a GetLinkedList Method with return type as KeyValue Pair.
        // Gets the linked list present at the entered position in the items[] array.
        protected LinkedList<KeyValue<K,V>> GetLinkedList(int position)
        {
            // Retreving key value pair at the index of position.
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if(linkedList== null)
            {
                // Creates new linked list and update items[] array with the same.
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        // Gets the value at the specified key.
        // Generic Method to find the key value pair at the particular position.
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            // Iterating foreach loop to get the value if the keys are equal
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }

            return default(V);
        }
        // Generic Method to Adds the specified key,value pair at the end of the linked list present at the position corresponding to the key.
        public void Add(K key, V value)
        {
            // Gets the position to the key.
            int position = GetArrayPosition(key);
            // Getting  the linked list present at the position.
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            /// Adds the key-value pair at the end of the linked list.
            linkedList.AddLast(item);
            Console.WriteLine(item.Key + " " + item.Value);
        }
        // Generic Method to Remove a particular item from the Hash Table
        public void Remove(K key)
        {
            // Getting the position of the item at the particular key 
            int position = GetArrayPosition(key);
            // Getting the key Value Pair at the given position
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                // if both the key matches then returning true  
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }
            if (itemFound)
            {
                //Item is removing from the hash table 
                linkedList.Remove(foundItem);
            }
        }
        //UC2 Generic Method to find frequency of words in large paragraph phrase
        public int GetFrequency(V value)
        {
            int frequency = 0;
            // Iterating foreach loop to get the key value pair in the list
            foreach (LinkedList<KeyValue<K, V>> list in items)
            {
                if (list == null)
                {
                    continue;
                }
                // iterating for each loop to get each object in the list
                foreach (KeyValue<K, V> obj in list)
                {
                    if (obj.Equals(null))
                    {
                        continue;
                    }
                    // if object matches the value then increasing the frequency count 
                    if (obj.Value.Equals(value))
                    {
                        frequency++;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Words '{0}' appears {1} times", value, frequency);
            return frequency;
        }
        // UC3 Generic Method to Remove a particular word from large paragraph phrase
        public void RemoveValue(V value)
        {
            // Iterating foreach loop to get the key value pair in the list
            foreach (LinkedList<KeyValue<K, V>> li in items)
            {
                if (li == null)
                    continue;
                // iterating for each loop to get each object in the list
                foreach (KeyValue<K, V> obj in li)
                {
                    if (obj.Equals(null))
                    {
                        continue;
                    }
                    // if object matches the value then Removing it
                    if (obj.Value.Equals(value))
                    {
                        Remove(obj.Key);
                        break;
                    }
                }
            }
        }
    }
}
