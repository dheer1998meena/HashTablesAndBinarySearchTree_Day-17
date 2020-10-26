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
        //Defining members elements with the properties.
        public struct KeyValue<k,v>
        {
            public k Key { get; set; }
            public v Value { get; set; }
            public int Frequency { get; set; }
        }
        // Defining a Variable to store the size of the Linked list
        //A linked list implementing the functionality with storage type as a structure instance.
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;
        // Creating a parameterized constructor of the MyMapNode Class to initialise the size and the key-value struct.
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        // Hash Code Method to Find the Array Position with key as the parameter
        // Gets a unique array items[] position for entered key.
        // Returning a unique position to each different key.
        // Math function to find the absolute position at which the particular key value pair is situated.
        protected int GetArrayPosition(K Key)
        {
            int position = Key.GetHashCode() % size;
            return Math.Abs(position);
        }
        // Creating a GetLinkedList Method with return type as KeyValue Pair.
        // Gets the linked list present at the entered position in the items[] array.
        // Retreving key value pair at the index of position.
        protected LinkedList<KeyValue<K,V>> GetLinkedList(int position)
        {
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
        // Iterating foreach loop to get the value if the keys are equal
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }

            return default(V);
        }
        // Generic Method to Adds the specified key,value pair at the end of the linked list present at the position corresponding to the key.
        // Gets the position to the key.
        // Getting  the linked list present at the position.
        // Then Adds the key-value pair at the end of the linked list.
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
            Console.WriteLine(item.Key + " " + item.Value);
        }
        // Generic Method to Remove a particular item from the Hash Table
        // Getting the position of the item at the particular key 
        // Getting the key Value Pair at the given position
        // if both the key matches then returning true  
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemFound = false;
            KeyValue<K, V> foundItem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
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
        // Iterating foreach loop to get the key value pair in the list.
        // iterating for each loop to get each object in the list
        public int GetFrequency(V value)
        {
            int frequency = 0;
            foreach (LinkedList<KeyValue<K, V>> list in items)
            {
                if (list == null)
                {
                    continue;
                }
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
        // Iterating foreach loop to get the key value pair in the list
        // iterating for each loop to get each object in the list
        public void RemoveValue(V value)
        {
            foreach (LinkedList<KeyValue<K, V>> li in items) 
            {
                if (li == null)
                    continue;
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
