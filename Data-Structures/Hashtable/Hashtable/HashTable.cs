using System;
using System.Collections.Generic;
using System.Text;


namespace Hashtable.Classes
{
   public class HashTablez
    {
        public HashNode[] HTable { get; set; }

        public int Bucket { get; set; }

        public HashTablez (int bucket)
        {
            Bucket = bucket;
            HTable = new HashNode[bucket];
        }

        public int Hash(string key)
        {
            int indexValue = 0; 

            for (int i = 0; i < key.Length; i++)
            {
                int kValue = key[i];
                  indexValue = indexValue + kValue;
                  indexValue = indexValue * 2069;

                  indexValue = indexValue % Bucket;
            }



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

        public object Get(string key)
        {
            int index = Hash(key);
            if (HTable[index] == null)
            {
                return null;
            }
            else if (HTable[index].Key == key)
            {
                return HTable[index].Value;
            }
            else
            {
                HashNode temp = HTable[index];
                while (temp.Key != key)
                {
                    temp = temp.Next;

                }
                if (temp.Key == key)
                {
                    return temp.Value;
                }
                else
                {
                    return null;
                }
            }


        }

        public bool Contains(string key)
        {
            int index = Hash(key);
            if (HTable[index] == null)
            {
                return false;

            }
            else if (HTable[index].Key == key)
            {
                return true;
            }

            return false;
        }


    }
}
