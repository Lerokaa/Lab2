using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Lesson
    {
		private DateTime _timeParaStart;
		private DateTime _timeParaEnd;
		private DateTime _timeRestStart;
		private DateTime _timeRestEnd;
		private Smena _smena;
		public (DateTime timeParaStart, DateTime timeParaEnd, DateTime timeRestStart, DateTime timeRestEnd, Smena Smena)
		{
		    _timeParaStart = timeParaStart;
		    _timeParaEnd = timeParaEnd;
		    _timeRestStart = timeRestStart;
		    _timeRestEnd = timeRestEnd;
		    _smena = smena;
		}
    }
}
