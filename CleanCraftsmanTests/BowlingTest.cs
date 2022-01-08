using CleanCraftsman;
using Xunit;

namespace CleanCraftsmanTests
{
    public class BowlingTest
    {
        //Arrange
        private readonly Game game;

        public BowlingTest()
        {
            //Arrange
            game = new Game();
        }

        private void RollMany(int frames, int pins)
        {
            for (int i = 0; i < frames; i++)
            {
                game.Roll(pins);
            }
        }

        private void RollSpare()
        {
            RollMany(2, 5);
        }

        private void RollStrike()
        {
            game.Roll(10);
        }

        [Fact]
        public void PerfectGame()
        {
            //Act
            // 10 Strikes + 2 x 10's
            RollMany(12, 10);

            //Assert
            Assert.Equal(300, game.Score());
        }

        [Fact]
        public void OneStrike()
        {
            //Act
            RollStrike();
            game.Roll(2);
            game.Roll(3);

            RollMany(16, 0);

            //Assert

            //      15 for Spare (10) + 2 + 3
            // +     5  (2 + 3) 
            // =    20
            Assert.Equal(20, game.Score());
        }

        [Fact]
        public void OneSpare()
        {
            //Act
            RollSpare();
            game.Roll(7);

            RollMany(17, 0);

            //Assert

            //      17 for Spare (5+5) + 7
            // +     7 
            // =    24
            Assert.Equal(24, game.Score());
        }

        [Fact]
        public void AllOnes()
        {
            //Score of 20 if each Roll equals 1

            //Act
            RollMany(20, 1);

            //Assert
            Assert.Equal(20, game.Score());
        }

        [Fact]
        public void GutterGame()
        {
            //20 zeros in a GutterGame

            //Act
            RollMany(20, 0);

            //Assert
            Assert.Equal(0, game.Score());
        }
    }
}