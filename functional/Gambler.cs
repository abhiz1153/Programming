using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functional
{
    class Gambler
    {
        Utility utility = new Utility();
        public void Gamb()
        {
            try
            {
                int bets = 0, wins = 0, loss = 0;
                Random rand = new Random();
                Console.Write("Stake ");
                int stake = utility.Number();
                Console.Write("Goal ");
                int goal = utility.Number();
                Console.Write("Trials ");
                int trials = utility.Number();
                for (int t = 0; t < trials; t++)
                {


                    int cash = stake;
                    while (cash > 0 && cash < goal)
                    {
                        bets++;
                        if (rand.NextDouble()<0.5)
                            cash++;
                        else
                            cash--;
                    }
                    if (cash == goal)
                        wins++;
                    else
                        loss++;

                }


                Console.WriteLine(wins + " wins of " + trials);
                Console.WriteLine("Percent of games won = " + 100.0 * wins / trials + "%");
                Console.WriteLine("Percent of games loss = " + 100.0 * loss / trials + "%");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
