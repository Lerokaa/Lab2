using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Pair
    {
		private DateTime _timePairStart;
		private DateTime _timePairEnd;
		private DateTime _timeRestStart;
		private DateTime _timeRestEnd;
		private WorkShift _shift;
		public DateTime PairStart
		{
			get { return _timePairStart; }
			set { _timePairStart = value; }
		}
		public DateTime PairEnd
		{
			get { return _timePairEnd; }
			set { _timePairEnd = value; }
		}
		public DateTime RestStart
		{
			get { return _timeRestStart; }
			set { _timeRestStart = value; }
		}
		public DateTime RestEnd
		{
			get { return _timeRestEnd; }
			set { _timeRestEnd = value; }
		}
		public WorkShift Shift
		{
			get { return _shift; }
			set { _shift = value; }
		}
		public Pair(DateTime timePairStart, DateTime timePairEnd, DateTime timeRestStart, DateTime timeRestEnd, WorkShift shift)
		{
		    _timePairStart = timePairStart;
		    _timePairEnd = timePairEnd;
		    _timeRestStart = timeRestStart;
		    _timeRestEnd = timeRestEnd;
		    _shift = shift;
		}
    }
}
