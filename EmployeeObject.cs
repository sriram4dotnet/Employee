using System;
using System.Collections.Generic;

namespace Employee
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    public class Project
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class EmployeeObject
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public DateTime HireDate { get; set; }
        public Address Address { get; set; }
        public List<string> Skills { get; set; }
        public List<Project> Projects { get; set; }
    }

}
