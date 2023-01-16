using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Model
{
  public  class Employee
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string Family { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
