using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._7
{
    class CallInfo
    {
        public TimeSpan Duration { get; private set; }
        public DateTime Time { get; private set; }

        public CallInfo(TimeSpan duration, DateTime time)
        {
            Duration = duration;
            Time = time;
        }

        public CallInfo(int year, int month, int day, int hour, int minute, int second) : this(new TimeSpan(), new DateTime(year, month, day, hour, minute, second)){ }
        public CallInfo(DateTime time) : this(new TimeSpan(), time) { }

        public void setEndCallTime(DateTime endTime)
        {
            Duration = Time.Subtract(endTime);
        }

        public override string ToString()
        {
            return $"Call started: {Time.ToString()}    Call ended: {Time.Add(Duration)}";
        }
    }
}
