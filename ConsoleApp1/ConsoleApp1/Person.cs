using System;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public void intro()
        {
            Console.WriteLine("my name is: "+FirstName+" "+LastName);
        }
    }
}
