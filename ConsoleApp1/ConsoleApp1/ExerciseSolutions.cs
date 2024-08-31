using System;


namespace ConsoleApp1
{
    internal class ExerciseSolutions
    {
        public static void lessThanTen(int n)
        {
            Console.WriteLine((n>=1 && n<=10)?"Valid":"Not Valid");
        }
        public static int findMax(int a,int b)
        {
            return a > b ? a : b;
        }
        public static void imageType(float height, float width)
        {
            if (height >= width)
            {
                Console.WriteLine("Potrait");
            }
            else
            {
                Console.WriteLine("Landscape");
            }
        }

        public static void check(int speed,int limit)
        {
            var demerit = 0f;
            if (speed <= limit)
            {
                Console.WriteLine("OK");
            }
            else
            {

                demerit = (speed - limit) / 5f;
                if(demerit > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine(String.Format("Demerit:{0}",demerit));
                }

            }
            

        }
    }
}
