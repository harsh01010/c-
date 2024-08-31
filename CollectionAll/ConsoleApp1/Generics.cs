using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class Generics
    {
        //public void compare(object a, object b)
        //{
        //    if(a.Equals(b))
        //        Console.WriteLine("equal");
        //    else Console.WriteLine("not equal");

        //}
        public void compare<T>(T a, T b)
        {
            if (a.Equals(b))
                Console.WriteLine("equal");
            else Console.WriteLine("not equal");
        }
        public int add<T>(T a, T b)
        {
            //return a + b;// gives error as + cannot be applied to type 'T'
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 + d2; // by using dynamic keyword the datatype is identified as runtime(using varkeyword datatype is identified at compilation time)
        }
    }

    // we can also make the class generic , and the the methods inside will only accept the 'T' type

    public class temp<T>
    {
        public static int add(T a,T b)
        {
            return (dynamic)a + (dynamic)b;
        }
    }
}
