/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;
using System.Linq;
public class Basketball
{
    public static void Run()
    {
        var players = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        var playerMap = new Dictionary<string, int>();
        var playerKeys = new List<string>();
        while (!reader.EndOfData) {
            var fields = reader.ReadFields()!;
            var playerId = fields[0];
            var points = int.Parse(fields[8]);
            playerMap[playerId] = Convert.ToInt32(points);
            playerKeys.Add(playerId);
        }
        playerMap.OrderBy(pair => pair.value).ToDictionary(pair => pair.key, pair => pair.value);
        for (int i = 0; i < playerMap.Count(); i++)
        {
            Console.WriteLine($"{i} {playerMap[playerKeys[i]]}");
        }
    
        Console.WriteLine($"Players: {{{string.Join(", ", players)}}}");

        var topPlayers = new string[10];
    }
}