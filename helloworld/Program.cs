using System;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime moment = DateTime.Now;

            int day = (int)moment.DayOfWeek;
            int hour = moment.Hour;
            string message = "";

            if (day > 1 && day < 6)
            {
                if (hour > 9 && hour < 13)
                {
                    message = "Bonjour, ";
                }
                else if (hour < 18)
                {
                    message = "Bon après-midi, ";
                }
                else
                {
                    message = "Bonsoir, ";
                }
            }
            if ((day == 4 && hour > 18) || (day == 1 && hour <= 9) || day == 0)
            {
                message = "Bon  week-end, ";
            }
            Console.WriteLine(message + Environment.UserName);
        }
    }
}
