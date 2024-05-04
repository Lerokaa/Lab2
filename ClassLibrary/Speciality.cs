using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ClassLibrary
{
    internal class Speciality
    {
        //https://docs.google.com/document/d/1pDw7bbBJDmeqT8VVwp68BSOF_4yd9cNb9xpH_q2KW0E/edit
        private readonly string name;
        private readonly string redname;
        public Speciality(string name, string redname)
        {
            this.name = name;
            this.redname = redname;
        }
    }
}
