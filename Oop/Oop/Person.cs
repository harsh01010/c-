using System;


namespace Oop
{
    public class Person
    {
        public string name;
        public int age;
        public string address;
        public void introduce(string to)
        {
            Console.WriteLine($"Hi {to},this is {name}");
        }
    }

}
