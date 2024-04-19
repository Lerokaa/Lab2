using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Division
{
    private string name;
    private Employee head;
    private Organization organization;
    
    public Department(string name, Employee head, Organization organization)
    {
        this.name = name;
        this.head = head;
        this.organization = organization;
    }
}

class Employee
{
    public string Name { get { return name; } set { name = value; } }
    public DateTime HireDate { get { return HireDate; } set { HireDate = value; }}

    public Employee(string name)
    {
        this.Name = name;
        this.HireDate = DateTime.Now;
    }
}

class Organization
{
    public string Name { get { return name; } set { name = value; } }

    public Organization(string name)
    {
        this.Name = name;
    }
}
}
