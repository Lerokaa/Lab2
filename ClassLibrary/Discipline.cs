using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Discipline
    {

        private string name;
        private string shortname;

        /// <summary>
        /// имя
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// сокращение
        /// </summary>
        public string ShortName
        {
            get { return shortname; }
            set { shortname = value; }
        }

        public Discipline(string name, string shortname)
        {
            this.Name = name;
            this.ShortName = shortname;
        }
    }
}
