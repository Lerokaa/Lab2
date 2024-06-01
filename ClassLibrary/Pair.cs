using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Pair
    {
		private readonly TimeSpan _timePairStart;
		private readonly TimeSpan _timePairEnd;
		private readonly TimeSpan _timeRestStart;
		private readonly TimeSpan _timeRestEnd;
		private readonly WorkShift _workshift;
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
		public WorkShift WorkShift
		{
			get { return _workshift; }
		}
		public Pair(TimeSpan timePairStart, TimeSpan timePairEnd, TimeSpan timeRestStart, TimeSpan timeRestEnd, WorkShift workshift)
		{
		    _timePairStart = timePairStart;
            _timePairEnd = timePairEnd;
            _timeRestStart = timeRestStart;
            _timeRestEnd = timeRestEnd;
            _workshift = workshift;
        }
    }
}
