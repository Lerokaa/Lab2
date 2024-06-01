using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //https://docs.google.com/document/d/1pDw7bbBJDmeqT8VVwp68BSOF_4yd9cNb9xpH_q2KW0E/edit
    public class Speciality
    {
        private readonly string specialityName;
        private readonly string reductionName;
        public Speciality(string specialityName, string reductionName)
        {
            this.specialityName = specialityName;
            this.reductionName = reductionName;
        }

        public string SpecialityName { get { return specialityName; } }
        public string ReductionName { get { return reductionName; } }
    }
}
