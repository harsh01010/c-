using System;
using System.Collections.Generic;
using System.Linq;


namespace LinqTuts
{
   public class Student
    {
        public int StudentId {  get; set; }
        public string StEmail {  get; set; }
        public string FullName { get; set; }
        public List<string>Skills { get; set; }
    }
}
