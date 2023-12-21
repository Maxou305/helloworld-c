using helloworld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraistests
{
    internal class FakeTime : ITime
    {
        DateTime _fakeTime;
        public FakeTime() : this(1992, 6, 11, 9, 35, 58)
        {
        }
        public FakeTime(int year, int month, int day, int hour, int minute, int sec)
        {
            _fakeTime = new DateTime(year, month, day, hour, minute, sec);
        }
        public DateTime GetDate()
        {
            return _fakeTime;
        }
    }
}
