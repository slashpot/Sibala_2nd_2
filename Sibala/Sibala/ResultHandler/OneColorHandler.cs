using System.Linq;

namespace Sibala.ResultHandler
{
    public class OneColorHandler : ISibalaResultHandler
    {
        private SibalaGame _sibalaGame;

        public OneColorHandler(SibalaGame sibalaGame)
        {
            _sibalaGame = sibalaGame;
        }

        public void SetResult()
        {
            _sibalaGame.Type = SibalaType.OneColor;
            _sibalaGame.Points = _sibalaGame.Dices.First();
            _sibalaGame.Output = "One Color";
            _sibalaGame.MaxPoint = _sibalaGame.Points;
        }
    }
}