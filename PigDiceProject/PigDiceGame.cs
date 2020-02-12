using System;
using System.Collections.Generic;
using System.Text;

namespace PigDiceProject {
    public class PigDiceGame {

        private Random rnd = new Random(DateTime.Now.Millisecond);

        public int RollTheDie() {
            return rnd.Next(1, 7);
        }

        public int PigDice() {

            var score = 0;
            var roll = RollTheDie();
            while(roll != 1) {
                score += roll;
                roll = RollTheDie();
            }
            return score;
        }

        public void Play() {
            var WorldRecordScore = 300;
            var highScore = 0;
            var gamesToPlay = 1000;
            while (gamesToPlay > 0  || highScore > WorldRecordScore)  {
                var score = PigDice();
                if (score > highScore) {
                    highScore = score;
                
                gamesToPlay--;
                    Console.WriteLine($" New World Record Score is {highScore}");
                }
            }
                
                
            
        }
    }
}
