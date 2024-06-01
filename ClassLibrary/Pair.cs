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
		}
		public TimeSpan PairEnd
		{
			get { return _timePairEnd; }
		}
		public TimeSpan RestStart
		{
			get { return _timeRestStart; }
		}
		public TimeSpan RestEnd
		{
			get { return _timeRestEnd; }
		}
		public WorkShift Shift
		{
			get { return _shift; }
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
