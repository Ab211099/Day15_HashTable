using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyMapNode
{
    class MyMapNode<K, V>
    {
        
        private int size;
        private LinkedList<KeyValue<K, V>>[] items;
//1. The constructor takes a size parameter.
//2. The constructor creates an array of LinkedList objects with the size parameter.
//3. The constructor initializes the array with null values.
//4. The constructor creates a new instance variable named items.
//5. The constructor sets the items instance variable to the array of LinkedList objects
        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        //It return the position of the key in the array
        protected int GetArrayPosition(K key)
        {
            int position = key.GetHashCode() % size;
            return Math.Abs(position);
        }
//1. The GetLinkedList method is a helper method that returns the linked list for the given position.
//2. If the linked list for the given position is null, it creates a new linked list and returns it.
//3. The GetLinkedList method is called in the constructor and in the Add method.
//4. The GetLinkedList method is also called in the Contains method.
//5. The GetLinkedList method is also called in the Remove method.
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int pos)
        {
            LinkedList<KeyValue<K, V>> linkedlist = items[pos];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<KeyValue<K, V>>();
                items[pos] = linkedlist;
            }
            return linkedlist;
        }

//1. Get the array position of the key.
//2. Get the linked list at that position.
//3. Iterate through the linked list and return the value if the key matches.
//4. If the key doesn’t match, return the default value.

        public V GetV(K key)
        {
            int pos = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(pos);
            foreach (KeyValue<K, V> item in linkedlist)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }
            // 1. Get the array position of the key.
            //2. Get the linked list at that position.
            //3. Create a new KeyValue<K, V> object with the key and value.
            //4. Add the KeyValue<K, V> object to the linked list.
        public void Add(K key, V value)
        {
            int pos = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedlist = GetLinkedList(pos);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedlist.AddLast(item);
        }
        public bool IsEmpty()
        {
            if (Getsize() <= 0)
                return true;
            else
                return false;
        }
        public int Getsize()
        {
            return size;
        }


    }


//1. The KeyValue<TKey, TValue> struct is a gen
//
//-+
//eric type.
//2. The Key and Value properties are both of type TKey and TValue, respectively.
//3. The KeyValue<TKey, TValue> struct is a value type.
//4. The KeyValue<TKey, TValue> struct is immutable.
    public struct KeyValue<k, v>
    {
        public k Key { get; set; }
        public v Value { get; set; }
    }
}
   


