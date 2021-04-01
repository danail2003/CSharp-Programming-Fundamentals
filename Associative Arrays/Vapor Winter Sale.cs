using System;
using System.Linq;
using System.Collections.Generic;

namespace Vapor_Winter_Sale
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();
            Dictionary<string, string> gamesWithDlc = new Dictionary<string, string>();
            Dictionary<string, double> gamesWithoutDlc = new Dictionary<string, double>();
            Dictionary<string, double> orderedGames = new Dictionary<string, double>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains("-"))
                {
                    string[] token = input[i].Split("-");

                    gamesWithoutDlc[token[0]] = double.Parse(token[1]);
                }
                else if (input[i].Contains(":"))
                {
                    string[] token = input[i].Split(":");

                    if (gamesWithoutDlc.ContainsKey(token[0]))
                    {
                        gamesWithDlc[token[0]] = token[1];
                        double value = gamesWithoutDlc[token[0]];
                        gamesWithoutDlc[token[0]] += (value * 0.20);
                    }
                }
            }

            foreach (var game in gamesWithoutDlc.ToList())
            {
                if (gamesWithDlc.ContainsKey(game.Key))
                {
                    double value = gamesWithoutDlc[game.Key];
                    gamesWithoutDlc[game.Key] -= (value * 0.50);
                }
                else
                {
                    double value = gamesWithoutDlc[game.Key];
                    gamesWithoutDlc[game.Key] -= (value * 0.20);                    
                }

                orderedGames[game.Key] = gamesWithoutDlc[game.Key];
            }

            foreach (var game in orderedGames.OrderBy(x=>x.Value))
            {
                if (gamesWithDlc.ContainsKey(game.Key))
                {
                    Console.WriteLine($"{game.Key} - {gamesWithDlc[game.Key]} - {game.Value:f2}");
                }
            }

            foreach (var game in orderedGames.OrderByDescending(x=>x.Value))
            {
                if (!gamesWithDlc.ContainsKey(game.Key))
                {
                    Console.WriteLine($"{game.Key} - {game.Value:f2}");
                }
            }
        }
    }
}
