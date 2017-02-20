using NUnit.Framework;
using RockPaperScissors.Domain;
using RockPaperScissors.Models;

namespace RPS.UnitTests.Controllers
{
    [TestFixture]
    public class RulesTests
    {
        [Test]
        public void Rock_Crushes_Scissors()
        {
            //Given
            Game game = new Game();
            Player player1 = new Player();
            Player player2 = new Player();

            //When
            player1.choice = Options.Rock;
            player2.choice = Options.Scissors;

            //Then
            Assert.That(game.Winner, Is.EqualTo(player1));
        }

    }

  
}
