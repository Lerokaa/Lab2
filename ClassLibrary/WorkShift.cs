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
        private readonly DateTime date;

        public WorkShift(string name, DateTime? date = null)
        {
            this.name = name;
            this.date = date ?? DateTime.Now;
        }

        public string Name
        {
            get { return name; }
        }

        public DateTime Date
        {
            get { return date; }
        }
    }
}
