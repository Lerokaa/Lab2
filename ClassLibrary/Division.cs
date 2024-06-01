using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Division
    {
        private readonly string name;
        private readonly Employee head;
        private readonly Organization organization;
        public Division(string name, Employee head, Organization organization)
        {
            this.name = name;
            this.head = head;
            this.organization = organization;
        }
        public string Name
        {
            get { return name; }

        }
        public Employee Head
        {
            get { return Head; }

        }
        public Organization Organization
        {
            get { return organization; }

        }



    }

}




