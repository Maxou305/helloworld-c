using helloworld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    internal class Message
    {
        private string _helloMessage;
        private int _morning;
        private int _afternoon;
        private int _evening;
        public string HelloMessage
        {
            get { return _helloMessage; }
            set { _helloMessage = BuildMessage(value); }
        }

        public Message(int morning, int afternoon, int evening)
        {
            this._morning = morning;
            this._afternoon = afternoon;
            this._evening = evening;
        }

        private string BuildMessage(string message)
        {
            DateTime moment = DateTime.Now;

            int day = (int)moment.DayOfWeek;
            int hour = moment.Hour;

            if (day > 1 && day < 6)
            {
                if (hour < _afternoon)
                {
                    return "Bonjour, "+message;
                }
                else if (hour < _evening)
                {
                    return "Bon après-midi, "+message;
                }
                else
                {
                    return "Bonsoir, " + message;
                }
            }
            if ((day == 4 && hour > _evening) || (day == 1 && hour <= _morning) || day == 0)
            {
                return "Bon  week-end, " + message;
            }
            return "Oups I fucked up somewhere Oo";
        }

    }
}
