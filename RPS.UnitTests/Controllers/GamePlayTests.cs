using NUnit.Framework;
using RockPaperScissors.Domain;
using RockPaperScissors.Models;

namespace RPS.UnitTests.Controllers
{
    [TestFixture]
    class GamePlayTests
    {

        [TestCase(Weapon.Paper, "lost")]
        [TestCase(Weapon.Scissors, "won")]
        [TestCase(Weapon.Rock, "draw")]
        public void player_chooses_rock(Weapon opponent, string result)
        {
            //Given
            Player player = new Player();

            //When
            player.weapon = Weapon.Rock;

            //Then
            Assert.That(player.beats(opponent), Is.EqualTo(result));
        }

        [TestCase(Weapon.Paper, "draw")]
        [TestCase(Weapon.Scissors, "lost")]
        [TestCase(Weapon.Rock, "won")]
        public void player_chooses_paper(Weapon opponent, string result)
        {
            //Given
            Player player = new Player();

            //When
            player.weapon = Weapon.Paper;

            //Then
            Assert.That(player.beats(opponent), Is.EqualTo(result));
        }

        [TestCase(Weapon.Paper, "won")]
        [TestCase(Weapon.Scissors, "draw")]
        [TestCase(Weapon.Rock, "lost")]
        public void player_chooses_scissors(Weapon opponent, string result)
        {
            //Given
            Player player = new Player();

            //When
            player.weapon = Weapon.Scissors;

            //Then
            Assert.That(player.beats(opponent), Is.EqualTo(result));
        }
    }
}
