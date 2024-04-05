using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //https://docs.google.com/document/d/1pDw7bbBJDmeqT8VVwp68BSOF_4yd9cNb9xpH_q2KW0E/edit
    internal class Speciality
    {
        private string Name;
        private string AbbreviationName;

        public Speciality(string Name, string AbbreviationName)
        {
            this.Name = Name;
            this.AbbreviationName = AbbreviationName;
        }
        public Speciality(){}
    }
}
