using System.Linq;

namespace Sibala
{
    public class OneColorHandler
    {
        private SibalaGame _sibalaGame;

        public OneColorHandler(SibalaGame sibalaGame)
        {
            _sibalaGame = sibalaGame;
        }

        public void SetOneColor()
        {
            _sibalaGame.Type = SibalaType.OneColor;
            _sibalaGame.Points = _sibalaGame.Dices.First();
            _sibalaGame.Output = "One Color";
            _sibalaGame.MaxPoint = _sibalaGame.Points;
        }
    }
}