using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Lesson
    {
		private DateTime _timeLessonStart;
		private DateTime _timeLessonEnd;
		private DateTime _timeRestStart;
		private DateTime _timeRestEnd;
		private Smena _smena;
		public DateTime LessonStart
		{
			get { return _timeLessonStart; }
		}
		public DateTime LessonEnd
		{
			get { return _timeLessonEnd; }
		}
		public DateTime RestStart
		{
			get { return _timeRestStart; }
		}
		public DateTime RestEnd
		{
			get { return _timeRestEnd; }
		}
		public Smena GetSmena
		{
			get { return _smena; }
		}
		public Lesson(DateTime timeParaStart, DateTime timeParaEnd, DateTime timeRestStart, DateTime timeRestEnd, Smena Smena)
		{
		    _timeParaStart = timeParaStart;
		    _timeParaEnd = timeParaEnd;
		    _timeRestStart = timeRestStart;
		    _timeRestEnd = timeRestEnd;
		    _smena = smena;
		}
    }
}
