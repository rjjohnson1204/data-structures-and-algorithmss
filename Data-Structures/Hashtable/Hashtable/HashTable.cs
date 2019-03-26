using System;
using System.Collections.Generic;
using System.Text;

namespace Hashtable.Classes
{
    class HashTable
    {
        public HashNode[] HTable { get; set; }

        public int Bucket { get; set; }

        public HashTable (int bucket)
        {
            Bucket = bucket;
            HTable = new HashNode[bucket];
        }

        public int Hash (string key)
        {
            int indexValue = 0; 

            for (int i = 0; i < key.Length; i++)
            {
                indexValue += key[i];
            }

            indexValue = indexValue % Bucket;


        return indexValue; 
        }


        

        public void Add(string key, object value)
        {
            HashNode newNode = new HashNode(key, value);

            int index = Hash(key);

            if (HTable[index] == null)
            {
                HTable[index] = newNode;

            }
            else
            {
                HashNode temp = HTable[index];
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
        }
    }
}
