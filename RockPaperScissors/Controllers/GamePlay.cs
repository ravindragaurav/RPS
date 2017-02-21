using RockPaperScissors.Domain;
using RockPaperScissors.Models;

namespace RockPaperScissors.Controllers
{
    public class GamePlay
    {
        public string getResult(Player player, Weapon opponent)
        {
            string result = "";

            if (player.weapon == Weapon.Rock)
            {
                switch (opponent)
                {
                    case Weapon.Paper:
                        result = "lost";
                        break;

                    case Weapon.Scissors:
                        result = "won";
                        break;

                    case Weapon.Rock:
                        result = "draw";
                        break;
                }
            }

            if (player.weapon == Weapon.Paper)
            {
                switch (opponent)
                {
                    case Weapon.Paper:
                        result = "draw";
                        break;

                    case Weapon.Scissors:
                        result = "lost";
                        break;

                    case Weapon.Rock:
                        result = "won";
                        break;
                }
            }

            if (player.weapon == Weapon.Scissors)
            {
                switch (opponent)
                {
                    case Weapon.Paper:
                        result = "won";
                        break;

                    case Weapon.Scissors:
                        result = "draw";
                        break;

                    case Weapon.Rock:
                        result = "lost";
                        break;
                }
            }

            return result;

        }
    }
}