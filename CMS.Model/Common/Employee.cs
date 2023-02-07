using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Model.Common
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string? EmpName { get; set; }
        public string? EmpPosition { get; set; }
        public string? EmpPlace { get; set; }
        public string? EmpSalary { get; set; }
        public int depID { get; set; }
    }
}
