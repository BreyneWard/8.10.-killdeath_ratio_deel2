using System.Linq;

namespace _8._10._killdeath_ratio_deel2;
class Program
{
    static void Main(string[] args)
    {
        double kills = 0.0;
        double deaths = 0.0;

        int numberOfPlayers = Input.AskInteger("How many players?");
        string[] players = new string[numberOfPlayers];
        double[] playerKdRatio = new double[numberOfPlayers];

        

        for (int i = 0; i < numberOfPlayers; i++)
        {
            string playerName = Input.AskString("Enter your name: ");
            players[i] = playerName;
            kills = Input.AskDouble("How many kills?");
            deaths = Input.AskDouble("How many deaths?");
            playerKdRatio[i] = kills / deaths;
        }

        // Highest kill/death ratio
        double maxValue = playerKdRatio.Max();
        int maxIndex = playerKdRatio.ToList().IndexOf(maxValue);

        Console.WriteLine($"{players[maxIndex]} has the highest kill/death ratio of {maxValue}");

    }

    public static class Input
    {
        public static string AskString(string question)
        {
            Console.Write($"{question}");
            return Console.ReadLine() ?? string.Empty;
        }
        public static int AskInteger(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (int.TryParse(Console.ReadLine(), out int r))
                    return r;

            }
        }
        public static char AskChar(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (char.TryParse(Console.ReadLine(), out char r))
                    return r;

            }


        }

        public static double AskDouble(string question)
        {
            while (true)
            {
                Console.Write($"{question}");
                if (double.TryParse(Console.ReadLine(), out double r))
                    return r;

            }
        }
    }
}
