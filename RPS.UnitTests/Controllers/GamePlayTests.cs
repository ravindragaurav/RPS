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
    }
}
