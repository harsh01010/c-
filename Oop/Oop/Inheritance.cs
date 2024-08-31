using System;


namespace Oop
{
   public class Inheritance
    {
        public string Name {  get; set; }
        public int Id { get; set; }
        
        public Inheritance() { }
        public Inheritance(string name,int id):this()
        {
            this.Name = name;
            this.Id = id;
        }
        public virtual void printInfo()
        {
            Console.WriteLine("Inside the virtual(overridable) function of the parent class");
        }
        
    }

    public class  Derived:Inheritance
    {
        public string SubName {  get; set; }
        public  int Amount {  get; set; }
        public Derived():base() { }
        public Derived(string name,string subname,int id,int amount):this()
        {  
            this.SubName=subname;
            this.Amount=amount;
            base.Name =name;
            base.Id =id;

        }

        public override void printInfo()
        {
            Console.WriteLine("overridden method");
        }
    }
    // a child can have only 1 immediate parent 
    //multiple inheritace
    interface Iparent1
    {
        void Test();
    }
    interface Iparent2
    {
        void Test();
    }
    public class Child : Iparent1, Iparent2
    {
        /*
        public void Test()
        {
            Console.WriteLine("Abmiguity problem solved!");
        }
        */
        void Iparent1.Test() { Console.WriteLine("Test of the interface 1"); } 
        void Iparent2.Test() { Console.WriteLine("Test of the interface 2"); }
        // when the object of the child class will be created , Test method cannot be called by the refrence of the child class
        // the test method can be called by the refrences of the Iparent1 and Iparent2 , and their specific implementation of the test will be executed

    }
}

