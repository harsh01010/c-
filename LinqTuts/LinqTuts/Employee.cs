using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTuts
{
    public class Employee
    {
        public int Id { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Email {  get; set; }
    }
}
