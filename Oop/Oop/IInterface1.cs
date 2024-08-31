using System;


namespace Oop
{
     interface IInterface1
    {
        void Add(int a, int b);
    }

    interface IInterface2 : IInterface1
    {
        void Sub(int a, int b);
    }

    class ImplementationClass : IInterface2
    {
        public void Add(int a,int b)
        {
            Console.WriteLine(a+b);
        }
        void IInterface2.Sub(int a, int b)
        { Console.WriteLine(a-b); }
            

    }
}
