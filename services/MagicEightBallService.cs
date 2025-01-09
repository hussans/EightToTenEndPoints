using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EightToTenEndPoints.services
{
 public class MagicEightBallService
    {
        public List<string> Responses { get; } = new()
        {
            "Yes, definitely!",
            "It is certain.",
            "Reply hazy, try again.",
            "Ask again later.",
            "Don't count on it.",
            "My sources say no.",
            "Outlook not so good.",
            "Signs point to yes."
        };

        public string GetResponseForQuestion()
        {
            var random = new Random();
            int index = random.Next(Responses.Count);
            string response = Responses[index];

            return response;
        }
    }
}