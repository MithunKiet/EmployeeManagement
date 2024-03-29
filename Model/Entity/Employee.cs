﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public int EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public DateTime EmploymentDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public ICollection<EmployeeSkills> EmployeeSkills { get; set; }
        public ICollection<Skill> Skills { get; set; }

        

    }
}
