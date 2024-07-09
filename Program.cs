public class Program
{
    static void Main(string[] args)
    {
        //Algorithm help: https://www.geeksforgeeks.org/elo-rating-algorithm/

        float player_1_score = 1000;
        float player_2_score = 1200;

        int amountOfGamesPlayed = 1;

        //Propability
        double p1 = (1.0f / (1.0f + Math.Pow(10, ((player_2_score - player_1_score) / 400)))) / amountOfGamesPlayed; //400 * wins - losses = 400 * 1
        double p2 = (1.0f / (1.0f + Math.Pow(10, ((player_1_score - player_2_score) / 400)))) / amountOfGamesPlayed; //400 * wins - losses = 400 * 1

        Console.WriteLine("Player 1 propability " + p1.ToString());
        Console.WriteLine("Player 2 propability: " + p2.ToString());

        //Update ranking

        //Algorithm help: https://www.omnicalculator.com/sports/elo
        //https://www.noveltech.dev/elo-ranking-csharp-unity

        //FIDE uses k-factor of 40 for players under 2300 ELO and less than 30 games: https://en.wikipedia.org/wiki/Elo_rating_system#Most_accurate_K-factor
        //20 for over 30 games but under 2400 ELO
        //10 if 2400 or over ELO and at least 30 games
        int k = 40;

        //Player 1 win test
        player_1_score += (k * (1 - (float)p1)) * amountOfGamesPlayed; //1 win - 0 losses = 1
        player_2_score += (k * ((float)p1 - 1)) * amountOfGamesPlayed; //0 wins - 1 losses = -1

        Console.WriteLine("player 1 new ELO rating: " + player_1_score);
        Console.WriteLine("player 2 new ELO rating: " + player_2_score);

    }
}
