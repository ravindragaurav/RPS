using RockPaperScissors.Controllers;
using RockPaperScissors.Domain;

namespace RockPaperScissors.Models
{
    public class Player
    {
        public Weapon weapon { get; set; }
        public string beats(Weapon opponent)
        {
            GamePlay gameplay = new GamePlay();
            return gameplay.getResult(this, opponent);
        }
    }
}