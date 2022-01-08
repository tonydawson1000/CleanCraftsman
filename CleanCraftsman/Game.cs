namespace CleanCraftsman
{
    public class Game
    {
        //Bowling Game Rules

        // If the Frame is a Strike, the Score is 10 plus the next two Balls
        // If the Frame is a Spare, the Score is 10 plus the next Ball
        // Otherwise the Score is the two Balls in the Frame

        // 10 Frames in each Game
        // 2 Balls in each Frame - EXCEPT 10th Frame - which has 3
        // Total Rolls for a Game = 21

        private int score = 0;
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void Roll(int pins)
        {
            //Accumulate all the pins for each Roll
            rolls[currentRoll++] = pins;
        }

        private bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
        private int SpareBonus(int frameIndex)
        {
            return rolls[frameIndex + 2];
        }

        private bool IsStrike(int frameIndex)
        {
            return rolls[frameIndex] == 10;
        }
        private int StrikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }

        private int TwoBallsInFrame(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }

        public int Score()
        {
            int frameIndex = 0;

            for (int frame = 0; frame < 10; frame++)
            {
                if(IsSpare(frameIndex))
                {
                    score += 10 + SpareBonus(frameIndex);

                    frameIndex += 2;
                }
                else if(IsStrike(frameIndex))
                {
                    score += 10 + StrikeBonus(frameIndex);
                    
                    frameIndex++;
                }
                else
                {
                    score += TwoBallsInFrame(frameIndex);

                    frameIndex += 2;
                }
            }

            return score;
        }
    }
}