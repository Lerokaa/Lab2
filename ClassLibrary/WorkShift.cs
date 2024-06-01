using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class WorkShift
    {
        private readonly string name;

        public WorkShift(string name)
        {
            this.name = name;
           
        }

        public string Name
        {
            get { return name; }
        }

        
    }
}
