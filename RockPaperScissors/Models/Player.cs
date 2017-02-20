using RockPaperScissors.Domain;

namespace RockPaperScissors.Models
{
    public class Player
    {
        public Weapon weapon { get; set; }

        public string beats(Weapon opponent)
        {
            string result = "";
            if (this.weapon == Weapon.Rock)
            {
                switch (opponent)
                {
                    case Weapon.Paper:
                        result =  "lose";
                        break;

                    case Weapon.Scissors:
                        result = "won";
                        break;

                    case Weapon.Rock:
                        result = "draw";
                        break;
                }
            }
            return result;
        }
    }
}