using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Employee.DTO
{
    public abstract class Employee
    {
        public int idEmployee { get; set; }
        public int hoursWorked { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public decimal salary {get; set; }
        

    }
}
