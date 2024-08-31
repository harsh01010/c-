using System;
using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //generics (provides type safety)
            Generics g = new Generics();
            g.compare<int>(33, "ddd");
            //g.compare("stri", 3f);
            */
            /*
            int[] arr = new int[] { 2, 3, 4, 1 };
            foreach(int i in arr) {
                Console.Write(i + " ");    
            }
            Console.WriteLine();
            Array.Resize(ref arr, 10); // puts other vlaues as 0
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            */
            //Collections
            /* non-generics-> Stack,Queue,ArrayList,sortedList,HashTable all are auto resizing and not typesafe (system.collections)*/
            /* generic collection -> typesafe + auto resizing , List<T>,Dicitionary<T,T> (system.collections.generics)lll*/
            //ArrayList
            /*
             not typesafe -> can store any type of value
             dynamic size
            capacity increases-> 0->4->8->16->32->...
            Can store elements of any type even in a single arrayList, but operates on object references.
            When iterating through a collection that can contain elements of any type, such as an ArrayList or a non-generic collection,we
            often use the object keyword to handle the elements.
             */
            /*
            ArrayList al = new ArrayList();
            // ArrayList al2 = new ArrayList(10);//10 is initial capacity
            al.Add(23);
            al.Add(3.44);
            al.Add("hello");
            al.AddRange(new int[] { 3, 4, 2 });
            al.Insert(1, "one"); // insert "one" at 1 index
            al.Remove(23);
            al.RemoveAt(0);
            Console.WriteLine(al.Contains(1));
            Console.WriteLine(al.IndexOf(1));
            //Sort(),Reverse(),ToArray(),
            foreach(object item in al)
            {
                Console.WriteLine(item);
            }
            */

            //HashTable
            /* 
             not typesafe -> can store any type of value
            key(user defined , not fiexed indexes)/value combination
            uses hashing,do not maintains order in which elements are inserted
            every item contains a key(object),value(object) and a hashcode(integer)
             */
            /*
            Hashtable ht = new Hashtable();
            ht.Add("key", "value");
            ht.Add(3, "hello");
            ht.Add(3.33, 4);

            Console.WriteLine(ht["key"]);

            foreach(object key in ht.Keys)
            {
                Console.WriteLine(ht[key]+" "+key.GetHashCode());
            }

            ht.Add("temp", "temp");
            ht.Remove("temp");
            bool containsKey = ht.ContainsKey("key");
            bool containsValue = ht.ContainsValue("value");
            Console.WriteLine(ht.Count);
            ht.Clear();
            */

            /*
            //Stack
            Stack stack = new Stack();
            stack.Push(23);
            var top = stack.Peek();
            stack.Pop();
            var cnt = stack.Count;
            bool isPresent = stack.Contains(top);
            */
            /*
            //Queue
            Queue queue = new Queue();
            queue.Enqueue(34); // adds at back
            var front = queue.Dequeue();//removes form front
            queue.Enqueue(66);
            front = queue.Peek();//returns the front element,do not removes
            //Contains,Count,Clear
            */
            //SortedList
            /*
             stores key value pairs
             Keys are sorted
              O(log n) lookup time
             */
            /*
            SortedList sl = new SortedList();
            sl.Add("key", "value");
            //Remove,ContainsKey,Clear,Count,
            ICollection keys = sl.Keys;
            ICollection values = sl.Values;
            object val = sl["key"];
            Console.WriteLine(val);
            */
            /*Generic Collections: 
             List<T>
            LinkedList<T>

             Dictionary<TKey, TValue>
             HashSet<T>

             Queue<T>
             Stack<T>
             
             SortedSet<T>
            SortedList<TKey, TValue>
             SortedDictionary<TKey, TValue>
                E.t.c
            */
            List<int> l = new List<int>() { 34,44,33,55,66,77};
            foreach(int i in l)
            {
                //Console.WriteLine(i);
            }
            //Add,Insert(index,item),Remove(item),RemoveAt(index),
            //Count,clear(),Contains(item),IndexOf(item),Sort(),ToArray()

            Queue<int>qq = new Queue<int>();
            //Enqueue,Dequeue,Peek,Contains,clear,Count,ToArray

            Stack<int>st = new Stack<int>();
            st.Push(44);
           // Console.WriteLine(st.Peek());
            //Push(),Pop(),Peek(),Contains(),Clear(),Count,ToArray()

            //Dictionary
            Dictionary<int, int> dic = new Dictionary<int, int>()
            {
                {1,2 },{3,4}, {5,6},

            };
            Console.WriteLine(dic[3]);
            int temp;
            if(dic.TryGetValue(9,out temp))
            {
                Console.WriteLine("{0} is present",temp);
            }
            //Add(key,value),Remove(key),TeyGetValue(key,out val),ContainsKey(key)
            //ContainsValue(value),Clear(),Count,Keys,Vlaues(ICollections<>)
            /*
             Dictionaries are strongly typed(both keys and values), it is more efficent
            than the hashtables due to absence of boxing/unboxing and type checking
            
            Uses hashing
            also maintains the order as the keys are inserted(.net core 3.0 and .net 5.0+)
             */
            foreach(int keys in dic.Keys)
            {
                Console.WriteLine(dic[keys]);
            }

            //HashSet<t>
            /*
             No duplicates,
            Unordered,hashing
            Add(item),Remove(item),Contains(item),Clear(),Count,UnionWith(IEnumerable<T>other,
            InterserctionSith(IEnumerable<T> other),ExveptWith(other)->difference operation,
            SymmetricExceptSith(other)->symmetric difference,ToArray().
             */

            //SortedSet<T>
            /* 
             unique elements
              sorted order
               uses slef balancing bst (o(log n))
              methods are same as the HashSet
             */

            //SortedList vs SortedDictionary
            /*
             sortedList is implemented using array (O(1) access time,O(n) insertions deletions)
              SortedDictionary is implemented using RB tree(O(log n) all operations)
                
          
             */

           

        }
    }
}
