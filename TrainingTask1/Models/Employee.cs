using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingTask1.Models
{
    public class Employee
    {
        public int employee_id { get; set; }
        public char name { get; set; }
        public char Status { get; set; }
        public char Manager { get; set; }
        public char wfm_manager { get; set; }
        public string Email { get; set; }
        public string Lockstatus { get; set; }
        public int experience { get; set; }
        public int profile_id { get; set; }
    }
}
