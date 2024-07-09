public class Program
{
    static void Main(string[] args)
    {
        float player_1_score = 1000;
        float player_2_score = 2000;

        //Probablity
        double p1 = 1.0f / (1.0f + Math.Pow(10, ((player_1_score - player_2_score) / 400))); //400 * wins - losses = 400 * 1
        double p2 = 1.0f / (1.0f + Math.Pow(10, ((player_2_score - player_1_score) / 400))); //400 * wins - losses = 400 * 1

        Console.WriteLine("Player 1 propability " + p1.ToString());
        Console.WriteLine("Player 2 propability: " + p2.ToString());

    }
}
