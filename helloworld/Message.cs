using helloworld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld
{
    public class Message
    {
        private string _helloMessage;

        private ITime moment;

        private int _morning;
        private int _afternoon;
        private int _evening;

        public string HelloMessage
        {
            get { return _helloMessage; }
            set { _helloMessage = BuildMessage(moment, value); }
        }

        public Message(int morning, int afternoon, int evening)
        {
            this._morning = morning;
            this._afternoon = afternoon;
            this._evening = evening;
            moment = new Time();
        }
        public Message(int morning, int afternoon, int evening, ITime time)
        {
            this._morning = morning;
            this._afternoon = afternoon;
            this._evening = evening;
            moment = time;
        }

        public string BuildMessage(ITime moment, string user)
        {
            int day = (int) moment.GetDate().DayOfWeek;
            int hour = moment.GetDate().Hour;

            if (day > 1 && day < 6)
            {
                if (hour < _afternoon)
                {
                    return "Bonjour, " + user;
                }
                else if (hour < _evening)
                {
                    return "Bon après-midi, " + user;
                }
                else
                {
                    return "Bonsoir, " + user;
                }
            }
            if ((day == 4 && hour > _evening) || (day == 1 && hour <= _morning) || day == 0)
            {
                return "Bon  week-end, " + user;
            }
            return "Oups I fucked up somewhere Oo";
        }
    }
}