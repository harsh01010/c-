using System;
using System.Collections.Generic;


namespace Oop
{
    public class  Customer
    {
        public int id;
        public string name;
        public List<int> orders;
        public List<int> payments = new List<int>();// we can also intialize like this
        public Customer() { 
            orders = new List<int>();// always do it
        }
        public Customer(string name):this()
        {
            this.name = name;
           

        }
        public Customer(int id) :this()
        {
            this.id = id;

        }
        public Customer(int id, string name) :this(id)
        {
            this.name = name;
        }
        public  void getData()
        {
            Console.WriteLine($"{id} {name}");

        }

    }

}
