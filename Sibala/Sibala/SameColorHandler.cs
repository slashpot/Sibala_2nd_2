using System.Linq;

namespace Sibala
{
    public class SameColorHandler : ISibalaHandler
    {
        private SibalaGame _sibalaGame;

        public SameColorHandler(SibalaGame sibalaGame)
        {
            _sibalaGame = sibalaGame;
        }

        public void SetResult()
        {
            _sibalaGame.Type = SibalaType.OneColor;
            _sibalaGame.Value = _sibalaGame.Dices.First();
            _sibalaGame.Output = "One Color";
            _sibalaGame.MaxDice = _sibalaGame.Value;
        }
    }
}