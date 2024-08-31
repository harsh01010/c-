// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                


                            //Console.WriteLine("Hello World!");
            //Data types
            /*
            byte number=2;
            int count = 10;
            float totalPrice = 20.45f;//default double
            char character = 'A';
            string firstName = "mosh";
            decimal dec = 2.2m;
            */
            /*
            var number = 2;
            var count = 10;
            var totalPrice = 20.45f;
            var character = 'A';
            var firstName = "mosh";
            var dec = 2.2m;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(dec);
            Console.WriteLine(firstName);

            const float pi = 3.14f;
            */
            /*
             //overflowing
            byte b = 255;
            b+=1;
            Console.WriteLine(b);
             */
            //Format string
            /*
            Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);
            Console.WriteLine("{1} {0}",int.MinValue,int.MaxValue);

            string st = "Hello";
            Console.WriteLine($"{st} World");
            */

            /*
            //type conversion

            byte b = 1;
            int i = b; //implicit type conversion

            Console.WriteLine(i);

            int x = 20000;
            byte y = (byte)x;//explict casting , chance of data loss

            string number = "12345";
            int iNum = Convert.ToInt32(number);
            Console.WriteLine(iNum);
            //handle exception
            try
            {
                var str = "123ab";
                Console.WriteLine(Convert.ToInt32(str));
            }
            catch(Exception e) {
                Console.WriteLine("could not be converted");
            }

            string val = "123";
            int result;
            if(int.TryParse(val,out result))
                {
                    Console.WriteLine( result);
                }
            else{
                Console.WriteLine("cannot be converted");
                }
            */
            /*
            //operators
            var a = 10;
            var b = 3;
            Console.WriteLine(a + b);
            Console.WriteLine(a /(float)b);
            Console.WriteLine((a+b)*5);
            Console.WriteLine(a>b?"hello":"bye");
            Console.WriteLine(a!=b);//True
            Console.WriteLine(a>b && a!=b);
            Console.WriteLine(a==b);
            Console.WriteLine(a>b || a==b);
            */
            /*
            //classes
            var p = new Person();
            p.FirstName = "temp";
            p.LastName = ".";
            p.intro();

            var cal = new Calculator();
            var res = Calculator.Add(3, 4);
            Console.WriteLine(res);
            */
            //array
            /*
            int[] nums = new int[3];
            nums[0] = 1;
            nums[1] = 4;
            nums[2] = 5;
            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]);

            string[] names = new string[3] { "jack", "jhon", "harry" };
        */
            /*
            //strings
            //strings are immutable
            string name = "hello" + "world";
            string str = string.Format("{0} {1}", "hello", "world");

            var nums = new int[3] { 1, 2, 3 };
            string lst = string.Join(",", nums);
            Console.WriteLine(lst);

            var fName = "mosh";
            var lName = "hamedani";
            var fullName = string.Format("{0} {1}", fName, lName);
            Console.WriteLine(fullName);

            var text = "hi how\n are you:\\look this path\\";
            var text2 = @"hi how 
are you:\look this path\";
            Console.WriteLine(text2);
            */
            /*
            //enums
            Console.WriteLine((int)vals.y);

            var mtd = 3;
            Console.WriteLine((vals)mtd);
            var methodName = "x";
           var valsMethod = (vals) Enum.Parse(typeof(vals), methodName);
            */
            /*
            // value type and refrence type
            int a = 20;
            int b = a;
            b++;
            Console.WriteLine(String.Format("a:{0} b:{1}",a,b));

            int[] arr = new int[3] { 1, 2, 3 };
            var brr = arr;
            brr[0] = 20;
            Console.WriteLine(arr[0]);
            Console.WriteLine(brr[0]);
            */
            /*
            //conditionals
            // if else,switch case,ternary operator
            var month = Months.feb;
            switch (month)
            {
                case Months.jan:
                    Console.WriteLine("it's jan");
                    break;
                case Months.feb:
                    Console.WriteLine("it's feb");
                    break;
                case Months.mar:
                    Console.WriteLine("it's march");
                    break;
                default:
                    Console.WriteLine("other months");
                    break;
            }
            */
            /*
            //Exercise
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());

            ExerciseSolutions.lessThanTen(x);

            Console.WriteLine("Enter the first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(ExerciseSolutions.findMax(a, b));

            Console.WriteLine("Enter the height of the image:");
            float h = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the width of the image:");
            float w = Convert.ToSingle(Console.ReadLine());
            
            ExerciseSolutions.imageType(h, w);

            Console.WriteLine("Enter the Speed and the Limit seperated by space: ");
            var vals = Console.ReadLine().Split(' ');
            ExerciseSolutions.check( Convert.ToInt32(vals[0]), Convert.ToInt32(vals[1]) );
            */
            //Iteration statements
            // for , foreach,while , do while
            /*
            for(var i = 0; i < 20; i++)
            {
                Console.WriteLine(i%2);
            }

            string name = "Hello world";
            foreach(var ch in name)
            {
                Console.WriteLine(ch);
            }
            var names = new String[4]{ "aa","vv","vvvv","ddd"};
            foreach(var x in names)
            {
                Console.WriteLine(x);
            }
            
            while (true)
            {
               
                var inp = Console.ReadLine();
                if (String.IsNullOrEmpty(inp))
                {
                    break;
                }
            }
             string str = "ABCD";
            char []arr = str.ToCharArray();
            Array.Reverse(arr);
            string rev = new string(arr);
            System.Console.WriteLine(rev);
            //System.Console.WriteLine(String.Join("",rev));
            string st = "A,B,CD,E";
            string []brr = st.Split(',');
            foreach(string c in brr)
            {
               System.Console.WriteLine(c);
            }

            // IndexOf("") -> returns -1 if no match found

            The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.
            The Replace() method swaps all instances of a string with a new string.

            IndexOfAny([,,,],starting index)
            */
            //random
            /*
            var random = new Random(); // Random dice = new();
            var buffer = new char[20];
            for(int i =0;i<20;i++)
            {
                //random.next only generates non -ve numbers
                //Console.WriteLine(random.Next()); // any random value
                //Console.WriteLine(random.Next(100)); // random number less than  100                        
                // Console.WriteLine(random.Next(1,20)); // greater than or equals to 1 and less than 20;
                // Console.Write((char)('a'+random.Next(0,26)));
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            var password = new String(buffer);
            Console.WriteLine(password);
            */
            /*
            var inp = Console.ReadLine().Split(',');
            var max = int.MinValue;
            foreach (var num in inp)
            {
                var numInt = int.Parse(num);
                max = numInt > max ? numInt : max;
            }

            Console.WriteLine(max);
            */
            //Arrays
            /*
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
             string [] names = {"abc","abc","abc","abc"};

                int [,] arr2 = new int [3,4]; //2d array

            Console.WriteLine(numbers.Length);
            Console.WriteLine(Array.IndexOf(numbers, 4));

            Array.Clear(numbers, 0, 2); // sets 2 items from 0 th index as 0
            // if bool array then sets to false , in case of string or other type of objects clearing means seating to null
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Array.Sort(another);
            Array.Reverse(another);
            Console.WriteLine(another);

            var arr = new int[]{1,2,3,4};
     Array.Resize(ref arr,6); // resizes the size of the arr to 6 and the next 2 values are null , untill not specified

     // There is not any method to remove null elements from the array the best way is to count the non null elements through iteration and store it to another array.
            */
            /*
            var nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            nums.Add(2);
            nums.AddRange(new int[] { 1, 1, 2, 3, 2, 1 });
            Console.WriteLine(nums.IndexOf(1));
            Console.WriteLine(nums.LastIndexOf(1));
            Console.WriteLine(nums.Count);
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == 1)
                {
                    nums.Remove(nums[i]);
                }
            }
            nums.Clear();
            Console.WriteLine(nums.Count);
            */
            //exercise
            /*
            var inp = Console.ReadLine().Split(' ');

            switch (inp.Length)
            {
                case 0:
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.WriteLine("{0} {1}", inp[0], inp[2]);
                    break;
                case 1:
                    Console.WriteLine("{0}", inp[0]);
                break;
                default:
                    Console.WriteLine("{0} {1} and {2} other people liked", inp[0], inp[1],inp.Length-2);
                    break;


            }
            */
            /*
            var name = Console.ReadLine();
            var inp = name.ToCharArray();
            Array.Reverse(inp);
            Console.WriteLine(String.Join("",inp));
            */
            /*
            List<int> list = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (list.Contains(x))
                {
                    i--;
                    continue;
                }
                else
                {
                    list.Add(x);
                }
            }
            foreach (int x in list)

            {

            Console.WriteLine(x); 
            }
            */
            // System.Math
            //System.Console.WriteLine(Math.Max(11,1233));
            
            /*
            string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };
            foreach(string o in orderIDs)
            {
                if(o.StartsWith("B"))
                {
                    Console.WriteLine($"{o} starts with B");
                }

            }
            // st.Trim() -> removes all the leading and trailing whitespaces
            */

    /*
       string [][] arr = new string[][]
       {
            new string[]{"1","3","4"},
            new string[]{"2","4","5"},
       };
       foreach(string[] s in arr)
       {
        foreach(string str in s)
        {
            Console.WriteLine(str);
        }
       }
    */
    /*
    string inp = Console.ReadLine();
    FilterString.printBetween(inp);
    */
    /*
        //stringBuilder(System.Text)
        StringBuilder sb= new StringBuilder("this is a stringbuilder");
        sb.Append('-',5);
        sb.Append("this is appended");
        sb.AppendLine("\nnew line is appended");
        sb[2] = '5';
        sb.Replace("5","(5->Five)");
        sb.Remove(3,4); // start and end index
        sb.Insert(0,"inserted at head\n");
        
        System.Console.WriteLine(sb);

    */
    //FileHandling(System.IO)
    string diPath =      @"C:\All\code\f1\dev\cSharp";
    Directory.CreateDirectory(diPath+@"\tempDir");
   // DirectoryInfo directoryInfo= new DirectoryInfo(diPath);
   // System.Console.WriteLine(directoryInfo.LastAccessTime.ToString());
   string filePath = @"C:\All\code\f1\dev\cSharp\temp.txt";
   //File.Create(filePath);
   if(File.Exists(filePath))
   {
    System.Console.WriteLine("file exists");
    //File.AppendAllText(filePath,"this will append to file");
    string[] line = new string[]
    {
        "hello","welcome","how are you!",DateTime.Now.ToString()
    };
    File.WriteAllLines(filePath, line);
   }
   else System.Console.WriteLine("file does not exist");

   string[] files = Directory.GetFiles(diPath);
   foreach(string file in files)
   {
    System.Console.WriteLine(file);
   }
//    if(Directory.Exists(diPath)){
//     System.Console.WriteLine("dirExists");
//    }
  
    

        }
    }
}