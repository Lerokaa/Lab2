using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Pair
    {
		private DateTime _timeLessonStart;
		private DateTime _timeLessonEnd;
		private DateTime _timeRestStart;
		private DateTime _timeRestEnd;
		private Shift _shift;
		public DateTime LessonStart
		{
			get { return _timeLessonStart; }
			set { value ?? _timeLessonStart = value, throw new Exception(message: "Invalid lessonStart") }
		}
		public DateTime LessonEnd
		{
			get { return _timeLessonEnd; }
			set { value ?? _timeLessonEnd = value, throw new Exception(message: "Invalid lessonEnd") }
		}
		public DateTime RestStart
		{
			get { return _timeRestStart; }
			set { value ?? _timeRestStart = value, throw new Exception(message: "Invalid restStart") }
		}
		public DateTime RestEnd
		{
			get { return _timeRestEnd; }
			set { value ?? _timeRestEnd = value, throw new Exception(message: "Invalid restEnd") }
		}
		public Shift PairShift
		{
			get { return _shift; }
			set { value ?? _shift = value, throw new Exception(message: "Invalid shift") }
		}
		public Pair(DateTime timeParaStart, DateTime timeParaEnd, DateTime timeRestStart, DateTime timeRestEnd, Shift shift)
		{
		    _timeParaStart = timeParaStart;
		    _timeParaEnd = timeParaEnd;
		    _timeRestStart = timeRestStart;
		    _timeRestEnd = timeRestEnd;
		    _shift = shift;
		}
    }
}
