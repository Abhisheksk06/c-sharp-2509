using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignments
{
    public class Game
    {
        //Method to increase the score by 10
        public void IncreaseScore(ref int score)
        {
            score += 10;
            Console.WriteLine($"Score increased to: {score}");
        }
    }
}
