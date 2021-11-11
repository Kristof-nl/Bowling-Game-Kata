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
            for (int i = 0; i < 12; i++)
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

        [Fact]
        public void RandomGameWithSpares()
        {
            Bowling game = new Bowling();

            // Arrange
            int expected = 47;

            //Act
            List<int> numbers = new List<int>() { 1, 1, 1, 9, 1, 1, 1, 1, 1, 1, 9, 1, 1, 1, 1, 1, 9, 1, 1, 1 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
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

        [Fact]
        public void RandomGame1()
        {
            Bowling game = new Bowling();

            // Arrange
            int expected = 91;

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

        [Fact]
        public void RandomGame2()
        {
            Bowling game = new Bowling();

            // Arrange
            int expected = 84;

            //Act
            List<int> numbers = new List<int>() { 5, 3, 7, 3, 6, 3, 10, 3, 2, 1, 6, 3, 6, 4, 3, 2, 3, 1, 2 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void RandomGame2WithStrikeInTenthFrame()
        {
            Bowling game = new Bowling();

            // Arrange
            int expected = 273;

            //Act
            List<int> numbers = new List<int>() { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 1, 1 };
            for (int i = 0; i < numbers.Count; i++)
            {
                game.roll(numbers[i]);
            }

            int actual = game.score();

            // Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void RandomGame2WithSpareInTenthFrame()
        {
            Bowling game = new Bowling();

            // Arrange
            int expected = 262;

            //Act
            List<int> numbers = new List<int>() { 10, 10, 10, 10, 10, 10, 10, 10, 10, 1, 9, 1 };
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
