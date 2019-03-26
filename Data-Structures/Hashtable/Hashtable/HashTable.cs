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

        public void Add(string key, object value)
        {
            HashNode node = new HashNode(key, value);

            int i = Hash(key);

            if (hashTable[i] == null)
            {
                hashTable[i] = newHash;

            }
            else
            {
                HashNode temp = hashTable[i];

            }
        }
    }
}
