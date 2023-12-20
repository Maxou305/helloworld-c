using System;

namespace helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Environment.UserName;
            Message message = new Message(9, 13, 18)
            {
                HelloMessage = user
            };

            bool stop = false;

            while (!stop)
            {
                Console.WriteLine(message.HelloMessage);
                stop = Console.ReadLine() == "exit";
            }
        }
    }
}
