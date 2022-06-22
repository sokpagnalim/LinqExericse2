using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
           


            List<string> videoGames = new List<string>() { "Minecraft", 
                "Grand Theft Auto 5", 
                "Animal Crossing: New Horizon", 
                "Call Of Duty Warzone" };
            var orderVideoNameLength = videoGames.OrderBy(i => i.Length).ToList();

            foreach (var game in orderVideoNameLength)
            {
                Console.WriteLine(game);
            }
            //orderVideoNameLength.ForEach(Console.WriteLine);
        }
    }
}
