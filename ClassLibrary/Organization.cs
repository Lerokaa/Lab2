using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Organization
    {
        private string name;
        private string uraddress;
        private string factaddress;
        private Employee supervisor;
        public Organization(string name, string uraddress, string factaddress, Employee supervisor)
        {
            this.name = name;
            this.uraddress = uraddress;
            this.factaddress = factaddress;
            this.supervisor = supervisor;
        }
        public string Name
        {
            get { return name; } set { name = value; }
        }
        public string Uraddress
        {
            get { return uraddress; } set { uraddress = value; }
        }
        public Employee Supervisor
        {
            get { return supervisor; } set { supervisor = value; }
        }
        public string FactAddress
        {
            get { return factaddress; } set {  factaddress = value; }
        }
    }
}
