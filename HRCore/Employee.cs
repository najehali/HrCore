using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRCore
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string GrandfatherName { get; set; }
        public string FamilyName { get; set; }
        public DateTime? BirthDate { get; set; }
    }
}
