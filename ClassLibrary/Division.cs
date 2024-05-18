using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Division
    {
        private string name;
        private Employee head;
        private Organization organization;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Employee Head
        {
            get { return head; }
            set { head = value; }
        }
        public Organization Organization
        {
            get { return organization; }
            set { organization = value; }
        }

        public Division(string name, Employee head, Organization organization)
        {
            this.name = name;
            this.head = head;
            this.organization = organization;
        }

    }
}


    
