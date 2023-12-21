using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Time : ITime
    {
        DateTime _time;
        public Time() { 
            _time = DateTime.Now;
        }
        public DateTime GetDate()
        {
            return DateTime.Now;
        }
    }
}
