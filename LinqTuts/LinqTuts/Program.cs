kusing System;
using System.Collections.Generic;
using System.Linq;



namespace LinqTuts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};

            /*
            var querySyntax = from obj in list
                              where obj > 2
                              select obj;
            foreach (var item in querySyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            var methodSyntax = list.Where(obj => obj > 2);
            foreach (var item in methodSyntax)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            var mixedSyntax = (from obj in list
                               select obj).Max();
            Console.WriteLine("max={0}",mixedSyntax);
            */

            /*

            List<Employee>employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Tom" },
                new Employee() { Id = 2, Name = "John" }
               };

           IEnumerable<Employee>query = from emp in employees
                                        where emp.Id == 1
                                        select emp;
            foreach (Employee emp in query)
            {
                Console.WriteLine(emp.Name);
            }

            IQueryable<Employee> query1 = employees.AsQueryable().Where(x => x.Id == 1);
            */

            /* 
           List<Employee> employees = new List<Employee>()
           {
               new Employee(){Id=1,Name="Tom",Email = "tom@gmail.com"},
              new Employee(){Id=2,Name="Jogn",Email = "john@gmail.com"},
             new Employee(){Id=3,Name="Mark",Email = "mark@gmail.com"},
             new Employee(){Id=4,Name="Kim",Email = "kim@gmail.com"},
             new Employee(){Id=5,Name="Adam",Email = "adm@gmail.com"}

           };


               //Select 


           var basicQuery = (from emp in employees
                            select emp).ToList();
           var basicMethod = employees.ToList();

           var basicPropQuery = (from emp in employees
                                 select emp.Id).ToList(); // list of integers
           var basicPropMethod = employees.Select(emp => emp.Id.ToString()).ToList());

           var selectQuery = (from emp in employees
                              select new Student()
                              {
                                  StudentId = emp.Id,
                                  StEmail = emp.Email,
                                  FullName=emp.Name
                              }).ToList();
           var SelectMethod = employees.Select(emp => new Student()
           {
               StudentId = emp.Id,
               StEmail = emp.Email,
               FullName = emp.Name
           }).ToList();

           //select in anonymous type

           var selectAnon = (from emp in employees
                             select new
                             {
                                 CustomId = emp.Id,
                                 CustomName = emp.Name
                             }).ToList();

           // Select using index
           var query = employees.Select((emp,index)=>new {index=index,
           Name=emp.Name}).ToList();

           //above query will get execuete if we use ToList

           foreach (string emp in basicPropMethod)
           {
               Console.WriteLine(emp);
           }
           */


            /*
                List<string>strList = new List<string>() { "Nitish","kaushik","Andrew"};

                var methodResult = strList.SelectMany(x=>x).ToList();
                //select many selects the result and converts into single sequence
                // gives duplicates

                var queryResult = (from res in strList
                                   from ch in res
                                   select ch).ToList();

                List<Student> students = new List<Student>()
                {
                    new Student(){FullName="Ram",StEmail="temp",StudentId=23,Skills=new List<string>(){"c++","Python","java"}},
                    new Student(){FullName="shyam",StEmail="temp",StudentId=33,Skills=new List<string>(){"c++","Python","c#"}},
                    new Student(){FullName="Radha",StEmail="temp",StudentId=55,Skills=new List<string>(){"c++","Ansi C","OS"}},
                    new Student(){FullName="Radhika",StEmail="temp",StudentId=99,Skills=new List<string>(){"node js","react","js"}},

                };

                var methodSelectMany = students.SelectMany(x => x.Skills).ToList();
                //var methodSelectMany = students.SelectMany(x => x.Skills).SelectMany(y=>y).ToList();
                var querySelectMany = (from stu in students
                                      from skill in stu.Skills select skill).ToList();
                foreach(var c in methodSelectMany)
                {
                    Console.WriteLine(c);
                }
            */
            /*
            //Filtering 
            //Where
            var dataSource = new List<int>() { 4, 3, 6, 2, 5, 7, 4, 3, 5, 67, 8 };

            var querySyntax = (from data in dataSource
                               where data > 2
                               select data).ToList();
            var methodSyntax = dataSource.Where(x => x > 2).ToList();

            //OfType 
            var datSource = new List<object>() { "Adam","Harry","Kim","" +
                "John",1,2,3,4,5,6}; 

            var methodSyntaxOfType = datSource.OfType<string>().Where(x=>x.Length>3).ToList();
            var querySyntaxOfType = (from data in datSource
                                    where data is string
                                    select data).ToList();
            */


            /*
            //Sorting Operator

            //OrderBy
            var dataSrc = new List<int>() { 2,1,2,4,5,34,2,1,2};

            var querySyntax = (from num in dataSrc
                               where  num>3
                               orderby num
                               select num).ToList();
            var methodSyntax = dataSrc.Where(x=>x>3).OrderBy(num=>num).ToList();


            List<Employee> employees = new List<Employee>()
           {
               new Employee(){Id=1,Name="Tom",Email = "tom@gmail.com"},
              new Employee(){Id=2,Name="Jogn",Email = "john@gmail.com"},
             new Employee(){Id=3,Name="Mark",Email = "mark@gmail.com"},
             new Employee(){Id=4,Name="Kim",Email = "kim@gmail.com"},
             new Employee(){Id=5,Name="Adam",Email = "adm@gmail.com"}

           };

            var queryEmp = (from emp in employees
                            orderby emp.Id descending // OrderByDescending
                            select emp.Name).ToList();
            var methodEmp = employees.OrderBy(x=>x.Id).Select(emp
                =>emp.Name).ToList();

            //OrderByDescending  similar to OrderBy 


            //ThenBy and ThenByDescending
            List<Animal> animals = new List<Animal>()
            {
                new Animal()
                {
                    FirstName="fname1",
                    LastName="lname1",
                    LifeSpan=40
                },
                 new Animal()
                {
                    FirstName="fname2",
                    LastName="lname2",
                    LifeSpan=10
                },
                  new Animal()
                {
                    FirstName="5353",
                    LastName="fgggdg",
                    LifeSpan=44
                },
                   new Animal()
                {
                    FirstName="hfghfgh",
                    LastName="345345",
                    LifeSpan=98
                },
                    new Animal()
                {
                    FirstName="3434",
                    LastName="dgsdfg",
                    LifeSpan=44
                },

            };

            var res = animals.OrderBy(x => x.FirstName).ThenBy(x => x.LastName).ThenBy(x => x.LifeSpan).ToList
                ();
            //similarly ThenByDescending

            //Reverse
            int[] rollnums = new int[] { 2, 3, 24, 36, 4, 5, 33 };
            var mq = rollnums.Reverse().Where(x=>x>2).ToList();


            var qs = (from num in rollnums
                      select num).Reverse().ToList();

            List<string> names = new List<string>() { "hello", "Hola", "Namaste", "Konichiwa", "Preweet" };

            //IEnumerable<string> tempNames = names.Reverse();// this will give error as names is a generic collection and it has a Reverse function that returns void.

            var tempNames = names.AsEnumerable().Reverse().ToList();
            */
            /*

            //Quantifier Operators
            //All => returns true or false , no need to convert to list if used alone

            List<Animal> animals = new List<Animal>()
            {
                new Animal()
                {
                    FirstName="fname1",
                    LastName="lname1",
                    LifeSpan=40
                },
                 new Animal()
                {
                    FirstName="fname2",
                    LastName="lname2",
                    LifeSpan=10
                },
                  new Animal()
                {
                    FirstName="5353",
                    LastName="fgggdg",
                    LifeSpan=44
                },
                   new Animal()
                {
                    FirstName="hfghfgh",
                    LastName="345345",
                    LifeSpan=98
                },
                    new Animal()
                {
                    FirstName="3434",
                    LastName="dgsdfg",
                    LifeSpan=44
                },

            };

            var m = animals.All(x => x.LifeSpan > 30);

            var query = (from animal in animals
                          select animal).All(x => x.LifeSpan   > 30);

            List<Marks> marks = new List<Marks>()
            {
                new Marks()
                {
                    StuName = "test",
                    marks = new Dictionary<string, int> ()
                    {
                        {"math",100 },
                        {"physics",100 },
                        {"chemistry",100 }
                    }

                },
                 new Marks()
                {
                    StuName = "test1",
                    marks = new Dictionary<string, int> ()
                    {
                        {"math",100 },
                        {"physics",100 },
                        {"chemistry",100 }
                    }

                },
                  new Marks()
                {
                    StuName = "test2",
                    marks = new Dictionary<string, int> ()
                    {
                        {"math",55 },
                        {"physics",67 },
                        {"chemistry",99 }
                    }

                },
                   new Marks()
                {
                    StuName = "test3",
                    marks = new Dictionary<string, int> ()
                    {
                        {"math",88 },
                        {"physics",90 },
                        {"chemistry",55 }
                    }

                }
            };

            var res = marks.Where(curr => curr.marks.All(x => x.Value > 80)).Select(x=>x.StuName).ToList();

            var resQ = (from mark in marks
                        where mark.marks.All(x => x.Value > 80)
                        select mark).ToList();
            // similary Any => returns ture if any stisfies the condition 
            // if(lst.Any()) => to check if list is not empty

            var names = new List<string>() { "Kim", "Jacob", "Simon", "John" };
            var isExist = names.AsEnumerable().Contains("Nitish");
            var isExistUsingQuery = (from name in names
                                     select name).Contains("John");


            var animalIsExist = animals.Contains(new Animal()
            {
                FirstName = "fname1",
                LastName = "lname1",
                LifeSpan = 40
            });

            var comparer = new AnimalComparer();
           var animalIsExist2 = animals.Contains(new Animal()
            {
                FirstName = "fname1",
                LastName = "lname1",
                LifeSpan = 40
            }, comparer);

            */


            /*
            //Set Operations
            // Distinct
            var nums = new List<int>(){ 3,2,4,5,5,4,3,2,3,4};

            var distinctMtd = nums.Distinct().ToList();
            var dictinctQuery = (from num in nums
                                 select num).Distinct();

            var dataSet = new List<Simple>()
            {
                new Simple()
                {
                    Name = "ram",Id=34
                },
                new Simple()
                {
                    Name = "shyam",Id=66
                },new Simple(){Name="ram" , Id=55},new Simple(){Name="shyam",Id=66},
                new Simple(){Name="John",Id=100},new Simple(){Name="Raju",Id=101}
            };

            var resM = dataSet.Select(x => x.Name).Distinct().ToList();
            var resQ = (from data in dataSet
                        select data.Name).Distinct().ToList();

            var ress = dataSet.Distinct().ToList();

            var comparer = new simpleComparer();

            var res = dataSet.Distinct(comparer).ToList();


            //Except (set Difference)
            List<string> ds1 = new List<string>() { "A", "B", "C", "D" };
            List<string> ds2 = new List<string>() { "A", "B", "E", "F" };

            var dataSet2 = new List<Simple>()
            {
                new Simple()
                {
                    Name = "ram",Id=34
                },
                new Simple()
                {
                    Name = "shyam",Id=66
                },new Simple(){Name="radfm" , Id=535},new Simple(){Name="shyddam",Id=656}
            };

            var ms = ds1.Except(ds2).ToList();

            var ms2 = dataSet.Select(x => x.Name).Except(dataSet2.Select(x => x.Name)).ToList();

            var ms3 = dataSet.Except(dataSet2).ToList();    //this will not work


            // method 1 , using anonymous type
            var ms4 = dataSet.Select(x =>new { x.Name,x.Id}).Except(dataSet2.Select(x => new { x.Name,x.Id})).ToList();


            //method 2 , using IEqualityComparer

            var ms5 = dataSet.Except(dataSet2, new simpleComparer()).ToList();




            var qs5 = (from data in dataSet
                       select data).Except(dataSet2, new simpleComparer()).ToList();

            */
            /*

            var dataSrc1 = new List<Simple>()
            {
                new Simple()
                {
                    Name = "ram",Id=34
                },
                new Simple()
                {
                    Name = "shyam",Id=66
                },new Simple(){Name="ram" , Id=55},new Simple(){Name="shyam",Id=66},
                new Simple(){Name="John",Id=100},new Simple(){Name="Raju",Id=101}
            };

            var dataSrc2 = new List<Simple>()
            {
                new Simple()
                {
                    Name = "ram",Id=34
                },
                new Simple()
                {
                    Name = "shyam",Id=66
                },new Simple(){Name="radfm" , Id=535},new Simple(){Name="shyddam",Id=656}
            };


            var res = dataSrc1.Intersect(dataSrc2, new simpleComparer()).ToList();

            var res2 = dataSrc1.Select(x => new { x.Name, x.Id }).Intersect(dataSrc2.Select(x => new { x.Name, x.Id })).Select(x => x.Name).ToList();

            //Similarly Union

            */

            //Partitioning Operators(divides data into two parts and return one part)


            //take operator

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var ms = nums.Take(5).ToList();

            var ms2 = nums.Where(x => x % 2 == 0).Take(2).ToList();

            //TakeWhile
            var ms3 = nums.TakeWhile(x => x < 7).ToList();//once the condition becomes fail , it will not check further even if there is chance of conditon being ture

            List<string> names = new List<string>() { "Kim", "Dim", "min", "Mam" };

            var ms4 = names.TakeWhile((name, index) => name.Length > index).ToList();

            //Skip => skip first n and remaining will return as op.
            //SkipWhile

            //paging using skip and take
            /*
            int totalPagePerView = 4;
            Console.WriteLine("Enter your page number");
            if(int.TryParse(Console.ReadLine(),out int pageNumber))
            {
                var ms5 = getData().Skip((pageNumber - 1) * totalPagePerView).Take(totalPagePerView).ToList();
                Console.WriteLine("page no: {0}",pageNumber);
                foreach (var x in ms5)
                {
                    Console.WriteLine("{0} {1}",x.Id,x.Name);
                }
            }
            else { Console.WriteLine("Input is not valid"); }

            */
            //Join
            //inner join -> elements which has a common properties in both the data sources

            var temps = new List<Temp>()
            {
                new Temp(){Id=1,Name="A 1",AddressId=1},
                new Temp(){Id=2,Name="A 2",AddressId=0},
                new Temp(){Id=3,Name="A 3",AddressId=2},
                new Temp(){Id=4,Name="A 4",AddressId=0},
                new Temp(){Id=5,Name="A 5",AddressId=3},

            };

            var addresses = new List<Address>()
            {
                new Address(){Id=1,Info="Line 1"},
                new Address(){Id=2,Info="Line 2"},
                new Address(){Id=3,Info="Line 3"},
                new Address(){Id=4,Info="Line 4"},
                new Address(){Id=5,Info="Line 5"}
            };

            var qs = (from temp in temps
                     join address in addresses
                     on temp.AddressId equals address.Id
                     select new
                     {
                         name = temp.Name,
                         address = address.Info
                     }).ToList();

            var Ms = temps.Join(addresses,temp=>temp.AddressId,address=>address.Id
                    , (temp, address) => new
                    {
                        name =  temp.Name,
                        address = address.Info
                    }).ToList();


            var results = new List<Results>()
            {
                new Results(){Id=1,TempId=1,Marks=80},
                new Results(){Id=2,TempId=2,Marks=90},
                new Results(){Id=3,TempId=3,Marks=95}
            };


            var qs2 = (from temp in temps
                       join address in addresses
                       on temp.AddressId equals address.Id
                       join res in results
                       on temp.Id equals res.TempId                       select new
                       {
                           name = temp.Name,
                           address = address.Info,
                           marks = res.Marks
                       }).ToList();

            var Ms2 = temps.Join(addresses, temp => temp.AddressId, address => address.Id,
                (temp, address) => new { temp, address }).Join(results, res => res.temp.Id, result => result.TempId,
                (x, result) => new
                {
                    name = x.temp.Name,
                    addresses = x.address.Info,
                    marks = result.Marks
                }).ToList();


            //Group Join => is used to group the result based on a common key.

            //outer.(inner,outerKey,innerKey,result)
            var groupMs = addresses.GroupJoin(temps,address=>address.Id,temp=>temp.AddressId,
                
                    (address, temp) => new {address,temp}).ToList();



            Console.WriteLine();






        }
        public static List<Simple> getData()
        {
            return new List<Simple>()
            {
                     new Simple() { Id = 1, Name = "Kim" },
                     new Simple() { Id = 2, Name = "John" },
                     new Simple() { Id = 3, Name = "Jane" },
                     new Simple() { Id = 4, Name = "Alex" },
                     new Simple() { Id = 5, Name = "Emily" },
                     new Simple() { Id = 6, Name = "Michael" },
                     new Simple() { Id = 7, Name = "Sarah" },
                     new Simple() { Id = 8, Name = "David" },
                     new Simple() { Id = 9, Name = "Laura" },
                     new Simple() { Id = 10, Name = "Robert" },
                     new Simple() { Id = 11, Name = "Jessica" },
                     new Simple() { Id = 12, Name = "Daniel" },
                     new Simple() { Id = 13, Name = "Karen" },
                     new Simple() { Id = 14, Name = "James" },
                     new Simple() { Id = 15, Name = "Lisa" },
                     new Simple() { Id = 16, Name = "Thomas" },
                     new Simple() { Id = 17, Name = "Mary" },
                     new Simple() { Id = 18, Name = "Christopher" },
                     new Simple() { Id = 19, Name = "Patricia" },
                     new Simple() { Id = 20, Name = "Mark" }
            };
        }
    }
    // to compare different refrences of same class(true if values are equal)
    class AnimalComparer : IEqualityComparer<Animal>
    {
        public bool Equals(Animal x, Animal y)
        {
            if (object.ReferenceEquals(x, y)) return true;

            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null))
                return false;

            return x.FirstName == y.FirstName
                    && x.LastName == y.LastName
                    && x.LifeSpan == y.LifeSpan;
        }
        public int GetHashCode(Animal obj)
        {
            if (obj == null)
                return 0;
            int nameHashcode = obj.FirstName.GetHashCode();
            int lifeHashcode =  obj.LifeSpan.GetHashCode();

            return lifeHashcode;



        }
    }

    class Simple /*:IEquatable<Simple>*/ // option 1
    {
        public string Name { get; set; }
        public int Id { get; set; }

        //Option 1
        /*
        public bool Equals(Simple other)
        {
            if(object.ReferenceEquals(this, other)) return true;
            if(object.ReferenceEquals(this,null) || object.ReferenceEquals(other,null)) 
                return false;
                return other.Id == this.Id && other.Name
                 == this.Name;
        }

        public override int GetHashCode()
        {
            int idHash = Id.GetHashCode();
            int nameHashcode = Name.GetHashCode();

            return idHash ^ nameHashcode;
        }
        */
    }

    //Option 2
    class simpleComparer : IEqualityComparer<Simple>
    {
        public bool Equals(Simple x, Simple y)
        {
            if(object.ReferenceEquals(y, x)) return true;

            if (object.ReferenceEquals(x, null) || object.ReferenceEquals(y, null)) return false;

            return x.Id == y.Id && x.Name==y.Name;
        }



        public int GetHashCode(Simple obj)
        {
            int idHash = obj.Id.GetHashCode();
            int nameHash = obj.Name.GetHashCode();
            return idHash ^ nameHash;

        }
    }

   

}
