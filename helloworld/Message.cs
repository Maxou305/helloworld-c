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
        private string helloMessage;
        private int morning;
        private int afternoon;
        private int evening;
        public string HelloMessage
        {
            get { return helloMessage; }
            set { helloMessage = getMessage(value); }
        }

        public Message(int morning, int afternoon, int evening)
        {
            this.morning = morning;
            this.afternoon = afternoon;
            this.evening = evening;
        }

        private string getMessage(string message)
        {
            DateTime moment = DateTime.Now;

            int day = (int)moment.DayOfWeek;
            int hour = moment.Hour;

            if (day > 1 && day < 6)
            {
                if (hour < afternoon)
                {
                    return "Bonjour, "+message;
                }
                else if (hour < evening)
                {
                    return "Bon après-midi, "+message;
                }
                else
                {
                    return "Bonsoir, " + message;
                }
            }
            if ((day == 4 && hour > evening) || (day == 1 && hour <= morning) || day == 0)
            {
                return "Bon  week-end, " + message;
            }
            return "Oups I fucked up somewhere Oo";
        }

    }
}
