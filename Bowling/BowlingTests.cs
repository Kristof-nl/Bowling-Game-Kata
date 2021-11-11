using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bowling
{
    public class BowlingTests
    {

        [Fact]
        public void TestGutterGame()
        {
            Bowling game = new Bowling();
            // Arrange
            int expected = 0;

            //Act
            for (int i = 0; i < 20; i++)
            {
                game.roll(0);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestAllOnes()
        {
            Bowling game = new Bowling();


            // Arrange
            int expected = 20;

            //Act
            for (int i = 0; i < 20; i++)
            {
                game.roll(1);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPerfectGame()
        {
            Bowling game = new Bowling();
            // Arrange
            int expected = 300;

            //Act
            for (int i = 0; i < 10; i++)
            {
                game.roll(10);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestOneSpare()
        {
            Bowling game = new Bowling();

            // Arrange
            int expected = 29;

            //Act
            List<int> numbers = new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 5, 5, 1, 1, 1, 1, 1, 1, 1, 1 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestOneStrike()
        {
            Bowling game = new Bowling();

            // Arrange
            int expected = 30;

            //Act
            List<int> numbers = new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1, 1, 1, 1, 1 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);
        }
        public void RandomGameWithSpares()
        {
            Bowling game = new Bowling();

            // Arrange
            int expected = 56;

            //Act
            List<int> numbers = new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1, 1, 1, 1, 1 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);
        }

        public void RandomGameWithStrikes()
        {
            Bowling game = new Bowling();

            // Arrange
            int expected = 79;

            //Act
            List<int> numbers = new List<int>() { 10, 1, 1, 10, 1, 1, 10, 1, 1, 10, 10, 1, 1, 1, 1 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);
        }

        public void RandomGame()
        {
            Bowling game = new Bowling();

            // Arrange
            int expected = 79;

            //Act
            List<int> numbers = new List<int>() { 10, 1, 7, 2, 8, 1, 9, 1, 3, 10, 3, 2, 7, 1, 4, 1, 3, 3 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);
        }


    }
}
