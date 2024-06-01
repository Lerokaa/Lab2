using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Pair
    {
		private TimeSpan _timePairStart;
		private TimeSpan _timePairEnd;
		private TimeSpan _timeRestStart;
		private TimeSpan _timeRestEnd;
		private WorkShift _shift;
		public TimeSpan PairStart
		{
			get { return _timePairStart; }
			set { _timePairStart = value; }
		}
		public TimeSpan PairEnd
		{
			get { return _timePairEnd; }
			set { _timePairEnd = value; }
		}
		public TimeSpan RestStart
		{
			get { return _timeRestStart; }
			set { _timeRestStart = value; }
		}
		public TimeSpan RestEnd
		{
			get { return _timeRestEnd; }
			set { _timeRestEnd = value; }
		}
		public WorkShift Shift
		{
			get { return _shift; }
			set { _shift = value; }
		}
		public Pair(TimeSpan timePairStart, TimeSpan timePairEnd, TimeSpan timeRestStart, TimeSpan timeRestEnd, WorkShift shift)
		{
		    _timePairStart = timePairStart;
            _timePairEnd = timePairEnd;
            _timeRestStart = timeRestStart;
            _timeRestEnd = timeRestEnd;
            _shift = shift;
        }
    }
}
